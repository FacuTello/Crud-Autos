using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

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
            Auto nuevo = new Auto();

            nuevo.Id = int.Parse(txtId.Text);
            nuevo.Modelo = txtModelo.Text;
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Color = ddlColores.SelectedValue;
            nuevo.Fecha = DateTime.Parse(txtFecha.Text);
            nuevo.Usado = cbUsado.Checked;

            if (rbImportado.Checked)
                nuevo.Importado = true;
            else if (rbNacional.Checked)
                nuevo.Importado = false;

            List<Auto> temporal = (List<Auto>)Session["listaAutos"];
            temporal.Add(nuevo);

            Response.Redirect("default.aspx");
        }
    }
}