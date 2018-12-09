using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditPlayer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {        
    }

    protected void ddl_players_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void dv_player_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
    {
        ddl_players.DataBind();
    }
}