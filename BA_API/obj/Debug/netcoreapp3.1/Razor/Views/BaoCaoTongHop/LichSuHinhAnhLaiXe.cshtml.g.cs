#pragma checksum "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\LichSuHinhAnhLaiXe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b927cff9ecbe2a6cf029839de149b87615e82be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaoCaoTongHop_LichSuHinhAnhLaiXe), @"mvc.1.0.view", @"/Views/BaoCaoTongHop/LichSuHinhAnhLaiXe.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\BA_Work\BA_API\BA_API\Views\_ViewImports.cshtml"
using BA_API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BA_Work\BA_API\BA_API\Views\_ViewImports.cshtml"
using BA_API.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b927cff9ecbe2a6cf029839de149b87615e82be", @"/Views/BaoCaoTongHop/LichSuHinhAnhLaiXe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3bfb59427742d22d27d0c529a835ce80d09517b", @"/Views/_ViewImports.cshtml")]
    public class Views_BaoCaoTongHop_LichSuHinhAnhLaiXe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\LichSuHinhAnhLaiXe.cshtml"
  
    ViewData["Title"] = "Lịch sử hình ảnh lái xe";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #report2 {
        font-size: 14px;
    }

        #report2 thead tr th {
            padding: 0.5rem;
        }

    #embedIframe {
        padding: 0 15px 0 0;
    }

    #report2 {
        display: block;
        height: 600px;
        overflow: auto;
    }

        #report2 thead, #report2 tbody tr {
            display: table;
            width: 100%;
            table-layout: fixed;
        }

        #report2 thead {
            *width: calc( 100% - 1em ) /* scrollbar is average 1em/16px width, remove it from thead width */
        }

    #report2 {
        *width: 400px;
    }

    .textDisplay {
        overflow: hidden;
        white-space: nowrap;
        text-overflow: ellipsis;
        cursor: pointer
    }

    .image {
        position: absolute;
        top: 0px;
        right: 30px;
        width: 40%;
        height: 40%;
        background-position: right;
        background-repeat: no-repeat;
        background-size: contain;
 ");
            WriteLiteral(@"       z-index: 401
    }

    #embedIframe {
        height: 100%;
    }

    .leaflet-popup-content {
        width: auto !important;
        display: flex;
        justify-content: center;
    }
</style>

<div class=""col-xl-12 col-lg-12"">
    <div class=""card mb-4"">
        <div class=""card-header py-3 flex-row align-items-center justify-content-between"">

            <div class=""row"">
                <div class=""col-xl-3 col-lg-3 "">
                    <label for=""start"">Từ ngày</label>
                    <input type=""text"" class=""form-control"" autocomplete=""off"" id=""start"" name=""start"" placeholder=""Từ ngày"">
                </div>
                <div class=""col-xl-3 col-lg-3 "">
                    <label for=""end"">Đến ngày</label>
                    <input type=""text"" class=""form-control"" autocomplete=""off"" id=""end"" name=""end"" placeholder=""Đến ngày"">
                </div>
                <div class=""col-xl-3 col-lg-3 "">
                    <label for=""licensePlate"">Biển số");
            WriteLiteral(@" xe</label>
                    <input type=""text"" class=""form-control"" id=""licensePlate"" placeholder=""Biển số xe"">
                </div>
                <div class=""col-xl-3 col-lg-3"" style=""position: relative"">
                    <button type=""submit"" name=""btnResult"" class=""btn btn-info"" style=""margin: auto; position: absolute;bottom: 0"">Tìm kiếm</button>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-md-4 col-xl-4 col-lg-4 "">

                <div class=""p-3 info-vehicle d-none"">
                    <div class=""container-fluid"">
                        <div class=""row"" style=""border: 3px solid #c0c0c0; -ms-border-radius: 10px; border-radius: 10px; background-color: rgb(40,44,52); text-shadow: 1px 1px #5f9ea0; color: white; padding: 15px 0;"">
                            <div class=""col-md-7"" style=""border-right: 1px solid gainsboro"">
                                <h6><i class=""fa fa-home""></i> <span class=""info-1""> </span>");
            WriteLiteral(@"</h6>
                                <h6><i class=""fa fa-building""></i> <span class=""info-2""></span></h6>
                                <h6><i class=""fa fa-handshake""></i> <span class=""info-3""></span></h6>
                                <h6><i class=""fa fa-phone-square""></i> <span class=""info-4""></span></h6>
                            </div>
                            <div class=""col-md-5"">
                                <h3><i class=""fa fa-car""></i> <span class=""info-5""></span></h3>
                                <p><i class=""fa fa-search""></i> <span class=""info-6""></span></p>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""table-responsive p-3"">
                    <table id=""report2"" class=""table table-bordered text-center"" style=""color: black; text-align: left"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th>Giấy ");
            WriteLiteral(@"phép Lx</th>
                                <th>Địa chỉ</th>
                                <th>Thời gian</th>
                            </tr>
                        </thead>
                        <tbody></tbody>
                    </table>
                </div>
            </div>
            <div class=""col-md-8 col-xl-8 col-lg-8"" style=""position: relative; padding: 0 20px 0 0;"">
                <div id=""image"" class=""image"">
                </div>
                <div id=""embedIframe"">
                </div>
            </div>
        </div>
        <nav aria-label=""Page navigation"">
            <ul class=""pagination""></ul>
        </nav>
    </div>
</div>

<!-- Hiển thị dữ liệu-->
<div class=""col-xl-12 col-lg-12 d-none"">
    <div class=""card mb-4"">
        <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
            <h6 class=""m-0 font-weight-bold text-primary"">Lịch sử hình ảnh lái xe</h6>
        </div>
        <div class=""table");
            WriteLiteral(@"-responsive p-3"">
            <table id=""report"" class=""table table-bordered text-center"" style=""color: black;text-align: left"">
                <thead>
                    <tr>
                        <th>Biển số xe</th>
                        <th>Tên lái xe</th>
                        <th>Giấy phép lái xe</th>
                        <th>Thời gian truyền</th>
                        <th>Kinh độ</th>
                        <th>Vĩ độ</th>
                        <th>Tốc độ</th>
                        <th>Hình ảnh vi phạm</th>
                        <th>Địa chỉ</th>
                        <th>Trạng thái</th>
                        <th>Loại vi phạm</th>
                        <th>Kênh</th>
                    </tr>
                </thead>
                <tbody></tbody>
                <tfoot><tr></tr></tfoot>
            </table>
        </div>
        <nav aria-label=""Page navigation"">
            <ul class=""pagination""></ul>
        </nav>
    </div>
</div>

<script>
   ");
            WriteLiteral(@" //datePicker();
    $(function () {
        addClassActive(""category-BAO_CAO"", ""BAO_CAO_CHI_TIET_HANH_TRINH"");

        $('.map-btn').click(function (event) {
            event.preventDefault();
            var lat = 10.829619407653809;
            var lng = 106.76204681396484;
            showMap(lat, lng);
        });
        $('#report2 tbody').on('click', 'tr', function () {
            $(""#embedIframe"").append(DIV_LOADING);
            var lat = $(this).attr(""data-latitude"");
            var lng = $(this).attr(""data-longitude"");
            var urlImg = $(this).attr(""data-img"");
            urlImg = JSON.parse(urlImg);
            showMap(lat, lng, urlImg);
            $(""#div_loader"").remove();
        });

    });

    var mymap = L.map('embedIframe');
    function showMap(lat, lng, urlImg) {
        mymap.setView([lat, lng], 13);

        L.tileLayer('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{y}?access_token=pk.eyJ1IjoibXJ0aWVuMDIzIiwiYSI6ImNrcDR4NW1oaDBnaWEyd3MxM");
            WriteLiteral(@"nhtcnFjMjEifQ.s2ANDHDH7Fsdtiy9MN1AQA', {
            attribution: 'Map data &copy; <a href=""https://www.openstreetmap.org/copyright"">OpenStreetMap</a> contributors, Imagery © <a href=""https://www.mapbox.com/"">Mapbox</a>',
            maxZoom: 18,
            id: 'mapbox/streets-v11',
            tileSize: 512,
            zoomOffset: -1,
            accessToken: 'pk.eyJ1IjoibXJ0aWVuMDIzIiwiYSI6ImNrcDR4NW1oaDBnaWEyd3MxMnhtcnFjMjEifQ.s2ANDHDH7Fsdtiy9MN1AQA'
        }).addTo(mymap);

        let html = ``;

        urlImg.forEach(function (item) {
<<<<<<< HEAD
            html += `<div><img width=""280"" height=""230"" class='img-responsive' style='padding-right:5px' src=""${item.imageLocation}"" /><h6>Channel: ${item.cameraChannel}</h6></div>`;
        });
=======
            //console.log(item)
            html += `<div><img width=""280"" height=""230"" class='img-responsive' style='padding-right:5px' src=""${item.imageLocation}"" /><h6>Channel: ${item.cameraChannel}</h6></div>`;
           

        }");
            WriteLiteral(@")
>>>>>>> origin/tien

        html += ``;

        //var marker = L.marker([lat, lng]).addTo(mymap).bindPopup(`<img width=""300"" height=""250"" src=""${urlImg}"" />`).openPopup();
        var marker = L.marker([lat, lng]).addTo(mymap).bindPopup(`${html}`).openPopup();
        //$(""#image"").css(""background-image"", `url(${urlImg})`);
    }
    //
</script>

<script>

    var plate = '");
#nullable restore
#line 232 "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\LichSuHinhAnhLaiXe.cshtml"
            Write(ViewBag.plate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var start = ");
#nullable restore
#line 233 "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\LichSuHinhAnhLaiXe.cshtml"
           Write(ViewBag.start);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var end = ");
#nullable restore
#line 234 "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\LichSuHinhAnhLaiXe.cshtml"
         Write(ViewBag.end);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var index = \'");
#nullable restore
#line 235 "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\LichSuHinhAnhLaiXe.cshtml"
            Write(ViewBag.index);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    $(document).ready(function () {
        SetDefaultDateTime();
        if (start > 0) {
            let d = new Date(start).toLocaleString(""en-GB"", { hour12: false });
            jQuery('#start').datetimepicker({
                value: d,
                format: 'd/m/Y H:i',
                lang: 'vi',
                onShow: function (ct) {
                    this.setOptions({
                        maxDate: jQuery('#end').val() ? jQuery('#end').val() : false
                    });
                },
                onHide: function() {
                    this.setOptions({});
                }
            });
        }

        if (end > 0) {
            let d = new Date(start + interval - 1).toLocaleString(""en-GB"", { hour12: false });
            jQuery('#end').datetimepicker({
                value: d,
                format: 'd/m/Y H:i',
                lang: 'vi',
                onShow: function (ct) {
                    this.setOptions({
                        m");
            WriteLiteral(@"inDate: jQuery('#start').val() ? jQuery('#start').val() : false
                    });
                }
            });
        }

        $(""#licensePlate"").val(plate);

        if (plate !== """")
            showResult2(index);

    });

    $(""[name='btnResult']"").click(function (e) {
        e.preventDefault();
        showResult2();
    });

    function showResult2(index) {

        $(""#div_loader"").remove();
        var licensePlate = $(""#licensePlate"").val();
        var start = $(""#start"").val();
        var end = $(""#end"").val();
        start = start !== """" ? strToDate(start) : 0;
        end = end !== """" ? strToDate(end) : 0;
        $(""#report2 tbody tr"").remove();
        $(""#embedIframe iframe"").remove();
        //$(""#report tbody tr"").remove();
        window.history.pushState(window.location.href, ""Lịch sử hình ảnh lái xe"", `?plate=${licensePlate}&start=${start}&end=${end}`);
        callApi(`${API_THONG_KE}processimage/image/${licensePlate}/${start}/${end}`, n");
            WriteLiteral(@"ull, ""GET"", function (item) {
        //callApi(`${WAY_URL}waypoint/${licensePlate}/${start}/${end}`, null, ""GET"", function (item) {
<<<<<<< HEAD
=======
            console.log(item)
>>>>>>> origin/tien
            if (item.length > 0) {
                $.notify(""Tải dữ liệu thành công"", ""success"");
                let res = """";
                let count = 1;
                item.forEach(function (pro) {
                    res += `<tr data-latitude='${pro.latitude}' data-longitude='${pro.longitude}' data-img='${JSON.stringify(pro.lstImageMap)}'>`;
                    res += `<td>${pro.driverLicense}</td>`;
                    //if (pro.address !== """" || pro.address !== null) res += `<td class='textDisplay' title='${pro.address}'><code>${pro.address}</code></td>`;else res += `<td></td>`;
                    res += `<td class='textDisplay' title='Đang cập nhật'><code>Đang cập nhật</code></td>`;
                    res += `<td>${epochToTime(pro.dateTime)}</td>`;
                    res += ""</tr");
            WriteLiteral(@">"";
                    count++;
                });
                $(""#report2 tbody"").html(res);

            } else {
                $.notify(`Không tìm thấy kết quả nào`, ""error"");
                $(""#report2 tbody tr"").remove();
                $(""#embedIframe iframe"").remove();
            }
            $(""#div_loader"").remove();

        });
        loadDetailVehicle(licensePlate);
    }

    function loadDetailVehicle(licensePlate) {
        $("".info-vehicle"").removeClass('d-none');
        //var licensePlate = $(""#licensePlate"").val();
        clear();
        callApi(`${REP_URL}vehicle/${licensePlate}/${start}/${end}`, null, ""GET"", function (item) {
            $("".info-1"").html(item.departmentName);
            $("".info-2"").html(item.providerName);
            $("".info-3"").html(item.companyName);
            $("".info-4"").html(item.phone);
            $("".info-5"").html(item.vehicle);
            $("".info-6"").html(""Loại xe: "" + item.vehicleTypeString);
            $(""#div");
            WriteLiteral(@"_loader"").remove();
        });
    }

    function clear() {
        $("".info-1"").html("""");
        $("".info-2"").html("""");
        $("".info-3"").html("""");
        $("".info-4"").html("""");
        $("".info-5"").html("""");
        $("".info-6"").html("""");
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
