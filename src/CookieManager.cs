using Microsoft.AspNetCore.Http;

namespace ctorx.Core.AspNet.Cookies
{
    public class CookieManager
    {
        readonly IHttpContextAccessor HttpContextAccessor;

        public CookieManager(IHttpContextAccessor httpContextAccessor)
        {
            this.HttpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Gets a cookie
        /// </summary>
        public string Get(string cookieKey)
        {
            var context = this.HttpContextAccessor.HttpContext;
            return context.Request.Cookies[cookieKey];
        }

        /// <summary>
        /// Sets a cookie
        /// </summary>
        public void Set(string cookieKey, string cookieValue, CookieOptions? options = null)
        {
            var context = this.HttpContextAccessor.HttpContext;
            if(options != null)
            {
                context.Response.Cookies.Append(cookieKey, cookieValue, options);
            }
            else
            {
                context.Response.Cookies.Append(cookieKey, cookieValue);
            }
        }

        /// <summary>
        /// Deletes a cookie
        /// </summary>
        public void Delete(string cookieKey)
        {
            var context = this.HttpContextAccessor.HttpContext;
            context.Response.Cookies.Delete(cookieKey);
        }
    }
}