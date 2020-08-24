using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Collections;

namespace AjaxDemo
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.AppendHeader("Access-Control-Allow-Origin", "*");

            //EnableCorsAttribute cors = new EnableCorsAttribute("*","*","*");
            //Config.EnableCors(cors);

            // string course = Request.Params["class"];
            string course="GSK";
            string action = Request.Params["action"];
            Hashtable cart_items = new Hashtable();

            if (Session["cart"] != null)
            {
                cart_items = (Hashtable)Session["cart"];
                if (action == "Add")
                {
                    if (cart_items.ContainsKey(course))
                    {
                        int amount = int.Parse(cart_items[course].ToString());
                        cart_items.Remove(course);
                        amount++;
                        cart_items.Add(course, amount);
                        Session["cart"] = cart_items;
                        Response.ContentType = "text/xml";
                        Response.Write(toXml(cart_items));
                    }
                    else
                    {
                        cart_items.Add(course, 1);
                        Session["cart"] = cart_items;
                        Response.ContentType = "text/xml";
                        Response.Write(toXml(cart_items));
                    }
                }
                else
                {
                    cart_items.Remove(course);
                    Session["cart"] = null;
                    Response.ContentType = "text/xml";
                    Response.Write(toXml(cart_items));
                }
            }
            else
            {
                cart_items.Add(course, 1);
                Session["cart"] = cart_items;
                Response.ContentType = "text/xml";
                Response.Write(toXml(cart_items));
            }

        }

        string toXml(Hashtable h)
        {
            XmlDocument xml = new XmlDocument();
            XmlNode version = xml.CreateXmlDeclaration("1.0", "ISO-8859-1", "yes");
            XmlNode root = xml.CreateElement("cart");
            xml.AppendChild(version);
            xml.AppendChild(root);

            foreach (string key in h.Keys)
            {
                XmlNode course = xml.CreateElement("course");
                XmlNode name = xml.CreateElement("name");
                XmlNode count = xml.CreateElement("count");
                name.AppendChild(xml.CreateTextNode(key));
                count.AppendChild(xml.CreateTextNode(h[key].ToString()));
                course.AppendChild(name);
                course.AppendChild(count);
                root.AppendChild(course);
            }

            string xmlString = xml.InnerXml;
            return xmlString;
        }
    }
}