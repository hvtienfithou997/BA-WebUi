#pragma checksum "D:\BA_Work\BA_API\BA_API\Views\QuanTriHeThong\NhatKyTruyCap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e09f06e735f8d5c64eb23a744600ffcfdaf49d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanTriHeThong_NhatKyTruyCap), @"mvc.1.0.view", @"/Views/QuanTriHeThong/NhatKyTruyCap.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e09f06e735f8d5c64eb23a744600ffcfdaf49d0", @"/Views/QuanTriHeThong/NhatKyTruyCap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3bfb59427742d22d27d0c529a835ce80d09517b", @"/Views/_ViewImports.cshtml")]
    public class Views_QuanTriHeThong_NhatKyTruyCap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\BA_Work\BA_API\BA_API\Views\QuanTriHeThong\NhatKyTruyCap.cshtml"
  
    ViewData["Title"] = "Nhật ký truy cập người dùng";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
                    <label for=""username"">Tên đăng nhập</label>
                    <input class=""form-control"" autocomplete=""off"" id=""username"" placeholder=""Tên đăng nhập"" />
                </div>
                <div class=""form-group col-xl-4 col-lg-6"">
                    <label for=""start"">Từ ngày</label>
                    <input type=""text"" class=""form-control"" id=""start"" name=""start"" placeholder=""Từ ngày"">
                </div>
                <div class=""form-group col-xl-4 col-lg-6"">
                    <label for=""end"">Đến ngày</label>
                    <input type=""text"" c");
            WriteLiteral(@"lass=""form-control"" id=""end"" name=""end"" placeholder=""Đến ngày"">
                </div>
            </div>
            <button type=""submit"" name=""btn-result"" class=""btn btn-info"" style=""margin: auto"">Tìm kiếm</button>
        </div>
    </div>
</div>
<!-- Hiển thị dữ liệu-->
<div class=""col-xl-12 col-lg-12"">
    <div class=""card mb-4"">
        <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
            <h6 class=""m-0 font-weight-bold text-primary"">Nhật ký truy cập người dùng</h6>
            <h6 class=""total font-weight-bold""></h6>
        </div>
        <div class=""table-responsive p-3"">
            <table id=""report"" class=""table table-bordered text-center"" style=""color: black"">
                <thead>
                    <tr>
                        <th rowspan=""2"" style=""width: 10px;"">STT</th>
                        <th rowspan=""2"">Người dùng</th>
                        <th rowspan=""2"">Thời gian</th>
                        <th rowspan=""2"">P");
            WriteLiteral(@"hương thức</th>
                        <th rowspan=""2"">Chức năng</th>
                        <th rowspan=""2"">Tham số truy vấn</th>
                        <th rowspan=""2"">Trạng thái</th>
                    </tr>
                </thead>
                <tbody></tbody>
            </table>
        </div>
        <nav aria-label=""Page navigation"">
            <ul class=""pagination""></ul>
        </nav>
    </div>
</div>
<script>

    var username = '");
#nullable restore
#line 62 "D:\BA_Work\BA_API\BA_API\Views\QuanTriHeThong\NhatKyTruyCap.cshtml"
               Write(ViewBag.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var start = \'");
#nullable restore
#line 63 "D:\BA_Work\BA_API\BA_API\Views\QuanTriHeThong\NhatKyTruyCap.cshtml"
            Write(ViewBag.start);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var end = \'");
#nullable restore
#line 64 "D:\BA_Work\BA_API\BA_API\Views\QuanTriHeThong\NhatKyTruyCap.cshtml"
          Write(ViewBag.end);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var index = \'");
#nullable restore
#line 65 "D:\BA_Work\BA_API\BA_API\Views\QuanTriHeThong\NhatKyTruyCap.cshtml"
            Write(ViewBag.index);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

    $(document).ready(function () {

        addClassActive(""category-QUAN_TRI_HE_THONG"", ""QUAN_TRI_HE_THONG_NHAT_KY_TRUY_CAP"");
            datePicker();
        if (start > 0)
            $('[name=""start""]').datepicker({ format: 'dd/mm/yyyy' }).datepicker('setDate', EpochToHuman(start));
        if (end > 0)
            $('[name=""end""]').datepicker({ format: 'dd/mm/yyyy' }).datepicker('setDate', EpochToHuman(end));

        if (username !== '') {
            $(""#username"").val(username);
            showResult(0);
        }
    });

    function showResult(index) {
        let username = $(""#username"").val();
        let start = $(""#start"").val();
        let end = $(""#end"").val();
        start = start !== """" ? ConvertToUnix(start) : 0;
        end = end !== """" ? ConvertToUnix(end) : 0;
        $(""#report tbody tr"").remove();
        $(""#report tfoot tr th"").remove();
        window.history.pushState(window.location.href, ""Nhật ký truy cập"", `?username=${username}&start=${start");
            WriteLiteral(@"}&end=${end}&index=${index}`);
        callApi(`${REP_URL}user/log?username=${username}&start=${start}&end=${end}&index=${index}`, null, ""GET"", function (item) {
            if (item.records > 0) {
                $.notify(""Tải dữ liệu thành công"", ""success"");
                let res = """";
                let count = 1;
                item.data.forEach(function (pro) {
                    res += ""<tr>"";
                    res += `<td>${count}</td>`;
                    res += `<td class=""text-left"">${pro.username}</td>`;
                    res += `<td class=""text-left"">${pro.sdate}</td>`;
                    res += `<td class=""text-left"">${pro.method}</td>`;
                    res += `<td class=""text-left"">${pro.resource}</td>`;
                    res += `<td class=""text-left"">${pro.params !== null ? pro.params : """"}</td >`;
                    res += `<td class=""text-left"">${pro.statusCode === 200 ? ""<span class='text-success'>Thành công<span>"" : ""<span class='text-success'>Không thành côn");
            WriteLiteral(@"g<span>""}</td>`;
                    res += ""</tr>"";
                    count++;
                });

                $(""#report tbody"").html(res);
                Paging(index, 'showResult', item.records);

            } else {
                $.notify(`Không tìm thấy kết quả nào`, ""error"");
            }

        });
    }

    $(""[name='btn-result']"").click(function () {
        index = 0;
        showResult(index);
    });
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
