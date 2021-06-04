#pragma checksum "D:\BA_Work\BA_API\BA_API\Views\QuanTriHeThong\NhomNguoiDung.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6878b50dfc7b60c90ead1f799ca83aa0b13093db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanTriHeThong_NhomNguoiDung), @"mvc.1.0.view", @"/Views/QuanTriHeThong/NhomNguoiDung.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6878b50dfc7b60c90ead1f799ca83aa0b13093db", @"/Views/QuanTriHeThong/NhomNguoiDung.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3bfb59427742d22d27d0c529a835ce80d09517b", @"/Views/_ViewImports.cshtml")]
    public class Views_QuanTriHeThong_NhomNguoiDung : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\BA_Work\BA_API\BA_API\Views\QuanTriHeThong\NhomNguoiDung.cshtml"
  
    ViewData["Title"] = "Nhóm người dùng";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .modalEdit .star label:nth-child(1):after {
        content: "" (*)"";
        color: red;
    }

    .custom {
        float: right;
        height: 25px;
        font-size: 12px;
        line-height: 1;
    }
</style>

<!-- Khu vực tìm kiếm -->
<div class=""col-xl-12 col-lg-12"">
    <div class=""card mb-4"">
        <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
            <h6 class=""m-0 font-weight-bold text-primary"">
                Tra cứu thông tin
            </h6>
        </div>
        <div class=""card-body"">
            <div class=""row"">
                <div class=""form-group col-xl-4 col-lg-6"">
                    <label for=""term"">Tên nhóm</label>
                    <input type=""text"" class=""form-control"" id=""term"" name=""term"" placeholder=""Nhập tên nhóm"">
                </div>
            </div>
            <div class=""row"">
                <div class=""col-xl-10""></div>
                <div class=""col-xl-2"" style");
            WriteLiteral(@"=""text-align: right"">
                    <button type=""submit"" name=""btnResult"" class=""btn btn-info"" style=""margin: auto"">Tìm kiếm</button>
                    <button name=""btn-addNew"" class=""btn btn-success"" data-toggle=""modal"" data-target="".modalEdit"" onclick=""clearBeforeSave()""><i class=""fas fa-plus fa-fw""></i>Thêm</button>
                </div>

            </div>
        </div>
    </div>
</div>

<!-- Hiển thị dữ liệu-->
<div class=""col-xl-12 col-lg-12"">
    <div class=""card mb-4"">
        <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
            <h6 class=""m-0 font-weight-bold text-primary"">Danh sách nhóm người dùng</h6>
        </div>
        <div class=""table-responsive p-3"">
            <table id=""report"" class=""table table-bordered text-center"" style=""color: black;text-align: left"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th>Tên</th>
                        <th>");
            WriteLiteral(@"Loại</th>
                        <th>Kích hoạt</th>
                        <th>Trạng thái</th>
                        <th>Thao tác</th>
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
          ");
            WriteLiteral(@"      <input type=""text"" hidden=""hidden"" id=""id"" value=""0"" />
                <div class=""mb-3 star"">
                    <label data-error=""wrong"" data-success=""right"" for=""formCompany"">Tên nhóm người dùng </label>
                    <input type=""text"" id=""userGroup"" class=""form-control"">
                </div>
            </div>
            <div class=""modal-footer d-flex justify-content-center"">
                <button class=""btn btn-success d-none"" name=""btnAdd"">Lưu</button>
                <button class=""btn btn-success"" name=""btnSave"">Lưu</button>
                <button class=""btn btn-primary"" name=""btnSaveContinue"">Lưu và tiếp tục</button>
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

    $(function() {
        addClassActive(""category-Q");
            WriteLiteral(@"UAN_TRI_HE_THONG"", ""QUAN_TRI_HE_THONG_NHOM_NGUOI_DUNG"");
        
    });

    search("""");
    $(""[name='btnResult']"").click(function () {
        let term = $(""#term"").val();
        term = term !== """" || typeof term != 'undefined' ? term : """";
        search(term);

    });
    function search(term) {
        callApi(`${REP_URL}roles?name=${term}`, null, ""GET"", function (item) {
            if (item.length > 0) {
                $.notify(""Tải dữ liệu thành công"", ""success"");
                let res = """";
                let count = 1;
                item.forEach(function (pro) {
                    res += `<tr>`;
                    res += `<td class=""text-left"">${count}</td>`;
                    res += `<td class=""text-left"">${pro.name}</td>`;
                    res += `<td class=""text-left"">${pro.type}</td>`;
                    if (pro.status == 0) {
                        res += `<td><input type='checkbox' name='active' data-active='1' onclick='checkActive(this,""${pro.id}"")' c");
            WriteLiteral(@"lass=''/></td>`;
                    }
                    else if (pro.status == 1) {
                        res += `<td><input type='checkbox' data-active='0' checked name='active' onclick='checkActive(this,""${pro.id}"")' class=''/></td>`;
                    }

                    res += `<td class=""text-left"">${pro.status = pro.status == 0 ? ""Khóa"" : ""Kích hoạt""}</td>`;
                    res += `<td><a href="""" class=""btn btn-primary btn-rounded"" data-toggle=""modal"" data-target="".modalEdit"" onclick=""loadData('${pro.id}')"">Sửa</a>&nbsp<button class=""btn btn-danger btn-rounded"" onclick=""showDelete('${pro.id}')"">Xóa</button></td>`;
                    res += ""</tr>"";
                    count++;
                });
                $(""#report tbody"").html(res);
                //$('#report').DataTable({
                //    ""info"": false,
                //    ""searching"": false,
                //    ""lengthChange"": false
                //});
            } else {
                $.notify");
            WriteLiteral(@"(`Không tìm thấy kết quả nào`, ""error"");
                $(""#report tbody tr"").remove();
            }
        });
    }

    function loadData(id) {
        if (id !== """") {
            $("".modal-title"").html(""Sửa thông tin "");
            $(""[name='btnSaveContinue']"").addClass(""d-none"");
            $(""[name='btnAdd']"").addClass(""d-none"");
            $(""[name='btnSave']"").removeClass(""d-none"");
            $(""#id"").val("""");
            callApi(`${REP_URL}roles/${id}`, null, ""GET"", function (item) {
                $(""#id"").val(item.id);
                $(""#userGroup"").val(item.name);
            });
        }
    }
    $(""[name='btnSave']"").click(function () {
        save();
    });

    $(""[name='btnAdd']"").click(function () {
        save();
    });
    $(""[name='btnSaveContinue']"").click(function () {
        save();
        $(""#userGroup"").val("""");
    });

    function save() {
        let id = $(""#id"").val();
        let userGroup = $(""#userGroup"").val();
        if");
            WriteLiteral(@" (userGroup === """" || userGroup == null) {
            $.notify(""Chưa nhập tên nhóm người dùng"");
            $(""#userGroup"").focus();
            return;
        }
        var obj = { ""id"": id, ""name"": userGroup }
        callApi(`${REP_URL}roles`, obj, ""POST"", function (res) { });
        $('#modalEdit').modal('hide');
    }

    function clearBeforeSave() {
        $("".modal-title"").html(""Tạo mới dữ liệu"");
        $(""[name='btnSave']"").addClass(""d-none"");
        $(""[name='btnAdd']"").removeClass(""d-none"");
        $(""[name='btnSaveContinue']"").removeClass(""d-none"");

        $(""#id"").val(""0"");
        $(""#userGroup"").val("""");
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
  ");
            WriteLiteral(@"              clearInterval(interval);
                callApi(`${REP_URL}roles/${id}`, null, ""DELETE"", function (res) {
                    $.notify(""Xóa thành công"", ""success"");
                    search("""");
                });
                document.getElementById(""msg"").innerHTML = ""Đã xóa"";
                setTimeout(function () {
                    $(""#boxMessage"").removeClass(""show"");
                }, 500);
            }
        }, 1000);
    }
    function cancel() {
        clearInterval(interval);
        document.getElementById(""msg"").innerHTML = ""Đã hủy"";
        setTimeout(function () {
            $(""#boxMessage"").removeClass(""show"");
        }, 500);
    }

    function checkActive(me, id) {
        var val = $(me).attr('data-active');
        callApi(`${REP_URL}roles/${id}/active?status=${val}`, null, ""GET"", function (item) {
            $(""#id"").val(item.id);
            $(""#userGroup"").val(item.name);
        });
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
