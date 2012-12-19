using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladin
{
    public class FlashOfLight: Spell
    {
        public override float ManaCost
        {
            get { return Paladin.BaseMana * 0.37f; }
        }

        public override float HPS
        {
            get { throw new NotImplementedException(); }
        }

        public override float HPM
        {
            get { throw new NotImplementedException(); }
        }

        public override float MPS
        {
            get { throw new NotImplementedException(); }
        }

        public override float Coefficient
        {
            get { throw new NotImplementedException(); }
        }

        public override float MinHeal
        {
            get { throw new NotImplementedException(); }
        }

        public override float MaxHeal
        {
            get { throw new NotImplementedException(); }
        }
    }
}
