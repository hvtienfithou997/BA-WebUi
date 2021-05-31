#pragma checksum "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTruyenDuLieu\ToanQuoc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c69356c6be1b6328cfd88ec7c9fd3e980cb8b301"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaoCaoTruyenDuLieu_ToanQuoc), @"mvc.1.0.view", @"/Views/BaoCaoTruyenDuLieu/ToanQuoc.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69356c6be1b6328cfd88ec7c9fd3e980cb8b301", @"/Views/BaoCaoTruyenDuLieu/ToanQuoc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3bfb59427742d22d27d0c529a835ce80d09517b", @"/Views/_ViewImports.cshtml")]
    public class Views_BaoCaoTruyenDuLieu_ToanQuoc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTruyenDuLieu\ToanQuoc.cshtml"
  
    ViewData["Title"] = "Toàn quốc";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
                    <label for=""start"">Nhập ngày</label>
                    <input type=""text"" class=""form-control"" id=""date"" name=""date"" placeholder=""Từ ngày"">
                </div>
                <button type=""submit"" name=""btnReport"" class=""btn btn-info"" style=""margin: auto"">Tìm kiếm</button>
                
            </div>
        </div>
    </div>
</div>

<!-- Hiển thị dữ liệu-->
<div class=""col-xl-12 col-lg-12"">
    <div class=""card mb-4"">
        <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
         ");
            WriteLiteral(@"   <h6 class=""m-0 font-weight-bold text-primary"">Báo cáo truyền dữ liệu toàn quốc</h6>
            <h6 class=""total font-weight-bold""></h6>
        </div>
        <div class=""table-responsive p-3"">
            <table id=""report"" class=""table table-bordered text-center"" style=""color: black"">
                <thead>
                    <tr>
                        <th rowspan=""2"" style=""width: 10px;"">STT</th>
                        <th rowspan=""2"">Sở GTVT</th>
                        <th rowspan=""2"">Tổng số phương tiện	</th>
                        <th rowspan=""2"">Số phương tiện truyền dữ liệu</th>
                        <th rowspan=""2"">Số bản tin</th>
                    </tr>
                </thead>
                <tbody></tbody>
                <tfoot><tr></tr></tfoot>
            </table>
        </div>
    </div>
</div>

<script>
    $(function() {
        addClassActive(""category-BAO_CAO"", ""BAO_CAO_TRUYEN_DL_TOAN_QUOC"");
        
        datePickerOne();
    });
    
</scri");
            WriteLiteral(@"pt>

<script>
    $(""[name='btnReport']"").click(function(e) {
        var date = $(""#date"").val();
        date = date !== """" ? ConvertToUnix(date) : 0;
        $(""#report tbody tr"").remove();
        $(""#report tfoot tr th"").remove();
        callApi(`${REP_URL}datatransfer/country?date=${date}`, null, ""GET"", function (item) {
            if (item.records > 0) {
                $.notify(""Tải dữ liệu thành công"", ""success"");
                let res = """";
                let count = 1;
                item.data.forEach(function (pro) {
                    res += ""<tr>"";
                    res += `<td>${count}</td>`;
                    res += `<td class=""text-left""><a href=""/bao-cao-truyen-du-lieu/truyen-du-lieu/so-gtvt?department=${pro.department_id}&date=${date}&index=0"">${pro.department_name}</a></td>`;
                    res += `<td class=""text-right"">${pro.total_vehicle}</td>`;
                    res += `<td class=""text-right"">${pro.total_vehicle_transfer}</td>`;
                    ");
            WriteLiteral(@"res += `<td class=""text-right"">${pro.image_count}</td>`;
                    res += ""</tr>"";
                    count++;
                });

                let totalRes = `<th>Tổng</th>`;
                totalRes += `<th></th>`;
                totalRes += `<th class=""text-right"">${item.totalVehicles}</th>`;
                totalRes += `<th class=""text-right"">${item.totalVehicleTransfers}</th>`;
                totalRes += `<th class=""text-right"">${item.totalImages}</th>`;
                $(""#report tbody"").empty();
                $(""#report tbody"").html(res);
                $(""#report tfoot tr"").html(totalRes);
                $(""#report tfoot tr th"").addClass(""text-danger"");
            }
        });
    })
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
