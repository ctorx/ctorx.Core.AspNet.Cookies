using Microsoft.AspNetCore.Http;

namespace ctorx.Core.Mvc.Cookies
{
    public interface ICookieManager
    {
        /// <summary>
        /// Gets a cookie
        /// </summary>
        string Get(string cookieKey);

        /// <summary>
        /// Sets a cookie
        /// </summary>
        void Set(string cookieKey, string cookieValue, CookieOptions options = null);

        /// <summary>
        /// Deletes a cookie
        /// </summary>
        void Delete(string cookieKey);
    }
}