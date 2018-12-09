<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="cph_head" ContentPlaceHolderID="cph_head" Runat="Server">
    <div class="container">
        <h2>Welcome to the ESC Hub</h2>
    </div>
</asp:Content>
<asp:Content ID="cph_body" ContentPlaceHolderID="cph_body" Runat="Server">
    <div class="container">
        <p>
            We are the Edmonton Smash Community.  We're a community of over 200 active unique players spanning across all Smash Bros games.<br />
            The site is currently under development.
        </p>
        <hr />
        <p>
            Rankings: <br />
            Melee: <a href="Rankings/MeleeRankings.aspx">MeleeRankings</a> <br />
            S4: <a href="Rankings/S4Rankings.aspx">S4Rankings.aspx</a> <br />
            PM: <a href="Rankings/PMRankings.aspx">PMRankings.aspx</a> <br />
        </p>
    </div>
</asp:Content>

