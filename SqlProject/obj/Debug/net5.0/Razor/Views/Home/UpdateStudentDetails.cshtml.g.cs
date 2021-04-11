#pragma checksum "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a655336171ef457b93e223cf779c3cf09ba5f22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UpdateStudentDetails), @"mvc.1.0.view", @"/Views/Home/UpdateStudentDetails.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\_ViewImports.cshtml"
using SqlProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\_ViewImports.cshtml"
using SqlProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a655336171ef457b93e223cf779c3cf09ba5f22", @"/Views/Home/UpdateStudentDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f1b48bdd53d0e3951381c22dbd0da2a640c86a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UpdateStudentDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SqlEntities.Entities.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FetchStudents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
  
    ViewData["Title"] = "Students Data";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   var tempList = new List<SelectListItem>();
                int index = 1;


                foreach (var item in ViewBag.collegeNames)
                {
                    tempList.Add(new SelectListItem() { Text = item, Value = index.ToString() });
                    index++;
                }
                var items = tempList;


                var tempList2 = new List<SelectListItem>();
                int index2 = 1;


                foreach (var item in ViewBag.teacherNames)
                {
                    tempList2.Add(new SelectListItem() { Text = item, Value = index2.ToString() });
                    index2++;
                }
                var items2 = tempList2; 
    
   

#line default
#line hidden
#nullable disable
            WriteLiteral("<button>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a655336171ef457b93e223cf779c3cf09ba5f225569", async() => {
                WriteLiteral("Back To List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n<style>\r\n    .error {\r\n        color: red;\r\n    }\r\n</style>\r\n<h1>Update List</h1>\r\n<hr />\r\n");
#nullable restore
#line 38 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
 using (Html.BeginForm("UpdateStudentsList", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 42 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.HiddenFor(x => x.StudentId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <label>First-Name</label>\r\n        ");
#nullable restore
#line 44 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.ValidationMessageFor(x => x.StudentFirstName, "", new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 45 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.TextBoxFor(x => x.StudentFirstName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 48 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.HiddenFor(x => x.StudentId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <label>Last-Name</label>\r\n        ");
#nullable restore
#line 50 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.ValidationMessageFor(x => x.StudentLastName, "", new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 51 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.TextBoxFor(x => x.StudentLastName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Student-Gender</label><br />\r\n        ");
#nullable restore
#line 55 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.ValidationMessageFor(x => x.StudentGender, "", new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        Male:");
#nullable restore
#line 56 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
        Write(Html.RadioButtonFor(x => x.StudentGender, "Male"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        Female:");
#nullable restore
#line 57 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
          Write(Html.RadioButtonFor(x => x.StudentGender, "Female"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Student Date-Of-Birth</label>\r\n        ");
#nullable restore
#line 61 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.ValidationMessageFor(x => x.StudentDob, "", new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 62 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.EditorFor(x => x.StudentDob, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Student Age</label>\r\n        ");
#nullable restore
#line 66 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.ValidationMessageFor(x => x.StudentAge, "", new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 67 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.TextBoxFor(x => x.StudentAge, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>State</label>\r\n        ");
#nullable restore
#line 72 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.ValidationMessageFor(x => x.State, "", new { @class = "error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 73 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.TextBoxFor(x => x.State, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 97 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.LabelFor(model => model.TeacherId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 99 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
       Write(Html.DropDownListFor(model => model.TeacherId, items2, "Select Designation", htmlAttributes: new { @class = "makewide" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 100 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
       Write(Html.ValidationMessageFor(model => model.TeacherId, "", new { id = "Desig_ErrorMessage", @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 105 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
   Write(Html.LabelFor(model => model.CollegeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
       Write(Html.DropDownListFor(model => model.CollegeId, items, "Select Designation", htmlAttributes: new { @class = "makewide" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 108 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
       Write(Html.ValidationMessageFor(model => model.CollegeId, "", new { id = "Desig_ErrorMessage", @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 115 "C:\Users\Lenovo\source\repos\SqlProject\SqlProject\Views\Home\UpdateStudentDetails.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SqlEntities.Entities.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591