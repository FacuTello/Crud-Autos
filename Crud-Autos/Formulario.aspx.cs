using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud_Autos
{
    public partial class Formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlColores.Items.Add("Rojo");
            ddlColores.Items.Add("Negro");
            ddlColores.Items.Add("Turquesa");
            ddlColores.Items.Add("Blanco");
            ddlColores.Items.Add("Amarillo");

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}