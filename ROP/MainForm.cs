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


namespace ROP
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }


        private Rotor rr, rm, rl, reflector;

        // vytvoření všech rotorů
        void MainFormLoad(object sender, System.EventArgs e)
        {
            rr = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", lblRotor1, 'V');
            rm = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", lblRotor2, 'E');
            rl = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", lblRotor3, 'Q');
            reflector = new Rotor("YRUHQSLDPXNGOKMIEBFZCWVJAT", null, '\0');
            rr.SetNext(rm);
            rm.SetNext(rl);
            rl.SetNext(reflector);
            rm.SetPrevious(rr);
            rl.SetPrevious(rm);
            reflector.SetPrevious(rl);

            //nastavení nápověd 
            ToolTip ttSettings = new ToolTip();
            ttSettings.SetToolTip(btnSettings, "Nastavení");
            ToolTip ttAbout = new ToolTip();
            ttAbout.SetToolTip(btnAbout, "Informace");
            ToolTip ttLoadFile = new ToolTip();
            ttLoadFile.SetToolTip(btnLoadFile, "Nahrání ze souboru");
            ToolTip ttSaveFile = new ToolTip();
            ttSaveFile.SetToolTip(btnSaveFile, "Uložení do souboru");
        }

        void BtnAboutClick(object sender, System.EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        void BtnSettingsClick(object sender, System.EventArgs e)
        {
            Settings s = new Settings(this);
            s.ShowDialog();
        }
        // zašifrování písmeno po zapsání
        void TxtInitKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.KeyValue >= 65 && e.KeyValue <= 90) && !e.Control)
            {
                rr.Move();
                rr.PutDataIn((char)e.KeyValue);
                txtFinal.AppendText("" + rr.GetDataOut());
                
            }
        }

        //přesune první (pravý) rotor nahoru
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

        //přesune třetí (levý) rotor nahoru
        void BtnRotor3UpClick(object sender, System.EventArgs e)
        {
            rl.Move();
        }

        //přesune třetí rotor dolů
        void BtnRotor3DownClick(object sender, System.EventArgs e)
        {
            rl.MoveBack();
        }

        //zašifruje data v horním textovém poli a výsledek vloží do dolního textboxu.
        void Button1Click(object sender, System.EventArgs e)
        {
           
            char[] charIn = txtInit.Text.ToUpper().ToCharArray();
            txtFinal.Text = "";
            for (int i = 0; i < charIn.Length; i++)
            {
                if (charIn[i] >= 65 && charIn[i] <= 90)
                {
                    rr.Move();
                    rr.PutDataIn(charIn[i]);
                    txtFinal.AppendText("" + rr.GetDataOut());
                }
            }
        }

        //metoda výměny rotorů, které se používají
        public void ChangeRotors(string rot1, string rotName1, char rotNotch1,
                                 string rot2, string rotName2, char rotNotch2,
                                 string rot3, string rotName3, char rotNotch3)
        {
            lblRotorL.Text = rotName1;
            lblRotorM.Text = rotName2;
            lblRotorR.Text = rotName3;
            rr = null;
            rm = null;
            rl = null;

            rr = new Rotor(rot3, lblRotor1, rotNotch3);
            rm = new Rotor(rot2, lblRotor2, rotNotch2);
            rl = new Rotor(rot1, lblRotor3, rotNotch1);

            rr.ResetOffset();
            rm.ResetOffset();
            rl.ResetOffset();

            rr.SetNext(rm);
            rm.SetNext(rl);
            rl.SetNext(reflector);
            rm.SetPrevious(rr);
            rl.SetPrevious(rm);
            reflector.SetPrevious(rl);

            lblRotor1.Text = "A";
            lblRotor2.Text = "A";
            lblRotor3.Text = "A";
        }

        //výměna reflektoru
        public void SetReflector(string refl)
        {
            reflector = new Rotor(refl, null, '\0');
            reflector.SetPrevious(rl);
            rl.SetNext(reflector);
        }

        //získat vybraný reflektor
        public string GetReflector()
        {
            return reflector.Layout();
        }
        
        //otevřít soubour zašifrovat/dešifrovat
        private void BtnLoadFile_Click(object sender, System.EventArgs e)
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
                        if (chIn[i] >= 'A' && chIn[i] <= 'Z')
                        {
                            rr.Move();
                            rr.PutDataIn(chIn[i]);
                            txtFinal.AppendText("" + rr.GetDataOut());
                        }
                    }
                }
        }
        //uložit výsledný text do souboru
        private void BtnSaveFile_Click(object sender, EventArgs e)
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

        

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtFinal.Clear();
            txtInit.Clear();
        }

        public string GetRightRotor()
        {
            return rr.Layout();
        }
        public string GetMiddleRotor()
        {
            return rm.Layout();
        }
        public string GetLeftRotor()
        {
            return rl.Layout();
        }
    }
}