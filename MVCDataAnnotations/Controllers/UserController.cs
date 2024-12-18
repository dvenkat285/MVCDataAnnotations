using MVCDataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataAnnotations.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
       public ViewResult AddUser()
        { 
        return View();
        }
        [HttpPost]
        public ViewResult AddUser(User user)
        {
            if(ModelState.IsValid) 
                return View("DisplayUser", user);
            else 
                return View("AddUser", user);
        }
        public JsonResult IsValidDate(DateTime DOB)  //ajax code for server side validation client don't have send req but it will update automatic
        {
            bool Status;
            if ((DOB> DateTime.Now.AddYears(-18)))
            {
                Status = false;
            }
            else
            {
                Status = true;
            }
            return Json(Status, JsonRequestBehavior.AllowGet);
        }
    }
}