using System.Web.Mvc;

namespace DPS_School.Areas.Staff
{
    public class StaffAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Staff";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Staff_default",
                "Staff/{controller}/{action}/{id}",
                new {Controller= "Staff", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}