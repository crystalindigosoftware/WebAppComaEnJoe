using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTemplate
{
    public partial class UpdateCheff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            int IdCheff = int.Parse(TBIdCheff.Text);

            var CheffSeleccionado = new Cheffs();
            CheffSeleccionado = Negocio.ComaEnJoe.GetCheff(IdCheff);

            //relleno los controles

            TBId.Text = CheffSeleccionado.ID.ToString();
            TBNombre.Text = CheffSeleccionado.Nombre;
            TBApellido.Text = CheffSeleccionado.Apellido;
            TBTelefono.Text = CheffSeleccionado.Telefono;
            TBEspecialidad.Text = CheffSeleccionado.Especialidad;

            TBId.Enabled = false;
            TBIdCheff.Text = "";

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            //capturamos valores

            int _IdCheff = int.Parse(TBId.Text);
            string _nombre = TBNombre.Text;
            string _apellido = TBApellido.Text;
            string _telefono = TBTelefono.Text;
            string _especialidad = TBEspecialidad.Text;

            Cheffs dato = new Cheffs();

            dato.ID = _IdCheff;
            dato.Nombre = _nombre;
            dato.Apellido = _apellido;
            dato.Telefono = _telefono;
            dato.Especialidad = _especialidad;

            int resultado = Negocio.ComaEnJoe.UpdateCheff(dato);

            if (resultado > 0)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                this.LblError.Text = "Ha ocurrido un error al modificar, intente nuevamente";
                this.LblError.Visible = true;
            }
        }
    }
}