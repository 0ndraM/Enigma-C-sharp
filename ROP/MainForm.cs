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
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ROP
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }


        private Rotor rr, rm, rl, reflector;
        void MainFormLoad(object sender, System.EventArgs e)
        {
            rr = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", lblRotor1, 'V');
            rm = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", lblRotor2, 'E');
            rl = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", lblRotor3, 'Q');
            reflector = new Rotor("YRUHQSLDPXNGOKMIEBFZCWVJAT", null, '\0');
            rr.SetNextRotor(rm);
            rm.SetNextRotor(rl);
            rl.SetNextRotor(reflector);
            rm.SetPreviousRotor(rr);
            rl.SetPreviousRotor(rm);
            reflector.SetPreviousRotor(rl);

        }

        void BtnDespreClick(object sender, System.EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        void BtnSettingsClick(object sender, System.EventArgs e)
        {
            Settings s = new Settings(this);
            s.ShowDialog();
        }
        // posun "grafickěho" rotoru
        void TxtInitKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.KeyValue >= 65 && e.KeyValue <= 90) && !e.Control)
            {
                rr.Move();
                rr.PutDataIn((char)e.KeyValue);
                txtFinal.AppendText("" + rr.GetDataOut());
            }
        }

        //přesuňte první (pravý) rotor nahoru
        void BtnRotor1UpClick(object sender, System.EventArgs e)
        {
            rr.Move();
        }

        //posunout první rotor dolů
        void BtnRotor1DownClick(object sender, System.EventArgs e)
        {
            rr.MoveBack();
        }

        //posunout druhý rotor nahoru
        void BtnRotor2UpClick(object sender, System.EventArgs e)
        {
            rm.Move();
        }

        //posunout druhý (střední) rotor dolů.
        void BtnRotor2DownClick(object sender, System.EventArgs e)
        {
            rm.MoveBack();
        }

        //přesuňte třetí (levý) rotor nahoru
        void BtnRotor3UpClick(object sender, System.EventArgs e)
        {
            rl.Move();
        }

        //přesuňte třetí rotor dolů
        void BtnRotor3DownClick(object sender, System.EventArgs e)
        {
            rl.MoveBack();
        }

        //zašifrujte data v horním textovém poli a výsledek vložte do dolního pole.
        void Button1Click(object sender, System.EventArgs e)
        {
            //HDXCONVRWUEUVEZWDXDFCHXGO
            char[] chIn = txtInit.Text.ToUpper().ToCharArray();
            txtFinal.Text = "";
            for (int i = 0; i < chIn.Length; i++)
            {
                if (chIn[i] >= 65 && chIn[i] <= 90)
                {
                    rr.Move();
                    rr.PutDataIn(chIn[i]);
                    txtFinal.AppendText("" + rr.GetDataOut());
                }
            }
        }

        //metoda výměny rotorů, které se používají
        public void ChangeRotors(string rot1, string rotName1, char rotNotch1,
                                 string rot2, string rotName2, char rotNotch2,
                                 string rot3, string rotName3, char rotNotch3)
        {
            lblRotorS.Text = rotName1;
            lblRotorM.Text = rotName2;
            lblRotorD.Text = rotName3;
            rr = null;
            rm = null;
            rl = null;

            rr = new Rotor(rot3, lblRotor1, rotNotch3);
            rm = new Rotor(rot2, lblRotor2, rotNotch2);
            rl = new Rotor(rot1, lblRotor3, rotNotch1);

            rr.ResetOffset();
            rm.ResetOffset();
            rl.ResetOffset();

            rr.SetNextRotor(rm);
            rm.SetNextRotor(rl);
            rl.SetNextRotor(reflector);
            rm.SetPreviousRotor(rr);
            rl.SetPreviousRotor(rm);
            reflector.SetPreviousRotor(rl);

            lblRotor1.Text = "A";
            lblRotor2.Text = "A";
            lblRotor3.Text = "A";
        }

        //výměna reflektoru
        public void SetReflector(string refl)
        {
            reflector = new Rotor(refl, null, '\0');
            reflector.SetPreviousRotor(rl);
            rl.SetNextRotor(reflector);
        }

        //získat vybraný reflektor
        public string GetReflector()
        {
            return reflector.GetLayout();
        }
        
        //otevřít soubour zašifrovat/dešifrovat
        private void loadFile_Click(object sender, System.EventArgs e)
        {
             using (OpenFileDialog openFileDialog = new OpenFileDialog())
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                    string celyText = sr.ReadToEnd();
                    txtInit.Text = celyText;

                    sr.Close();
                    fs.Close();
                    //MessageBox.Show(celyText);
                    char[] chIn = txtInit.Text.ToUpper().ToCharArray();
                    txtFinal.Text = "";
                    for (int i = 0; i < chIn.Length; i++)
                    {
                        if (chIn[i] >= 65 && chIn[i] <= 90)
                        {
                            rr.Move();
                            rr.PutDataIn(chIn[i]);
                            txtFinal.AppendText("" + rr.GetDataOut());
                        }
                    }
                }
        }
        //uložit výsledný text do souboru
        private void saveFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                FileStream fs2 = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs2, Encoding.UTF8);
                sw.Write(txtFinal.Text);
                sw.Close();
                fs2.Close();
                }
        }

        public string GetRightRotor()
        {
            return rr.GetLayout();
        }
        public string GetMiddleRotor()
        {
            return rm.GetLayout();
        }
        public string GetLeftRotor()
        {
            return rl.GetLayout();
        }
    }
}

