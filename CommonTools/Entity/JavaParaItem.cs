using System;

namespace CommonTools.Entity
{
    public class JavaParaItem:ParaItem
    {
        Boolean valuePrint = false;

        public bool ValuePrint { get => valuePrint; set => valuePrint = value; }

        public override string ToString()
        {
            return String.Format("ValuePrint={0} ", valuePrint);
        }
    }
}
