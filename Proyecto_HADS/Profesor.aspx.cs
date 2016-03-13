﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_HADS
{
    public partial class Profesor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            validConexion();
        }

        protected void validConexion()
        {
            if (Session["correo"] == null || !Session["tipo"].Equals("P"))
                Response.Redirect("Inicio.aspx");
        }

    }
}