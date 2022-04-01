using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrarAluno(object sender, EventArgs e)
        {
            try
            {
                Aluno a = new Aluno();

                a.Nome = txtNome.Text;
                a.Endereco = txtEndereco.Text;
                a.Email = txtEmail.Text;

                AlunoDAL d = new AlunoDAL();

                d.Gravar(a);

                lblMensagem.Text = "Aluno(a) " + a.Nome + " cadastrado(a) com sucesso!!!";

                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
            finally
            {

            }
        }
    }
}