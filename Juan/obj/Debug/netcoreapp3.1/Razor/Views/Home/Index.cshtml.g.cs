#pragma checksum "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "403da6cfee02cebc43137a7dc9a695acd64a929c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\_ViewImports.cshtml"
using Juan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\_ViewImports.cshtml"
using Juan.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"403da6cfee02cebc43137a7dc9a695acd64a929c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1c44a181510f898f0d37a7b87a285bb8e52abfc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- main wrapper start -->
<main>
    <!-- hero slider section start -->
    <section class=""hero-slider"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""hero-slider-active slick-arrow-style slick-arrow-style_hero slick-dot-style"">
                        <!-- single slider item start -->
");
#nullable restore
#line 13 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                         foreach (var slide in Model.Slides)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"hero-single-slide\">\n                <div class=\"hero-slider-item bg-img\" data-bg=\"assets/img/slider/");
#nullable restore
#line 16 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                                                           Write(slide.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                    <div class=\"hero-slider-content slide-1\">\n                        <h5 class=\"slide-subtitle\">");
#nullable restore
#line 18 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                              Write(slide.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        <h2 class=\"slide-title\">");
#nullable restore
#line 19 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                           Write(slide.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                        <p class=\"slide-desc\">");
#nullable restore
#line 20 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                         Write(slide.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <a href=\"shop.html\" class=\"btn btn-hero\">");
#nullable restore
#line 21 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                                            Write(slide.ShopBtnText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                    </div>\n                </div>\n            </div>");
#nullable restore
#line 24 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <!-- single slider item end -->
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- hero slider section end -->
    <!-- service features start -->
    <section class=""service-policy-area"">
        <div class=""container"">
            <div class=""row"">
                <!-- single policy item start -->
");
#nullable restore
#line 37 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                 foreach (var feature in Model.Features)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4\">\n                        <div class=\"service-policy-item mt-30 bg-1\">\n                            <div class=\"policy-icon\">\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1741, "\"", 1776, 2);
            WriteAttributeValue("", 1747, "assets/img/icon/", 1747, 16, true);
#nullable restore
#line 42 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
WriteAttributeValue("", 1763, feature.Icon, 1763, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"policy icon\" />\n                            </div>\n                            <div class=\"policy-content\">\n                                <h5 class=\"policy-title\">");
#nullable restore
#line 45 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                                    Write(feature.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                <p class=\"policy-desc\">");
#nullable restore
#line 46 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                                  Write(feature.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 50 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section>
    <!-- service features end -->
    <!-- our product area start -->
    <section class=""our-product section-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""section-title text-center"">
                        <h2 class=""title"">");
#nullable restore
#line 61 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                     Write(Model.ProductSummary.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                        <p class=\"sub-title\">");
#nullable restore
#line 62 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                        Write(Model.ProductSummary.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                </div>\n            </div>\n            <div class=\"row\">\n                <div class=\"col-12\">\n                    <div class=\"product-carousel-4 mbn-50 slick-row-15 slick-arrow-style\">\n");
#nullable restore
#line 69 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                         foreach (var product in Model.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"product-item mb-50\">\n                                <div class=\"product-thumb\">\n                                    <a href=\"product-details.html\">\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 3188, "\"", 3225, 2);
            WriteAttributeValue("", 3194, "assets/img/product/", 3194, 19, true);
#nullable restore
#line 74 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
WriteAttributeValue("", 3213, product.Url, 3213, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3226, "\"", 3232, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                    </a>
                                </div>
                                <div class=""product-content"">
                                    <h5 class=""product-name"">
                                        <a href=""product-details.html"">");
#nullable restore
#line 79 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                                                  Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                    </h5>\n                                    <div class=\"price-box\">\n                                        <span class=\"price-regular\">$");
#nullable restore
#line 82 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                                                Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        <span class=""price-old""><del>$70.00</del></span>
                                    </div>
                                    <div class=""product-action-link"">
                                        <a href=""#"" data-toggle=""tooltip"" title=""Wishlist"">
                                            <i class=""ion-android-favorite-outline""></i>
                                        </a>
                                        <a href=""#"" data-toggle=""tooltip"" title=""Add To Cart"">
                                            <i class=""ion-bag""></i>
                                        </a>
                                        <a href=""#"" data-toggle=""modal"" data-target=""#quick_view"">
                                            <span data-toggle=""tooltip"" title=""Quick View"">
                                                <i class=""ion-ios-eye-outline""></i>
                                            </span>
                                        </a>
        ");
            WriteLiteral("                            </div>\n                                </div>\n                            </div>\n");
#nullable restore
#line 100 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- our product area end -->
    <!-- banner statistic area start -->
    <div class=""banner-statistics"">
        <div class=""container"">
            <div class=""row no-gutters mtn-30"">
");
#nullable restore
#line 111 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                 foreach (var banner in Model.Banners)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6\">\n                        <div class=\"img-container mt-30\">\n                            <a href=\"product-details.html\">\n                                <img");
            BeginWriteAttribute("src", " src=\"", 5434, "\"", 5469, 2);
            WriteAttributeValue("", 5440, "assets/img/banner/", 5440, 18, true);
#nullable restore
#line 116 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
WriteAttributeValue("", 5458, banner.Url, 5458, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n                                     alt=\"banner-image\" />\n                            </a>\n                            <div class=\"banner-text\">\n                                <h5 class=\"banner-subtitle\">");
#nullable restore
#line 120 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                                       Write(banner.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                <h3 class=\"banner-title\">");
#nullable restore
#line 121 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                                    Write(Html.Raw(@banner.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 125 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <!-- banner statistic area end -->
    <!-- new products area start -->
    <section class=""top-seller-area section-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""section-title text-center"">
                        <h2 class=""title"">");
#nullable restore
#line 136 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                     Write(Model.NewProductSummary.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                        <p class=\"sub-title\">");
#nullable restore
#line 137 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                        Write(Model.NewProductSummary.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-xl-4 col-lg-5 col-md-5"">
                    <div class=""product-banner"">
                        <a href=""#"">
                            <img src=""assets/img/banner/banner-3.jpg""
                                 alt=""product banner"" />
                        </a>
                    </div>
                </div>
                <div class=""col-xl-8 col-lg-7 col-md-7"">
                    <div class=""top-seller-carousel slick-row-15 mtn-30"">
                        <!-- product item start -->
");
#nullable restore
#line 153 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                         foreach (var newproduct in Model.NewProducts)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""slide-item"">
                                <div class=""pro-item-small mt-30"">
                                    <div class=""product-thumb"">
                                        <a href=""product-details.html"">
                                            <img");
            BeginWriteAttribute("src", " src=\"", 7424, "\"", 7464, 2);
            WriteAttributeValue("", 7430, "assets/img/product/", 7430, 19, true);
#nullable restore
#line 159 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
WriteAttributeValue("", 7449, newproduct.Url, 7449, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7465, "\"", 7471, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                        </a>
                                    </div>
                                    <div class=""pro-small-content"">
                                        <h6 class=""product-name"">
                                            <a href=""product-details.html"">");
#nullable restore
#line 164 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                                                      Write(newproduct.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                        </h6>\n                                        <div class=\"price-box\">\n                                            <span class=\"price-regular\">$");
#nullable restore
#line 167 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                                                    Write(newproduct.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            <span class=""price-old""><del>$70.00</del></span>
                                        </div>
                                        <div class=""ratings"">
                                            <span><i class=""ion-android-star""></i></span>
                                            <span><i class=""ion-android-star""></i></span>
                                            <span><i class=""ion-android-star""></i></span>
                                            <span><i class=""ion-android-star""></i></span>
                                            <span><i class=""ion-android-star""></i></span>
                                        </div>
                                        <div class=""product-link-2"">
                                            <a href=""#"" data-toggle=""tooltip"" title=""Wishlist"">
                                                <i class=""ion-android-favorite-outline""></i>
                                            </a>
          ");
            WriteLiteral(@"                                  <a href=""#"" data-toggle=""tooltip"" title=""Add To Cart"">
                                                <i class=""ion-bag""></i>
                                            </a>
                                            <a href=""#""
                                               data-toggle=""modal""
                                               data-target=""#quick_view"">
                                                <span data-toggle=""tooltip"" title=""Quick View"">
                                                    <i class=""ion-ios-eye-outline""></i>
                                                </span>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 195 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- new products area end -->
    <!-- latest blog area start -->
    <section class=""latest-blog-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""section-title text-center"">
                        <h2 class=""title"">");
#nullable restore
#line 208 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                     Write(Model.BlogSummary.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                        <p class=\"sub-title\">");
#nullable restore
#line 209 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                        Write(Model.BlogSummary.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                </div>\n            </div>\n            <div class=\"row\">\n                <div class=\"col-12\">\n                    <div class=\"blog-carousel-active slick-row-15\">\n");
#nullable restore
#line 216 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                         foreach (var blog in Model.Blogs)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"blog-post-item\">\n                                <div class=\"blog-thumb\">\n                                    <a href=\"blog-details.html\">\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 10933, "\"", 10964, 2);
            WriteAttributeValue("", 10939, "assets/img/blog/", 10939, 16, true);
#nullable restore
#line 221 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
WriteAttributeValue("", 10955, blog.Url, 10955, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""blog thumb"" />
                                    </a>
                                </div>
                                <div class=""blog-content"">
                                    <h5 class=""blog-title"">
                                        <a href=""blog-details.html"">");
#nullable restore
#line 226 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                                                               Write(blog.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                    </h5>
                                    <ul class=""blog-meta"">
                                        <li><span>By: </span>Admin,</li>
                                        <li><span>On: </span>14.07.2029</li>
                                    </ul>
                                    <a href=""blog-details.html"" class=""read-more"">Read More...</a>
                                </div>
                            </div>
");
#nullable restore
#line 235 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- latest blog area end -->
    <!-- brand area start -->
    <div class=""brand-area section-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""brand-active-carousel"">
");
#nullable restore
#line 248 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                         foreach (var brand in Model.Brands)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"brand-item\">\n                                <a href=\"#\">\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 12351, "\"", 12384, 2);
            WriteAttributeValue("", 12357, "assets/img/brand/", 12357, 17, true);
#nullable restore
#line 252 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
WriteAttributeValue("", 12374, brand.Url, 12374, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"brand image\" />\n                                </a>\n                            </div>\n");
#nullable restore
#line 255 "C:\Users\HP\Desktop\asp.net\Juan\Juan\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n    <!-- brand area end -->\n</main>\n<!-- main wrapper end -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
