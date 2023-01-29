using System;
using System.Windows.Forms;

namespace ROP
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ToolTip ttUp;
        private Button btnSelect;
        private Button btnDown;
        private Label label4;
        private Button btnOk;
        private Button btnDeselect;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnUp;
        private ToolTip ttDeselect;
        private ToolTip ttSelect;
        private ToolTip ttDown;
        private ComboBox cmbReflector;
        private GroupBox groupBox1;
        private Button btnCancel;
        private ListBox lstAvailableRotors;
        private Label lblRotorStructure;
        private ListBox lstSelectedRotors;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.ttUp = new System.Windows.Forms.ToolTip(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.cmbReflector = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRotorStructure = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstAvailableRotors = new System.Windows.Forms.ListBox();
            this.lstSelectedRotors = new System.Windows.Forms.ListBox();
            this.ttDeselect = new System.Windows.Forms.ToolTip(this.components);
            this.ttSelect = new System.Windows.Forms.ToolTip(this.components);
            this.ttDown = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.btnSelect, "btnSelect");
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelectClick);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.btnDown, "btnDown");
            this.btnDown.Name = "btnDown";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.BtnDownClick);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // btnDeselect
            // 
            this.btnDeselect.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.btnDeselect, "btnDeselect");
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.UseVisualStyleBackColor = false;
            this.btnDeselect.Click += new System.EventHandler(this.BtnDeselectClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.btnUp, "btnUp");
            this.btnUp.Name = "btnUp";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.BtnUpClick);
            // 
            // cmbReflector
            // 
            this.cmbReflector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReflector.Items.AddRange(new object[] {
            resources.GetString("cmbReflector.Items"),
            resources.GetString("cmbReflector.Items1")});
            resources.ApplyResources(this.cmbReflector, "cmbReflector");
            this.cmbReflector.Name = "cmbReflector";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblRotorStructure);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lblRotorStructure
            // 
            this.lblRotorStructure.BackColor = System.Drawing.SystemColors.Window;
            this.lblRotorStructure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblRotorStructure, "lblRotorStructure");
            this.lblRotorStructure.Name = "lblRotorStructure";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // lstAvailableRotors
            // 
            this.lstAvailableRotors.Items.AddRange(new object[] {
            resources.GetString("lstAvailableRotors.Items"),
            resources.GetString("lstAvailableRotors.Items1"),
            resources.GetString("lstAvailableRotors.Items2"),
            resources.GetString("lstAvailableRotors.Items3"),
            resources.GetString("lstAvailableRotors.Items4")});
            resources.ApplyResources(this.lstAvailableRotors, "lstAvailableRotors");
            this.lstAvailableRotors.Name = "lstAvailableRotors";
            this.lstAvailableRotors.SelectedIndexChanged += new System.EventHandler(this.LstAvailableRotorsSelectedIndexChanged);
            // 
            // lstSelectedRotors
            // 
            resources.ApplyResources(this.lstSelectedRotors, "lstSelectedRotors");
            this.lstSelectedRotors.Name = "lstSelectedRotors";
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.cmbReflector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lstSelectedRotors);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstAvailableRotors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.SettingsLoad);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
    }
}