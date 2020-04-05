using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Del(User user)
        {

            XDocument xdoc = XDocument.Load("D:\\users.xml");
            XElement root = xdoc.Element("Who");
            foreach (XElement xe in root.Elements("user").ToList())
            {
                if (xe.Element("login").Value == user.Login)
                {
                    xe.Remove();
                    xdoc.Save("D:\\users.xml");
                }
            }
            return View();
        }

        public ActionResult RegE()
        {
            return View();
        }
        public ActionResult BuyE()
        {
            return View();
        }
        public ActionResult Af()
        {
            return View();
        }
        public ActionResult Buy(User user)
        {
            return View();
        }
        public ActionResult LK(User user)
        {
            XDocument xdoc = XDocument.Load("D:\\users.xml");
            XElement root = xdoc.Element("Who");
            foreach (XElement xe in root.Elements("user").ToList())
            {
                if (xe.Element("login").Value == user.Login)
                {
                    if (user.Email != null)
                        xe.Element("email").Value = user.Email;
                    if (user.Name != null)
                        xe.Element("name").Value = user.Name;
                    if (user.Surname != null)
                        xe.Element("surname").Value = user.Surname;
                    if (user.Ot != null)
                        xe.Element("ot").Value = user.Ot;
                    if (user.Address != null)
                        xe.Element("address").Value = user.Address;
                    if (user.Birth != null)
                        xe.Element("birth").Value = user.Birth;
                    if (user.Number != null)
                        xe.Element("number").Value = user.Number;
                    xdoc.Save("D:\\users.xml");
                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user, bool ist = false)
        {
            if (ist == true)
            {
                XmlDocument xDoc = new XmlDocument();
                if (!System.IO.File.Exists("D:\\users.xml"))
                {
                    StreamWriter file = new StreamWriter("D:\\users.xml");
                    file.Write("<Who></Who>");
                    file.Close();
                }
                xDoc.Load("D:\\users.xml");
                XmlElement xRoot = xDoc.DocumentElement;
                XmlElement userElem = xDoc.CreateElement("user");
                XmlElement loginElem = xDoc.CreateElement("login");
                XmlElement passwordElem = xDoc.CreateElement("password");

                XmlElement emailElem = xDoc.CreateElement("email");
                XmlElement nameElem = xDoc.CreateElement("name");
                XmlElement surnameElem = xDoc.CreateElement("surname");
                XmlElement otElem = xDoc.CreateElement("ot");
                XmlElement addressElem = xDoc.CreateElement("address");
                XmlElement birthElem = xDoc.CreateElement("birth");
                XmlElement numberElem = xDoc.CreateElement("number");
                
                XmlText loginText = xDoc.CreateTextNode(user.Login);
                XmlText passwordText = xDoc.CreateTextNode(user.Password);

                XmlText emailText = xDoc.CreateTextNode("");
                XmlText nameText = xDoc.CreateTextNode("");
                XmlText surnameText = xDoc.CreateTextNode("");
                XmlText otText = xDoc.CreateTextNode("");
                XmlText addressText = xDoc.CreateTextNode("");
                XmlText birthText = xDoc.CreateTextNode("");
                XmlText numberText = xDoc.CreateTextNode("");
                

                loginElem.AppendChild(loginText);
                userElem.AppendChild(loginElem);
                passwordElem.AppendChild(passwordText);
                userElem.AppendChild(passwordElem);

                emailElem.AppendChild(emailText);
                userElem.AppendChild(emailElem);
                nameElem.AppendChild(nameText);
                userElem.AppendChild(nameElem);
                surnameElem.AppendChild(surnameText);
                userElem.AppendChild(surnameElem);
                otElem.AppendChild(otText);
                userElem.AppendChild(otElem);
                addressElem.AppendChild(addressText);
                userElem.AppendChild(addressElem);
                birthElem.AppendChild(birthText);
                userElem.AppendChild(birthElem);
                numberElem.AppendChild(numberText);
                userElem.AppendChild(numberElem);
                
                xRoot.AppendChild(userElem);
                xDoc.Save("D://users.xml");

                return View();
            }
            else return Redirect("/Home/Err");
        }
        public ActionResult Err()
        {
            return View();
        }
        public ActionResult Reg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Reg(User user)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Auto(User user)
        {
            if (System.IO.File.Exists("D:\\users.xml"))
            {
                bool ok = false;
                XmlDocument xDoc = new XmlDocument();
                XmlElement xRoot = xDoc.DocumentElement;
                XDocument xdoc = XDocument.Load("D:\\users.xml");
                foreach (XElement el in xdoc.Root.Elements())
                {
                    XElement companyElement = el.Element("login");
                    XElement priceElement = el.Element("password");
                    if ((companyElement.Value == user.Login) && (priceElement.Value == user.Password))
                    {
                        ok = true;
                    }
                    //}
                }
                if (ok == true)
                    return View();
                else return Redirect("/Home/RegE"); ;
            }
            else return Redirect("/Home/RegE"); ;


        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}