﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Player
    {
        public int player_id { get; set; }
        public string game_tag { get; set; }
        public string f_name { get; set; }
        public string l_name { get; set; }
        public int game_rating { get; set; }
        public DateTime last_update { get; set; }

        public Player(int id, string tag, string fname, string lname, int rating)
        {
            player_id = id;
            game_tag = tag;
            f_name = fname;
            l_name = lname;
            game_rating = rating;
        }
    }

