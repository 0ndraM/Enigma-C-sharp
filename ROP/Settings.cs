using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROP
{
    public partial class Settings : Form
    {
        public Settings(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private string rotor1, rotor2, rotor3, rotor4, rotor5;
        public MainForm mf;
        private ArrayList al1, al2, al3;
        


        public MainForm MainForm { get; }

        //zavření nastavení
        void BtnCancelClick(object sender, System.EventArgs e)
        {
            Close();
        }

        // vytvoření všech rotorú
        void SettingsLoad(object sender, System.EventArgs e)
        {
            al1 = new ArrayList();
            al2 = new ArrayList();
            al3 = new ArrayList();
            al1.Add("Rotor I");
            al1.Add("Rotor II");
            al1.Add("Rotor III");
            al1.Add("Rotor IV");
            al1.Add("Rotor V");
            rotor1 = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
            rotor2 = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
            rotor3 = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
            rotor4 = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
            rotor5 = "VZBRGITYUPSDNHLXAWMJQOFECK";
            al2.Add(rotor1);
            al2.Add(rotor2);
            al2.Add(rotor3);
            al2.Add(rotor4);
            al2.Add(rotor5);
            al3.Add("Q");
            al3.Add("E");
            al3.Add("V");
            al3.Add("J");
            al3.Add("Z");
            lstAvailableRotors.Items.Clear();
            for (int i = 0; i < al1.Count; i++)
            {
                lstAvailableRotors.Items.Add(al1[i]);
            }
            ttSelect.SetToolTip(btnSelect, "Výběr rotoru");
            ttDeselect.SetToolTip(btnDeselect, "Zrušení výběru rotoru");
            ttUp.SetToolTip(btnUp, "Posuňte rotor nahoru");
            ttDown.SetToolTip(btnDown, "Posuňte rotor dolů");

            for (int i = 0; i < cmbReflector.Items.Count; i++)
            {
                if (cmbReflector.Items[i].ToString().EndsWith(mf.GetReflector()))
                {
                    cmbReflector.SelectedIndex = i;
                }
            }

            for (int i = 0; i < al2.Count; i++)
            {
                if (al2[i].ToString() == mf.GetLeftRotor())
                {
                    lstAvailableRotors.Items.Remove(al1[i].ToString());
                    lstSelectedRotors.Items.Add(al1[i].ToString());
                    break;
                }
            }

            for (int i = 0; i < al2.Count; i++)
            {
                if (al2[i].ToString() == mf.GetMiddleRotor())
                {
                    lstAvailableRotors.Items.Remove(al1[i].ToString());
                    lstSelectedRotors.Items.Add(al1[i].ToString());
                    break;
                }
            }
            for (int i = 0; i < al2.Count; i++)
            {
                if (al2[i].ToString() == mf.GetRightRotor())
                {
                    lstAvailableRotors.Items.Remove(al1[i].ToString());
                    lstSelectedRotors.Items.Add(al1[i].ToString());
                    break;
                }
            }
        }

        //nabídka reflektorů
        private void cmbReflector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //změna pořadí vybraných rotorů
        void LstAvailableRotorsSelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lstAvailableRotors.SelectedIndex < 0)
            {
                return;
            }
            for (int i = 0; i < al1.Count; i++)
            {
                if (lstAvailableRotors.SelectedItem.ToString() == "" + al1[i])
                {
                    lblRotorStructure.Text = "" + al2[i];
                    return;
                }
            }
            lblRotorStructure.Text = "";
        }
        
        //přídámí rotoru do vybraných
        void BtnSelectClick(object sender, System.EventArgs e)
        {
            if (lstAvailableRotors.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Nejprve si vyberte rotor!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lstSelectedRotors.Items.Add(lstAvailableRotors.SelectedItem);
            lstAvailableRotors.Items.Remove(lstAvailableRotors.SelectedItem);
            lblRotorStructure.Text = "";
        }

        //odebrání rotoru z vybraných
        void BtnDeselectClick(object sender, System.EventArgs e)
        {
            if (lstSelectedRotors.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Nejprve si vyberte rotor!!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lstAvailableRotors.Items.Add(lstSelectedRotors.SelectedItem);
            lstSelectedRotors.Items.Remove(lstSelectedRotors.SelectedItem);
        }

        //posunutí ozoru na hornější pozici
        void BtnUpClick(object sender, System.EventArgs e)
        {
            if (lstSelectedRotors.SelectedIndex <= 0)
            {
                return;
            }

            string strTemp = "" + lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex - 1];
            lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex - 1] = lstSelectedRotors.SelectedItem;
            lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex] = strTemp;
            lstSelectedRotors.SelectedIndex--;

        }

        //posunutí rotoru na nižší pozici
        void BtnDownClick(object sender, System.EventArgs e)
        {
            if (lstSelectedRotors.SelectedIndex < 0 || lstSelectedRotors.SelectedIndex == lstSelectedRotors.Items.Count - 1)
            {
                return;
            }

            string strTemp = "" + lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex + 1];
            lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex + 1] = lstSelectedRotors.SelectedItem;
            lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex] = strTemp;
            lstSelectedRotors.SelectedIndex++;
        }

        //uložení nastavení
        void BtnOkClick(object sender, System.EventArgs e)
        {
            if (lstSelectedRotors.Items.Count != 3)
            {
                MessageBox.Show(this, "Musíte si vybrat přesně tři rotory!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ArrayList alRot = new ArrayList();
            ArrayList alRotName = new ArrayList();
            ArrayList alRotNotch = new ArrayList();

            for (int j = 0; j < lstSelectedRotors.Items.Count; j++)
            {
                for (int i = 0; i < al1.Count; i++)
                {
                    if (lstSelectedRotors.Items[j].ToString() == "" + al1[i])
                    {
                        alRot.Add(al2[i]);
                        alRotName.Add(al1[i].ToString().Substring(al1[i].ToString().LastIndexOf(" ")).Trim());
                        alRotNotch.Add(al3[i]);
                        break;
                    }
                }
            }

            mf.ChangeRotors(alRot[0].ToString(),
                            alRotName[0].ToString(),
                            alRotNotch[0].ToString().ToCharArray()[0],
                            alRot[1].ToString(),
                            alRotName[1].ToString(),
                            alRotNotch[1].ToString().ToCharArray()[0],
                            alRot[2].ToString(),
                            alRotName[2].ToString(),
                            alRotNotch[2].ToString().ToCharArray()[0]);

            //změna reflektoru
            if (cmbReflector.SelectedIndex >= 0)
            {
                mf.SetReflector(cmbReflector.SelectedItem.ToString().Substring(cmbReflector.SelectedItem.ToString().LastIndexOf("=") + 2).Trim());
            }
            
            //MessageBox.Show("\""+mf.GetReflector()+"\""); //test
            Close();

        }

    }
}
