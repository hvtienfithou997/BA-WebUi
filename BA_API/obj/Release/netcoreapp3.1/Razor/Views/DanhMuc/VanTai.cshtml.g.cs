#pragma checksum "D:\BA_Work\BA_API\BA_API\Views\DanhMuc\VanTai.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d1b03ee9ee478fdaf0d019c62c951b23b7bbe77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DanhMuc_VanTai), @"mvc.1.0.view", @"/Views/DanhMuc/VanTai.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d1b03ee9ee478fdaf0d019c62c951b23b7bbe77", @"/Views/DanhMuc/VanTai.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3bfb59427742d22d27d0c529a835ce80d09517b", @"/Views/_ViewImports.cshtml")]
    public class Views_DanhMuc_VanTai : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\BA_Work\BA_API\BA_API\Views\DanhMuc\VanTai.cshtml"
  
    ViewData["Title"] = "Danh mục đơn vị vận tải";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    .select2 {
        width: 100% !important;
    }

    .custom {
        float: right;
        height: 25px;
        font-size: 12px;
        line-height: 1;
    }

    .modalEdit .star label:nth-child(1):after {
        content: "" (*)"";
        color: red;
    }
</style>

<div class=""col-xl-12 col-lg-12"">
    <div class=""card mb-4"">
        <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
            <h6 class=""m-0 font-weight-bold text-primary"">
                Tra cứu thông tin đơn vị vận tải
            </h6>
        </div>
        <div class=""card-body"">
            <div class=""row"">

                <div class=""form-group col-xl-3 col-lg-6"">
                    <label for=""department"">Sở GTVT</label>
                    <select class=""form-control"" id=""department"" placeholder=""Sở GTVT"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d1b03ee9ee478fdaf0d019c62c951b23b7bbe774729", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d1b03ee9ee478fdaf0d019c62c951b23b7bbe776212", async() => {
                WriteLiteral("Chọn đơn vị vận tải");
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
            </div>
            <div class=""row"">
                <div class=""col-xl-10""></div>
                <div class=""col-xl-2"" style=""text-align: right"">
                    <button name=""btn-result"" class=""btn btn-info"">Tìm kiếm</button>&nbsp;
                    <button name=""btn-addNew"" class=""btn btn-success"" data-toggle=""modal"" data-target="".modalEdit"" onclick=""clearBeforeSave()""><i class=""fas fa-plus fa-fw""></i>Thêm</button>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""col-xl-12 col-lg-12"">
    <div class=""card mb-4"">
        <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
            <h6 class=""m-0 font-weight-bold text-primary"">Danh sách đơn vị vận tải</h6>
            <h6 class=""total font-weight-bold""></h6>
        </div>
        <div class=""table-responsive p-3"">
            <table id=""result"" class=""table table-bordered text-center"" ");
            WriteLiteral(@"style=""color: black"">
                <thead>
                    <tr>
                        <th rowspan=""2"" style=""width: 10px;"">STT</th>
                        <th rowspan=""2"">Đơn vị vận tải</th>
                        <th rowspan=""2"">Mã số thuế</th>
                        <th rowspan=""2"">Địa chỉ</th>
                        <th rowspan=""2"">Sở GTVT</th>
                        <th rowspan=""2"">Điện thoại</th>
                        <th rowspan=""2"">Thao tác</th>
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
            <div class=""modal-header te");
            WriteLiteral(@"xt-center"">
                <h4 class=""modal-title w-100 font-weight-bold""></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body mx-3"">
                <input type=""text"" hidden=""hidden"" id=""id"" value=""0"" />
                <div class=""mb-3 star"">
                    <label data-error=""wrong"" data-success=""right"" for=""formCompany"">Tên đơn vị vận tải: </label>
                    <input type=""text"" id=""formCompany"" class=""form-control"">
                </div>
                <div class=""mb-3 star"">
                    <label data-error=""wrong"" data-success=""right"" for=""formDepartment"">Sở GTVT :</label><br />
                    <select class=""form-control"" id=""formDepartment"" placeholder=""Sở GTVT"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d1b03ee9ee478fdaf0d019c62c951b23b7bbe7710556", async() => {
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
                <div class=""mb-3 star"">
                    <label data-error=""wrong"" data-success=""right"" for=""formTax"">Mã số thuế: </label>
                    <input type=""text"" id=""formTax"" class=""form-control"">
                </div>

                <div class=""mb-3"">
                    <label data-error=""wrong"" data-success=""right"" for=""formAddress"">Địa chỉ: </label>
                    <input type=""text"" id=""formAddress"" class=""form-control"">
                </div>
                <div class=""mb-3 star"">
                    <label data-error=""wrong"" data-success=""right"" for=""formPhone"">Số điện thoại :</label>
                    <input type=""text"" id=""formPhone"" class=""form-control"">
                </div>
                <div class=""mb-3"">
                    <label data-error=""wrong"" data-success=""right"" for=""formFax"">Số fax :</label>
                    <input type=""text"" id=""formFax"" class=""form-control"">
                </d");
            WriteLiteral(@"iv>
                <div class=""mb-3"">
                    <label data-error=""wrong"" data-success=""right"" for=""formEmail"">Email :</label>
                    <input type=""text"" id=""formEmail"" class=""form-control"">
                </div>
                <div class=""mb-3"">
                    <label data-error=""wrong"" data-success=""right"" for=""formWeb"">Website :</label>
                    <input type=""text"" id=""formWeb"" class=""form-control"">
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
    <p id=""msg""></p>");
            WriteLiteral("\r\n    <button class=\"btn btn-light custom\" onclick=\"cancel()\">Hoàn tác</button>\r\n</div>\r\n<script>\r\n    \r\n    \r\n    var departmentid = \'");
#nullable restore
#line 150 "D:\BA_Work\BA_API\BA_API\Views\DanhMuc\VanTai.cshtml"
                   Write(ViewBag.departmentid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var companyid = \'");
#nullable restore
#line 151 "D:\BA_Work\BA_API\BA_API\Views\DanhMuc\VanTai.cshtml"
                Write(ViewBag.companyid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var index = \'");
#nullable restore
#line 152 "D:\BA_Work\BA_API\BA_API\Views\DanhMuc\VanTai.cshtml"
            Write(ViewBag.index);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    $(function () {
        addClassActive(""category-DANH_MUC"", ""DANH_MUC_DVVT"");
        $(""#department"").select2();
        $(""#transportUnit"").select2();

        loadSoGTVT(0);

        if (USER_ROLE === 2 || USER_ROLE === 3) {
            $(""#department"").prop(""disabled"", true);
            $(""#formDepartment"").prop(""disabled"", true);
            
            setTimeout(function () {
                    loadSoGTVT(ALLOW_QUERY.Department);
            }, 500);
        } else if (USER_ROLE === 4 || USER_ROLE === 5) {
            setTimeout(function () {
                    loadSoGTVT(ALLOW_QUERY.Department);
                },
                500);
            $(""#department"").prop(""disabled"", true);
            $(""#transportUnit"").prop(""disabled"", true);
        } else if (USER_ROLE === 6 || USER_ROLE === 7) {
            $(""#transmissionUnit"").val(ALLOW_QUERY.Provider);
            $(""#transmissionUnit"").prop(""disabled"", true);
        }


        if (departmentid !== """")
");
            WriteLiteral(@"            showResult(index);
    });
    $(""[name='btn-result']"").click(function () {
        index = 0;
        showResult(index);
    });

    function loadSoGTVT(sogtvt) {
        callApi(`${REP_URL}department/all`, null, ""GET"", function (obj) {
            let res = ""<option value='0'>Chọn sở GTVT</option>"";
            obj.forEach(function (pro) {
                res += `<option value=""${pro.id}"">${pro.name}</option>`;
            });
            $(""#department"").html(res);
            $(""#formDepartment"").html(res);
            if (departmentid !== """") {
                $(""#department"").val(departmentid).change();
                loadDVVT(departmentid, '');
            }
            if (sogtvt !== 0) {
                $(""#department"").val(sogtvt);
                $(""#formDepartment"").val(sogtvt);
                loadDVVT(sogtvt, '');
                showResult(index);
            }

        });

    }
    $(""#department"").change(function () {
        console.log($(this).v");
            WriteLiteral(@"al());
        loadDVVT($(this).val(), """");
    });

    function showResult(index) {
        try {
            var department = $(""#department"").val();
            var transportUnit = $(""#transportUnit"").val();
            $(""#result tbody tr"").remove();
            //window.history.pushState(window.location.href, ""Danh mục đơn vị vận tải"", `?departmentid=${department}&companyid=${transportUnit}&index=${index}`);
            callApi(`${REP_URL}company?departmentid=${department}&companyid=${transportUnit}&index=${index}`, null, ""GET"", function (item) {

                let res = """";
                let count = 1;
                if (item.data.length > 0) {
                    item.data.forEach(function (pro) {
                        res += ""<tr>"";
                        res += `<td>${count}</td>`;
                        res += `<td class=""text-left"">${pro.name}</td>`;
                        res += `<td class=""text-left"">${pro.taxId}</td>`;
                        res += `<td class=""tex");
            WriteLiteral(@"t-left"">${pro.address}</td>`;
                        res += `<td class=""text-left"">${pro.department_name}</td>`;
                        res += `<td class=""text-right"">${pro.phone = pro.phone !== null ? pro.phone : """"}</td>`;
                        res += `<td><a href="""" class=""btn btn-primary btn-rounded mb-4"" data-toggle=""modal"" data-target="".modalEdit"" onclick=""loadData('${pro.id}')"">Sửa</a>&nbsp<button class=""btn btn-danger btn-rounded mb-4"" onclick=""showDelete('${pro.id}')"">Xóa</button></td>`;
                        res += ""</tr>"";
                        count++;
                    });
                    $(""#result tbody"").html(res);
                    Paging(index, 'showResult', item.records);
                }

                //} else {
                //    $.notify(`Không tìm thấy kết quả nào`, ""error"");
                //}
            });
        } catch (e) {

        }
    }
    function loadDVVT(departmentId, companyId) {
        try {
            callApi(`${REP_URL}c");
            WriteLiteral(@"ompany/department/${departmentId}`, null, ""GET"", function (obj) {
                let res = ""<option value='0'>Chọn đơn vị vận tải</option>"";
                obj.forEach(function (pro) {
                    res += `<option value=""${pro.id}"">${pro.name}</option>`;
                });
                $(""#transportUnit"").select2();
                $(""#transportUnit"").html(res);
                $(""#formCompany"").html(res);
                $(""#formCompany"").select2();
                //$(""#transportUnit"").val(companyid).trigger('change.select2');
                if (companyId !== '') {
                    $(""#formCompany"").val(companyId);
                }
            });
        } catch (e) {}
    }

    function clearBeforeSave() {
        $("".modal-title"").html(""Tạo mới dữ liệu"");
        $(""[name='btnSave']"").addClass(""d-none"");
        $(""[name='btnAdd']"").removeClass(""d-none"");
        $(""[name='btnSaveContinue']"").removeClass(""d-none"");
        callApi(`${REP_URL}department/all`, null,");
            WriteLiteral(@" ""GET"", function (obj) {
            let res = ""<option value='0'>Chọn sở GTVT</option>"";
            obj.forEach(function (pro) {
                res += `<option value=""${pro.id}"">${pro.name}</option>`;
            });
            $(""#formDepartment"").html(res);
            if (ALLOW_QUERY.Department !== 0)
                $(""#formDepartment"").val(ALLOW_QUERY.Department);
        });
        $(""#formCompany"").val("""");
        $(""#formTax"").val("""");
        $(""#formAddress"").val("""");
        $(""#formPhone"").val("""");
        $(""#formFax"").val("""");
        $(""#formEmail"").val("""");
        $(""#formWeb"").val("""");
        $(""#formDepartment"").select2();
    }
    $(""[name='btnAdd']"").click(function () {
        save();
    });
    $(""[name='btnSaveContinue']"").click(function () {
        save();
        $(""#formCompany"").val("""");
    });

    $(""[name='btnSave']"").click(function() {
        save();
    });
    function save() {
        //var success = true;
        let id = $(""#id"").");
            WriteLiteral(@"val();
        let department = $(""#formDepartment"").val();
        let company = $(""#formCompany"").val();
        let tax = $(""#formTax"").val();
        let address = $(""#formAddress"").val();
        let phone = $(""#formPhone"").val();
        let fax = $(""#formFax"").val();
        let email = $(""#formEmail"").val();
        let web = $(""#formWeb"").val();

        if (company === """" || company == null) {
            $.notify(""Chưa nhập tên đơn vị vận tải"");
            $(""#formCompany"").focus();
            return;
        }
        if (department === ""0"" || department === ""-1"" || department == null) {
            $.notify(""Chưa chọn sở giao thông vận tải"");
            $(""#formDepartment"").focus();
            return;
        }
        if (tax === """" || tax == null) {
            $.notify(""Chưa nhập mã số thuế"");
            $(""#formTax"").focus();
            return;
        }

        if (phone === """" || phone == null) {
            $.notify(""Chưa nhập số điện thoại"");
           ");
            WriteLiteral(@" $(""#formPhone"").focus();
            return;
        }

        var obj = {""id"": id,""name"": company,""departmentId"": department,""taxId"": tax,""address"": address,""phone"": phone,""email"": email,""fax"": fax,""website"": web}
        callApi(`${REP_URL}company`, obj, ""POST"", function (res) { });
        $('#modalEdit').modal('hide');
    }

    function loadData(id) {
        if (id !== """") {
            $("".modal-title"").html(""Sửa thông tin "");
            $(""[name='btnSaveContinue']"").addClass(""d-none"");
            $(""[name='btnAdd']"").addClass(""d-none"");
            $(""[name='btnSave']"").removeClass(""d-none"");
            $(""#id"").val("""");
            $(""#formDepartment"").val(0);

            $(""#formCompany"").val("""");
            $(""#formTax"").val("""");
            $(""#formAddress"").val("""");
            $(""#formPhone"").val("""");
            $(""#formFax"").val("""");
            $(""#formEmail"").val("""");
            $(""#formWeb"").val("""");
            callApi(`${REP_URL}company/${id}`, null, ""GET");
            WriteLiteral(@""", function (item) {
                $(""#id"").val(item.id);
                $(""#formDepartment"").select2().val(item.departmentId).trigger('change.select2');
                $(""#formCompany"").val(item.name);
                $(""#formTax"").val(item.taxId);
                $(""#formAddress"").val(item.address);
                $(""#formPhone"").val(item.phone);
                $(""#formFax"").val(item.fax);
                $(""#formEmail"").val(item.email);
                $(""#formWeb"").val(item.website);
                //$(""#formDepartment"").select2();
            });
        }
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
                callApi(`${REP");
            WriteLiteral(@"_URL}company/${id}`, null, ""DELETE"", function (res) {
                    //$.notify(""Xóa thành công"", ""success"");
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
