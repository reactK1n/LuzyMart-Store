#pragma checksum "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "710aaeb3540323e4ca9f219d8c442dc19fc59fc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\_ViewImports.cshtml"
using LuzyMart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\_ViewImports.cshtml"
using LuzyMart.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\_ViewImports.cshtml"
using LuzyMart.Models.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\_ViewImports.cshtml"
using LuzyMart.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"710aaeb3540323e4ca9f219d8c442dc19fc59fc5", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c1943c33c6b338ac52c3b8117fb6424571a2255", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\t<section>\r\n\t\t<div class=\"container \">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-12 padding-right\">\r\n\t\t\t\t\t<div class=\"product-details\">\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t<div class=\"col-sm-5\">\r\n\t\t\t\t\t\t\t<div class=\"view-product\" style=\"width:100%;\">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=", 265, "", 270, 0);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
                                     Write(Model.Images.FirstOrDefault().Link);

#line default
#line hidden
#nullable disable
            WriteLiteral(" alt=\"\"  />\r\n\t\t\t\t\t\t\t\t<h3>ZOOM</h3>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div id=\"similar-product\" class=\"carousel slide\" data-ride=\"carousel\">\r\n\r\n\t\t\t\t\t\t\t\t<!-- Wrapper for slides -->\r\n\t\t\t\t\t\t\t\t<div class=\"carousel-inner\" style=\"display:flex; justify-content:center;\">\r\n");
#nullable restore
#line 18 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
                                         foreach (var image in Model.Images.Take(3))
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<div class=\"item active\">\r\n\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 676, "\"", 683, 0);
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=", 689, "", 705, 1);
#nullable restore
#line 21 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
WriteAttributeValue("", 694, image.Link, 694, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 705, "\"", 711, 0);
            EndWriteAttribute();
            WriteLiteral(" ></a>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 23 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t<div class=\"col-sm-7\">\r\n\t\t\t\t\t\t\t<div class=\"product-information\">\r\n\t\t\t\t\t\t\t\t<!--/product-information-->\r\n\t\t\t\t\t\t\t\t<img src=\"images/new.jpg\" class=\"newarrival\"");
            BeginWriteAttribute("alt", " alt=\"", 969, "\"", 975, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t<h2>");
#nullable restore
#line 35 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
                               Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 36 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
                              
								var id = new Random().Next(10292, 90138);
							

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<p>Product ID: ");
#nullable restore
#line 39 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
                                          Write(id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t<p>Description: ");
#nullable restore
#line 41 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\t\t\t\t\t\t\t\t<img src=\"images/rating.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1216, "\"", 1222, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t<span>\r\n");
#nullable restore
#line 44 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
                                  
									var price = new Random().Next(15, 200);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<span>US $");
#nullable restore
#line 46 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
                                         Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral(@"									<label>Quantity:</label>
									<input type=""text"" value=""3"" />
									<button type=""button"" class=""btn btn-fefault cart"">
										<i class=""fa fa-shopping-cart""></i>
										Add to cart
									</button>
								</span>
								<p><b>Availability:</b> In Stock</p>
								<p><b>Condition:</b> New</p>
								<p><b>Brand:</b> E-SHOPPER</p>
								<a");
            BeginWriteAttribute("href", " href=\"", 1731, "\"", 1738, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"images/share.png\" class=\"share img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 1796, "\"", 1802, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
							</div><!--/product-information-->
						</div>
					</div><!--/product-details-->

					<div class=""category-tab shop-details-tab"">
						<!--category-tab-->
						<div class=""col-sm-12"">
							<ul class=""nav nav-tabs"">
								<li><a href=""#details"" data-toggle=""tab"">Details</a></li>
								<li><a href=""#companyprofile"" data-toggle=""tab"">Company Profile</a></li>
								<li><a href=""#tag"" data-toggle=""tab"">Tag</a></li>
								<li class=""active""><a href=""#reviews"" data-toggle=""tab"">Reviews (5)</a></li>
							</ul>
						</div>
						<div class=""tab-content"">
							<div class=""tab-pane fade"" id=""details"">
								<div class=""col-sm-3"">
									<div class=""product-image-wrapper"">
										<div class=""single-products"">
											<div class=""productinfo text-center"">
												<img src=""images/gallery_04.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2665, "\"", 2671, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
												<h2>$567777</h2>
												<p>Easy Polo Black Edition</p>
												<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
											</div>
										</div>
									</div>
								</div>
							</div>

							<div class=""tab-pane fade active in"" id=""reviews"">
								<div class=""col-sm-12"">
									<ul>
										<li><a");
            BeginWriteAttribute("href", " href=\"", 3088, "\"", 3095, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-user\"></i>EUGEN</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 3155, "\"", 3162, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-clock-o\"></i>12:41 PM</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 3228, "\"", 3235, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-calendar-o""></i>31 DEC 2014</a></li>
									</ul>
									<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>
									<p><b>Write Your Review</b></p>

									");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "710aaeb3540323e4ca9f219d8c442dc19fc59fc512048", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t\t\t<input type=\"text\" placeholder=\"Your Name\" />\r\n\t\t\t\t\t\t\t\t\t\t\t<input type=\"email\" placeholder=\"Email Address\" />\r\n\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t\t<textarea");
                BeginWriteAttribute("name", " name=\"", 3907, "\"", 3914, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n\t\t\t\t\t\t\t\t\t\t<b>Rating: </b> <img src=\"images/product-details/rating.png\"");
                BeginWriteAttribute("alt", " alt=\"", 3999, "\"", 4005, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t\t\t<button type=\"button\" class=\"btn btn-default pull-right\">\r\n\t\t\t\t\t\t\t\t\t\t\tSubmit\r\n\t\t\t\t\t\t\t\t\t\t</button>\r\n\t\t\t\t\t\t\t\t\t");
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
            WriteLiteral(@"
								</div>
							</div>

						</div>
					</div><!--/category-tab-->

					<div class=""recommended_items"">
						<!--recommended_items-->
						<h2 class=""title text-center"">recommended items</h2>

						<div id=""recommended-item-carousel"" class=""carousel slide"" data-ride=""carousel"">
							<div class=""carousel-inner"">
								<div class=""item active"">
");
#nullable restore
#line 123 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
                                 foreach(var product in Model.Images.Select(im => im.Link))
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"product-image-wrapper\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"single-products\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"productinfo text-center\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=", 4782, "", 4787, 0);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 129 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
                                                         Write(product);

#line default
#line hidden
#nullable disable
            WriteLiteral(" alt=\"\" />\r\n");
#nullable restore
#line 130 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
                                                      
														var randPrice = new Random().Next(30, 150);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<h2>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t$");
#nullable restore
#line 133 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
                                                        Write(randPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</h2>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 136 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
                                                  Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<button type=\"button\" class=\"btn btn-default add-to-cart\"><i class=\"fa fa-shopping-cart\"></i>Add to cart</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 142 "C:\Users\User\Desktop\Repos\LuzyMartDemo\LuzyMart\Views\Product\Details.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"								</div>
							</div>
							<a class=""left recommended-item-control"" href=""#recommended-item-carousel"" data-slide=""prev"">
								<i class=""fa fa-angle-left""></i>
							</a>
							<a class=""right recommended-item-control"" href=""#recommended-item-carousel"" data-slide=""next"">
								<i class=""fa fa-angle-right""></i>
							</a>
						</div>
					</div><!--/recommended_items-->

				</div>
			</div>
		</div>
	</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
