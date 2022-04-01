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
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
            lblMensagem.Text = "";
            
        }

        protected void btnPesquisarAluno(object sender, EventArgs e)
        {
            try
            {
                int Matricula = Convert.ToInt32(txtMatricula.Text);

                AlunoDAL d = new AlunoDAL();
                Aluno a = d.PesquisarPorMatricula(Matricula);

                if(a != null)
                {
                    pnlDados.Visible = true;
                    txtMatricula.Enabled = false;
                    txtNome.Text = a.Nome;
                    txtEndereco.Text = a.Endereco;
                    txtEmail.Text = a.Email;
                }
                else
                {
                    lblMensagem.Text = "Aluno(a) Não Encontrado(a)!";
                }
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnExcluirAluno(object sender, EventArgs e)
        {
            try
            {
                int Matricula = Convert.ToInt32(txtMatricula.Text);

                Aluno a = new Aluno();
                AlunoDAL d = new AlunoDAL();

                d.Excluir(Matricula);

                txtMatricula.Enabled = true;
                txtMatricula.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;

                lblMensagem.Text = "Aluno(a) Excluído(a) com Sucesso!";
            }
            catch (Exception ex)
            {

                lblMensagem.Text=ex.Message;
            }
        }

        protected void btnAtualizarAluno(object sender, EventArgs e)
        {
            try
            {
                Aluno a = new Aluno();

                a.Matricula = Convert.ToInt32(txtMatricula.Text);
                a.Nome = Convert.ToString(txtNome.Text);
                a.Endereco = Convert.ToString(txtEndereco.Text);
                a.Email = Convert.ToString(txtEmail.Text);

                AlunoDAL d = new AlunoDAL();
                d.Atualizar(a);

                lblMensagem.Text = "Aluno(a) "+ a.Nome +" Atualizado(a) com Sucesso!";

                pnlDados.Visible = true;
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;  
            }
        }
    }
}