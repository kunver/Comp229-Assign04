﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign04
{
    public partial class Model : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         string name = Request.QueryString["name"];
         string faction = Request.QueryString["faction"];
        }
    }
}