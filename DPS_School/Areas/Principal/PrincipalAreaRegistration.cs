using System.Web.Mvc;

namespace DPS_School.Areas.Principal
{
    public class PrincipalAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Principal";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Principal_default",
                "Principal/{controller}/{action}/{id}",
                new {action = "Index", id = UrlParameter.Optional }
                
            );
        }
    }
}