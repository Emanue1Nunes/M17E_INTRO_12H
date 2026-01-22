using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_INTRO_12H
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                // Só para a primeira carga da página
                tb_x.Text = "0";
                tb_y.Text = "0";
            }
            if(Request.QueryString["resultado"] != null)
            {
                if(Request.QueryString["resultado"] == "erro")
                {
                    Response.Write("<script>alert('O parametro não existe!');</script>");
                }
            }
        }

        protected void bt_soma_Click(object sender, EventArgs e)
        {
            int resultado = Soma(int.Parse(tb_x.Text),int.Parse(tb_y.Text));
            lb_resultado.Text = "Resultado: " + resultado.ToString();
        }

        protected void bt_redirect_Click(object sender, EventArgs e)
        {
            int resultado = Soma(int.Parse(tb_x.Text), int.Parse(tb_y.Text));
            string url = "resultado.aspx?resultado=" + resultado.ToString();
            Response.Redirect(url);
        }

        int Soma(int x, int y)
        {
            return x + y;
        }
    }
}