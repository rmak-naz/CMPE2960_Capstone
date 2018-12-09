using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;

namespace ESC_Registration_Application
{
    public partial class Registration_Application : Form
    {
        List<Player> playerList = new List<Player>();
        List<Entrant> entrantsList = new List<Entrant>();
        Random _rnd = new Random();
        Player addPlayer;
        SerialPort bt_serial;
        Thread ThreadRX = null;

        private delegate void delVoidString(string str_);

        public Registration_Application()
        {
            InitializeComponent();
            pg_Registration.Enabled = false;
            pg_players.Enabled = false;
        }

        private void btn_connCheck_Click(object sender, EventArgs e)
        {            
            string connResult;
            tb_conn.Text = "Connecting to DB...";
            DBConnection.GetConnString(out connResult);
            if (connResult == "Could not connect to server; please check connectionstring")
            {                
                pg_Registration.Enabled = false;                                
            }
            else
            {                
                pg_Registration.Enabled = true;
                tb_playerid.Focus();            //focus at player id text box at registation tab click
                tb_playerid.SelectAll();        //highlight all text 
                pg_players.Enabled = true;
                ddl_export.SelectedIndex = 0;
                FillDatabaseTab();
                if (InitializeBluetooth())
                {
                    connResult += "; BT Connected";
                    try
                    {
                        bt_serial.Write("c");
                    }
                    catch
                    {
                        Debug.WriteLine("BT not connected.");
                    }
                }                    
                else
                {
                    connResult += "; BT connect failed.";                    
                }
                    
            }
            tb_conn.Text = connResult;                        
        }

        private void btn_fillPlayer_Click(object sender, EventArgs e)
        {
            int temp_int;
            if (tb_playerid.Text.Trim() == "")
            {
                lbl_add_status.Text = "Empty ID.";
                return;
            }
            else if (!int.TryParse(tb_playerid.Text, out temp_int))
            {
                lbl_add_status.Text = "Invalid ID.";
            }
            else
            {
                addPlayer = DBConnection.GetPlayer(tb_playerid.Text.Trim());
                if (addPlayer != null)
                {
                    lbl_add_status.Text = "Found player from ID.";
                    try
                    {
                        bt_serial.Write("y");
                    }
                    catch
                    {
                        Debug.WriteLine("BT not connected.");
                    }

                    tb_gametag.Text = addPlayer.game_tag;
                    tb_rating.Text = addPlayer.game_rating.ToString();

                    string fullname = addPlayer.f_name + " " + addPlayer.l_name;
                    tb_fullname.Text = fullname;

                    tb_playerid.Enabled = false;
                    tb_fullname.Enabled = false;
                    tb_gametag.Enabled = false;
                    tb_rating.Enabled = false;

                    btn_addentrant.Enabled = true;
                    btn_insertplayer.Enabled = false;
                    btn_generate_id.Enabled = false;
                }
                else
                {
                    lbl_add_status.Text = "Could not find player.";
                    try
                    {
                        bt_serial.Write("n");
                    }
                    catch
                    {
                        Debug.WriteLine("BT not connected.");
                    }
                }                
            }
        }

        private void btn_insertplayer_Click(object sender, EventArgs e)
        {
            if (IsFormFilled())
            {
                string[] nameSplit = tb_fullname.Text.Split(' ');
                addPlayer = new Player(
                    Convert.ToInt32(tb_playerid.Text),
                    tb_gametag.Text, 
                    nameSplit[0], 
                    nameSplit[1], 
                    Convert.ToInt32(tb_rating.Text));

                if (DBConnection.InsertNewPlayer(addPlayer))
                {
                    lbl_add_status.Text = "Successfully added player to db.";
                    btn_addentrant.Enabled = true;
                    FillDatabaseTab();
                }
                else
                {
                    lbl_add_status.Text = "Failed to add player.  Player already exists.";
                }
            }
            else
            {
                lbl_add_status.Text = "Form not filled.";
            }
        }

        private void btn_addentrant_Click(object sender, EventArgs e)
        {
            if (IsFormFilled())
            {
                Entrant newEntrant = new Entrant(addPlayer, new List<bool>() { cb_melee_entry.Checked, cb_s4_entry.Checked, cb_pm_entry.Checked });
                if (entrantsList.Contains(newEntrant))
                {
                    lbl_add_status.Text = "Player already added in entrants list.";
                    return;
                }
                entrantsList.Add(newEntrant);

                ListViewItem lvi = new ListViewItem(newEntrant._player.game_tag);
                lvi.SubItems.AddRange(new string[]
                        { newEntrant._entries[0] ? "x" : "", newEntrant._entries[1] ? "x" : "", newEntrant._entries[2] ? "x" : "", newEntrant._player.game_rating.ToString()});
                lvi.Tag = newEntrant;
                lv_entrants.Items.Add(lvi);
                ClearForm();
                addPlayer = null;        
            }
            else
            {
                lbl_add_status.Text = "Form not fully filled.";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            tb_fullname.Text = "";
            tb_gametag.Text = "";
            tb_playerid.Text = "";
            tb_rating.Text = "";
            cb_melee_entry.Checked = false;
            cb_s4_entry.Checked = false;
            cb_pm_entry.Checked = false;

            tb_fullname.Enabled = true;
            tb_gametag.Enabled = true;
            tb_playerid.Enabled = true;
            tb_rating.Enabled = true;

            lbl_add_status.Text = "Form cleared.  Click fill data to check ID.";

            btn_insertplayer.Enabled = true;            
            btn_generate_id.Enabled = true;

            try
            {
                bt_serial.Write("n");
            }
            catch
            {
                Debug.WriteLine("BT not connected.");
            }
        }

        private bool IsFormFilled()
        {
            if (tb_fullname.Text.Trim() == "" ||
                tb_gametag.Text.Trim() == "" ||
                tb_playerid.Text.Trim() == "" ||
                tb_rating.Text.Trim() == "" ||
                (tb_fullname.Text.Split(' ').Count() < 2) ||
                (!cb_melee_entry.Checked && !cb_pm_entry.Checked && !cb_s4_entry.Checked))
                return false;
            else
                return true;
            
            
        }

        private void btn_generate_id_Click(object sender, EventArgs e)
        {            
            int new_id;
            
            do
            {
                new_id = _rnd.Next(1000000, 2000000);
            } while (DBConnection.DoesPlayerExist(new_id.ToString()));

            tb_playerid.Text = new_id.ToString();
            btn_addentrant.Enabled = false;            
        }

        private void btn_export_entrants_Click(object sender, EventArgs e)
        {
            string fileName;
            List<Entrant> exportList;
            if (ddl_export.SelectedItem != null)
            {
                switch (ddl_export.SelectedItem.ToString())
                {
                    case "Melee":
                        fileName = "ExportMelee.txt";
                        exportList = entrantsList.FindAll(entrant => entrant._entries[0]);
                        break;
                    case "S4":
                        fileName = "ExportS4.txt";
                        exportList = entrantsList.FindAll(entrant => entrant._entries[1]);
                        break;
                    default: //For PM
                        fileName = "ExportPM.txt";
                        exportList = entrantsList.FindAll(entrant => entrant._entries[2]);
                        break;                    
                }
            }
            else
            {
                fileName = "Export.txt";
                exportList = entrantsList;
            }
            
            string curPath = @"..\..\";
            using (StreamWriter writer = File.CreateText(curPath + fileName))
            {
                exportList.Sort();
                exportList.ForEach(entrant => writer.WriteLine(entrant._player.game_tag));
            }
            lbl_add_status.Text = "Exported entrants list";
        }

        private void btn_clear_entrants_Click(object sender, EventArgs e)
        {
            entrantsList.Clear();
            lv_entrants.Items.Clear();
        }

        private void btn_remove_entrant_Click(object sender, EventArgs e)
        {
            entrantsList.Remove((Entrant)lv_entrants.SelectedItems[0].Tag);
            lv_entrants.Items.Remove(lv_entrants.SelectedItems[0]);            
        }

        private void Registration_Application_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rmak2_ESC_PlayersDataSet1.Player' table. You can move, or remove it, as needed.
            //this.playerTableAdapter.Fill(this.rmak2_ESC_PlayersDataSet1.Player);
        }

        private void FillDatabaseTab()
        {
            //playerTableAdapter.Fill(rmak2_ESC_PlayersDataSet1.Player);
            DataTable dt = new DataTable();
            DBConnection.GetPlayers().Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dgv_players.DataSource = bs;
        }

        private void tb_playerid_Click(object sender, EventArgs e)
        {

        }

        private bool InitializeBluetooth()
        {
            bt_serial = new SerialPort("COM4", 9600, Parity.None);            

            try
            {
                tb_conn.Text = "Connecting bluetooth...";
                bt_serial.Open();
                Debug.WriteLine("BT connected");
                ThreadRX = new Thread(ReadCardData);
                ThreadRX.IsBackground = true;
                ThreadRX.Start();
                return true;
            }
            catch
            {
                Debug.WriteLine("Unable to open port!");
                bt_serial.Close();
                return false;
            }
        }

        private void ReadCardData()
        {
            string sID = "";
            //9 for NAIT ID
            //13 for UofA ID
            int idLength = 9;
            while (bt_serial.IsOpen)
            {
                byte[] buffer = new byte[2000];
                //Action GetData = null;                
                bt_serial.BaseStream.BeginRead(buffer, 0, buffer.Length, delegate (IAsyncResult ar)
                {
                    try
                    {
                        int actualLength = bt_serial.BaseStream.EndRead(ar);
                        byte[] received = new byte[actualLength];
                        Buffer.BlockCopy(buffer, 0, received, 0, actualLength);
                        Debug.WriteLine("Found data...");
                        if (sID.Length < idLength)
                        {
                            sID += Encoding.ASCII.GetString(received);
                            Debug.WriteLine("ascii : " + sID);                            
                            if (sID.Length >= idLength)
                            {
                                Debug.WriteLine("Completed read...");
                                if (sID.Length == 13)
                                {
                                    sID = sID.Substring(4, sID.Length - 4 - 2);
                                }
                                Invoke(new delVoidString(UpdateID), sID);
                                sID = "";
                            }
                        }
                    }
                    catch (Exception err)
                    {
                        Debug.WriteLine("RX Thread error: " + err.Message);
                    }
                    //GetData();                    
                }, null);
                Thread.Sleep(1);
            }
        }

        private void UpdateID(string id)
        {
            tb_playerid.Text = id;
        }
    }
}
