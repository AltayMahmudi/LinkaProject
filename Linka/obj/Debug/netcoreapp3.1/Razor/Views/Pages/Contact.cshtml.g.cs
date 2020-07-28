#pragma checksum "C:\Users\User\source\repos\Linka\Linka\Views\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c25ec91ce7bae62e8781b76698504d11b779334c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_Contact), @"mvc.1.0.view", @"/Views/Pages/Contact.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Linka\Linka\Views\_ViewImports.cshtml"
using Linka;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Linka\Linka\Views\_ViewImports.cshtml"
using Linka.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c25ec91ce7bae62e8781b76698504d11b779334c", @"/Views/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acb715c7ca580cc99205a380124b3e06ace9de59", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\source\repos\Linka\Linka\Views\Pages\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Start Page Title Area -->
<div class=""page-title-area bg-9"">
    <div class=""container"">
        <div class=""page-title-content"">
            <h2>Contact</h2>
            <ul>
                <li>
                    <a href=""index.html"">
                        Home
                    </a>
                </li>
                <li>Contact</li>
            </ul>
        </div>
    </div>
</div>
<!-- End Page Title Area -->
<!-- Start Contact Info Area -->
<section class=""contact-info-area pt-100 pb-70"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-sm-6"">
                <div class=""single-contact-info"">
                    <i class=""bx bx-envelope""></i>
                    <h3>Email Us:</h3>
                    <a href=""mailto:hello@arduix.com"">hello@linka.com</a>
                    <a href=""mailto:info@arduix.com"">info@linka.com</a>
                </div>
            </div>
            <div class=""col-lg-3 col-sm-6"">
       ");
            WriteLiteral(@"         <div class=""single-contact-info"">
                    <i class=""bx bx-phone-call""></i>
                    <h3>Call Us:</h3>
                    <a href=""tel:+(123)1800-567-8990"">Tel. + (123) 1800-567-8990</a>
                    <a href=""tel:+(124)1523-567-9874"">Tel. + (124) 1523-567-9874</a>
                </div>
            </div>
            <div class=""col-lg-3 col-sm-6"">
                <div class=""single-contact-info"">
                    <i class=""bx bx-location-plus""></i>
                    <h3>London</h3>
                    <a href=""#"">123, Western Road, Melbourne Australia</a>
                </div>
            </div>
            <div class=""col-lg-3 col-sm-6"">
                <div class=""single-contact-info"">
                    <i class=""bx bx-support""></i>
                    <h3>Live Chat</h3>
                    <a href=""#"">live chat all the time with our company 24/7</a>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- End");
            WriteLiteral(@" Contact Info Area -->
<!-- Start Contact Area -->
<section class=""main-contact-area pb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""contact-wrap contact-pages mb-0"">
                    <div class=""contact-form"">
                        <div class=""section-title"">
                            <h2>Drop us a message for any query</h2>
                        </div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c25ec91ce7bae62e8781b76698504d11b779334c6390", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-lg-6 col-sm-6"">
                                    <div class=""form-group"">
                                        <input type=""text"" name=""name"" id=""name"" class=""form-control"" required data-error=""Please enter your name"" placeholder=""Your Name"">
                                        <div class=""help-block with-errors""></div>
                                    </div>
                                </div>

                                <div class=""col-lg-6 col-sm-6"">
                                    <div class=""form-group"">
                                        <input type=""email"" name=""email"" id=""email"" class=""form-control"" required data-error=""Please enter your email"" placeholder=""Your Email"">
                                        <div class=""help-block with-errors""></div>
                                    </div>
                                </div>

                              ");
                WriteLiteral(@"  <div class=""col-lg-6 col-sm-6"">
                                    <div class=""form-group"">
                                        <input type=""text"" name=""phone_number"" id=""phone_number"" required data-error=""Please enter your number"" class=""form-control"" placeholder=""Your Phone"">
                                        <div class=""help-block with-errors""></div>
                                    </div>
                                </div>

                                <div class=""col-lg-6 col-sm-6"">
                                    <div class=""form-group"">
                                        <input type=""text"" name=""msg_subject"" id=""msg_subject"" class=""form-control"" required data-error=""Please enter your subject"" placeholder=""Your Subject"">
                                        <div class=""help-block with-errors""></div>
                                    </div>
                                </div>

                                <div class=""col-lg-12 col-md-12"">
        ");
                WriteLiteral(@"                            <div class=""form-group"">
                                        <textarea name=""message"" class=""form-control"" id=""message"" cols=""30"" rows=""5"" required data-error=""Write your message"" placeholder=""Your Message""></textarea>
                                        <div class=""help-block with-errors""></div>
                                    </div>
                                </div>

                                <div class=""col-lg-12 col-md-12"">
                                    <button type=""submit"" class=""default-btn btn-two"">
                                        Send Message
                                    </button>
                                    <div id=""msgSubmit"" class=""h3 text-center hidden""></div>
                                    <div class=""clearfix""></div>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- End Contact Area -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <!-- Jquery-3.5.1.Slim.Min.JS -->
    <script src=""/js/jquery-3.5.1.slim.min.js""></script>
    <!-- Popper JS -->
    <script src=""/js/popper.min.js""></script>
    <!-- Bootstrap JS -->
    <script src=""/js/bootstrap.min.js""></script>
    <!-- Meanmenu JS -->
    <script src=""/js/jquery.meanmenu.js""></script>
    <!-- Wow JS -->
    <script src=""/js/wow.min.js""></script>
    <!-- Owl Carousel JS -->
    <script src=""/js/owl.carousel.js""></script>
    <!-- Owl Magnific JS -->
    <script src=""/js/jquery.magnific-popup.min.js""></script>
    <!-- Nice Select JS -->
    <script src=""/js/jquery.nice-select.min.js""></script>
    <!-- Form Validator JS -->
    <script src=""/js/form-validator.min.js""></script>
    <!-- Contact JS -->
    <script src=""/js/contact-form-script.js""></script>
    <!-- Ajaxchimp JS -->
    <script src=""/js/jquery.ajaxchimp.min.js""></script>
    <!-- Custom JS -->
    <script src=""/js/custom.js""></script>
");
            }
            );
            WriteLiteral("\r\n");
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
