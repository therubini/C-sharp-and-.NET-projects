using ManagementPortal.Enums;
using System.Web.Mvc;

namespace ManagementPortal.Helpers
{
    public static class AnchorExtensions
    {
        public static MvcHtmlString AnchorButton(this HtmlHelper helper, AnchorType Type, string Url)
        {
            switch (Type)
            {
                case AnchorType.BackToList:
                    return new MvcHtmlString(ButtonString(Url, "Back to List", "fa-arrow-left"));

                case AnchorType.Create:
                    return new MvcHtmlString(ButtonString(Url, "Create New", "fa-plus-square"));

                case AnchorType.Delete:
                    return new MvcHtmlString(ButtonString(Url, "Delete", "fa-trash"));

                case AnchorType.Details:
                    return new MvcHtmlString(ButtonString(Url, "Details", "fa-info-circle"));

                case AnchorType.Edit:
                    return new MvcHtmlString(ButtonString(Url, "Edit", "fa-pencil"));

                // new save button
                case AnchorType.Save:
                    return new MvcHtmlString(ButtonString(Url, "Save", "fa-floppy-o"));

                // new home/Menu button
                case AnchorType.Home:
                    return new MvcHtmlString(ButtonString(Url, "Home Menu", "fa-arrow-left"));

                default:
                    return new MvcHtmlString(ButtonString(Url, "NA"));
            }
        }

        public static MvcHtmlString AnchorButton(this HtmlHelper helper, AnchorType Type, string Url, string controller) //Overload added to render a custom AnchorButton to a path outside of class
        {
            switch (Type)
            {
                case AnchorType.BackToList:
                    return new MvcHtmlString(ButtonString(Url, controller, "fa-arrow-left"));

                case AnchorType.Create:
                    return new MvcHtmlString(ButtonString(Url, controller, "fa-plus-square"));

                case AnchorType.Delete:
                    return new MvcHtmlString(ButtonString(Url, controller, "fa-trash"));

                case AnchorType.Details:
                    return new MvcHtmlString(ButtonString(Url, controller, "fa-info-circle"));

                case AnchorType.Edit:
                    return new MvcHtmlString(ButtonString(Url, controller, "fa-pencil"));

                // new save button
                case AnchorType.Save:
                    return new MvcHtmlString(ButtonString(Url, controller, "fa-floppy-o"));

                // new home/Menu button
                case AnchorType.Home:
                    return new MvcHtmlString(ButtonString(Url, controller, "fa-arrow-left"));

                default:
                    return new MvcHtmlString(ButtonString(Url, controller));
            }
        }



        private static string ButtonString(string url, string text, string icon = "")
        {
            var anchor = new TagBuilder("a");
            anchor.MergeAttribute("type", "button");
            anchor.AddCssClass("btn btn-sm btn-primary");
            anchor.MergeAttribute("href", url);

            var span = new TagBuilder("span");

            if (icon != "")
            {
                var i = new TagBuilder("i");
                i.AddCssClass($"fa {icon}");
                span.InnerHtml = $"{i.ToString(TagRenderMode.Normal)}";
            }

            span.InnerHtml += $" {text}";

            anchor.InnerHtml = $"{span.ToString(TagRenderMode.Normal)}";

            return anchor.ToString(TagRenderMode.Normal);
        }


    }
}