<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Comp229_Assign04._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
   <h1>Wrath of Kings</h1>
    </div>

    <div>
        <h4>This is our current list of models.</h4>
        <div>
             <table>
        <asp:Repeater ID="modellist" runat="server">
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:HyperLink runat="server" NavigateUrl='<%# string.Format("~/Model.aspx?name={0}&faction={1}", Eval("name"), Eval("faction")) %>' >
                            <asp:Label runat="server" Text='<%# Eval("name")%>'>  </asp:Label>
                        </asp:HyperLink>
                    </td>
                    <td>

                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
</table>
        </div>
    </div>

</asp:Content>
