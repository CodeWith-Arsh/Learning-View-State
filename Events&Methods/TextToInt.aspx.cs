using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Events_Methods
{
    public partial class TextToInt : System.Web.UI.Page
    {
        private int intValue;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["StoredIntValue"] != null)
            {
                intValue = (int)ViewState["StoredIntValue"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int intValue;

            // Try to convert the textbox value to an integer
            if (int.TryParse(txtValue.Text, out intValue))
            {
                // Successfully converted to integer, store in ViewState for persistence
                ViewState["StoredIntValue"] = intValue;

                // Display the value
                lblResult.Text = "The integer value is: " + intValue;
                Response.Write(intValue);

            }
            else
            {
                // Handle the case where the conversion failed
                lblResult.Text = "Please enter a valid integer.";
            }
        }
    }
}