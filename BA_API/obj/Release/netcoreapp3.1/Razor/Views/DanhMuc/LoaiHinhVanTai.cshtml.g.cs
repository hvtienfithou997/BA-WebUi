#pragma checksum "D:\BA_Work\BA_API\BA_API\Views\DanhMuc\LoaiHinhVanTai.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b6cde7e9a6255cef8ae104cae60198a56cf8b7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DanhMuc_LoaiHinhVanTai), @"mvc.1.0.view", @"/Views/DanhMuc/LoaiHinhVanTai.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b6cde7e9a6255cef8ae104cae60198a56cf8b7f", @"/Views/DanhMuc/LoaiHinhVanTai.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3bfb59427742d22d27d0c529a835ce80d09517b", @"/Views/_ViewImports.cshtml")]
    public class Views_DanhMuc_LoaiHinhVanTai : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\BA_Work\BA_API\BA_API\Views\DanhMuc\LoaiHinhVanTai.cshtml"
  
    ViewData["Title"] = "LoaiHinhVanTai";
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
                        <th>Loại hình vận tải</th>
                 ");
            WriteLiteral(@"       <th>Thao tác</th>
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
            WriteLiteral(@"  <label data-error=""wrong"" data-success=""right"" for=""lhvtName"">Tên loại hình :</label>
                    <input type=""text"" id=""lhvtName"" class=""form-control"">
                </div>
            </div>
            <div class=""modal-footer d-flex justify-content-center"">
                <button class=""btn btn-success d-none"" name=""btnAdd"">Lưu</button>
                <button class=""btn btn-success"" name=""btnSave"">Lưu</button>
                <button class=""btn btn-danger"" data-dismiss=""modal"" aria-label=""Close"">Hủy</button>
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
        addClassActive(""category-DANH_MUC"", ""DANH_MUC_LHVT"");
    });
    
    callApi(`${API_THONG_KE}vehicletype/get-all`, null, ""GET"", function (item) {
        if (item.length > 0) {
            $.notify(""Tải dữ liệu thành công"", ""success"");
         ");
            WriteLiteral(@"   let res = """";
            let count = 1;
            item.forEach(function (pro) {
                res += `<tr>`;
                res += `<td class=""text-left"">${count}</td>`;
                res += `<td class=""text-left"">${pro.name}</td>`;
                res +=
                    `<td><a href="""" class=""btn btn-primary btn-rounded"" data-toggle=""modal"" data-target="".modalEdit"" onclick=""loadData('${
                    pro.id}')"">Sửa</a>&nbsp<button class=""btn btn-danger btn-rounded"" onclick=""showDelete('${pro.id
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


    function cancel() {
        clearInterval(interval);
        document.getElementById(""msg"").innerHTML = ""Đã hủy"";
        setTimeout(");
            WriteLiteral(@"function () {
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
                callApi(`${API_THONG_KE}vehicletype/delete?id=${id}`, null, ""DELETE"", function (res) {
                    $.notify(""Xóa thành công"", ""success"");
                });
                document.getElementById(""msg"").innerHTML = ""Đã xóa"";
                setTimeout(function () {
                    $(""#boxMessage"").removeClass(""show"");
                }, 500);
            }
        }, 1000);
    }

    $(""[name='btnAdd']"").click(function () {
        add();
        clearData();
    });

    $(""[na");
            WriteLiteral(@"me='btnSave']"").click(function() {
        editData();
    });


    function add() {
        let lhvtName = $(""#lhvtName"").val();
       
        

        if (lhvtName === """") {
            $.notify(""Chưa nhập tên loại hình vận tải"");
            $(""#lhvtName"").focus();
            return;
        }

        let obj = { ""name"": lhvtName }
        callApi(`${API_THONG_KE}vehicletype/add`, obj, ""POST"", function (item) {
            $.notify(""Thêm thành công"", ""success"");
            $('#modalEdit').modal('hide');
        });
    }

    function clearData() {
        $(""#id"").val('');
        $(""#lhvtName"").val('');
        $(""#lhvtName"").focus();
      
    }
    function clearBeforeSave() {
        $("".modal-title"").html(""Thêm loại hình vận tải "");
        $(""[name='btnAdd']"").removeClass(""d-none"");
        $(""[name='btnSave']"").addClass(""d-none"");
        clearData();
    }


    function loadData(id) {

        $("".modal-title"").html(""Sửa thông tin loại hình vận tải """);
            WriteLiteral(@");
        $(""[name='btnAdd']"").addClass(""d-none"");
        $(""[name='btnSave']"").removeClass(""d-none"");

        clearData();
        callApi(`${API_THONG_KE}vehicletype/view?id=${id}`, null, ""GET"", function (item) {
            $(""#lhvtName"").val(item.name);
            $(""#id"").val(item.id);
            
        });
    }

    function editData() {
        let id = $(""#id"").val();
        let lhvtName = $(""#lhvtName"").val();
       

        if (lhvtName === """") {
            $.notify(""Chưa nhập tên loại hình vận tải"");
            $(""#lhvtName"").focus();
            return;
        }

        let obj = { ""id"": id, ""name"": lhvtName}

        callApi(`${API_THONG_KE}vehicletype/edit`, obj, ""PUT"", function (item) {
            if (item.success)
                $.notify(""Sửa thành công"", ""success"");
            $('#modalEdit').modal('hide');
        });
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
