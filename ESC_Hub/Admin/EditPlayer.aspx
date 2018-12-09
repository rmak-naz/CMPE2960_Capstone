<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditPlayer.aspx.cs" Inherits="EditPlayer" %>

<asp:Content ID="cph_head" ContentPlaceHolderID="cph_head" Runat="Server">
    <div class="container">
        <h2>Edit Player Information</h2>
    </div>
</asp:Content>
<asp:Content ID="cph_body" ContentPlaceHolderID="cph_body" Runat="Server">
    <div class="container">
        <div class="row">
            <asp:SqlDataSource ID="sql_getplayers" runat="server" ConnectionString="<%$ ConnectionStrings:rmak2_ESC_PlayersConnectionString %>" SelectCommand="SELECT [game_tag] FROM [Player]"></asp:SqlDataSource>
            Select Player: <asp:DropDownList ID="ddl_players" runat="server" DataSourceID="sql_getplayers" DataTextField="game_tag" DataValueField="game_tag" OnSelectedIndexChanged="ddl_players_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
        </div>
        <br />
        <%--<div class="row">
            First Name: <asp:TextBox ID="tb_fname" runat="server" Text=""></asp:TextBox>
        </div>
        <div class="row">
            Last Name: <asp:TextBox ID="tb_lname" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            Rating: <asp:TextBox ID="tb_rating" runat="server"></asp:TextBox>
        </div>--%>
        <asp:SqlDataSource ID="sql_player" runat="server" ConnectionString="<%$ ConnectionStrings:rmak2_ESC_PlayersConnectionString %>" SelectCommand="SELECT [player_id], [game_tag], [f_Name], [l_Name], [rating] FROM [Player] WHERE ([game_tag] = @game_tag)" DeleteCommand="DELETE FROM [Player] WHERE [player_id] = @player_id" InsertCommand="INSERT INTO [Player] ([player_id], [game_tag], [f_Name], [l_Name], [rating]) VALUES (@player_id, @game_tag, @f_Name, @l_Name, @rating)" UpdateCommand="UPDATE [Player] SET [game_tag] = @game_tag, [f_Name] = @f_Name, [l_Name] = @l_Name, [rating] = @rating WHERE [player_id] = @player_id">
            <DeleteParameters>
                <asp:Parameter Name="player_id" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="player_id" Type="String" />
                <asp:Parameter Name="game_tag" Type="String" />
                <asp:Parameter Name="f_Name" Type="String" />
                <asp:Parameter Name="l_Name" Type="String" />
                <asp:Parameter Name="rating" Type="Int32" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="ddl_players" Name="game_tag" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="game_tag" Type="String" />
                <asp:Parameter Name="f_Name" Type="String" />
                <asp:Parameter Name="l_Name" Type="String" />
                <asp:Parameter Name="rating" Type="Int32" />
                <asp:Parameter Name="player_id" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <div class="row">
        <asp:DetailsView ID="dv_player" runat="server" Height="50px" Width="50%" DataSourceID="sql_player" AutoGenerateRows="False" CellPadding="4" DataKeyNames="player_id" ForeColor="#333333" HeaderText="Player Information" OnItemDeleted="dv_player_ItemDeleted">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="player_id" HeaderText="Player ID" ReadOnly="True" SortExpression="player_id" />
                <asp:BoundField DataField="game_tag" HeaderText="Gamer Tag" SortExpression="game_tag" />
                <asp:BoundField DataField="f_Name" HeaderText="First Name" SortExpression="f_Name" />
                <asp:BoundField DataField="l_Name" HeaderText="Last Name" SortExpression="l_Name" />
                <asp:BoundField DataField="rating" HeaderText="Game Rating" SortExpression="rating" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" />
            </Fields>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="Black" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:DetailsView>
        </div>
    </div>
</asp:Content>

