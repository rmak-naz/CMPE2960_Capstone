using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Diagnostics;

public partial class UpdateRankings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        mv_fileupload.ActiveViewIndex = 0;
    }

    protected void btn_upload_Click(object sender, EventArgs e)
    {
        if (!fu_rankings.HasFile)
        {
            lbl_upload_status.Text = "No file chosen.";
            return;
        }

        if (fu_rankings.PostedFile.ContentType != "application/vnd.ms-excel")
        {
            lbl_upload_status.Text = "Wrong file type.  Please upload a .csv file.";
            return;
        }

        string inputContent;
        List<string> sql_strings = new List<string>();
        
        using (StreamReader inputStreamReader = new StreamReader(fu_rankings.PostedFile.InputStream))
        {
            inputContent = inputStreamReader.ReadToEnd();
        }
        lbl_upload_status.Text = "CSV file uploaded.  Now to check for names...";
        
        List<string> playerList = new List<string>(inputContent.Split(new char[] { '\r', '\n' },StringSplitOptions.RemoveEmptyEntries));
        //Create table
        List<string> headerList = new List<string>() { "Game tag", "Previous rating", "New rating" };
        TableHeaderRow thr = new TableHeaderRow();

        foreach (string colhead in headerList)
        {
            TableCell tbc = new TableCell();
            tbc.Text = colhead;
            thr.Cells.Add(tbc);
        }

        table_update.Rows.Add(thr);

        foreach (string row in playerList)
        {
            string game_tag = row.Split(',')[0];
            int new_rating = Convert.ToInt32(row.Split(',')[1]);
            Player foundPlayer = DBConnection.GetPlayer(game_tag);

            if (foundPlayer != null)
            {
                TableRow tr = new TableRow();
                foreach (string colhead in headerList)
                {
                    TableCell tbc = new TableCell();
                    switch (colhead)
                    {
                        case "Game tag":
                            tbc.Text = foundPlayer.game_tag;
                            break;
                        case "Previous rating":
                            tbc.Text = foundPlayer.game_rating.ToString();
                            break;
                        default:
                            tbc.Text = new_rating.ToString();
                            break;
                    }
                    tr.Cells.Add(tbc);
                }
                sql_strings.Add("UPDATE Player SET rating=" + new_rating + " WHERE player_id='" + foundPlayer.player_id + "' GO");
                table_update.Rows.Add(tr);
            }            
        }
        string sql_query = "";
        sql_strings.ForEach(query => sql_query += query + "|");
        hide_SQLStatement.Value = sql_query;

        mv_fileupload.SetActiveView(view_uploaded);
    }

    protected void btn_update_Click(object sender, EventArgs e)
    {
        int rows_updated = 0;
        List<string> sql_strings = new List<string>(hide_SQLStatement.Value.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries));        

        sql_strings.ForEach(query => rows_updated += DBConnection.ExplicitStatement(query));
        mv_fileupload.SetActiveView(view_default);
        lbl_upload_status.Text = rows_updated.ToString() + " rows updated.";
    }

    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        hide_SQLStatement.Value = null;
        lbl_upload_status.Text = "Canceled update.";
        mv_fileupload.SetActiveView(view_default);
    }
}