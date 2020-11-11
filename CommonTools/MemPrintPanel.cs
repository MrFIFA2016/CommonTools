using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonTools.Entity;

namespace CommonTools
{
    public partial class MemPrintPanel : UserControl
    {
        ParaItem paraItem;
        public MemPrintPanel(ParaItem paraItem)
        {
            InitializeComponent();
            this.paraItem = paraItem;
            this.paraItem.MemLength = (UInt32)memLengthBox.Value;
            this.paraItem.Mem64Length = (UInt32)mem64LengthBox.Value;

            this.memLengthBox.ValueChanged += MemLengthBox_ValueChanged;
            this.mem64LengthBox.ValueChanged += Mem64LengthBox_ValueChanged;
        }

        private void Mem64LengthBox_ValueChanged(object sender, EventArgs e)
        {
            this.paraItem.Mem64Length = (UInt32)mem64LengthBox.Value;
        }

        private void MemLengthBox_ValueChanged(object sender, EventArgs e)
        {
            this.paraItem.MemLength = (UInt32)memLengthBox.Value;
        }

        private void cBox_printMem_CheckedChanged(object sender, EventArgs e)
        {
            paraItem.MemPrint = cBox_printMem.Checked;
            if (cBox_printMem.Checked)
                memLengthBox.Enabled = true;
            else
                memLengthBox.Enabled = false;
        }

        private void cBox_printMem64_CheckedChanged(object sender, EventArgs e)
        {
            paraItem.MemU64Print = cBox_printMem64.Checked;
            if (cBox_printMem64.Checked)
                mem64LengthBox.Enabled = true;
            else
                mem64LengthBox.Enabled = false;
        }
    }
}
