#pragma checksum "D:\桌面2\NET Core\ASP.NET-Core-\T2ASP.NET Core\ClineDemo\Views\My\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0208a720262c2f72d2988f66a8de0987fda98a8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_My_Index), @"mvc.1.0.view", @"/Views/My/Index.cshtml")]
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
#line 1 "D:\桌面2\NET Core\ASP.NET-Core-\T2ASP.NET Core\ClineDemo\Views\_ViewImports.cshtml"
using ClineDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\桌面2\NET Core\ASP.NET-Core-\T2ASP.NET Core\ClineDemo\Views\_ViewImports.cshtml"
using ClineDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0208a720262c2f72d2988f66a8de0987fda98a8f", @"/Views/My/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6897a9b836deded6a4c14181d28e7e46675cac98", @"/Views/_ViewImports.cshtml")]
    public class Views_My_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\桌面2\NET Core\ASP.NET-Core-\T2ASP.NET Core\ClineDemo\Views\My\Index.cshtml"
  
	ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0208a720262c2f72d2988f66a8de0987fda98a8f3635", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<h1>api测试</h1>
<div id=""app"">

	<table class=""table table-striped table-hover"">
		<thead>
			<tr>
				<th>编号</th>
				<th>姓名</th>
				<th>年龄</th>
				<th>性别</th>
			</tr>
		</thead>
		<tbody id=""pp"">
		</tbody>
	</table>
</div>
<script>
	$.ajax({
		type: ""get"",
		url: ""https://localhost:44377/api/my"",
		success: function (data) {
			tablelist = data;
			console.log(tablelist);
			var sr = """";
			for (var i = 0; i < tablelist.length; i++) {
				sr += ""<tr><td> "" + tablelist[i].stuid + ""</td><td>"" +tablelist[i].stuname + ""</td><td> "" + tablelist[i].stuage + ""</td> <td> "" +
					tablelist[i].stusex + ""</td></tr >"";
			}
			$(""#pp"").html(sr);

		}
	});
	//var vm = new Vue({
	//	el: ""#app"",
	//	data: {
	//		key: """",
	//		tablelist: []
	//	},
	//	created: function () {
	//		var self = this;
	//		axios.get(""https://localhost:44377/api/my"").then(function (data) {
	//			this.tablelist = data.data;
	//			console.log(this.tablelist);
	//			var sr = """";
	//			for (var i = 0; ");
            WriteLiteral(@"i < this.tablelist.length; i++) {
	//				html = ""<tr>< td > "" + this.tablelist[i].stuid + ""</td ><td>"" + this.tablelist[i].stuname + ""</td><td> "" + this.tablelist[i].stuage + ""</td > <td> "" +
	//					this.tablelist[i].stusex + ""</td></tr >"";
	//			}
	//			$(""#pp"").html(sr);
	//		});

	//	}
	//});
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
