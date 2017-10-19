using SitefinityWebApp.Mvc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers
{
    //[ControllerToolboxItem(Name = "CustomImage_MVC", Title = "Custom Image", SectionName = "Feather samples", ModuleName = "Libraries")]
    [ControllerToolboxItem(Name = "Header", Title = "Header", SectionName = "MvcWidgets", ModuleName = "Libraries")]
    public class HeaderController : Controller
    {
        public ActionResult Index()
        {
            return View("Default");
        }
    }
}