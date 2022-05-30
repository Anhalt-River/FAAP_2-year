
namespace Geometric_experience
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btmClear = new System.Windows.Forms.Button();
            this.btmLook = new System.Windows.Forms.Button();
            this.btmSave = new System.Windows.Forms.Button();
            this.btmAdd = new System.Windows.Forms.Button();
            this.btmLoad = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.punAdd = new System.Windows.Forms.Panel();
            this.panUnifAll = new System.Windows.Forms.Panel();
            this.btnClearUnif = new System.Windows.Forms.Button();
            this.panRadius = new System.Windows.Forms.Panel();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.labRadius = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pan4 = new System.Windows.Forms.Panel();
            this.textBoxY4 = new System.Windows.Forms.TextBox();
            this.labY4 = new System.Windows.Forms.Label();
            this.textBoxX4 = new System.Windows.Forms.TextBox();
            this.labX4 = new System.Windows.Forms.Label();
            this.labUnif4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pan2 = new System.Windows.Forms.Panel();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.labY2 = new System.Windows.Forms.Label();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.labX2 = new System.Windows.Forms.Label();
            this.labUnif2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pan1 = new System.Windows.Forms.Panel();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.labY1 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.labX1 = new System.Windows.Forms.Label();
            this.labUnif1 = new System.Windows.Forms.Label();
            this.labSegment = new System.Windows.Forms.Label();
            this.pan3 = new System.Windows.Forms.Panel();
            this.textBoxY3 = new System.Windows.Forms.TextBox();
            this.labY3 = new System.Windows.Forms.Label();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.labX3 = new System.Windows.Forms.Label();
            this.labUnif3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFigChoose = new System.Windows.Forms.Button();
            this.listFigChoose = new System.Windows.Forms.ListBox();
            this.LabelFigChoose = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panLookTemp = new System.Windows.Forms.Panel();
            this.labLook = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MainPanel.SuspendLayout();
            this.punAdd.SuspendLayout();
            this.panUnifAll.SuspendLayout();
            this.panRadius.SuspendLayout();
            this.pan4.SuspendLayout();
            this.pan2.SuspendLayout();
            this.pan1.SuspendLayout();
            this.pan3.SuspendLayout();
            this.panLookTemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.btmClear);
            this.MainPanel.Controls.Add(this.btmLook);
            this.MainPanel.Controls.Add(this.btmSave);
            this.MainPanel.Controls.Add(this.btmAdd);
            this.MainPanel.Controls.Add(this.btmLoad);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(98, 450);
            this.MainPanel.TabIndex = 1;
            // 
            // btmClear
            // 
            this.btmClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btmClear.Location = new System.Drawing.Point(3, 47);
            this.btmClear.Name = "btmClear";
            this.btmClear.Size = new System.Drawing.Size(92, 38);
            this.btmClear.TabIndex = 4;
            this.btmClear.Text = "Clear";
            this.btmClear.UseVisualStyleBackColor = true;
            this.btmClear.Click += new System.EventHandler(this.btmClear_Click);
            // 
            // btmLook
            // 
            this.btmLook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btmLook.Location = new System.Drawing.Point(3, 3);
            this.btmLook.Name = "btmLook";
            this.btmLook.Size = new System.Drawing.Size(92, 38);
            this.btmLook.TabIndex = 3;
            this.btmLook.Text = "Look";
            this.btmLook.UseVisualStyleBackColor = true;
            this.btmLook.Click += new System.EventHandler(this.btmLook_Click);
            // 
            // btmSave
            // 
            this.btmSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btmSave.Location = new System.Drawing.Point(3, 179);
            this.btmSave.Name = "btmSave";
            this.btmSave.Size = new System.Drawing.Size(92, 38);
            this.btmSave.TabIndex = 2;
            this.btmSave.Text = "Save";
            this.btmSave.UseVisualStyleBackColor = true;
            this.btmSave.Click += new System.EventHandler(this.btmSave_Click);
            // 
            // btmAdd
            // 
            this.btmAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btmAdd.Location = new System.Drawing.Point(3, 91);
            this.btmAdd.Name = "btmAdd";
            this.btmAdd.Size = new System.Drawing.Size(92, 38);
            this.btmAdd.TabIndex = 0;
            this.btmAdd.Text = "Add";
            this.btmAdd.UseVisualStyleBackColor = true;
            this.btmAdd.Click += new System.EventHandler(this.btmAdd_Click);
            // 
            // btmLoad
            // 
            this.btmLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btmLoad.Location = new System.Drawing.Point(3, 135);
            this.btmLoad.Name = "btmLoad";
            this.btmLoad.Size = new System.Drawing.Size(92, 38);
            this.btmLoad.TabIndex = 1;
            this.btmLoad.Text = "Load";
            this.btmLoad.UseVisualStyleBackColor = true;
            this.btmLoad.Click += new System.EventHandler(this.btmLoad_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File|*.txt";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "Text File|*.txt";
            // 
            // punAdd
            // 
            this.punAdd.BackColor = System.Drawing.SystemColors.Info;
            this.punAdd.Controls.Add(this.panUnifAll);
            this.punAdd.Controls.Add(this.btnFigChoose);
            this.punAdd.Controls.Add(this.listFigChoose);
            this.punAdd.Controls.Add(this.LabelFigChoose);
            this.punAdd.Location = new System.Drawing.Point(101, 12);
            this.punAdd.Name = "punAdd";
            this.punAdd.Size = new System.Drawing.Size(322, 161);
            this.punAdd.TabIndex = 2;
            this.punAdd.Visible = false;
            // 
            // panUnifAll
            // 
            this.panUnifAll.Controls.Add(this.btnClearUnif);
            this.panUnifAll.Controls.Add(this.panRadius);
            this.panUnifAll.Controls.Add(this.pan4);
            this.panUnifAll.Controls.Add(this.pan2);
            this.panUnifAll.Controls.Add(this.pan1);
            this.panUnifAll.Controls.Add(this.pan3);
            this.panUnifAll.Location = new System.Drawing.Point(144, 6);
            this.panUnifAll.Name = "panUnifAll";
            this.panUnifAll.Size = new System.Drawing.Size(175, 152);
            this.panUnifAll.TabIndex = 4;
            this.panUnifAll.Visible = false;
            // 
            // btnClearUnif
            // 
            this.btnClearUnif.Location = new System.Drawing.Point(95, 2);
            this.btnClearUnif.Name = "btnClearUnif";
            this.btnClearUnif.Size = new System.Drawing.Size(75, 23);
            this.btnClearUnif.TabIndex = 4;
            this.btnClearUnif.Text = "Clear all";
            this.btnClearUnif.UseVisualStyleBackColor = true;
            this.btnClearUnif.Click += new System.EventHandler(this.btnClearUnif_Click);
            // 
            // panRadius
            // 
            this.panRadius.Controls.Add(this.textBoxRadius);
            this.panRadius.Controls.Add(this.labRadius);
            this.panRadius.Controls.Add(this.label7);
            this.panRadius.Location = new System.Drawing.Point(0, 0);
            this.panRadius.Name = "panRadius";
            this.panRadius.Size = new System.Drawing.Size(89, 26);
            this.panRadius.TabIndex = 5;
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(54, 1);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(35, 23);
            this.textBoxRadius.TabIndex = 8;
            // 
            // labRadius
            // 
            this.labRadius.AutoSize = true;
            this.labRadius.Location = new System.Drawing.Point(3, 4);
            this.labRadius.Name = "labRadius";
            this.labRadius.Size = new System.Drawing.Size(45, 15);
            this.labRadius.TabIndex = 5;
            this.labRadius.Text = "Radius:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 0;
            // 
            // pan4
            // 
            this.pan4.Controls.Add(this.textBoxY4);
            this.pan4.Controls.Add(this.labY4);
            this.pan4.Controls.Add(this.textBoxX4);
            this.pan4.Controls.Add(this.labX4);
            this.pan4.Controls.Add(this.labUnif4);
            this.pan4.Controls.Add(this.label6);
            this.pan4.Location = new System.Drawing.Point(1, 123);
            this.pan4.Name = "pan4";
            this.pan4.Size = new System.Drawing.Size(174, 26);
            this.pan4.TabIndex = 11;
            // 
            // textBoxY4
            // 
            this.textBoxY4.Location = new System.Drawing.Point(134, 1);
            this.textBoxY4.Name = "textBoxY4";
            this.textBoxY4.Size = new System.Drawing.Size(35, 23);
            this.textBoxY4.TabIndex = 8;
            // 
            // labY4
            // 
            this.labY4.AutoSize = true;
            this.labY4.Location = new System.Drawing.Point(114, 4);
            this.labY4.Name = "labY4";
            this.labY4.Size = new System.Drawing.Size(14, 15);
            this.labY4.TabIndex = 7;
            this.labY4.Text = "Y";
            // 
            // textBoxX4
            // 
            this.textBoxX4.Location = new System.Drawing.Point(54, 0);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.Size = new System.Drawing.Size(35, 23);
            this.textBoxX4.TabIndex = 4;
            // 
            // labX4
            // 
            this.labX4.AutoSize = true;
            this.labX4.Location = new System.Drawing.Point(34, 4);
            this.labX4.Name = "labX4";
            this.labX4.Size = new System.Drawing.Size(14, 15);
            this.labX4.TabIndex = 6;
            this.labX4.Text = "X";
            // 
            // labUnif4
            // 
            this.labUnif4.AutoSize = true;
            this.labUnif4.Location = new System.Drawing.Point(3, 4);
            this.labUnif4.Name = "labUnif4";
            this.labUnif4.Size = new System.Drawing.Size(23, 15);
            this.labUnif4.TabIndex = 5;
            this.labUnif4.Text = "P4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 0;
            // 
            // pan2
            // 
            this.pan2.Controls.Add(this.textBoxY2);
            this.pan2.Controls.Add(this.labY2);
            this.pan2.Controls.Add(this.textBoxX2);
            this.pan2.Controls.Add(this.labX2);
            this.pan2.Controls.Add(this.labUnif2);
            this.pan2.Controls.Add(this.label4);
            this.pan2.Location = new System.Drawing.Point(1, 61);
            this.pan2.Name = "pan2";
            this.pan2.Size = new System.Drawing.Size(174, 26);
            this.pan2.TabIndex = 9;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(134, 1);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(35, 23);
            this.textBoxY2.TabIndex = 8;
            // 
            // labY2
            // 
            this.labY2.AutoSize = true;
            this.labY2.Location = new System.Drawing.Point(114, 4);
            this.labY2.Name = "labY2";
            this.labY2.Size = new System.Drawing.Size(14, 15);
            this.labY2.TabIndex = 7;
            this.labY2.Text = "Y";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(54, 0);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(35, 23);
            this.textBoxX2.TabIndex = 4;
            // 
            // labX2
            // 
            this.labX2.AutoSize = true;
            this.labX2.Location = new System.Drawing.Point(34, 4);
            this.labX2.Name = "labX2";
            this.labX2.Size = new System.Drawing.Size(14, 15);
            this.labX2.TabIndex = 6;
            this.labX2.Text = "X";
            // 
            // labUnif2
            // 
            this.labUnif2.AutoSize = true;
            this.labUnif2.Location = new System.Drawing.Point(3, 4);
            this.labUnif2.Name = "labUnif2";
            this.labUnif2.Size = new System.Drawing.Size(23, 15);
            this.labUnif2.TabIndex = 5;
            this.labUnif2.Text = "P2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 0;
            // 
            // pan1
            // 
            this.pan1.Controls.Add(this.textBoxY1);
            this.pan1.Controls.Add(this.labY1);
            this.pan1.Controls.Add(this.textBoxX1);
            this.pan1.Controls.Add(this.labX1);
            this.pan1.Controls.Add(this.labUnif1);
            this.pan1.Controls.Add(this.labSegment);
            this.pan1.Location = new System.Drawing.Point(1, 30);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(174, 26);
            this.pan1.TabIndex = 4;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(134, 1);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(35, 23);
            this.textBoxY1.TabIndex = 8;
            // 
            // labY1
            // 
            this.labY1.AutoSize = true;
            this.labY1.Location = new System.Drawing.Point(114, 4);
            this.labY1.Name = "labY1";
            this.labY1.Size = new System.Drawing.Size(14, 15);
            this.labY1.TabIndex = 7;
            this.labY1.Text = "Y";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(54, 0);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(35, 23);
            this.textBoxX1.TabIndex = 4;
            // 
            // labX1
            // 
            this.labX1.AutoSize = true;
            this.labX1.Location = new System.Drawing.Point(34, 4);
            this.labX1.Name = "labX1";
            this.labX1.Size = new System.Drawing.Size(14, 15);
            this.labX1.TabIndex = 6;
            this.labX1.Text = "X";
            // 
            // labUnif1
            // 
            this.labUnif1.AutoSize = true;
            this.labUnif1.Location = new System.Drawing.Point(3, 4);
            this.labUnif1.Name = "labUnif1";
            this.labUnif1.Size = new System.Drawing.Size(23, 15);
            this.labUnif1.TabIndex = 5;
            this.labUnif1.Text = "P1:";
            // 
            // labSegment
            // 
            this.labSegment.AutoSize = true;
            this.labSegment.Location = new System.Drawing.Point(48, 4);
            this.labSegment.Name = "labSegment";
            this.labSegment.Size = new System.Drawing.Size(0, 15);
            this.labSegment.TabIndex = 0;
            // 
            // pan3
            // 
            this.pan3.Controls.Add(this.textBoxY3);
            this.pan3.Controls.Add(this.labY3);
            this.pan3.Controls.Add(this.textBoxX3);
            this.pan3.Controls.Add(this.labX3);
            this.pan3.Controls.Add(this.labUnif3);
            this.pan3.Controls.Add(this.label5);
            this.pan3.Location = new System.Drawing.Point(1, 92);
            this.pan3.Name = "pan3";
            this.pan3.Size = new System.Drawing.Size(174, 26);
            this.pan3.TabIndex = 10;
            // 
            // textBoxY3
            // 
            this.textBoxY3.Location = new System.Drawing.Point(134, 1);
            this.textBoxY3.Name = "textBoxY3";
            this.textBoxY3.Size = new System.Drawing.Size(35, 23);
            this.textBoxY3.TabIndex = 8;
            // 
            // labY3
            // 
            this.labY3.AutoSize = true;
            this.labY3.Location = new System.Drawing.Point(114, 4);
            this.labY3.Name = "labY3";
            this.labY3.Size = new System.Drawing.Size(14, 15);
            this.labY3.TabIndex = 7;
            this.labY3.Text = "Y";
            // 
            // textBoxX3
            // 
            this.textBoxX3.Location = new System.Drawing.Point(54, 0);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(35, 23);
            this.textBoxX3.TabIndex = 4;
            // 
            // labX3
            // 
            this.labX3.AutoSize = true;
            this.labX3.Location = new System.Drawing.Point(34, 4);
            this.labX3.Name = "labX3";
            this.labX3.Size = new System.Drawing.Size(14, 15);
            this.labX3.TabIndex = 6;
            this.labX3.Text = "X";
            // 
            // labUnif3
            // 
            this.labUnif3.AutoSize = true;
            this.labUnif3.Location = new System.Drawing.Point(3, 4);
            this.labUnif3.Name = "labUnif3";
            this.labUnif3.Size = new System.Drawing.Size(23, 15);
            this.labUnif3.TabIndex = 5;
            this.labUnif3.Text = "P3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 0;
            // 
            // btnFigChoose
            // 
            this.btnFigChoose.Location = new System.Drawing.Point(18, 132);
            this.btnFigChoose.Name = "btnFigChoose";
            this.btnFigChoose.Size = new System.Drawing.Size(120, 23);
            this.btnFigChoose.TabIndex = 2;
            this.btnFigChoose.Text = "Add";
            this.btnFigChoose.UseVisualStyleBackColor = true;
            this.btnFigChoose.Click += new System.EventHandler(this.btnFigChoose_Click);
            // 
            // listFigChoose
            // 
            this.listFigChoose.FormattingEnabled = true;
            this.listFigChoose.ItemHeight = 15;
            this.listFigChoose.Items.AddRange(new object[] {
            "Segment",
            "Triangle",
            "Rectangle",
            "Circle"});
            this.listFigChoose.Location = new System.Drawing.Point(18, 31);
            this.listFigChoose.Name = "listFigChoose";
            this.listFigChoose.Size = new System.Drawing.Size(120, 94);
            this.listFigChoose.TabIndex = 1;
            this.listFigChoose.SelectedIndexChanged += new System.EventHandler(this.listFigChoose_SelectedIndexChanged);
            // 
            // LabelFigChoose
            // 
            this.LabelFigChoose.AutoSize = true;
            this.LabelFigChoose.Location = new System.Drawing.Point(18, 13);
            this.LabelFigChoose.Name = "LabelFigChoose";
            this.LabelFigChoose.Size = new System.Drawing.Size(95, 15);
            this.LabelFigChoose.TabIndex = 0;
            this.LabelFigChoose.Text = "Figure choosing:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panLookTemp
            // 
            this.panLookTemp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panLookTemp.Controls.Add(this.labLook);
            this.panLookTemp.Controls.Add(this.richTextBox1);
            this.panLookTemp.Location = new System.Drawing.Point(101, 179);
            this.panLookTemp.Name = "panLookTemp";
            this.panLookTemp.Size = new System.Drawing.Size(322, 259);
            this.panLookTemp.TabIndex = 3;
            this.panLookTemp.Visible = false;
            // 
            // labLook
            // 
            this.labLook.AutoSize = true;
            this.labLook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labLook.Location = new System.Drawing.Point(3, 46);
            this.labLook.Name = "labLook";
            this.labLook.Size = new System.Drawing.Size(69, 21);
            this.labLook.TabIndex = 4;
            this.labLook.Text = "Figures:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(316, 186);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panLookTemp);
            this.Controls.Add(this.punAdd);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainPanel.ResumeLayout(false);
            this.punAdd.ResumeLayout(false);
            this.punAdd.PerformLayout();
            this.panUnifAll.ResumeLayout(false);
            this.panRadius.ResumeLayout(false);
            this.panRadius.PerformLayout();
            this.pan4.ResumeLayout(false);
            this.pan4.PerformLayout();
            this.pan2.ResumeLayout(false);
            this.pan2.PerformLayout();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.pan3.ResumeLayout(false);
            this.pan3.PerformLayout();
            this.panLookTemp.ResumeLayout(false);
            this.panLookTemp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btmSave;
        private System.Windows.Forms.Button btmLoad;
        private System.Windows.Forms.Button btmAdd;
        private System.Windows.Forms.Button btmLook;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Panel punAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listFigChoose;
        private System.Windows.Forms.Label LabelFigChoose;
        private System.Windows.Forms.Button btnFigChoose;
        private System.Windows.Forms.Panel pan1;
        private System.Windows.Forms.Label labSegment;
        private System.Windows.Forms.Label labUnif1;
        private System.Windows.Forms.Panel panRadius;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label labRadius;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pan4;
        private System.Windows.Forms.TextBox textBoxY4;
        private System.Windows.Forms.Label labY4;
        private System.Windows.Forms.TextBox textBoxX4;
        private System.Windows.Forms.Label labX4;
        private System.Windows.Forms.Label labUnif4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pan3;
        private System.Windows.Forms.TextBox textBoxY3;
        private System.Windows.Forms.Label labY3;
        private System.Windows.Forms.TextBox textBoxX3;
        private System.Windows.Forms.Label labX3;
        private System.Windows.Forms.Label labUnif3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pan2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.Label labY2;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label labX2;
        private System.Windows.Forms.Label labUnif2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.Label labY1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label labX1;
        private System.Windows.Forms.Panel panUnifAll;
        private System.Windows.Forms.Button btnClearUnif;
        private System.Windows.Forms.Button btmClear;
        private System.Windows.Forms.Panel panLookTemp;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labLook;
    }
}

