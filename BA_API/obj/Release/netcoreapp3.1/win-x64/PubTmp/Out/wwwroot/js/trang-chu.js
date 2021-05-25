$(document).ready(function () {
    //$('#dataTable').DataTable();
});

function getDashBoard() {
    callApi(`http://192.168.1.59:800/api/v1/dashboardlandmarks/dashboard/getDashboard`, null, "GET", function (item) {
        console.log(item);
    });
}


$("[name='quickSearch']").click(function (e) {
    e.preventDefault();
    var vehiclePlate = $("#vehiclePlate").val();
    var date = $("#date").val();

    date = date !== "" ? ConvertToUnix(date) : 0;

    if (vehiclePlate !== "" && date > 0) {
        callApi(`${REP_URL}dashboard/datatransfer/quick/${vehiclePlate}?start=${date}&end=${date}`, null, "GET", function (item) {
            $('#showDataTransfer').modal('show');
            var text = "<p>" + item + "<p>";
            $('#showDataTransfer .modal-body').html(text);

        });
    } else {
        $.notify("Bạn cần nhập biển kiểm soát và thời điểm ", "error");
    }
});


$("[name='showDetail']").click(function (e) {
    e.preventDefault();
    var vehiclePlate = $("#vehiclePlate").val();
    var date = $("#date").val();
    date = date !== "" ? ConvertToUnix(date) : 0;
    window.location.href = `/bao-cao/chi-tiet/lich-su-hinh-anh-lai-xe?plate=${vehiclePlate}&start=${date}&end=${date}`;
});

