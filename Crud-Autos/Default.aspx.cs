using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Crud_Autos
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["listaAutos"] == null)
            {
                AutoNegocio negocio = new AutoNegocio();
                Session.Add("listaAutos", negocio.listar());

            }

            grillaAutos.DataSource = Session["listaAutos"];
            grillaAutos.DataBind();
        }
    }
}