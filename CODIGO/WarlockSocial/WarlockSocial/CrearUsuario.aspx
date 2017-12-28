<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="WarlockSocial.CrearUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Crear Usuario</h2>
                    <h5>Ingrese Datos para Crear Usuario </h5>
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="NickName: "></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Contraseña: "></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Correo: "></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Fecha de Nacimiento: "></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server" Text="AAAA-MM-DD"></asp:TextBox>
                            </td>
                        </tr>
                        
                        <tr>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="Crear Usuario" OnClick="Button1_Click" />
                            </td>
                            
                        </tr>
                    </table>
    </div>
    </form>
</body>
</html>
