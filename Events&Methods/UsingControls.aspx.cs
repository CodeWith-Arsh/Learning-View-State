using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Events_Methods
{
    public partial class UsingControls : System.Web.UI.Page
    {
        private int intValue;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["StoredIntValue"] != null)
            {
                intValue = (int)ViewState["StoredIntValue"];
            }
        }

        protected void btnCode_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtValue.Text, out intValue))
            {
                // Successfully converted to integer, store in ViewState for persistence
                ViewState["StoredIntValue"] = intValue;

   
              

            }
            else
            {
                // Handle the case where the conversion failed
                lblResult.Text = "Please enter a valid integer.";
            }
            for (int i=1;i<=intValue;i++)
                {
                    System.Web.UI.HtmlControls.HtmlGenericControl addDiv =
       new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                addDiv.ID = "dynDivCode";
                addDiv.Style.Add(HtmlTextWriterStyle.BackgroundColor, "Gray");
                addDiv.Style.Add(HtmlTextWriterStyle.Height, "20px");
                addDiv.Style.Add(HtmlTextWriterStyle.Width, "1000");
                addDiv.InnerHtml = i+ " :Div";
                    this.Controls.Add(addDiv);
                
            }
                           
        }

        protected void txtTest_TextChanged(object sender, EventArgs e)
        {

        }
    }
}