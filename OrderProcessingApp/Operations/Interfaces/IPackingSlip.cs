using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Interfaces
{
    public interface IPackingSlip
    {
        public bool GeneratePackingSlip();
        public bool GenerateDuplicatePackingSlip();

    }
}
