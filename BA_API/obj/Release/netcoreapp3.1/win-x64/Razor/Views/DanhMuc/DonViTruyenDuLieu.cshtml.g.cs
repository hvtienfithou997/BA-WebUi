#pragma checksum "D:\BA_Work\BA_API\BA_API\Views\DanhMuc\DonViTruyenDuLieu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "340198e6f86d3f89b3d6c433ede49345de172c0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DanhMuc_DonViTruyenDuLieu), @"mvc.1.0.view", @"/Views/DanhMuc/DonViTruyenDuLieu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"340198e6f86d3f89b3d6c433ede49345de172c0c", @"/Views/DanhMuc/DonViTruyenDuLieu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3bfb59427742d22d27d0c529a835ce80d09517b", @"/Views/_ViewImports.cshtml")]
    public class Views_DanhMuc_DonViTruyenDuLieu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\BA_Work\BA_API\BA_API\Views\DanhMuc\DonViTruyenDuLieu.cshtml"
  
    ViewData["Title"] = "Danh sách đơn vị truyền dữ liệu";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""col-xl-12 col-lg-12"" style=""margin-bottom: 10px;"">
    <div class=""row"">
        <div class=""col-xl-8""></div>
        <div class=""col-xl-4"" style=""text-align: right"">
            <button name=""btn-addNew"" class=""btn btn-success"" data-toggle=""modal"" data-target="".modalEdit"" onclick=""clearBeforeSave()""><i class=""fas fa-plus fa-fw""></i>Thêm</button>
        </div>
    </div>
</div>


<!-- Hiển thị dữ liệu-->
<div class=""col-xl-12 col-lg-12"">
    <div class=""card mb-4"">
        <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
            <h6 class=""m-0 font-weight-bold text-primary"">Danh sách đơn vị truyền dữ liệu</h6>
        </div>
        <div class=""table-responsive p-3"">
            <table id=""report"" class=""table table-bordered text-center"" style=""color: black; text-align: left"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th>Tên đơn vị truyền dữ liệu</th>
       ");
            WriteLiteral(@"                 <th>Thao tác</th>
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

<div class=""modal fade modalEdit"" id=""modalEdit"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header text-center"">
                <h4 class=""modal-title w-100 font-weight-bold""></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body mx-3"">
                <input type=""text"" hidden=""hidden"" id=""id"" value=""0"" />
                <div class=""mb-3"">
        ");
            WriteLiteral(@"            <label data-error=""wrong"" data-success=""right"" for=""providerName"">Tên đơn vị truyền dữ liệu :</label>
                    <input type=""text"" id=""providerName"" class=""form-control"">
                </div>
                <div class=""mb-3"">
                    <label data-error=""wrong"" data-success=""right"" for=""providerName"">Số điện thoại :</label>
                    <input type=""text"" id=""providerNumber"" class=""form-control"">    
                </div>
                <div class=""mb-3"">
                    <label data-error=""wrong"" data-success=""right"" for=""providerEmail"">Email :</label>
                    <input type=""text"" id=""providerEmail"" class=""form-control"">
                </div>
                <div class=""mb-3"">
                    <label data-error=""wrong"" data-success=""right"" for=""providerUrl"">Website :</label>
                    <input type=""text"" id=""providerUrl"" class=""form-control"">
                </div>

            </div>
            <div class=""modal-footer d");
            WriteLiteral("-flex justify-content-center\">\r\n                <button class=\"btn btn-success d-none\" name=\"btnAdd\">Lưu</button>\r\n                <button class=\"btn btn-success\" name=\"btnSave\">Lưu</button>\r\n");
            WriteLiteral(@"                <button class=""btn btn-danger"" data-dismiss=""modal"" aria-label=""Close"">Hủy</button>
            </div>
        </div>
    </div>
</div>

<div id=""boxMessage"">
    <p id=""msg""></p>
    <button class=""btn btn-light custom"" onclick=""cancel()"">Hoàn tác</button>
</div>
<script>

    $(function () {
        addClassActive(""category-DANH_MUC"", ""DANH_MUC_DVTDL"");
    });
    callApi(`${REP_URL}provider/all`, null, ""GET"", function (item) {
        if (item.length > 0) {
            $.notify(""Tải dữ liệu thành công"", ""success"");
            let res = """";
            let count = 1;
            item.forEach(function (pro) {
                res += `<tr>`;
                res += `<td class=""text-left"">${count}</td>`;
                res += `<td class=""text-left"">${pro.name}</td>`;
                res +=
                    `<td><a href="""" class=""btn btn-primary btn-rounded"" data-toggle=""modal"" data-target="".modalEdit"" onclick=""loadData('${
                    pro.id}')"">Sửa</a>&nbs");
            WriteLiteral(@"p<button class=""btn btn-danger btn-rounded"" onclick=""showDelete('${pro.id
                    }')"">Xóa</button></td>`;
                res += ""</tr>"";
                count++;
            });
            $(""#report tbody"").html(res);
            $(""#report"").DataTable();
        } else {
            $.notify(`Không tìm thấy kết quả nào`, ""error"");
            $(""#report tbody tr"").remove();
        }
    });


    function add() {
        let providerName = $(""#providerName"").val();
        let providerNumber = $(""#providerNumber"").val();
        let providerEmail = $(""#providerEmail"").val();
        let providerUrl = $(""#providerUrl"").val();

       
        if (providerName === """") {
            $.notify(""Chưa nhập tên đơn vị truyền dữ liệu"");
            $(""#providerName"").focus();
            return;
        }

        let obj = { ""name"": providerName, ""phone"": providerNumber, ""email"": providerEmail, ""url"": providerUrl }

        //callApi(`${API_THONG_KE}provider/all`, null, ");
            WriteLiteral(@"""GET"", function (item) {
        callApi(`${API_THONG_KE}provider/add`, obj, ""POST"", function (item) {
            $.notify(""Thêm thành công"", ""success"");
            $('#modalEdit').modal('hide');
        });
    }

    $(""[name='btnAdd']"").click(function () {
        add();
        clearData();
    });

    $(""[name='btnSave']"").click(function() {
        editData();
    });
    function clearData() {
        $(""#id"").val('');
        $(""#providerName"").val('');
        $(""#providerName"").focus();
        $(""#providerNumber"").val("""");
        $(""#providerEmail"").val("""");
        $(""#providerUrl"").val("""");
    }


    function clearBeforeSave() {
        $("".modal-title"").html(""Thêm đơn vị truyền dữ liệu "");
        $(""[name='btnAdd']"").removeClass(""d-none"");
        $(""[name='btnSave']"").addClass(""d-none"");
        clearData();
    }

    function loadData(id) {

        $("".modal-title"").html(""Sửa thông tin đơn vị truyền dữ liệu "");
        $(""[name='btnAdd']"").addClass(""");
            WriteLiteral(@"d-none"");
        $(""[name='btnSave']"").removeClass(""d-none"");

        clearData();
        callApi(`${API_THONG_KE}provider/view?id=${id}`, null, ""GET"", function (item) {
            $(""#providerName"").val(item.name);
            $(""#id"").val(item.id);
            $(""#providerNumber"").val(item.phone);
            $(""#providerEmail"").val(item.email);
            $(""#providerUrl"").val(item.url);
        });
    }


    function editData() {
        let id = $(""#id"").val();
        let providerName = $(""#providerName"").val();
        let providerNumber = $(""#providerNumber"").val();
        let providerEmail = $(""#providerEmail"").val();
        let providerUrl = $(""#providerUrl"").val();

        if (providerName === """") {
            $.notify(""Chưa nhập tên đơn vị truyền dữ liệu"");
            $(""#providerName"").focus();
            return;
        }

        let obj = { ""id"": id, ""name"": providerName, ""phone"": providerNumber, ""email"": providerEmail, ""url"": providerUrl }

        ca");
            WriteLiteral(@"llApi(`${API_THONG_KE}provider/edit`, obj, ""PUT"", function (item) {
            if(item.success)
                $.notify(""Sửa thành công"", ""success"");
            $('#modalEdit').modal('hide');

        });
    }
    function cancel() {
        clearInterval(interval);
        document.getElementById(""msg"").innerHTML = ""Đã hủy"";
        setTimeout(function () {
            $(""#boxMessage"").removeClass(""show"");
        }, 500);
    }


    var interval;
    function showDelete(id) {
        var timer = 3;
        $(""#boxMessage"").addClass(""show"");
        interval = setInterval(function () {
            timer--;
            document.getElementById(""msg"").innerHTML = ""Dữ liệu sẽ được xóa sau: "" + timer;
            $(""#boxMessage"").addClass(""show"");
            if (timer < 1) {
                clearInterval(interval);
                callApi(`${API_THONG_KE}provider/delete?id=${id}`, null, ""DELETE"", function (res) {
                    $.notify(""Xóa thành công"", ""success"");
        ");
            WriteLiteral(@"        });
                document.getElementById(""msg"").innerHTML = ""Đã xóa"";
                setTimeout(function () {
                    $(""#boxMessage"").removeClass(""show"");
                }, 500);
            }
        }, 1000);
    }


</script>




");
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
