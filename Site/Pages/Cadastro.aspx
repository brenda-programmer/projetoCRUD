<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Cadastro de Aluno</h3>
                    <br />

                     Nome do  Aluno: <br />
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" Width="45%" CssClass="form-control"/>
                    <asp:RequiredFieldValidator 
                        ID="requiredNome" 
                        runat="server" 
                        ControlToValidate="txtNome" 
                        ErrorMessage="Por favor, digite o seu nome." 
                        ForeColor="Red" 
                        />
                    <br /> <br />

                     Endereço do  Aluno: <br />
                    <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço Residencial" Width="50%" CssClass="form-control" />
                    <asp:RequiredFieldValidator 
                        ID="requiredEndereco" 
                        runat="server" 
                        ControlToValidate="txtEndereco" 
                        ErrorMessage="Por favor, digite o seu endereço." 
                        ForeColor="Red" 
                        />
                    <br /> <br />

                     E-mail do  Aluno: <br />
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Email Válido" Width="25%" CssClass="form-control" />
                    <asp:RequiredFieldValidator 
                        ID="requiredEmail" 
                        runat="server" 
                        ControlToValidate="txtEmail" 
                        ErrorMessage="Por favor, digite o seu e-mail." 
                        ForeColor="Red" 
                        />
                    <br /> <br />

                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>

                    <asp:Button 
                        ID="btnCadastro" 
                        runat="server" 
                        Text="Cadastrar" 
                        CssClass="btn btn-lg btn-success" 
                        OnClick="btnCadastrarAluno"
                        />
                    <a href="/Default.aspx" class="btn btn-lg btn-default">Voltar</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
