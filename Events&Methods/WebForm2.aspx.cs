using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Events_Methods
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateDivs_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            if (!string.IsNullOrEmpty(input))
            {
                // Split the input by spaces (or any delimiter you prefer)
                string[] elements = input.Split(' ');

                // Clear the previous output
                lblOutput.Text = string.Empty;

                foreach (string element in elements)
                {
                    // Create a new div element
                    string div = $"<div style='border: 1px solid black; padding: 5px; margin: 5px;'>{element}</div>";
                    // Append the div to the label's text
                    lblOutput.Text += div;
                }
            }
        }
    }
}