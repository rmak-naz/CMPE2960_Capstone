namespace ESC_Registration_Application
{
    partial class Registration_Application
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.pg_Connect = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_connCheck = new System.Windows.Forms.Button();
            this.tb_conn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pg_Registration = new System.Windows.Forms.TabPage();
            this.btn_remove_entrant = new System.Windows.Forms.Button();
            this.ddl_export = new System.Windows.Forms.ComboBox();
            this.btn_clear_entrants = new System.Windows.Forms.Button();
            this.btn_export_entrants = new System.Windows.Forms.Button();
            this.btn_generate_id = new System.Windows.Forms.Button();
            this.lbl_add_status = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_addentrant = new System.Windows.Forms.Button();
            this.btn_insertplayer = new System.Windows.Forms.Button();
            this.lv_entrants = new System.Windows.Forms.ListView();
            this.col_gametag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_melee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_s4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_pm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_pm_entry = new System.Windows.Forms.CheckBox();
            this.cb_s4_entry = new System.Windows.Forms.CheckBox();
            this.cb_melee_entry = new System.Windows.Forms.CheckBox();
            this.tb_rating = new System.Windows.Forms.TextBox();
            this.tb_gametag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_fillPlayer = new System.Windows.Forms.Button();
            this.tb_playerid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pg_players = new System.Windows.Forms.TabPage();
            this.dgv_players = new System.Windows.Forms.DataGridView();
            this.playeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gametagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rmak2ESCPlayersDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rmak2_ESC_PlayersDataSet1 = new ESC_Registration_Application.rmak2_ESC_PlayersDataSet();
            this.SP_Bluetooth = new System.IO.Ports.SerialPort(this.components);
            this.playerTableAdapter = new ESC_Registration_Application.rmak2_ESC_PlayersDataSetTableAdapters.PlayerTableAdapter();
            this.tab_control.SuspendLayout();
            this.pg_Connect.SuspendLayout();
            this.pg_Registration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pg_players.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_players)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmak2ESCPlayersDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmak2_ESC_PlayersDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.pg_Connect);
            this.tab_control.Controls.Add(this.pg_Registration);
            this.tab_control.Controls.Add(this.pg_players);
            this.tab_control.Location = new System.Drawing.Point(13, 13);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(919, 571);
            this.tab_control.TabIndex = 0;
            // 
            // pg_Connect
            // 
            this.pg_Connect.Controls.Add(this.label7);
            this.pg_Connect.Controls.Add(this.btn_connCheck);
            this.pg_Connect.Controls.Add(this.tb_conn);
            this.pg_Connect.Controls.Add(this.label1);
            this.pg_Connect.Controls.Add(this.lbl_title);
            this.pg_Connect.Location = new System.Drawing.Point(4, 22);
            this.pg_Connect.Name = "pg_Connect";
            this.pg_Connect.Padding = new System.Windows.Forms.Padding(3);
            this.pg_Connect.Size = new System.Drawing.Size(911, 545);
            this.pg_Connect.TabIndex = 0;
            this.pg_Connect.Text = "DB Connect";
            this.pg_Connect.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Check the internet connection before continuing.";
            // 
            // btn_connCheck
            // 
            this.btn_connCheck.Location = new System.Drawing.Point(201, 212);
            this.btn_connCheck.Name = "btn_connCheck";
            this.btn_connCheck.Size = new System.Drawing.Size(75, 23);
            this.btn_connCheck.TabIndex = 3;
            this.btn_connCheck.Text = "Check Connection";
            this.btn_connCheck.UseVisualStyleBackColor = true;
            this.btn_connCheck.Click += new System.EventHandler(this.btn_connCheck_Click);
            // 
            // tb_conn
            // 
            this.tb_conn.Location = new System.Drawing.Point(201, 186);
            this.tb_conn.Name = "tb_conn";
            this.tb_conn.Size = new System.Drawing.Size(649, 20);
            this.tb_conn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database Connection";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_title.Location = new System.Drawing.Point(68, 56);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(799, 69);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "ESC Registration Application";
            // 
            // pg_Registration
            // 
            this.pg_Registration.Controls.Add(this.btn_remove_entrant);
            this.pg_Registration.Controls.Add(this.ddl_export);
            this.pg_Registration.Controls.Add(this.btn_clear_entrants);
            this.pg_Registration.Controls.Add(this.btn_export_entrants);
            this.pg_Registration.Controls.Add(this.btn_generate_id);
            this.pg_Registration.Controls.Add(this.lbl_add_status);
            this.pg_Registration.Controls.Add(this.btn_clear);
            this.pg_Registration.Controls.Add(this.tb_fullname);
            this.pg_Registration.Controls.Add(this.label6);
            this.pg_Registration.Controls.Add(this.btn_addentrant);
            this.pg_Registration.Controls.Add(this.btn_insertplayer);
            this.pg_Registration.Controls.Add(this.lv_entrants);
            this.pg_Registration.Controls.Add(this.groupBox1);
            this.pg_Registration.Controls.Add(this.tb_rating);
            this.pg_Registration.Controls.Add(this.tb_gametag);
            this.pg_Registration.Controls.Add(this.label5);
            this.pg_Registration.Controls.Add(this.label4);
            this.pg_Registration.Controls.Add(this.btn_fillPlayer);
            this.pg_Registration.Controls.Add(this.tb_playerid);
            this.pg_Registration.Controls.Add(this.label3);
            this.pg_Registration.Controls.Add(this.label2);
            this.pg_Registration.Location = new System.Drawing.Point(4, 22);
            this.pg_Registration.Name = "pg_Registration";
            this.pg_Registration.Padding = new System.Windows.Forms.Padding(3);
            this.pg_Registration.Size = new System.Drawing.Size(911, 545);
            this.pg_Registration.TabIndex = 1;
            this.pg_Registration.Text = "Registration";
            this.pg_Registration.UseVisualStyleBackColor = true;
            // 
            // btn_remove_entrant
            // 
            this.btn_remove_entrant.Location = new System.Drawing.Point(748, 518);
            this.btn_remove_entrant.Name = "btn_remove_entrant";
            this.btn_remove_entrant.Size = new System.Drawing.Size(75, 23);
            this.btn_remove_entrant.TabIndex = 21;
            this.btn_remove_entrant.Text = "Remove entrant";
            this.btn_remove_entrant.UseVisualStyleBackColor = true;
            this.btn_remove_entrant.Click += new System.EventHandler(this.btn_remove_entrant_Click);
            // 
            // ddl_export
            // 
            this.ddl_export.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_export.FormattingEnabled = true;
            this.ddl_export.Items.AddRange(new object[] {
            "Melee",
            "S4",
            "PM"});
            this.ddl_export.Location = new System.Drawing.Point(472, 520);
            this.ddl_export.Name = "ddl_export";
            this.ddl_export.Size = new System.Drawing.Size(121, 21);
            this.ddl_export.TabIndex = 20;
            // 
            // btn_clear_entrants
            // 
            this.btn_clear_entrants.Location = new System.Drawing.Point(829, 518);
            this.btn_clear_entrants.Name = "btn_clear_entrants";
            this.btn_clear_entrants.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_entrants.TabIndex = 18;
            this.btn_clear_entrants.Text = "Clear List";
            this.btn_clear_entrants.UseVisualStyleBackColor = true;
            this.btn_clear_entrants.Click += new System.EventHandler(this.btn_clear_entrants_Click);
            // 
            // btn_export_entrants
            // 
            this.btn_export_entrants.Location = new System.Drawing.Point(391, 518);
            this.btn_export_entrants.Name = "btn_export_entrants";
            this.btn_export_entrants.Size = new System.Drawing.Size(75, 23);
            this.btn_export_entrants.TabIndex = 17;
            this.btn_export_entrants.Text = "Export List";
            this.btn_export_entrants.UseVisualStyleBackColor = true;
            this.btn_export_entrants.Click += new System.EventHandler(this.btn_export_entrants_Click);
            // 
            // btn_generate_id
            // 
            this.btn_generate_id.Location = new System.Drawing.Point(80, 73);
            this.btn_generate_id.Name = "btn_generate_id";
            this.btn_generate_id.Size = new System.Drawing.Size(75, 23);
            this.btn_generate_id.TabIndex = 16;
            this.btn_generate_id.Text = "Generate ID";
            this.btn_generate_id.UseVisualStyleBackColor = true;
            this.btn_generate_id.Click += new System.EventHandler(this.btn_generate_id_Click);
            // 
            // lbl_add_status
            // 
            this.lbl_add_status.AutoSize = true;
            this.lbl_add_status.Location = new System.Drawing.Point(13, 353);
            this.lbl_add_status.Name = "lbl_add_status";
            this.lbl_add_status.Size = new System.Drawing.Size(196, 13);
            this.lbl_add_status.TabIndex = 15;
            this.lbl_add_status.Text = "Click fill data to check ID before adding.";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(161, 325);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear Form";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tb_fullname
            // 
            this.tb_fullname.Location = new System.Drawing.Point(80, 159);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(300, 20);
            this.tb_fullname.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Full Name";
            // 
            // btn_addentrant
            // 
            this.btn_addentrant.Enabled = false;
            this.btn_addentrant.Location = new System.Drawing.Point(80, 325);
            this.btn_addentrant.Name = "btn_addentrant";
            this.btn_addentrant.Size = new System.Drawing.Size(75, 23);
            this.btn_addentrant.TabIndex = 11;
            this.btn_addentrant.Text = "Add entrant";
            this.btn_addentrant.UseVisualStyleBackColor = true;
            this.btn_addentrant.Click += new System.EventHandler(this.btn_addentrant_Click);
            // 
            // btn_insertplayer
            // 
            this.btn_insertplayer.Location = new System.Drawing.Point(282, 325);
            this.btn_insertplayer.Name = "btn_insertplayer";
            this.btn_insertplayer.Size = new System.Drawing.Size(98, 23);
            this.btn_insertplayer.TabIndex = 10;
            this.btn_insertplayer.Text = "Add Player to DB";
            this.btn_insertplayer.UseVisualStyleBackColor = true;
            this.btn_insertplayer.Click += new System.EventHandler(this.btn_insertplayer_Click);
            // 
            // lv_entrants
            // 
            this.lv_entrants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_gametag,
            this.col_melee,
            this.col_s4,
            this.col_pm,
            this.col_rating});
            this.lv_entrants.FullRowSelect = true;
            this.lv_entrants.Location = new System.Drawing.Point(391, 73);
            this.lv_entrants.MultiSelect = false;
            this.lv_entrants.Name = "lv_entrants";
            this.lv_entrants.Size = new System.Drawing.Size(514, 438);
            this.lv_entrants.TabIndex = 9;
            this.lv_entrants.UseCompatibleStateImageBehavior = false;
            this.lv_entrants.View = System.Windows.Forms.View.Details;
            // 
            // col_gametag
            // 
            this.col_gametag.Text = "Gamer Tag";
            this.col_gametag.Width = 251;
            // 
            // col_melee
            // 
            this.col_melee.Text = "Melee";
            // 
            // col_s4
            // 
            this.col_s4.Text = "Smash 4";
            // 
            // col_pm
            // 
            this.col_pm.Text = "PM";
            // 
            // col_rating
            // 
            this.col_rating.Text = "Rating";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_pm_entry);
            this.groupBox1.Controls.Add(this.cb_s4_entry);
            this.groupBox1.Controls.Add(this.cb_melee_entry);
            this.groupBox1.Location = new System.Drawing.Point(80, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick Event";
            // 
            // cb_pm_entry
            // 
            this.cb_pm_entry.AutoSize = true;
            this.cb_pm_entry.Location = new System.Drawing.Point(6, 65);
            this.cb_pm_entry.Name = "cb_pm_entry";
            this.cb_pm_entry.Size = new System.Drawing.Size(42, 17);
            this.cb_pm_entry.TabIndex = 2;
            this.cb_pm_entry.Text = "PM";
            this.cb_pm_entry.UseVisualStyleBackColor = true;
            // 
            // cb_s4_entry
            // 
            this.cb_s4_entry.AutoSize = true;
            this.cb_s4_entry.Location = new System.Drawing.Point(6, 42);
            this.cb_s4_entry.Name = "cb_s4_entry";
            this.cb_s4_entry.Size = new System.Drawing.Size(67, 17);
            this.cb_s4_entry.TabIndex = 1;
            this.cb_s4_entry.Text = "Smash 4";
            this.cb_s4_entry.UseVisualStyleBackColor = true;
            // 
            // cb_melee_entry
            // 
            this.cb_melee_entry.AutoSize = true;
            this.cb_melee_entry.Location = new System.Drawing.Point(6, 19);
            this.cb_melee_entry.Name = "cb_melee_entry";
            this.cb_melee_entry.Size = new System.Drawing.Size(55, 17);
            this.cb_melee_entry.TabIndex = 0;
            this.cb_melee_entry.Text = "Melee";
            this.cb_melee_entry.UseVisualStyleBackColor = true;
            // 
            // tb_rating
            // 
            this.tb_rating.Location = new System.Drawing.Point(80, 192);
            this.tb_rating.Name = "tb_rating";
            this.tb_rating.Size = new System.Drawing.Size(301, 20);
            this.tb_rating.TabIndex = 5;
            // 
            // tb_gametag
            // 
            this.tb_gametag.Location = new System.Drawing.Point(80, 132);
            this.tb_gametag.Name = "tb_gametag";
            this.tb_gametag.Size = new System.Drawing.Size(301, 20);
            this.tb_gametag.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gamer Tag";
            // 
            // btn_fillPlayer
            // 
            this.btn_fillPlayer.Location = new System.Drawing.Point(306, 100);
            this.btn_fillPlayer.Name = "btn_fillPlayer";
            this.btn_fillPlayer.Size = new System.Drawing.Size(75, 23);
            this.btn_fillPlayer.TabIndex = 3;
            this.btn_fillPlayer.Text = "Fill Data";
            this.btn_fillPlayer.UseVisualStyleBackColor = true;
            this.btn_fillPlayer.Click += new System.EventHandler(this.btn_fillPlayer_Click);
            // 
            // tb_playerid
            // 
            this.tb_playerid.Location = new System.Drawing.Point(80, 102);
            this.tb_playerid.Name = "tb_playerid";
            this.tb_playerid.Size = new System.Drawing.Size(220, 20);
            this.tb_playerid.TabIndex = 2;
            this.tb_playerid.Click += new System.EventHandler(this.tb_playerid_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Player ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registration Form";
            // 
            // pg_players
            // 
            this.pg_players.Controls.Add(this.dgv_players);
            this.pg_players.Location = new System.Drawing.Point(4, 22);
            this.pg_players.Name = "pg_players";
            this.pg_players.Size = new System.Drawing.Size(911, 545);
            this.pg_players.TabIndex = 2;
            this.pg_players.Text = "Players DB";
            this.pg_players.UseVisualStyleBackColor = true;
            // 
            // dgv_players
            // 
            this.dgv_players.AllowUserToAddRows = false;
            this.dgv_players.AllowUserToDeleteRows = false;
            this.dgv_players.AutoGenerateColumns = false;
            this.dgv_players.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_players.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playeridDataGridViewTextBoxColumn,
            this.gametagDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.dgv_players.DataSource = this.rmak2ESCPlayersDataSet1BindingSource;
            this.dgv_players.Location = new System.Drawing.Point(3, 3);
            this.dgv_players.Name = "dgv_players";
            this.dgv_players.ReadOnly = true;
            this.dgv_players.Size = new System.Drawing.Size(905, 539);
            this.dgv_players.TabIndex = 0;
            // 
            // playeridDataGridViewTextBoxColumn
            // 
            this.playeridDataGridViewTextBoxColumn.DataPropertyName = "player_id";
            this.playeridDataGridViewTextBoxColumn.HeaderText = "player_id";
            this.playeridDataGridViewTextBoxColumn.Name = "playeridDataGridViewTextBoxColumn";
            this.playeridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gametagDataGridViewTextBoxColumn
            // 
            this.gametagDataGridViewTextBoxColumn.DataPropertyName = "game_tag";
            this.gametagDataGridViewTextBoxColumn.HeaderText = "game_tag";
            this.gametagDataGridViewTextBoxColumn.Name = "gametagDataGridViewTextBoxColumn";
            this.gametagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "f_Name";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "f_Name";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "l_Name";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "l_Name";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rmak2ESCPlayersDataSet1BindingSource
            // 
            this.rmak2ESCPlayersDataSet1BindingSource.DataMember = "Player";
            this.rmak2ESCPlayersDataSet1BindingSource.DataSource = this.rmak2_ESC_PlayersDataSet1;
            // 
            // rmak2_ESC_PlayersDataSet1
            // 
            this.rmak2_ESC_PlayersDataSet1.DataSetName = "rmak2_ESC_PlayersDataSet";
            this.rmak2_ESC_PlayersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_Bluetooth
            // 
            this.SP_Bluetooth.PortName = "COM3";
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // Registration_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 596);
            this.Controls.Add(this.tab_control);
            this.Name = "Registration_Application";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Application_Load);
            this.tab_control.ResumeLayout(false);
            this.pg_Connect.ResumeLayout(false);
            this.pg_Connect.PerformLayout();
            this.pg_Registration.ResumeLayout(false);
            this.pg_Registration.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pg_players.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_players)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmak2ESCPlayersDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmak2_ESC_PlayersDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage pg_Connect;
        private System.Windows.Forms.TabPage pg_Registration;
        private System.Windows.Forms.Label lbl_title;
        private System.IO.Ports.SerialPort SP_Bluetooth;
        private System.Windows.Forms.TextBox tb_conn;
        private System.Windows.Forms.Label label1;
        private rmak2_ESC_PlayersDataSet rmak2_ESC_PlayersDataSet1;
        private System.Windows.Forms.Button btn_connCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_pm_entry;
        private System.Windows.Forms.CheckBox cb_s4_entry;
        private System.Windows.Forms.CheckBox cb_melee_entry;
        private System.Windows.Forms.TextBox tb_rating;
        private System.Windows.Forms.TextBox tb_gametag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_fillPlayer;
        private System.Windows.Forms.TextBox tb_playerid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addentrant;
        private System.Windows.Forms.Button btn_insertplayer;
        private System.Windows.Forms.ListView lv_entrants;
        private System.Windows.Forms.ColumnHeader col_gametag;
        private System.Windows.Forms.ColumnHeader col_melee;
        private System.Windows.Forms.ColumnHeader col_s4;
        private System.Windows.Forms.ColumnHeader col_pm;
        private System.Windows.Forms.TextBox tb_fullname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_add_status;
        private System.Windows.Forms.Button btn_generate_id;
        private System.Windows.Forms.Button btn_clear_entrants;
        private System.Windows.Forms.Button btn_export_entrants;
        private System.Windows.Forms.ColumnHeader col_rating;
        private System.Windows.Forms.ComboBox ddl_export;
        private System.Windows.Forms.Button btn_remove_entrant;
        private System.Windows.Forms.TabPage pg_players;
        private System.Windows.Forms.DataGridView dgv_players;
        private System.Windows.Forms.BindingSource rmak2ESCPlayersDataSet1BindingSource;
        private rmak2_ESC_PlayersDataSetTableAdapters.PlayerTableAdapter playerTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn playeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gametagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
    }
}

