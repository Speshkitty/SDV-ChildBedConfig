﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildBedConfig
{
    class ModConfig
    {
        /*****************************/
        /**      Properties         **/
        /*****************************/
        public List<Farmer> Farmers { get; set; }

        /*****************************/
        /**      Public methods     **/
        /*****************************/
        ///<summary>Constructor, set up the example of the config for players to follow</summary>
        public ModConfig()
        {
            Farmer Default = new Farmer();
            Farmers = new List<Farmer>();
            Farmers.Add(Default);
        }
    }

    /// <summary>
    /// Class for the farmer -- we have a list of them in the config
    /// </summary>
    class Farmer
    {
        /*****************************/
        /**      Properties         **/
        /*****************************/
        ///<summary>Name of the farmer</summary>
        public string CharacterName { get; set; }

        ///<summary>Determines whether or not to show the crib</summary>
        public bool ShowHomeCrib { get; set; }

        ///<summary>Determines whether or not to show the bed closest to the crib</summary>
        public bool ShowHomeBed1 { get; set; }

        ///<summary>Determines whether or not to show the bed furthest from the crib</summary>
        public bool ShowHomeBed2 { get; set; }

        //This is all the same as the above, it just affects the cabins
        public bool ShowCabinCrib { get; set; }
        public bool ShowCabinBed1 { get; set; }
        public bool ShowCabinBed2 { get; set; }

        /*****************************/
        /**      Public methods     **/
        /*****************************/
        public Farmer()
        {
            CharacterName = "NoName";
            ShowHomeCrib = true;
            ShowHomeBed1 = true;
            ShowHomeBed2 = true;
            ShowCabinCrib = true;
            ShowCabinBed1 = true;
            ShowCabinBed2 = true;
        }

        public Farmer(string name, bool showhcrib, bool showhbed1, bool showhbed2, bool showccrib, bool showcbed1, bool showcbed2)
        {
            CharacterName = name;
            ShowHomeCrib = showhcrib;
            ShowHomeBed1 = showhbed1;
            ShowHomeBed2 = showhbed2;
            ShowCabinCrib = showccrib;
            ShowCabinBed1 = showcbed1;
            ShowCabinBed2 = showcbed2;
        }
    }
}
