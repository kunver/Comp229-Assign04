<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Model.aspx.cs" Inherits="Comp229_Assign04.Model" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Image ID="ModelImage" ImageUrl='<%# Eval("imageUrl")%>' runat="server"/>
    </div>
        <div>
            <asp:DataList ID="DataList1" runat="server"></asp:DataList>
            <asp:Label runat="server" Text='<%# Eval("name")%>'/>
            <asp:Label runat="server" Text='<%# Eval("faction")%>'/>
            <asp:Label runat="server" Text='<%# Eval("rank")%>'/>
            <asp:Label runat="server" Text='<%# Eval("size")%>'/>
          
        </div>
        <div>
            <asp:Button ID="Update" runat="server" Text="Update" />
        </div>
    </form>
</body>
</html>
