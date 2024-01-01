using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class HospitalAuthorize : TypeFilterAttribute
{
    public HospitalAuthorize() : base(typeof(HospitalAuthorizeFilter))
    {
    }
}

public class HospitalAuthorizeFilter : IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var token = context.HttpContext.Request.Cookies["hospitalPatientToken"];

        if (string.IsNullOrEmpty(token))
        {
            context.Result = new RedirectToActionResult("Login", "Account", null);
        }
    }
}