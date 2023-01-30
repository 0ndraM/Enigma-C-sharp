using System;
using System.Windows.Forms;

namespace ROP
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnRotor3Down = new System.Windows.Forms.Button();
            this.lblRotor2 = new System.Windows.Forms.Label();
            this.btnRotor3Up = new System.Windows.Forms.Button();
            this.lblRotorM = new System.Windows.Forms.Label();
            this.btnRotor2Up = new System.Windows.Forms.Button();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnRotor1Up = new System.Windows.Forms.Button();
            this.txtInit = new System.Windows.Forms.TextBox();
            this.lblRotor1 = new System.Windows.Forms.Label();
            this.lblRotor3 = new System.Windows.Forms.Label();
            this.btnRotor2Down = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRotorL = new System.Windows.Forms.Label();
            this.lblRotorR = new System.Windows.Forms.Label();
            this.btnRotor1Down = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.loadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.Window;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.Location = new System.Drawing.Point(56, 262);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(40, 32);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.BtnAboutClick);
            // 
            // btnRotor3Down
            // 
            this.btnRotor3Down.BackColor = System.Drawing.SystemColors.Window;
            this.btnRotor3Down.Image = ((System.Drawing.Image)(resources.GetObject("btnRotor3Down.Image")));
            this.btnRotor3Down.Location = new System.Drawing.Point(16, 112);
            this.btnRotor3Down.Name = "btnRotor3Down";
            this.btnRotor3Down.Size = new System.Drawing.Size(32, 32);
            this.btnRotor3Down.TabIndex = 13;
            this.btnRotor3Down.UseVisualStyleBackColor = false;
            this.btnRotor3Down.Click += new System.EventHandler(this.BtnRotor3DownClick);
            // 
            // lblRotor2
            // 
            this.lblRotor2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblRotor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRotor2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblRotor2.Location = new System.Drawing.Point(56, 75);
            this.lblRotor2.Name = "lblRotor2";
            this.lblRotor2.Size = new System.Drawing.Size(32, 32);
            this.lblRotor2.TabIndex = 10;
            this.lblRotor2.Text = "A";
            this.lblRotor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRotor3Up
            // 
            this.btnRotor3Up.BackColor = System.Drawing.SystemColors.Window;
            this.btnRotor3Up.Image = ((System.Drawing.Image)(resources.GetObject("btnRotor3Up.Image")));
            this.btnRotor3Up.Location = new System.Drawing.Point(16, 40);
            this.btnRotor3Up.Name = "btnRotor3Up";
            this.btnRotor3Up.Size = new System.Drawing.Size(32, 32);
            this.btnRotor3Up.TabIndex = 12;
            this.btnRotor3Up.UseVisualStyleBackColor = false;
            this.btnRotor3Up.Click += new System.EventHandler(this.BtnRotor3UpClick);
            // 
            // lblRotorM
            // 
            this.lblRotorM.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblRotorM.Location = new System.Drawing.Point(56, 16);
            this.lblRotorM.Name = "lblRotorM";
            this.lblRotorM.Size = new System.Drawing.Size(32, 24);
            this.lblRotorM.TabIndex = 19;
            this.lblRotorM.Text = "II";
            this.lblRotorM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRotor2Up
            // 
            this.btnRotor2Up.BackColor = System.Drawing.SystemColors.Window;
            this.btnRotor2Up.Image = ((System.Drawing.Image)(resources.GetObject("btnRotor2Up.Image")));
            this.btnRotor2Up.Location = new System.Drawing.Point(56, 40);
            this.btnRotor2Up.Name = "btnRotor2Up";
            this.btnRotor2Up.Size = new System.Drawing.Size(32, 32);
            this.btnRotor2Up.TabIndex = 14;
            this.btnRotor2Up.UseVisualStyleBackColor = false;
            this.btnRotor2Up.Click += new System.EventHandler(this.BtnRotor2UpClick);
            // 
            // txtFinal
            // 
            this.txtFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinal.Location = new System.Drawing.Point(10, 300);
            this.txtFinal.Multiline = true;
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(360, 88);
            this.txtFinal.TabIndex = 10;
            // 
            // btnRotor1Up
            // 
            this.btnRotor1Up.BackColor = System.Drawing.SystemColors.Window;
            this.btnRotor1Up.Image = ((System.Drawing.Image)(resources.GetObject("btnRotor1Up.Image")));
            this.btnRotor1Up.Location = new System.Drawing.Point(96, 40);
            this.btnRotor1Up.Name = "btnRotor1Up";
            this.btnRotor1Up.Size = new System.Drawing.Size(32, 32);
            this.btnRotor1Up.TabIndex = 15;
            this.btnRotor1Up.UseVisualStyleBackColor = false;
            this.btnRotor1Up.Click += new System.EventHandler(this.BtnRotor1UpClick);
            // 
            // txtInit
            // 
            this.txtInit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInit.Location = new System.Drawing.Point(10, 170);
            this.txtInit.Multiline = true;
            this.txtInit.Name = "txtInit";
            this.txtInit.Size = new System.Drawing.Size(360, 88);
            this.txtInit.TabIndex = 9;
            this.txtInit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtInitKeyUp);
            // 
            // lblRotor1
            // 
            this.lblRotor1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblRotor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRotor1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblRotor1.Location = new System.Drawing.Point(96, 75);
            this.lblRotor1.Name = "lblRotor1";
            this.lblRotor1.Size = new System.Drawing.Size(32, 32);
            this.lblRotor1.TabIndex = 11;
            this.lblRotor1.Text = "A";
            this.lblRotor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRotor3
            // 
            this.lblRotor3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblRotor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRotor3.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblRotor3.Location = new System.Drawing.Point(16, 75);
            this.lblRotor3.Name = "lblRotor3";
            this.lblRotor3.Size = new System.Drawing.Size(32, 32);
            this.lblRotor3.TabIndex = 9;
            this.lblRotor3.Text = "A";
            this.lblRotor3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRotor2Down
            // 
            this.btnRotor2Down.BackColor = System.Drawing.SystemColors.Window;
            this.btnRotor2Down.Image = ((System.Drawing.Image)(resources.GetObject("btnRotor2Down.Image")));
            this.btnRotor2Down.Location = new System.Drawing.Point(56, 112);
            this.btnRotor2Down.Name = "btnRotor2Down";
            this.btnRotor2Down.Size = new System.Drawing.Size(32, 32);
            this.btnRotor2Down.TabIndex = 16;
            this.btnRotor2Down.UseVisualStyleBackColor = false;
            this.btnRotor2Down.Click += new System.EventHandler(this.BtnRotor2DownClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblRotorL);
            this.groupBox1.Controls.Add(this.lblRotorM);
            this.groupBox1.Controls.Add(this.lblRotorR);
            this.groupBox1.Controls.Add(this.btnRotor1Down);
            this.groupBox1.Controls.Add(this.btnRotor2Down);
            this.groupBox1.Controls.Add(this.btnRotor1Up);
            this.groupBox1.Controls.Add(this.btnRotor2Up);
            this.groupBox1.Controls.Add(this.btnRotor3Down);
            this.groupBox1.Controls.Add(this.btnRotor3Up);
            this.groupBox1.Controls.Add(this.lblRotor1);
            this.groupBox1.Controls.Add(this.lblRotor2);
            this.groupBox1.Controls.Add(this.lblRotor3);
            this.groupBox1.Location = new System.Drawing.Point(120, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 152);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotory";
            // 
            // lblRotorL
            // 
            this.lblRotorL.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblRotorL.Location = new System.Drawing.Point(16, 16);
            this.lblRotorL.Name = "lblRotorL";
            this.lblRotorL.Size = new System.Drawing.Size(32, 24);
            this.lblRotorL.TabIndex = 20;
            this.lblRotorL.Text = "I";
            this.lblRotorL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRotorR
            // 
            this.lblRotorR.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblRotorR.Location = new System.Drawing.Point(96, 16);
            this.lblRotorR.Name = "lblRotorR";
            this.lblRotorR.Size = new System.Drawing.Size(32, 24);
            this.lblRotorR.TabIndex = 18;
            this.lblRotorR.Text = "III";
            this.lblRotorR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRotor1Down
            // 
            this.btnRotor1Down.BackColor = System.Drawing.SystemColors.Window;
            this.btnRotor1Down.Image = ((System.Drawing.Image)(resources.GetObject("btnRotor1Down.Image")));
            this.btnRotor1Down.Location = new System.Drawing.Point(94, 112);
            this.btnRotor1Down.Name = "btnRotor1Down";
            this.btnRotor1Down.Size = new System.Drawing.Size(32, 32);
            this.btnRotor1Down.TabIndex = 17;
            this.btnRotor1Down.UseVisualStyleBackColor = false;
            this.btnRotor1Down.Click += new System.EventHandler(this.BtnRotor1DownClick);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.SystemColors.Window;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(10, 262);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(40, 32);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettingsClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(202, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Šifrování / dešifrování";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // loadFile
            // 
            this.loadFile.BackColor = System.Drawing.SystemColors.Window;
            this.loadFile.Image = ((System.Drawing.Image)(resources.GetObject("loadFile.Image")));
            this.loadFile.Location = new System.Drawing.Point(102, 262);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(40, 32);
            this.loadFile.TabIndex = 16;
            this.loadFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadFile.UseVisualStyleBackColor = false;
            this.loadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFile
            // 
            this.saveFile.BackColor = System.Drawing.SystemColors.Window;
            this.saveFile.Image = ((System.Drawing.Image)(resources.GetObject("saveFile.Image")));
            this.saveFile.Location = new System.Drawing.Point(148, 262);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(40, 32);
            this.saveFile.TabIndex = 17;
            this.saveFile.UseVisualStyleBackColor = false;
            this.saveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(380, 400);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.loadFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtInit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enigma";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            }


        #endregion


        private System.Windows.Forms.Button button1;
        private Button btnAbout;
        private Button btnRotor3Down;
        private Label lblRotor2;
        private Button btnRotor3Up;
        private Label lblRotorM;
        private Button btnRotor2Up;
        private TextBox txtFinal;
        private Button btnRotor1Up;
        private TextBox txtInit;
        private Label lblRotor1;
        private Label lblRotor3;
        private Button btnRotor2Down;
        private GroupBox groupBox1;
        private Label lblRotorL;
        private Label lblRotorR;
        private Button btnRotor1Down;
        private Button btnSettings;
        private Button loadFile;
        private OpenFileDialog openFileDialog1;
        private Button saveFile;
    }
}

