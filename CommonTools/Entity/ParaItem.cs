using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools.Entity
{
    public class ParaItem
    {
        Boolean valuePrint = false;
        Boolean memPrint = false;
        Boolean memU64Print = false;
        UInt32 memLength = 0;
        UInt32 mem64Length = 0;

        public bool ValuePrint { get => valuePrint; set => valuePrint = value; }
        public bool MemPrint { get => memPrint; set => memPrint = value; }
        public bool MemU64Print { get => memU64Print; set => memU64Print = value; }
        public uint MemLength { get => memLength; set => memLength = value; }
        public uint Mem64Length { get => mem64Length; set => mem64Length = value; }

        public override string ToString()
        {
            return String.Format("ValuePrint={0} MemPrint={1} MemU64Print={2} memLength={3} mem64Length={4}", valuePrint, memPrint, memU64Print, memLength, mem64Length);
        }
    }
}
