<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detalhes</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Detalhes do Aluno</h3>
                    
                    Informe a Matrícula: <br />
                    <asp:TextBox ID="txtMatricula" runat="server" CssClass="form-control" Width="5%" />
                    <br /> 
                    <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar" CssClass="btn btn-info btn-lg" OnClick="btnPesquisarAluno" />
                    <br />  <br />

                    <asp:Panel ID="pnlDados" runat="server">

                        Nome do(a) Aluno(a): <br />
                        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" Width="45%" />
                        <br />
                        Endereço do(a) Aluno(a): <br />
                        <asp:TextBox ID="txtEndereco" runat="server" CssClass="form-control" Width="50%" />
                        <br />
                        En-mail do(a) Aluno(a): <br />
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Width="25%" />
                        <br />

                        <p>
                            <asp:Label ID="lblMensagem" runat="server" />
                        </p>

                        <asp:Button ID="btnExclui" runat="server" Text="Excluir" CssClass="btn btn-danger btn-lg"/>
                        <asp:Button ID="btnAtualiza" runat="server" Text="Atualizar" CssClass="btn btn-warning btn-lg" />
                        <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>

                    </asp:Panel>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
