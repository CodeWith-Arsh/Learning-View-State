using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Events_Methods
{
    public partial class NewDiv : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblDiv.Text = string.Empty; //clear the previous divs

            if (int.TryParse(inputNumber.Text, out int numberOfDivs))
            {
                for (int i = 0; i < numberOfDivs; i++)
                {
                    string div = $"<div style='border': 1px solid black; padding:5px margin:5px;'>Div {i + 1}</div>";

                    lblDiv.Text += div;
                }

            }
            else
            {
                lblDiv.Text = "Enter a Valid Number";
            }
        }
    }
}