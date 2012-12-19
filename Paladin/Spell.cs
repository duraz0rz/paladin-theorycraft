using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladin
{
    public abstract class Spell
    {
        abstract public float ManaCost { get; }
        abstract public float Coefficient { get; }
        abstract public float MinHeal { get; }
        abstract public float MaxHeal { get; }

        abstract public float HPS { get; }
        abstract public float HPM { get; }
        abstract public float MPS { get; }
    }
}
