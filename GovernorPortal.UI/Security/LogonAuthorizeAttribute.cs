using System.Web.Mvc;

namespace GovernorPortal.UI.Security
{
    /// <summary>
    /// Attribute class used to allow the Global filter to specify all controller actions
    /// must be accessed by a logged on user, except where they specify the AllowAnonymousAttribute
    /// </summary>
    public sealed class LogonAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            bool skipAuthorization = filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true)
            || filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true);
            if (!skipAuthorization)
            {
                base.OnAuthorization(filterContext);
            }
        }
    }

}