<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UpdateRankings.aspx.cs" Inherits="UpdateRankings" %>

<asp:Content ID="head" ContentPlaceHolderID="cph_head" runat="Server">
    <div class="container">
        <h2>Update Rankings</h2>
    </div>
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="cph_body" runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                Upload a .csv file to get started:
                <br />
                <asp:FileUpload ID="fu_rankings" runat="server" />
                <br />

            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btn_upload" runat="server" Text="Upload" OnClick="btn_upload_Click" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                Status:
                <asp:Label ID="lbl_upload_status" runat="server" Width="100%" BorderStyle="Inset" Text="Upload a csv!"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:MultiView ID="mv_fileupload" runat="server">
                    <asp:View ID="view_default" runat="server">
                        Nothing yet...
                    </asp:View>
                    <asp:View ID="view_uploaded" runat="server">
                        <asp:HiddenField ID="hide_SQLStatement" runat="server" />
                        <asp:PlaceHolder ID="ph_upload" runat="server">
                            <asp:Table ID="table_update" CssClass="table-fill" runat="server" Width="100%" GridLines="Both"></asp:Table>
                        </asp:PlaceHolder>
                        <asp:Button ID="btn_update" runat="server" Text="Update Now!" OnClick="btn_update_Click" />
                        <asp:Button ID="btn_cancel" runat="server" Text="Cancel" OnClick="btn_cancel_Click" />
                    </asp:View>
                </asp:MultiView>
                
            </div>
        </div>
    </div>
</asp:Content>


