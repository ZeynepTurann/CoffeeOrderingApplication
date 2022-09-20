using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeOrderingApplication.Functions
{
    public static class CleaningFunction
    {
        /*
       * marked class as static because we can call it anywhere without taking its instance!
       */
        public static void ClearControls(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                else if (item is MaskedTextBox)
                {
                    MaskedTextBox mskTxt = (MaskedTextBox)item;
                    mskTxt.Clear();
                }

                else if (item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = false;
                }
                else if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.SelectedIndex = 0;
                }
                else if (item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    if (rb.Name == "rdbTall")
                        rb.Checked = true;
                    else
                        rb.Checked = false;
                }
                else if (item is GroupBox)
                {
                    GroupBox grp = (GroupBox)item;
                    ClearControls(grp.Controls);
                }
                else if (item is FlowLayoutPanel)
                {
                    FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)item;
                    ClearControls(flowLayoutPanel.Controls);
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)item;
                    numericUpDown.Value = 1;
                }
            }
        }
    }
}
