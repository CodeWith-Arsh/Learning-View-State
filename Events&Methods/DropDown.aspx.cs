﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Events_Methods
{
    public partial class DropDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem malelistItem = new ListItem("Male", "1");
                ListItem femaleListItem = new ListItem("Female", "2");
                DropDownList1.Items.Add(malelistItem);
                DropDownList1.Items.Add(femaleListItem);

            }
        }
    }
}