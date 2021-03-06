<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well"> Consulta de Alunos</h3>

                        <asp:GridView 
                            ID="gridAlunos" 
                            runat="server" 
                            CssClass="table table-hover table-striped" 
                            GridLines="None" 
                            AutoGenerateColumns="false" 
                            BackColor="#99ccff"
                         >
                            <Columns>
                                <asp:BoundField DataField="Matricula" HeaderText="Matrícula" />
                                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                                <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                                <asp:BoundField DataField="Email" HeaderText="E-mail" />
                            </Columns>
                            <RowStyle CssClass="cursor-pointer" />
                        </asp:GridView>
                    
                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>

                    <a href="/Default.aspx" class="btn btn-lg btn-default">Voltar</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
