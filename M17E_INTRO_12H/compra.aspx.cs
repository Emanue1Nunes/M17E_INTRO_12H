using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_INTRO_12H
{
    public partial class compra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                AtualizarDDMarcas();
            }
        }

        private void AtualizarDDMarcas()
        {
            dd_marca.Items.Add(new ListItem("Apple", "3"));
        }
        /// <summary>
        /// Evento quando a marca selecionada muda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void dd_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            dd_modelo.Items.Clear();
            // Verificar a marca selecionada
            if (dd_marca.SelectedIndex <= 0)
            {
                return;
            }
            if(dd_marca.SelectedIndex == 1)
            {
                dd_modelo.Items.Add(new ListItem("Asus 1", "1"));
                dd_modelo.Items.Add(new ListItem("Asus 2", "2"));
            }
            if(dd_marca.SelectedIndex == 2)
            {
                dd_modelo.Items.Add(new ListItem("HP 1", "1"));
                dd_modelo.Items.Add(new ListItem("HP 2", "2"));
            }
            if(dd_marca.SelectedIndex == 3)
            {
                dd_modelo.Items.Add(new ListItem("Apple 1", "1"));
                dd_modelo.Items.Add(new ListItem("Apple 2", "2"));
            }   
        }

        protected void bt_comprar_Click(object sender, EventArgs e)
        {
            // validação dos dados
            try
            {
                // nome - obrigatório e no minimo 5 letras
                string nome = tb_nome.Text;
                if (string.IsNullOrEmpty(nome) || nome.Length < 5)
                {
                    throw new Exception("O nome deve ter pelo menos 5 letras");
                }
                // email - obrigatório com @ .
                string email = tb_email.Text;
                if(string.IsNullOrEmpty(email) || !email.Contains("@") || !email.Contains("."))
                {
                    throw new Exception("O email não é válido");
                }
                // data nascimento - pelo menos 18 anos
                DateTime data = DateTime.Parse(tb_data_nascimento.Text);
                TimeSpan idade = DateTime.Now - data;
                if (idade.TotalDays / 365 < 18)
                {
                    throw new Exception("Tem de ter pelo menos 18 anos");
                }
                // marca - obrigatório
                if(dd_marca.SelectedIndex <= 0)
                {
                    throw new Exception("Tem de selecionar uma marca");
                }
                // modelo - obrigatório
                if (dd_modelo.SelectedIndex <= 0)
                {
                    throw new Exception("Tem de selecionar uma marca");
                }
                // processador - só pode ter 1
                if (!rb_amd.Checked && !rb_intel.Checked && !rb_outro.Checked)
                {
                    throw new Exception("Selecione o modelo de processador do pc");
                }
                // aceitou as condições 
                if(!cb_aceitar.Checked)
                {
                    throw new Exception("Tem de aceitar os termos e condições");
                }
                // guardar imagem 
                // existe ficheiro?
                if(fu_foto_perfil.HasFile)
                {
                    throw new Exception("Envie uma imagem de perfil");
                }
                // validação do tipo de ficheiro
                if(fu_foto_perfil.PostedFile.ContentType != "image/jpeg" &&
                   fu_foto_perfil.PostedFile.ContentType != "image/png")
                {
                    throw new Exception("O tipo de ficheiro não é válido");
                }
                // validar o tamanho do ficheiro 
                if(fu_foto_perfil.PostedFile.ContentLength == 0 || 
                   fu_foto_perfil.PostedFile.ContentLength > 50000000)
                {
                    throw new Exception("O tamanho do ficheiro não é válido");
                }
                // guardar 
                string ficheiro = Server.MapPath("~/imagens/");
                ficheiro += "/" + fu_foto_perfil.FileName;
                fu_foto_perfil.SaveAs(ficheiro);
                lb_erro.Text = "Compra efetuada com sucesso!";
            }
            catch (Exception ex)
            {
                lb_erro.Text = "Ocorreu o seguinte erro: " + ex.Message;
            }
        }
    }
}