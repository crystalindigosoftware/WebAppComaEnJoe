using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace WebAppTemplate
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Id"] != null)
            {
                int IdCheff = int.Parse(Request.QueryString["Id"].ToString());
                ListarCheffPorId(IdCheff);
            }
            else {
                ListarTodosLosCheffs();
            }
            
        }

        private void ListarTodosLosCheffs() {
            var ProbarLista = new List<Cheffs>();
            var paginaActual = GridView1.PageCount;
            var itemsXPagina = GridView1.PageSize;
            ProbarLista = Negocio.ComaEnJoe.ListChefs(paginaActual, itemsXPagina);
            GridView1.DataSource = ProbarLista;
            GridView1.DataBind();
        }

        private void ListarCheffPorId(int Id) {
            var CheffSeleccionado = new Cheffs();
            CheffSeleccionado = Negocio.ComaEnJoe.GetCheff(Id);

            GridView1.DataSource = new List<Cheffs> { CheffSeleccionado }; //explicar este fix

            GridView1.DataBind();
        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            int IdCheff = int.Parse(TBIdCheff.Text);
            ListarCheffPorId(IdCheff);

        }
    }
}