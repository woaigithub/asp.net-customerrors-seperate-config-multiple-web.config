﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Silver : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = System.Configuration.ConfigurationManager.AppSettings["title"];
            throw new HttpException(404, "Not Found");
        }
    }
}