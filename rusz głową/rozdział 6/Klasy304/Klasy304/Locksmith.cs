﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy304
{
    internal class Locksmith
    {
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
        }

        private string writtenDownCombination = null;
        public void WriteDownCombination(String combination)
        {
            writtenDownCombination = combination;
        }

        virtual public void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}
