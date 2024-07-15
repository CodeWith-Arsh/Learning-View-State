using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Events_Methods
{
    public partial class eventHandler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Click += new EventHandler(Button1_Click);
            Button1.Command += new CommandEventHandler(Button1_Command);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
        }
        protected void Button1_Command(object sender, CommandEventArgs e)
        {
        }
        protected void CommandButton_Click(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Print":
                    OutputLabel.Text = "You clicked Print Button";
                    break;
                case "Delete":
                    OutputLabel.Text = "You clicked Delete Button";
                    break;
                case "Show":
                    if (e.CommandArgument.ToString() == "Top10")
                    {
                        OutputLabel.Text = "You clicked Show Top 10 Employees Button";
                    }
                    else
                    {
                        OutputLabel.Text = "You clicked Show Bottom 10 Employees Button";
                    }
                    break;
                default:
                    OutputLabel.Text = "We don't know which button you clicked";
                    break;
            }
        }
    }
}