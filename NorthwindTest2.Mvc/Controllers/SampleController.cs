using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Xml;

namespace NorthwindTest2.Mvc.Controllers
{
    public class SampleController : Controller
    {
        string menuFilename = "menuitems.xml";
        public ActionResult Page(string id)
        {
            return View(@"~\SampleViews\" + id + ".cshtml");
        }

        public JsonResult MenuItems()
        {
            var listMenuItems = new List<object>();
            if (HttpContext.Request.IsAuthenticated)
            {
                using (StreamReader sr = new StreamReader(HttpContext.Server.MapPath("~") + menuFilename))
                {
                    using (XmlReader reader = XmlReader.Create(sr))
                    {
                        while (reader.Read())
                        {
                            if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "menuitem"))
                            {
                                listMenuItems.Add(new { Title = reader.GetAttribute("title"), Route = reader.GetAttribute("route") });
                            }
                        }
                        reader.Close();
                    }
                    sr.Close();
                }

            }
            return Json(listMenuItems.ToList(), JsonRequestBehavior.AllowGet);
        }

    }
}