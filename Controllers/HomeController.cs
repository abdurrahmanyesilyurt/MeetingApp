using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace meetingApp.Controllers
{
    public class HomeController:Controller 
    {

        public IActionResult Index()
        {
            int saat=DateTime.Now.Hour; 
           // ViewBag.selamlama=saat>12 ? "iyi günler": "Günaydin";
           // ViewBag.UserName="Melo";

            ViewData["Selamlama"]=saat >12 ? "iyi günler": "Günaydin";

            int UserCount=Repository.Users.Where(info=> info.WillAttend==true).Count();            


            var meetinginfo =new MeetingInfo(){
                Id=1,
                Location="Istabul,Kongre merkezi",
                Date=new DateTime(2024,01,20,20,0,0),
                NumberOfPeople=UserCount,
 
            };
            return View(meetinginfo);
        }

    }
    
    
}