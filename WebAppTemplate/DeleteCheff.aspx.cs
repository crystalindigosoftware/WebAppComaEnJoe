using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTemplate
{
    public partial class DeleteCheff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            int IdCheff = int.Parse(TBIdCheff.Text);

            int resultado = Negocio.ComaEnJoe.DeleteCheff(IdCheff);

            if (resultado > 0)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                this.LblError.Text = "Ha ocurrido un error al eliminar, intente nuevamente";
                this.LblError.Visible = true;
            }
        }
    }
}