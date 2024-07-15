using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Events_Methods
{
    public partial class Generating_Divs_Using_Drop_Down : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem malelistItem = new ListItem("1", "1");
                ListItem femaleListItem = new ListItem("2", "2");
                DropDownList1.Items.Add(malelistItem);
                DropDownList1.Items.Add(femaleListItem);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text;
            DropDownList1.Items.Add(new ListItem(inputText));
            txtInput.Text = string.Empty;
            lblMessage.Text = "Item added successfully!";


            string selectedItemText = DropDownList1.SelectedItem.Text;
            if (int.TryParse(selectedItemText, out int selectedItemInt))
                {
                int savedItemInt = selectedItemInt;
                lblMessage.Text = $"{selectedItemInt}";
                for (int i = 1; i <= savedItemInt; i++)
                {
                    System.Web.UI.HtmlControls.HtmlGenericControl addDiv =
       new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    addDiv.ID = "dynDivCode";
                    addDiv.Style.Add(HtmlTextWriterStyle.BackgroundColor, "#ffffff");
                    addDiv.Style.Add(HtmlTextWriterStyle.Height, "40px");
                    addDiv.Style.Add(HtmlTextWriterStyle.Width, "1000");
                    addDiv.Style.Add(HtmlTextWriterStyle.BorderStyle, "solid");
                    addDiv.Style.Add(HtmlTextWriterStyle.BorderColor, "#F2F7A1");
                    addDiv.Style.Add(HtmlTextWriterStyle.MarginBottom, "10px");
                    addDiv.InnerHtml = "This is Div" + i;
                    this.Controls.Add(addDiv);

                }
            }


           
         
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }