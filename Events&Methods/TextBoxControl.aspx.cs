using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Events_Methods
{
    public partial class TextBoxControl : System.Web.UI.Page
    {
        public static string MakeDiv = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MakeDiv = TextBox1.ToString();


            for (int i = 0; i < MakeDiv.Length; i++)
            {
                MakeDiv = "<div id='" + MakeDiv + "<div>";
                Response.Write(MakeDiv);
            }
        }
    }
}