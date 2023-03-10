using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CraCode.WebLayer.CustomHelpers
{
    public static class CustomHelpers
        {
            public static IHtmlString ImageActionLink(this HtmlHelper htmlHelper,
                string linkText, string action, string controller,
                object routeValues, object htmlAttributes, string imageSrc)
            {
                var urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);
                var img = new TagBuilder("img");
                img.Attributes.Add("src", VirtualPathUtility.ToAbsolute(imageSrc));

                var anchor = new TagBuilder("a")
                    { InnerHtml = img.ToString(TagRenderMode.SelfClosing) };
                anchor.Attributes["href"] = urlHelper.Action(action, controller, routeValues);
                anchor.MergeAttributes(new RouteValueDictionary(htmlAttributes));

                return MvcHtmlString.Create(anchor.ToString());
            }
        }
    
}