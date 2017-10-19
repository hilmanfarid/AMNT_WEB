using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Footer", Title = "Footer", SectionName = "MvcWidgets")]
    public class FooterController : Controller
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        public string Link1 { get; set; }
        [Category("String Properties")]
        public string Link2 { get; set; }
        [Category("String Properties")]
        public string Link3 { get; set; }
        [Category("String Properties")]
        public string Link4 { get; set; }
        [Category("String Properties")]
        public string Link5 { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {

            var model = new FooterModel();

            if (string.IsNullOrEmpty(this.Link1))
                model.Link1 = "career";
            else
                model.Link1 = this.Link1;

            if (string.IsNullOrEmpty(this.Link2))
                model.Link2 = "contactus";
            else
                model.Link2 = this.Link1;

            if (string.IsNullOrEmpty(this.Link3))
                model.Link3 = "privacypolicy";
            else
                model.Link3 = this.Link1;

            if (string.IsNullOrEmpty(this.Link4))
                model.Link4 = "termofuse";
            else
                model.Link4 = this.Link1;

            if (string.IsNullOrEmpty(this.Link5))
                model.Link5 = "sitemap";
            else
                model.Link5 = this.Link1;

            //model.HeaderModel = new HeaderModel();

            //HeaderModel HeaderModel = new HeaderModel();

            //if (string.IsNullOrEmpty(HeaderModel.Facebook))
            //    HeaderModel.Facebook = "www.facebook.com";
            //else
            //    HeaderModel.Facebook = HeaderModel.Facebook;

            //if (string.IsNullOrEmpty(HeaderModel.Instagram))
            //    HeaderModel.Instagram = "www.instagram.com";
            //else
            //    HeaderModel.Instagram = HeaderModel.Instagram;

            //if (string.IsNullOrEmpty(HeaderModel.Linkedin))
            //    HeaderModel.Linkedin = "www.linkedin.com";
            //else
            //    HeaderModel.Linkedin = HeaderModel.Linkedin;

            //if (string.IsNullOrEmpty(HeaderModel.Twitter))
            //    HeaderModel.Twitter = "www.twitter.com";
            //else
            //    HeaderModel.Twitter = HeaderModel.Twitter;

            //model.HeaderModel = HeaderModel;

            return View("Default", model);
        }
    }
}