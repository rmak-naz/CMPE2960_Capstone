using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Data;

/// <summary>
/// Summary description for DBConnection
/// </summary>
public class DBConnection
{
    public static string GetConnString(out string result)
    {
        //Util-2 Assume failure.  
        string returnValue = "";
        result = "";

        //Util-3 Look for the name in the connectionStrings section.  
        ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["rmak2_ESC_PlayersConnectionString"];

        //If found, return the connection string.  
        if (settings != null)
            returnValue = settings.ConnectionString;

        using (SqlConnection conn = new SqlConnection(settings.ConnectionString))
        {
            try
            {
                conn.Open();
                result = "Successfully connected to " + conn.Database;
            }
            catch
            {
                result = "Could not connect to server; please check connectionstring";
            }
            finally
            {
                conn.Close();
            }
        }

        return returnValue;
    }

    public static bool IsConnected()
    {        
        //Util-3 Look for the name in the connectionStrings section.  
        ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["ESC_Registration_Application.Properties.Settings.rmak2_ESC_PlayersConnectionString"];

        //If found, return the connection string.  
        if (settings != null)
            Debug.WriteLine(settings.ConnectionString);

        using (SqlConnection conn = new SqlConnection(settings.ConnectionString))
        {
            try
            {
                conn.Open();                
            }
            catch
            {
                Debug.WriteLine("Could not connect to server; please check connectionstring");
            }
            finally
            {
                conn.Close();
            }
        }

        return true;
    }

    public static bool DoesPlayerExist(string game_tag)
    {
        string connError;
        using (SqlConnection conn = new SqlConnection(GetConnString(out connError)))
        {
            string sQuery_id = "SELECT * FROM Player";
            sQuery_id += " WHERE lower(game_tag) = '" + game_tag.ToLower() + "'";

            SqlCommand cmd = new SqlCommand(sQuery_id, conn);

            try
            {
                conn.Open();
                int numRows = cmd.ExecuteNonQuery();
                if (numRows >= 1)
                    return true;
                else
                    return false;
            }
            catch (SqlException e)
            {
                Debug.WriteLine("Could not run query.");
                Debug.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }

    public static Player GetPlayer(string game_tag)
    {
        string connError;
        using (SqlConnection conn = new SqlConnection(GetConnString(out connError)))
        {
            string sQuery = "SELECT * FROM Player";
            sQuery += " WHERE lower(game_tag) = '" + game_tag.ToLower() + "'";            

            SqlCommand cmd = new SqlCommand(sQuery, conn);

            try
            {
                conn.Open();
                //Debug.WriteLine("Successfully opened to the db..." + conn.Database);                    

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                if (dt.Rows.Count >= 1)
                {
                    Player foundPlayer = new Player(
                        Convert.ToInt32(dt.Rows[0]["player_id"]),
                        (string)dt.Rows[0]["game_tag"],
                        (string)dt.Rows[0]["f_name"],
                        (string)dt.Rows[0]["l_name"],
                        Convert.ToInt32(dt.Rows[0]["rating"]));
                    return foundPlayer;
                }

            }
            catch
            {
                Debug.WriteLine("Could not run query.");
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        return null;
    }

    public static int ExplicitStatement(string query)
    {
        string connError;
        int numRows = 0;
        using (SqlConnection conn = new SqlConnection(GetConnString(out connError)))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                numRows = cmd.ExecuteNonQuery();                
            }
            catch
            {
                Debug.WriteLine("Could not run query.");
                return numRows;
            }
            finally
            {
                conn.Close();
            }
            return numRows;
        }        
    }
}