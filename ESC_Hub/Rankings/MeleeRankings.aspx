<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MeleeRankings.aspx.cs" Inherits="MeleeRankings" %>

<asp:Content ID="head" ContentPlaceHolderID="cph_head" Runat="Server">
    <div class="container">
    <h2>Melee Rankings</h2>
        </div>
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="cph_body" Runat="Server">
    <div class="container">
        <asp:SqlDataSource ID="sql_listplayers" runat="server" ConnectionString="<%$ ConnectionStrings:rmak2_ESC_PlayersConnectionString %>" SelectCommand="SELECT [game_tag], [rating], [last_update] FROM [Player] ORDER BY [rating] DESC"></asp:SqlDataSource>
        <asp:GridView ID="gv_players" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="sql_listplayers" ForeColor="#333333" GridLines="None" OnRowCreated="gv_players_RowCreated" Width="100%">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Rank">
                    <ItemTemplate>
                        <asp:Label ID="gv_lbl_rownum" runat="server" Text="<%# Container.DataItemIndex + 1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="game_tag" HeaderText="game_tag" SortExpression="game_tag" />
                <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />
                <asp:BoundField DataField="last_update" HeaderText="last_update" SortExpression="last_update" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
</asp:Content>


