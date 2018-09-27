﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eShopLegacyWebForms
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var txt = Environment.GetEnvironmentVariable("eShopTitle");

            if (!String.IsNullOrEmpty(txt))
            {
                var label = new Label()
                {
                    Text = txt
                };

                ContainerEnv.Controls.Add(label);
            }

        }
    }
}