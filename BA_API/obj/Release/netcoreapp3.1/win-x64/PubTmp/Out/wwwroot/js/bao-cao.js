$(document).ready(function () {
    //loadSoGTVT();
    //loadLoaiHinh();
});

$("[name='showSynthesisReport']").click(function (e) {
    e.preventDefault();
    var start = $("#start").val();
    var end = $("#end").val();
    start = start !== "" ? ConvertToUnix(start) : 0;
    end = end !== "" ? ConvertToUnix(end) : 0;
    var vehicleType = $("#vehicleType").val();
    if (start < 1 || end < 1) {
        $.notify("Bạn cần nhập thời gian", "error");
        return;
    }
    //window.history.pushState(window.location.href, "Báo cáo tổng hợp", `?start=${start}&end=${end}&vehicleType=-1`);

    callApi(`${REP_URL}topicalreport/country?start=${start}&end=${end}&vehicleType=${vehicleType}`, null, "GET", function (item) {
        if (item.records > 0) {
            $.notify("Tải dữ liệu thành công", "success");
            let res = "";
            let count = 1;
            item.data.forEach(function (pro) {
                res += "<tr>";
                res += `<td>${count}</td>`;
                res += `<td class="text-left"><a href="/bao-cao/tong-hop/so-gtvt?id=${pro.department_id}&start=${start}&end=${end}&vehicleType=-1&index=0">${pro.department_name}</a></td>`;
                res += `<td>${pro.company_violate}</td>`;
                res += `<td>${pro.company_total}</td>`;
                res += `<td>${pro.company_rate}</td>`;
                res += `<td>${pro.vehicle_violate}</td>`;
                res += `<td>${pro.vehicle_total}</td>`;
                res += `<td>${pro.vehicle_rate}</td>`;
                res += "</tr>";
                count++;
            });

            let totalRes = `<th>Tổng</th>`;
            totalRes += `<th></th>`;
            totalRes += `<th>${item.companyViolateSum}</th>`;
            totalRes += `<th>${item.companyTotalSum}</th>`;
            totalRes += `<th>${item.companyRateAvg}</th>`;
            totalRes += `<th>${item.vehicleViolateSum}</th>`;
            totalRes += `<th>${item.vehicleTotalSum}</th>`;
            totalRes += `<th>${item.vehicleRateAvg}</th>`;
            $("#synthesisReport tbody").empty();
            $("#synthesisReport tbody").html(res);
            $("#synthesisReport tfoot tr").html(totalRes);
            $("#synthesisReport tfoot tr th").addClass("text-danger");
        }
    });
});




