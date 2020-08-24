<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo1.aspx.cs" Inherits="ASP_Page.Demo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%
            Response.Write("My Sctipt");
            Response.Write(Request.Form["fname"]);
            Response.Write(" "+Request.Form["lname"]);
        %>
    </div>
        <div>
        <%
            var a = Request.QueryString["ffname"];
            if (a != "")
            {
                 Response.Write("Hello "+a+"<br/>");
                 Response.Write("How r u?");
            }
        %>
        </div>

        <div>
            <%
                var b = Request.Form["cars"];
                if(b!="")
                {
                    Response.Write("<p>Your car is: "+ b +"</p>");
                }
            %>
        </div>

        <div>
            <%
                Response.Expires = -1;
                string hint = "";
                string[] word = new string[26];
                word[0] = "Gunwant";
                word[1] = "Amar";
                word[2] = "Brittany";
                word[3] = "Jeevan";
                word[4] = "Cinderella";
                word[5] = "Diana";
                word[6] = "Eva";
                word[7] = "Fiona";
                word[8] = "Gunda";
                word[9] = "Hege";
                word[10] = "Inga";
                word[11] = "Johanna";
                word[12] = "Kitty";
                word[13] = "Linda";
                word[14] = "Nina";
                word[15] = "Ophelia";
                word[16] = "Petunia";
                word[17] = "Amanda";
                word[18] = "Raquel";
                word[19] = "Cindy";
                word[20] = "Doris";
                word[21] = "Eve";
                word[22] = "Evita";
                word[23] = "Sunniva";
                word[24] = "Tove";
                word[25] = "Unni";

                string p = Request.QueryString["q"];
                //string g = Request.Form[q];
                string w = Request.Params["q"];


                if (w != null)
                {
                    if (w.Length > 0)
                    {
                        hint = "";
                        for (int j = 1; j < 30;)
                        {
                            if (w == (word[j].Substring(1, w.Length)))
                            {
                                if (hint == "")
                                {
                                    hint = word[j];
                                }
                                else
                                    hint = hint + ", " + word[j];
                            }
                        }
                    }
                }
                if(hint=="")
                {
                    Response.Write("No Suggestion");
                }
                else
                {
                    Response.Write(hint);
                }
            %>
        </div>
    </form>

</body>
</html>
