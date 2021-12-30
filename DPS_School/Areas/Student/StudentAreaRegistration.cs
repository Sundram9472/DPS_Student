using System.Web.Mvc;

namespace DPS_School.Areas.Student
{
    public class StudentAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Student";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Student_default",
                "Student/{controller}/{action}/{id}",
                new {Controller= "Student",action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}