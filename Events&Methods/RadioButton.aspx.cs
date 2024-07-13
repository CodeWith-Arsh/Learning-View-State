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
            Response.Write("Male Radio Button Selected" + "<br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (MaleRadioButton.Checked )
            {
                Response.Write("Your Gender is "+ MaleRadioButton.Text + "<br/>");
            }
            if (FemaleRadioButton.Checked)
            {
                Response.Write("Your Gender is " + FemaleRadioButton.Text + "<br/>");
            }
           if (UnknownRadioButton.Checked)
            {
                Response.Write("Your Gender is " + UnknownRadioButton.Text + "<br>");
            }
        }

        protected void Unknown_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}