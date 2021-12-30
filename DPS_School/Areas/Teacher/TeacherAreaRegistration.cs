using System.Web.Mvc;

namespace DPS_School.Areas.Teacher
{
    public class TeacherAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Teacher";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Teacher_default",
                "Teacher/{controller}/{action}/{id}",
                new {Controller= "Teacher",action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}