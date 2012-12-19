using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Paladin
{
    public abstract class Character
    {
        #region Constants
        abstract public float BaseMana { get; }
        abstract public float BaseStrength { get; }
        abstract public float BaseAgility { get; }
        abstract public float BaseIntellect { get; }
        abstract public float BaseSpirit { get; }
        abstract public float BaseStamina { get; }
        #endregion

        public Class charClass;
        public Race charRace;

        protected Dictionary<Slot, Gear> equippedGear = new Dictionary<Slot, Gear>();

        /*
         * To-do:
         * - Get from gear
         * 
         */
        public virtual float AttackPower
        {
            get
            {
                //switch (charRace)
                //{
                //    case Race.
                //}
                return 0f;
            }
        }

        /*
         * To-do:
         * - Get from gear
         * 
         */
        public virtual float Spellpower
        {
            get { return BaseIntellect; }
        }

        /*
         * To-Do:
         * - Get from gear
         * - Mining bonus
         * 
         */
        public virtual float HitPoints
        {
            get { return BaseStamina * 15; }
        }

        /// <summary>
        /// Calculates average bonus for a racial trait
        /// </summary>
        /// <returns></returns>
        public float RacialBonus()
        {
            switch (charRace)
            {

            }

            return 0f;
        }

        public Character (Race race)
        {
            charRace = race;
        }
    }

    public class Paladin : Character
    {
        #region Paladin constants

        public override float BaseMana 
        { 
            get { return 60000f; } 
        }
        public override float BaseStrength
        {
            get { return 184f; }
        }
        public override float BaseAgility
        {
            get { return 107f; }
        }
        public override float BaseIntellect
        {
            get { return 117f; }
        }
        public override float BaseSpirit
        {
            get { return 121f; }
        }
        public override float BaseStamina
        {
            get { return 169f; }
        }
        public static string Class
        {
            get { return "Paladin"; }
        }

        #endregion

        public PaladinSpec currentSpec = PaladinSpec.Holy;

        public Paladin(Race race) : base(race)
        {

        }


    }
}
