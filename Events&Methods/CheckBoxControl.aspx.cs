using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Events_Methods
{
    public partial class CheckBoxControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sbUserChoices=new StringBuilder();
            if (GraduateCheckBox.Checked )
            {
                sbUserChoices.Append(GraduateCheckBox.Text);
            }
            if (PostGraduateCheckBox.Checked)
            {
                sbUserChoices.Append(PostGraduateCheckBox.Text);
            }
            if (PHDCheckbox.Checked) 
            { 
            sbUserChoices.Append(PHDCheckbox.Text);
            }
            Response.Write("Your Selection" + sbUserChoices.ToString());
        }
    }
}