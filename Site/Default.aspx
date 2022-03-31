<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h1>Projeto CRUD - Controle de Alunos</h1>
            <br />
            <p>Selecione  a operação desejada:</p>
            <asp:DropDownList ID="ddlMenu" runat="server">
                <asp:ListItem Value="0" Text="- Escolha uma Opção - " />
                <asp:ListItem Value="1" Text="Cadastrar Aluno" />
                <asp:ListItem Value="2" Text="Consultar Aluno" />
                <asp:ListItem Value="3" Text="Obter os Dados do Aluno" />
            </asp:DropDownList>
            <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-large btn-primary" OnClick="btnAcessar"/>
            <p>
                <asp:Label ID="lblMensagem" runat="server" />
            </p>
        </div>
    </form>
</body>
</html>
