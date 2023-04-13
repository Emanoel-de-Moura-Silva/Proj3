<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="conta.aspx.cs" Inherits="proj3.conta" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
    
        <br>
        <asp:Label ID="Label1" runat="server" Font-Size="Larger" ForeColor="#FF0066" 
            Text="Cadastro de Contas"></asp:Label>
        <br />
        </div>
      <div>
        Numero da Conta:
        <asp:TextBox ID="txtNum" runat="server" 
            style="position: relative; top: -1px; left: 5px; height: 22px;"></asp:TextBox>
        <p title="Cadastro Contas">
            Saldo:
            <asp:TextBox ID="txtSaldo" runat="server" 
                style="position: relative; top: 4px; left: 77px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLimpar" runat="server" OnClick="btnLimpar_Click" Text="Limpar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
        </p>
        Movimento:
        <asp:TextBox ID="txtMov" runat="server" 
            style="position: relative; top: 0px; left: 44px"></asp:TextBox>
        <p>
        
            <asp:Button ID="btnCriarConta" runat="server"  
                Text="Criar Conta" onclick="btnCriarConta_Click" />
            <asp:Button ID="btnDebitar" runat="server" 
                Text="Debitar" style="position: relative; top: 3px; left: 64px" 
                Width="61px" onclick="btnDebitar_Click" />
            <asp:Button ID="btnCreditar" runat="server" Text="Creditar" 
                style="position: relative; top: 5px; left: 126px" 
                onclick="btnCreditar_Click" />
        </p>
        <asp:Label ID="lblGeral" runat="server" ForeColor="#CC0000"></asp:Label>
      </div>
    </form>
</body>
</html>
