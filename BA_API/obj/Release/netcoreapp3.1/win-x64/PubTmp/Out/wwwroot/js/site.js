$(document).ready(function () {
    $("div label").addClass("font-weight-bold");

});
var WAY_URL = "http://210.211.96.3:8080/image-waypoint-api/";
var REP_URL = "http://210.211.96.3:8080/image-report-api/";
var API_THONG_KE = "http://210.211.96.4:8081/api/";
var API_LHVT = "http://192.168.1.59:800/api/v1/transporttypelandmarks/lists?queryJson={%22FK_LanguageId%22:1}";
var PAGE_SIZE = 75;
var DIV_LOADING = `<div id="div_loader" class="loader"></div>`;

var user = JSON.parse(localStorage.getItem("userLogin"));

var AUTH;

var USER_ROLE;

var ALLOW_QUERY;
if (user !== null) {
    AUTH = user.authorization;

    USER_ROLE = user.roleId;


    ALLOW_QUERY = user.allowQueryData;
}

function addClassActive(selector1, selector2) {
    $("." + selector1).children("div").addClass("show");
    $("." + selector1).children("div").find("." + selector2).addClass("active");
    $("." + selector2).parent("div").parent("div").addClass("show");

    //console.log($("." + selector2).parent("div"));
}


$.ajaxSetup({
    contentType: 'application/json',
    dataType: "json",
    crossDomain: true,
    xhrFields: {
        withCredentials: false
    },
    beforeSend: function (xhr) {
        xhr.setRequestHeader("Authorization", AUTH);
        $("#container-wrapper").append(DIV_LOADING);
    },
    success: function (data, textStatus, request) {
    },
    error: function (request, textStatus, errorThrown) {
        $("#div_loader").remove();
        if (request.status == 401) {
            let token_exp = request.getResponseHeader('token-expired');
            if (token_exp != null && token_exp == 'true') {
                document.location.href = "/";
            }
        }
    }
});
function callApi(url, obj, method, callback) {
    if (obj == null) {
        $.ajax({
            type: method,
            url: `${url}`,
            success: function (res, textStatus, request) {
                if (request.status === 200) {
                    $("#div_loader").remove();
                    //$.notify("Thành công", "success");
                    if (typeof callback === "function") {
                        callback(res);
                    }
                }
            },
            failure: function (response) {
                $("#div_loader").remove();
                //$.notify(`Lỗi xảy ra ${response.error} 1`, "error");
            },
            error: function (response, textStatus, errorThrown) {
                $("#div_loader").remove();
                callback(response.responseText);
                //$.notify(`Lỗi xảy ra với API, vui lòng xem lại 2`, "error");
                if (response.status === 424) {
                    $.notify(`Không xoá được Đơn vị vận tải vì có phương tiện đang tồn tại.`, "error");
                    //document.location.href = "/";
                }
            }
        });
    } else {
        $.ajax({
            type: method,
            contentType: 'application/json',
            dataType: "json",
            url: `${url}`,
            data: JSON.stringify(obj),
            success: function (res, textStatus, xhr) {
                $("#div_loader").remove();
                if (xhr.status == '200') {
                    //$.notify("Thành công", "success");
                    if (typeof callback === "function") {
                        callback(res);
                    }
                }
            },
            failure: function (response) {
                $("#div_loader").remove();
            },
            error: function (request, textStatus, errorThrown) {
                $("#div_loader").remove();
                if (request.status === 401) {
                    $.notify(`Đăng nhập thất bại`, "error");
                    let token_exp = request.getResponseHeader('token-expired');
                    if (token_exp != null && token_exp == 'true') {
                        document.location.href = "/";
                    }
                    console.log(request.statusText);
                }
                if (request.status === 409) {
                    $.notify(`Không thêm được do trùng dữ liệu`, "error");
                }
            }
        });
    }
}


function EpochToDate(timestamp) {
    var d = new Date(timestamp);
    console.log(d);

}

function formatDate() {
    var dt = new Date();
    var dd = dt.getDate();
    var mm = dt.getMonth() + 1;

    var yyyy = dt.getFullYear();
    if (dd < 10) {
        dd = '0' + dd;
    }
    if (mm < 10) {
        mm = '0' + mm;
    }

    return dd + '/' + mm + '/' + yyyy;
}


function Paging(page, functionName, totalRecord) {

    $(".total").html("Tổng số: " + totalRecord);
    if (totalRecord === 0) { $('.pagination').html(''); return; }
    let extSpace = false;
    let totalPage = Math.ceil(totalRecord / PAGE_SIZE);

    let htmlPaging = "";
    if (page > 0)
        htmlPaging += `<li class="page-item" onclick="${functionName}(${page - 1})"><a class="page-link" href="#">Trước</a></li>`;
    else
        htmlPaging += `<li class="page-item"><a class="page-link">Trước</a></li>`;

    for (var i = 1; i <= totalPage; i++) {
        if (i > 2 && i < totalPage - 1) {
            if (!extSpace) {
                extSpace = true;
                htmlPaging += `...`;
            }
        } else {
            if (page === (i - 1)) {
                htmlPaging += `<li class="page-item"><span class="page-link text-success" style="background-color:#4aa04a; color:white !important" font-weight-bold>${i}</span></li>`;
            } else {
                htmlPaging += `<li class="page-item" onclick="${functionName}(${i - 1})"><a class="page-link" data-href="${i}" href="#">${i}</a></li>`;
            }
        }
    }

    if (page < totalPage)
        htmlPaging += `<li class="page-item" onclick="${functionName}(${page + 1})"><a class="page-link" href="#">Tiếp</a></li>`;
    else
        htmlPaging += `<li class="page-item"><a class="page-link">Tiếp</a></li>`;

    $('.pagination').html(htmlPaging);

}

function loadLoaiHinh() {
    let res = `<option value="-1" >Tất cả</option>
    <option value="0">Xe chưa phân loại </option>
    <option value="100">Xe tuyến cố định </option>
    <option value="200">Xe BUS </option>
    <option value="300">Xe hợp đồng </option>
    <option value="400">Xe du lịch </option>
    <option value="500">Xe Container </option>
    <option value="600">Xe tải </option>
    <option value="700">Xe taxi </option>
    <option value="800">Xe taxi tải </option>
    <option value="900">Xe đầu kéo </option>
    <option value="950">Xe trung chuyển </option>`;
    $("#vehicleType").html(res);
    $("#formVehicleType").html(res);
}

function datePickerOne() {
    var d = new Date();
    var currMonth = String(d.getMonth()).padStart(2, '0');
    var currYear = d.getFullYear();
    var currDay = String(d.getDate()).padStart(2, '0');
    var endDate = new Date(currYear, currMonth, currDay);
    $('[name="date"]').datepicker({ format: 'dd/mm/yyyy' }).datepicker('setDate', endDate);
}
function datePicker() {
    var d = new Date();
    var currMonth = String(d.getMonth()).padStart(2, '0');
    var currYear = d.getFullYear();
    var currDay = String(d.getDate()).padStart(2, '0');
    var startDate = new Date(currYear, currMonth, 1);
    var endDate = new Date(currYear, currMonth, currDay);
    $('[name="start"]').datepicker({ format: 'dd/mm/yyyy' }).datepicker('setDate', startDate);


    //$('[name="end"]').datepicker({
    //    dateFormat: 'dd/mm/yyyy'
    //}).on('show',
    //    function () {
    //        try {
    //            //$('[name="end"]').datepicker('setStartDate', $('[name="start"]').val());
    //        } catch (e) {
    //        }
    //    });
    $('[name="end"]').datepicker({ format: 'dd/mm/yyyy' }).datepicker('setDate', endDate);
}
Date.prototype.epochConverterGMTString = function () {
    if (typeof moment === "undefined") {
        return this.toUTCString();
    }
    moment.locale('en');
    var md = moment(this);
    if (!md.isValid()) {
        return 'Invalid input.';
    }
    var myLocaleData = moment.localeData(locale);
    var myFormat = ecFixFormat(myLocaleData.longDateFormat('LLLL')).replace(/\[([^\]]*)\]/g, " ");
    if (md.format("SSS") != '000') {
        myFormat = myFormat.replace(":mm", ":mm:ss.SSS");
    } else {
        myFormat = myFormat.replace(":mm", ":mm:ss");
    }
    return md.utc().format(myFormat);
}
Date.prototype.relativeDate = function () {
    if (typeof moment !== "undefined") {
        moment.locale('en');
        var md = moment(this);
        return md.fromNow();
    }
    return '';
}
Date.prototype.epochConverterLocaleString = function (disabletz) {
    disabletz = disabletz || false;
    if (typeof moment === "undefined") {
        return this.toDateString() + " " + this.toTimeString();
    }
    moment.locale(locale);
    var md = moment(this);
    if (!md.isValid()) {
        return 'Invalid input.';
    }
    var currentLocaleData = moment.localeData();
    var myLocaleData = moment.localeData(locale);
    var myFormat = ecFixFormat(myLocaleData.longDateFormat('LLLL'));
    if (md.format("SSS") != '000') {
        myFormat = myFormat.replace(":mm", ":mm:ss.SSS");
        myFormat = myFormat.replace(".mm", ".mm.ss.SSS");
    } else {
        myFormat = myFormat.replace(":mm", ":mm:ss");
        myFormat = myFormat.replace(".mm", ".mm.ss");
    }
    if (!disabletz) {
        myFormat += " [GMT]Z";
    }
    var customDate = md.format(myFormat);
    return customDate;
}
function getLocale() {
    var locale = getQueryParams('locale');
    var al = [];
    if (typeof moment !== "undefined") {
        al = moment.locales();
    }
    if (locale && al.indexOf(locale.toLowerCase()) > -1) return locale.toLowerCase();
    locale = localStorage.getItem('ec_locale');
    if (locale && (al.indexOf(locale) > -1 || al.length === 0)) return locale;
    locale = window.navigator.language || window.navigator.userLanguage || "en";
    return locale.toLowerCase();
}

function cleanTimestamp(ts) {
    if (!ts) {
        return "";
    }
    ts = ts.replace(/[`'"\s\,]+/g, '');
    if (ts.charAt(ts.length - 1) == "L") {
        ts = ts.slice(0, -1);
    }
    return ts;
}

function EpochToHuman(timestamp) {
    var iorg = timestamp;
    var hr = "<br/>&nbsp;";
    var errormessage = "Lỗi";
    var outputtext = "";
    var notices = "";
    inputtext = cleanTimestamp(iorg);
    if (inputtext && inputtext != iorg.trim()) {
        outputtext += "Converting " + inputtext + ":<br/>";
    }
    if ((inputtext.length === 0) || isNaN(inputtext)) {
        if (isHex(inputtext)) {
            inputtext = '0x' + inputtext;
        } else {
            $("#result1").html(errormessage + hr);
            return;
        }
    }
    if (inputtext.substring(0, 2) == '0x') {
        outputtext += "Converting <a href=\"/hex?q=" + inputtext.substring(2) + "\">hexadecimal timestamp</a> to decimal: " + parseInt(inputtext) + "<br/>";
    }
    inputtext = inputtext * 1;
    var epoch = inputtext;
    var cn = '';
    if (locale.substring(0, 2) == 'en') {
        cn = ' class="utcal"';
    }
    if ((inputtext >= 10E7) && (inputtext < 18E7)) {
        notices += '<br/>Expected a more recent date? You are missing 1 digit.';
    }
    if ((inputtext >= 1E16) || (inputtext <= -1E16)) {
        outputtext += "Assuming that this timestamp is in <b>nanoseconds (1 billionth of a second)</b>:<br/>";
        inputtext = Math.floor(inputtext / 1000000);
    } else if ((inputtext >= 1E14) || (inputtext <= -1E14)) {
        outputtext += "Assuming that this timestamp is in <b>microseconds (1/1,000,000 second)</b>:<br/>";
        inputtext = Math.floor(inputtext / 1000);
    } else if ((inputtext >= 1E11) || (inputtext <= -3E10)) {
        outputtext += "Assuming that this timestamp is in <b>milliseconds</b>:<br/>";
    } else {
        outputtext += "Assuming that this timestamp is in <b>seconds</b>:<br/>";
        if ((inputtext > 1E11) || (inputtext < -1E10)) {
            notices += "<br>Remove the last 3 digits if you are trying to convert milliseconds.";
        }
        inputtext = (inputtext * 1000);
    }
    if (inputtext < -68572224E5) {
        notices += "<br/>Dates before 14 september 1752 (pre-Gregorian calendar) are not accurate.";
    }
    var datum = new Date(inputtext);
    if (isValidDate(datum)) {
        var convertedDate = datum.epochConverterGMTString();
        var relativeDate = datum.relativeDate();
        outputtext += "<b" + cn + ">GMT</b>: " + convertedDate;
        outputtext += "<br/><b" + cn + ">Your time zone</b>: <span title=\"" + datum.toDateString() + " " + datum.toTimeString() + "\">" + datum.epochConverterLocaleString(1) + "</span>";


        let d = new Date(datum.epochConverterLocaleString(1));

        return datum;
    } else {
        outputtext += errormessage;
    }
}


function getTime(o, t) {
    o = o || 0;
    t = t || 1;
    if (o == "ymd") {
        if (typeof moment !== "undefined") return (moment().utc().format('YMMDDHHmmss')) + "Z";
        return "";
    }
    var hex = 0;
    if (o == "0x") {
        o = 0;
        hex = 1;
    }
    var res = Math.floor((o + (new Date().getTime() / 1000.0)) / t);
    if (hex) res = res.toString(16).toUpperCase();
    return res;
}


function getTzPref() {
    var tzpref = 1;
    if (localStorage.getItem('ec_tzpref') && localStorage.getItem('ec_tzpref') == 2) tzpref = 2;
    return tzpref;
}

function getClockPref() {
    var clockf;
    if (localStorage.getItem('ec_clockf')) {
        clockf = localStorage.getItem('ec_clockf');
    } else {
        var controldate = new Date(1546365600000);
        cchecks = controldate.epochConverterGMTString().search(" PM");
        if (cchecks > -1) {
            clockf = '12';
        } else {
            clockf = '24';
        }
    }
    return clockf;
}

function timezoneStart() {
    $(document).keypress(function (e) {
        if (!(e.ctrlKey || e.altKey || e.metaKey)) {
            if (String.fromCharCode(e.which).match(/[a-zA-Z]/)) e.preventDefault();
            switch (e.which) {
                case 101:
                case 69:
                    kp('ecinput');
                    jumpTo('top');
                    break;
            }
        }
    });
}

function jumpTo(toid) {
    var new_position = $('#' + toid).offset();
    window.scrollTo(new_position.left, new_position.top);
}

function emptyFields() {
    $('input:text').val("");
    $(".resultbox").fadeOut('', function () {
        $(".resultbox").html('').show();
    });
}

function kp(id) {
    $('#' + id).focus();
    $('#' + id).select();
}


function isValidDate(d) {
    if (Object.prototype.toString.call(d) !== "[object Date]")
        return false;
    return !isNaN(d.getTime());
}

function isHex(h) {
    var a = parseInt(h, 16);
    return (a.toString(16) === h.toLowerCase());
}

function Ax() {
    var d = $(location).attr('hostname');
    if ((d.search(/sja/i) > 0) || (d.search(/hconverte/i) > 3) || d.search(/ogl/i) > 0) {
        return 1;
    } else {
        return 0;
    }
}


String.prototype.capitalize = function () {
    return this.charAt(0).toUpperCase() + this.slice(1);
}
var locale = 'en';
$(document).ready(function () {
    locale = getLocale();
});
function getQueryParams(qn) {
    var qs = document.location.search;
    qs = qs.split('+').join(' ');
    var params = {},
        tokens, re = /[?&]?([^=]+)=([^&]*)/g;
    while (tokens = re.exec(qs)) {
        if (decodeURIComponent(tokens[1]) == qn) return decodeURIComponent(tokens[2]);
    }
    return false;
}

function regexInput(input) {
    var regex = /[^A-Za-z0-9]/;
    return input.match(regex);
}

var interval = (1000 * 60 * 60 * 24);
function SetDefaultDateTime() {

    //let dt = new Date().toLocaleDateString();
    var formatDt = formatDate();
    let startOfDay = (ConvertToUnix(formatDt) / interval) * interval;
    let endOfDay = startOfDay + interval - 1; // 23:59:59:9999

    let d = new Date(startOfDay).toLocaleString("en-GB", { hour12: false });
    let d1 = new Date(endOfDay).toLocaleString("en-GB", { hour12: false });

    jQuery('#start').datetimepicker({
        value: new Date(startOfDay),
        format: 'd/m/Y H:i',
        lang: 'vi',
        onShow: function (ct) {
            this.setOptions({
                maxDate: jQuery('#end').val() ? jQuery('#end').val() : false
            });
        }
    });

    jQuery('#end').datetimepicker({
        value: new Date(endOfDay),
        format: 'd/m/Y H:i',
        lang: 'vi',
        onShow: function (ct) {
            this.setOptions({
                minDate: jQuery('#start').val() ? jQuery('#start').val() : false
            });
        }
    });
}
function strToDate(dtStr) {
    let dateObject;
    let dateParts = dtStr.split("/");
    let timeParts = dateParts[2].split(" ")[1].split(":");
    dateParts[2] = dateParts[2].split(" ")[0];
    // month is 0-based, that's why we need dataParts[1] - 1
    //dateObject = ;
    return new Date(+dateParts[2], dateParts[1] - 1, +dateParts[0], timeParts[0], timeParts[1]).getTime();
}

function ConvertToUnix(date) {
    //date = formatDate(date);
    date = date.split("/");
    var newDate = new Date(+date[2], date[1] - 1, +date[0]);
    return newDate.getTime();
}