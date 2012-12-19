using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladin
{
    public enum Race
    {
        // Alliance
        Human,
        Dwarf,
        Night_Elf,
        Gnome,
        Draenai,
        Worgen,
        // Horde
        Orc,
        Troll,
        Tauren,
        Undead,
        Blood_Elf,
        Goblin,
        // Neutral to a point
        Pandaren
    }

    public enum Class
    {
        Warrior,
        Paladin,
        Death_Knight,
        Mage,
        Warlock,
        Druid,
        Shaman,
        Monk,
        Rogue,
        Hunter,
        Priest
    }

    #region Class specializations

    public enum PaladinSpec
    {
        Holy,
        Retribution,
        Protection
    }

    #endregion

}
