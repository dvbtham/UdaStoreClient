using Microsoft.AspNetCore.Mvc;

namespace UdaStore.Client.Core.Extensions
{
    public static class UrlHelperExtensions
    {
        public static string GetLocalUrl(this IUrlHelper urlHelper, string localUrl)
        {
            return !urlHelper.IsLocalUrl(localUrl) ? urlHelper.Action("Index", "Home") : localUrl;
        }
    }
}
