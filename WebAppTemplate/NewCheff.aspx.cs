using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTemplate
{
    public partial class NewCheff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            //capturamos valores

            string _nombre = TBNombre.Text;
            string _apellido = TBApellido.Text;
            string _telefono = TBTelefono.Text;
            string _especialidad = TBEspecialidad.Text;

            Cheffs dato = new Cheffs();

            dato.Nombre = _nombre;
            dato.Apellido = _apellido;
            dato.Telefono = _telefono;
            dato.Especialidad = _especialidad;

            int resultado = Negocio.ComaEnJoe.InsertCheff(dato);

            if (resultado > 0)
            {
                Response.Redirect("Default.aspx");
            }
            else {
                this.LblError.Text = "Ha ocurrido un error al insertar, intente nuevamente";
                this.LblError.Visible = true;
            }

        }
    }
}