using AspStore.ShopUI.Models;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspStore.ShopUI.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PagerTagHelper : TagHelper
    {
        private readonly IUrlHelperFactory urlHelperFactory;

        public PagerTagHelper(IUrlHelperFactory helperFactory)
        {
            this.urlHelperFactory = helperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PageInfo PageModel { get; set; }
        public string PageAction { get; set; }
        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder divTag = new("div");
            for (int i = 1; i <= PageModel.PageCount; i++)
            {
                TagBuilder aTag = new("a");
                aTag.Attributes["href"] = urlHelper.Action(PageAction, new { pageNumber = i });
                if (PageClassesEnabled)
                {
                    aTag.AddCssClass(PageClass);
                    aTag.AddCssClass(i == PageModel.PageNumber ? PageClassSelected : PageClassNormal);
                }
                aTag.InnerHtml.Append(i.ToString());
                divTag.InnerHtml.AppendHtml(aTag);
            }
            output.Content.AppendHtml(divTag.InnerHtml);
        }
    }
}
