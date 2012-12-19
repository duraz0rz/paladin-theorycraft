using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladin
{
    public enum Slot
    {
        Head,
        Shoulders,
        Cloak,
        Chest,
        Wrist,
        Gloves,
        Waist,
        Legs,
        Boots,
        Ring_1,
        Ring_2,
        Trinket_1,
        Trinket_2
    }

    public class Gear
    {
        public Slot GearSlot { get; private set; }
        public int Tier { get; private set;}
        public int ItemLevel { get; private set; }
        #region Primary Stats
        public int Strength { get; private set; }
        public int Agility { get; private set; }
        public int Intellect { get; private set; }
        public int Stamina { get; private set; }
        #endregion
        #region Secondary Stats
        #endregion
        #region Gem/socket info
        #endregion
        #region Enchant info
        #endregion

        public Gear(Slot slot)
        {
            GearSlot = slot;
        }
    }

    // Trinkets can have some modeling behind them for procs
    public class Trinket : Gear
    {

    }

    public class Gem
    {

    }

    public class Enchant
    {
        public Slot GearSlot { get; private set; }
    }
}
