<%@ Page Title="" Language="C#" MasterPageFile="~/Mint.Master" AutoEventWireup="true" CodeBehind="MintForm.aspx.cs" Inherits="Lab03.MintForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContent" runat="server">
    <style>
        
        .buttons {
            background-color: #A9D2C4;
            color: black;
            padding: 12px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            border-radius: 5px;

        }
        .inputs{
            border: 3px solid #555;
            height: 75%;
        }
       
        .auto-style8 {
            border: 3px solid #555;
        }
       
        .auto-style9 {
            width: 338px;
            height: 40px;
        }
        .auto-style10 {
            width: 338px;
            height: 38px;
        }
        .auto-style11 {
            width: 152%;
            padding: 5%;

        }
        .auto-style12 {
            width: 87px;
            height: 40px;
        }
        .auto-style13 {
            width: 87px;
            height: 38px;
        }
        .auto-style14 {
            width: 87px;
            height: 39px;
        }
        .auto-style15 {
            width: 338px;
            height: 39px;
        }
        .table{
            
        }
       
    </style>


    <table class="auto-style11">
        <tr>
            <td class="auto-style12">
                <asp:Label ID="Label1" runat="server" Text="Product Id: "></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox CssClass="auto-style8" ID="inputId" runat="server" Height="32px"></asp:TextBox>
                <asp:Button CssClass="buttons" ID="load" runat="server" OnClick="load_Click" Text="Load" />
            </td>
        </tr>
        <tr>
            <td class="auto-style12">
                <asp:Label ID="Label2" runat="server" Text="Product Name:"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox CssClass="inputs" ID="inputName" runat="server" style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">
                <asp:Label ID="Label3" runat="server" Text="Product Price:"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox CssClass="inputs" ID="inputPrice" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Label ID="Label4" runat="server" Text="Product Quantity:"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:TextBox CssClass="inputs" ID="inputQuantity" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13">
                <asp:Button CssClass="buttons" ID="clear" runat="server" OnClick="clear_Click" Text="Clear" />
            </td>
            <td class="auto-style10">
                <asp:Button CssClass="buttons" ID="insert" runat="server" OnClick="insert_Click" Text="Insert" />
                <asp:Button CssClass="buttons" ID="update" runat="server" OnClick="update_Click" Text="Update" />
                <asp:Button CssClass="buttons" ID="delete" runat="server" OnClick="delete_Click" Text="Delete" />
            </td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style9">
                <asp:RangeValidator ControlToValidate="inputQuantity" ID="RangeValidator1" runat="server" ErrorMessage="Quantity Must be between 1 and 100" MaximumValue="100" MinimumValue="1" ForeColor="#CC0000" Type="Double"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">
                <asp:Label ID="output" runat="server"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Must Be A Number" ControlToValidate="inputPrice" ForeColor="Red" Operator="DataTypeCheck" Type="Currency"></asp:CompareValidator>
            </td>
        </tr>
    </table>
</asp:Content>
