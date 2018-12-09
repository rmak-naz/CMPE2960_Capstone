using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Diagnostics;
using System.Configuration;

namespace ESC_Registration_Application
{
    static class DBConnection
    {
        //using (SqlConnection conn = new SqlConnection(GetConnString(out connError)))            

        public static string GetConnString(out string result)
        {
            //Util-2 Assume failure.  
            string returnValue = "";
            result = "";

            //Util-3 Look for the name in the connectionStrings section.  
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings["ESC_Registration_Application.Properties.Settings.rmak2_ESC_PlayersConnectionString"];

            //If found, return the connection string.  
            if (settings != null)
                returnValue = settings.ConnectionString;
            else
                return returnValue;

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

        public static Player GetPlayer(string p_id)
        {
            string connError;
            Player foundplayer;

            if (p_id.Trim() == "")
            {
                return null;
            }

            using (SqlConnection conn = new SqlConnection(GetConnString(out connError)))
            {
                string sQuery = "SELECT * FROM Player";
                sQuery += " WHERE player_id = '" + p_id + "'";

                SqlCommand cmd = new SqlCommand(sQuery, conn);
                cmd.CommandType = CommandType.Text;

                try
                {
                    conn.Open();
                    //Debug.WriteLine("Successfully opened to the db..." + conn.Database);                    

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    if (dt.Rows.Count == 1)
                    {
                        foundplayer = new Player(
                            Convert.ToInt32(dt.Rows[0]["player_id"]),
                            (string)dt.Rows[0]["game_tag"],
                            (string)dt.Rows[0]["f_Name"],
                            (string)dt.Rows[0]["l_Name"],
                            Convert.ToInt32(dt.Rows[0]["rating"]));
                        return foundplayer;
                    }

                }
                catch
                {
                    Debug.WriteLine("Could not run query.");
                }
                finally
                {
                    conn.Close();                    
                }
            }

            return null;
        }

        public static bool DoesPlayerExist(string p_id)
        {
            string connError;
            using (SqlConnection conn = new SqlConnection(GetConnString(out connError)))
            {
                string sQuery_id = "SELECT * FROM Player";
                sQuery_id += " WHERE player_id = '" + p_id + "'";

                SqlCommand cmd = new SqlCommand(sQuery_id, conn);                

                try
                {
                    conn.Open();
                    //Debug.WriteLine("Successfully opened to the db..." + conn.Database);                    

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    if (dt.Rows.Count >= 1)
                    {
                        return true;
                    }

                }
                catch
                {
                    Debug.WriteLine("Could not run query.");
                }
                finally
                {
                    conn.Close();
                }
            }

            return false;
        }

        public static bool DoesPlayerExist(Player player)
        {
            string connError;
            using (SqlConnection conn = new SqlConnection(GetConnString(out connError)))
            {
                string sQuery = "SELECT * FROM Player";
                sQuery += " WHERE (player_id = '" + player.player_id + "' OR";
                sQuery += " lower(game_tag) = '" + player.game_tag.ToLower() + "' OR (";
                sQuery += " lower(f_name) = '" + player.f_name.ToLower() + "' AND lower(l_name) = '" + player.l_name.ToLower() + "'))";

                SqlCommand cmd = new SqlCommand(sQuery, conn);

                try
                {
                    conn.Open();
                    //Debug.WriteLine("Successfully opened to the db..." + conn.Database);                    

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    if (dt.Rows.Count >= 1)
                    {
                        return true;
                    }

                }
                catch
                {
                    Debug.WriteLine("Could not run query.");
                    conn.Close();
                    return true;
                }
                finally
                {
                    conn.Close();
                }
            }

            return false;
        }

        public static bool InsertNewPlayer(Player newPlayer)
        {
            string connError;
            using (SqlConnection conn = new SqlConnection(GetConnString(out connError)))
            {
                if (!DoesPlayerExist(newPlayer))
                {
                    string insertcmd = "INSERT INTO Player (player_id, game_tag, f_name, l_name, rating) VALUES ('";
                    insertcmd += newPlayer.player_id.ToString() + "', '" + newPlayer.game_tag + "', '" + newPlayer.f_name + "', '" + newPlayer.l_name + "', '" + newPlayer.game_rating + "')";
                    SqlCommand cmd = new SqlCommand(insertcmd, conn);

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
                else
                {
                    return false;
                }
            }
        }
        public static SqlDataAdapter GetPlayers()
        {
            string error;
            SqlDataAdapter data = new SqlDataAdapter("SELECT player_id, game_tag, f_Name, l_Name, rating, last_update FROM dbo.Player", GetConnString(out error));
            return data;
        }
    }
}
