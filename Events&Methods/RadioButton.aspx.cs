using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Events_Methods
{
    public partial class RadioButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (MaleRadioButton.Checked == true)
            {
                Response.Write("Your Gender is"+ MaleRadioButton + "<br/>");
            }
            if (FemaleRadioButton.Checked == true)
            {
                Response.Write("Your Gender is" + FemaleRadioButton + "<br/>");
            }
           
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}