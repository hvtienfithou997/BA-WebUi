#pragma checksum "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\DonViVanTai.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f3e9e07b349042e8ac76161ae2d0c5ebaaadf12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaoCaoTongHop_DonViVanTai), @"mvc.1.0.view", @"/Views/BaoCaoTongHop/DonViVanTai.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f3e9e07b349042e8ac76161ae2d0c5ebaaadf12", @"/Views/BaoCaoTongHop/DonViVanTai.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3bfb59427742d22d27d0c529a835ce80d09517b", @"/Views/_ViewImports.cshtml")]
    public class Views_BaoCaoTongHop_DonViVanTai : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\DonViVanTai.cshtml"
  
    ViewData["Title"] = "Đơn vị vận tải";

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
                <div class=""form-group col-xl-3 col-lg-6"">
                    <label for=""department"">Sở GTVT</label>
                    <select class=""form-control"" id=""department"" placeholder=""Sở GTVT"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f3e9e07b349042e8ac76161ae2d0c5ebaaadf124463", async() => {
                WriteLiteral("Chọn sở GTVT");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                </div>
                <div class=""form-group col-xl-3 col-lg-6"">
                    <label for=""transportUnit"">Đơn vị vận tải</label>
                    <select class=""form-control"" id=""transportUnit"" placeholder=""Đơn vị vận tải"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f3e9e07b349042e8ac76161ae2d0c5ebaaadf125946", async() => {
                WriteLiteral("Chọn đơn vị vận tải");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                </div>
                <div class=""form-group col-xl-3 col-lg-6"">
                    <label for=""licensePlate"">Biển kiểm soát</label>
                    <select class=""form-control"" id=""licensePlate"" placeholder=""Biển kiểm soát"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f3e9e07b349042e8ac76161ae2d0c5ebaaadf127434", async() => {
                WriteLiteral("Chọn biển kiểm soát");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                </div>
                <div class=""form-group col-xl-3 col-lg-6"">
                    <label for=""vehicleType"">Loại hình</label>
                    <select class=""form-control"" id=""vehicleType"" placeholder=""Loại hình"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f3e9e07b349042e8ac76161ae2d0c5ebaaadf128910", async() => {
                WriteLiteral("Tất cả ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                </div>
                <div class=""form-group col-xl-3 col-lg-6"">
                    <label for=""start"">Từ ngày</label>
                    <input type=""text"" class=""form-control"" id=""start"" name=""start"" placeholder=""Từ ngày"">
                </div>
                <div class=""form-group col-xl-3 col-lg-6"">
                    <label for=""end"">Đến ngày</label>
                    <input type=""text"" class=""form-control"" id=""end"" name=""end"" placeholder=""Đến ngày"">
                </div>
            </div>
            <button type=""submit"" name=""showTransportUnit"" class=""btn btn-info"" style=""margin: auto"">Xem báo cáo</button>
        </div>
    </div>
</div>

<!-- Hiển thị dữ liệu-->
<div class=""col-xl-12 col-lg-12"">
    <div class=""card mb-4"">
        <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
            <h6 class=""m-0 font-weight-bold text-primary"">Báo cáo tổng hợp đơn vị vận tải</h6>
         ");
            WriteLiteral(@"   <h6 class=""total font-weight-bold""></h6>
        </div>
        <div class=""table-responsive p-3"">
            <table id=""report"" class=""table table-bordered text-center"" style=""color: black"">
                <thead>
                    <tr>
                        <th rowspan=""2"" style=""width: 10px;"">STT</th>
                        <th rowspan=""2"">Biển kiểm soát</th>
                        <th rowspan=""2"">Loại hình</th>
                        <th colspan=""3"">Dữ liệu ảnh</th>
                    </tr>
                    <tr>
                        <th>Vi phạm</th>
                        <th>Σ</th>
                        <th>%</th>
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
    datePicker();
    loadLoaiHinh();
</script>
<script");
            WriteLiteral(">\r\n    var company = \'");
#nullable restore
#line 92 "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\DonViVanTai.cshtml"
              Write(ViewBag.company);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var start = \'");
#nullable restore
#line 93 "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\DonViVanTai.cshtml"
            Write(ViewBag.start);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var end = \'");
#nullable restore
#line 94 "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\DonViVanTai.cshtml"
          Write(ViewBag.end);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var vehicleType = \'");
#nullable restore
#line 95 "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\DonViVanTai.cshtml"
                  Write(ViewBag.vehicleType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var index = \'");
#nullable restore
#line 96 "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\DonViVanTai.cshtml"
            Write(ViewBag.index);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var vehicle = \'");
#nullable restore
#line 97 "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\DonViVanTai.cshtml"
              Write(ViewBag.vehicle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var department = \'");
#nullable restore
#line 98 "D:\BA_Work\BA_API\BA_API\Views\BaoCaoTongHop\DonViVanTai.cshtml"
                 Write(ViewBag.department);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    var status = false;
    $(document).ready(function() {
        callApi(`${REP_URL}department/all`, null, ""GET"", function (obj) {
            let res = ""<option value='-1'>Chọn sở GTVT</option>"";
            obj.forEach(function (pro) {
                res += `<option value=""${pro.id}"">${pro.name}</option>`;
            });
            $(""#department"").select2();
            $(""#department"").html(res);
            if (department !== """") {
                $(""#department"").val(department);
                loadDVVT(department);
            }

        });
        $(""#department"").change(function () {
            loadDVVT($(this).val());
        });
        $(""#transportUnit"").change(function () {
            callApi(`${REP_URL}vehicle/company/${$(this).val()}`, null, ""GET"", function (obj) {
                let res = ""<option value=''>Chọn biển kiểm soát</option>"";
                obj.forEach(function (pro) {
                    res += `<option value=""${pro.vehicle}"">${pro.vehicle}</op");
            WriteLiteral(@"tion>`;
                });
                $(""#licensePlate"").select2().trigger('change');
                $(""#licensePlate"").html(res);
            });
        });
        if (vehicle === """")
            $(""#licensePlate"").val();

        setTimeout(function () {
            if (start > 0)
                $('[name=""start""]').datepicker({ format: 'dd/mm/yyyy'}).datepicker('setDate', EpochToHuman(start));
            if (end > 0)
                $('[name=""end""]').datepicker({ format: 'dd/mm/yyyy' }).datepicker('setDate', EpochToHuman(end));

        }, 1000);
        //if (department !== """") {
        //    showResult(index);
        //}
    });

    function showResult(index) {
        var transportUnit = $(""#transportUnit"").val();
        var department = $(""#department"").val();
        var start = $(""#start"").val();
        var end = $(""#end"").val();
        start = start !== """" ? ConvertToUnix(start) : 0;
        end = end !== """" ? ConvertToUnix(end) : 0;
        var vehicleTyp");
            WriteLiteral(@"e = $(""#vehicleType"").val();
        var vehicle = $(""#licensePlate"").val();
        $(""#report tbody tr"").remove();
        $(""#report tfoot tr th"").remove();
        window.history.pushState(window.location.href, ""Báo cáo đơn vị vận tải"", `?company=${transportUnit}&start=${start}&end=${end}&index=${index}&vehicleType=${vehicleType}&vehicle=${vehicle}&department=${department}`);
        //
        callApi(`${REP_URL}topicalreport/company/${transportUnit}?vehicle=${vehicle}&start=${start}&end=${end}&vehicleType=${vehicleType}&index=${index}&department=${department}`, null, ""GET"", function(item) {
            if (item.records > 0) {
                $.notify(""Tải dữ liệu thành công"", ""success"");
                let res = """";
                let count = 1;
                item.data.forEach(function(pro) {
                    res += ""<tr>"";
                    res += `<td>${count}</td>`;
                    res += `<td class=""text-left""><a href=""/bao-cao/tong-hop/lich-su-hinh-anh-lai-xe?plate=${pro.");
            WriteLiteral(@"vehicle}&start=${start}&end=${end}"">${pro.vehicle}</a></td>`;
                    res += `<td class=""text-left"">${pro.vehicle_type}</td>`;
                    res += `<td>${item.violateSum}</td>`;
                    res += `<td>${item.violateTotalSum}</td>`;
                    res += `<td>${item.violateRate}</td>`;
                    res += ""</tr>"";
                    count++;
                });

                let totalRes = `<th>Tổng</th>`;
                totalRes += `<th></th>`;
                totalRes += `<th></th>`;
                totalRes += `<th>${item.violateSum}</th>`;
                totalRes += `<th>${item.violateTotalSum}</th>`;
                totalRes += `<th>${item.violateRate}</th>`;

                $(""#report tbody"").html(res);
                $(""#report tfoot tr"").html(totalRes);
                $(""#report tfoot tr th"").addClass(""text-danger"");
                Paging(index, 'showResult', item.records);

            } else {
                $.notify(`Không tìm ");
            WriteLiteral(@"thấy kết quả nào`, ""error"");
            }

        });
    }

    $(""[name='showTransportUnit']"").click(function () {
        index = 0;
        showResult(index);
    });


    function loadDVVT(value) {
        callApi(`${REP_URL}company/department/${value}`, null, ""GET"", function (obj) {
            let res = ""<option value='-1'>Chọn đơn vị vận tải</option>"";
            obj.forEach(function (pro) {
                res += `<option value=""${pro.id}"">${pro.name}</option>`;
            });
            $(""#transportUnit"").select2();
            $(""#transportUnit"").html(res);
            if (company !== """") {
                $(""#transportUnit"").val(company);
                showResult(index);
            }
        });

    }

    function loadLicensePlate(value) {
        callApi(`${REP_URL}vehicle/company/${value}`, null, ""GET"", function (obj) {
            let res = ""<option value='-1'>Chọn biển kiểm soát</option>"";
            obj.forEach(function (pro) {
                res ");
            WriteLiteral("+= `<option value=\"${pro.vehicle}\">${pro.vehicle}</option>`;\r\n            });\r\n            $(\"#licensePlate\").html(res);\r\n\r\n        });\r\n    }\r\n</script>");
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
