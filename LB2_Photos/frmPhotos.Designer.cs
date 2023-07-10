namespace LB2_Photos
{
    partial class frmPhotos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.gbFrame = new System.Windows.Forms.GroupBox();
            this.radFramed = new System.Windows.Forms.RadioButton();
            this.radMatted = new System.Windows.Forms.RadioButton();
            this.radUnframed = new System.Windows.Forms.RadioButton();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.radWhite = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.gbMaterial = new System.Windows.Forms.GroupBox();
            this.radGold = new System.Windows.Forms.RadioButton();
            this.radSilver = new System.Windows.Forms.RadioButton();
            this.radSteel = new System.Windows.Forms.RadioButton();
            this.radOak = new System.Windows.Forms.RadioButton();
            this.radPine = new System.Windows.Forms.RadioButton();
            this.gbStyle = new System.Windows.Forms.GroupBox();
            this.radEclectic = new System.Windows.Forms.RadioButton();
            this.radVintage = new System.Windows.Forms.RadioButton();
            this.radAntique = new System.Windows.Forms.RadioButton();
            this.radModern = new System.Windows.Forms.RadioButton();
            this.radSimple = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblPictureStats = new System.Windows.Forms.Label();
            this.gbFrame.SuspendLayout();
            this.gbColor.SuspendLayout();
            this.gbMaterial.SuspendLayout();
            this.gbStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWidth
            // 
            this.lblWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblWidth.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(57, 38);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(150, 32);
            this.lblWidth.TabIndex = 8;
            this.lblWidth.Text = "Width (in)";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeight
            // 
            this.lblHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblHeight.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(57, 107);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(150, 32);
            this.lblHeight.TabIndex = 9;
            this.lblHeight.Text = "Height (in)";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(250, 38);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(148, 38);
            this.txtWidth.TabIndex = 0;
            this.txtWidth.Tag = "width";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(250, 101);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(148, 38);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.Tag = "height";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbFrame
            // 
            this.gbFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbFrame.Controls.Add(this.radFramed);
            this.gbFrame.Controls.Add(this.radMatted);
            this.gbFrame.Controls.Add(this.radUnframed);
            this.gbFrame.Location = new System.Drawing.Point(419, 12);
            this.gbFrame.Name = "gbFrame";
            this.gbFrame.Size = new System.Drawing.Size(175, 141);
            this.gbFrame.TabIndex = 4;
            this.gbFrame.TabStop = false;
            this.gbFrame.Text = "Frame";
            // 
            // radFramed
            // 
            this.radFramed.AutoSize = true;
            this.radFramed.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFramed.Location = new System.Drawing.Point(23, 97);
            this.radFramed.Name = "radFramed";
            this.radFramed.Size = new System.Drawing.Size(113, 35);
            this.radFramed.TabIndex = 2;
            this.radFramed.TabStop = true;
            this.radFramed.Text = "Framed";
            this.radFramed.UseVisualStyleBackColor = true;
            // 
            // radMatted
            // 
            this.radMatted.AutoSize = true;
            this.radMatted.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMatted.Location = new System.Drawing.Point(23, 56);
            this.radMatted.Name = "radMatted";
            this.radMatted.Size = new System.Drawing.Size(102, 35);
            this.radMatted.TabIndex = 1;
            this.radMatted.TabStop = true;
            this.radMatted.Text = "Matted";
            this.radMatted.UseVisualStyleBackColor = true;
            // 
            // radUnframed
            // 
            this.radUnframed.AutoSize = true;
            this.radUnframed.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUnframed.Location = new System.Drawing.Point(23, 20);
            this.radUnframed.Name = "radUnframed";
            this.radUnframed.Size = new System.Drawing.Size(136, 35);
            this.radUnframed.TabIndex = 0;
            this.radUnframed.TabStop = true;
            this.radUnframed.Text = "Unframed";
            this.radUnframed.UseVisualStyleBackColor = true;
            // 
            // gbColor
            // 
            this.gbColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbColor.Controls.Add(this.radWhite);
            this.gbColor.Controls.Add(this.radBlue);
            this.gbColor.Controls.Add(this.radGreen);
            this.gbColor.Controls.Add(this.radRed);
            this.gbColor.Controls.Add(this.radBlack);
            this.gbColor.Location = new System.Drawing.Point(63, 159);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(144, 233);
            this.gbColor.TabIndex = 3;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color";
            // 
            // radWhite
            // 
            this.radWhite.AutoSize = true;
            this.radWhite.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWhite.Location = new System.Drawing.Point(19, 162);
            this.radWhite.Name = "radWhite";
            this.radWhite.Size = new System.Drawing.Size(92, 35);
            this.radWhite.TabIndex = 4;
            this.radWhite.TabStop = true;
            this.radWhite.Text = "White";
            this.radWhite.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlue.Location = new System.Drawing.Point(19, 128);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(80, 35);
            this.radBlue.TabIndex = 3;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen.Location = new System.Drawing.Point(19, 94);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(96, 35);
            this.radGreen.TabIndex = 2;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.Location = new System.Drawing.Point(19, 56);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(74, 35);
            this.radRed.TabIndex = 1;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.Location = new System.Drawing.Point(19, 20);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(90, 35);
            this.radBlack.TabIndex = 0;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            // 
            // gbMaterial
            // 
            this.gbMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbMaterial.Controls.Add(this.radGold);
            this.gbMaterial.Controls.Add(this.radSilver);
            this.gbMaterial.Controls.Add(this.radSteel);
            this.gbMaterial.Controls.Add(this.radOak);
            this.gbMaterial.Controls.Add(this.radPine);
            this.gbMaterial.Location = new System.Drawing.Point(254, 159);
            this.gbMaterial.Name = "gbMaterial";
            this.gbMaterial.Size = new System.Drawing.Size(144, 233);
            this.gbMaterial.TabIndex = 5;
            this.gbMaterial.TabStop = false;
            this.gbMaterial.Text = "Material";
            // 
            // radGold
            // 
            this.radGold.AutoSize = true;
            this.radGold.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGold.Location = new System.Drawing.Point(19, 162);
            this.radGold.Name = "radGold";
            this.radGold.Size = new System.Drawing.Size(83, 35);
            this.radGold.TabIndex = 4;
            this.radGold.TabStop = true;
            this.radGold.Text = "Gold";
            this.radGold.UseVisualStyleBackColor = true;
            // 
            // radSilver
            // 
            this.radSilver.AutoSize = true;
            this.radSilver.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSilver.Location = new System.Drawing.Point(19, 128);
            this.radSilver.Name = "radSilver";
            this.radSilver.Size = new System.Drawing.Size(92, 35);
            this.radSilver.TabIndex = 3;
            this.radSilver.TabStop = true;
            this.radSilver.Text = "Silver";
            this.radSilver.UseVisualStyleBackColor = true;
            // 
            // radSteel
            // 
            this.radSteel.AutoSize = true;
            this.radSteel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSteel.Location = new System.Drawing.Point(19, 94);
            this.radSteel.Name = "radSteel";
            this.radSteel.Size = new System.Drawing.Size(84, 35);
            this.radSteel.TabIndex = 2;
            this.radSteel.TabStop = true;
            this.radSteel.Text = "Steel";
            this.radSteel.UseVisualStyleBackColor = true;
            // 
            // radOak
            // 
            this.radOak.AutoSize = true;
            this.radOak.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOak.Location = new System.Drawing.Point(19, 56);
            this.radOak.Name = "radOak";
            this.radOak.Size = new System.Drawing.Size(73, 35);
            this.radOak.TabIndex = 1;
            this.radOak.TabStop = true;
            this.radOak.Text = "Oak";
            this.radOak.UseVisualStyleBackColor = true;
            // 
            // radPine
            // 
            this.radPine.AutoSize = true;
            this.radPine.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPine.Location = new System.Drawing.Point(19, 20);
            this.radPine.Name = "radPine";
            this.radPine.Size = new System.Drawing.Size(79, 35);
            this.radPine.TabIndex = 0;
            this.radPine.TabStop = true;
            this.radPine.Text = "Pine";
            this.radPine.UseVisualStyleBackColor = true;
            // 
            // gbStyle
            // 
            this.gbStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbStyle.Controls.Add(this.radEclectic);
            this.gbStyle.Controls.Add(this.radVintage);
            this.gbStyle.Controls.Add(this.radAntique);
            this.gbStyle.Controls.Add(this.radModern);
            this.gbStyle.Controls.Add(this.radSimple);
            this.gbStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStyle.Location = new System.Drawing.Point(442, 159);
            this.gbStyle.Name = "gbStyle";
            this.gbStyle.Size = new System.Drawing.Size(144, 233);
            this.gbStyle.TabIndex = 5;
            this.gbStyle.TabStop = false;
            this.gbStyle.Text = "Style";
            // 
            // radEclectic
            // 
            this.radEclectic.AutoSize = true;
            this.radEclectic.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEclectic.Location = new System.Drawing.Point(19, 162);
            this.radEclectic.Name = "radEclectic";
            this.radEclectic.Size = new System.Drawing.Size(114, 35);
            this.radEclectic.TabIndex = 3;
            this.radEclectic.TabStop = true;
            this.radEclectic.Text = "Eclectic";
            this.radEclectic.UseVisualStyleBackColor = true;
            // 
            // radVintage
            // 
            this.radVintage.AutoSize = true;
            this.radVintage.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVintage.Location = new System.Drawing.Point(19, 128);
            this.radVintage.Name = "radVintage";
            this.radVintage.Size = new System.Drawing.Size(112, 35);
            this.radVintage.TabIndex = 2;
            this.radVintage.TabStop = true;
            this.radVintage.Text = "Vintage";
            this.radVintage.UseVisualStyleBackColor = true;
            // 
            // radAntique
            // 
            this.radAntique.AutoSize = true;
            this.radAntique.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAntique.Location = new System.Drawing.Point(19, 94);
            this.radAntique.Name = "radAntique";
            this.radAntique.Size = new System.Drawing.Size(115, 35);
            this.radAntique.TabIndex = 2;
            this.radAntique.TabStop = true;
            this.radAntique.Text = "Antique";
            this.radAntique.UseVisualStyleBackColor = true;
            // 
            // radModern
            // 
            this.radModern.AutoSize = true;
            this.radModern.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radModern.Location = new System.Drawing.Point(19, 56);
            this.radModern.Name = "radModern";
            this.radModern.Size = new System.Drawing.Size(113, 35);
            this.radModern.TabIndex = 1;
            this.radModern.TabStop = true;
            this.radModern.Text = "Modern";
            this.radModern.UseVisualStyleBackColor = true;
            // 
            // radSimple
            // 
            this.radSimple.AutoSize = true;
            this.radSimple.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSimple.Location = new System.Drawing.Point(19, 20);
            this.radSimple.Name = "radSimple";
            this.radSimple.Size = new System.Drawing.Size(105, 35);
            this.radSimple.TabIndex = 0;
            this.radSimple.TabStop = true;
            this.radSimple.Text = "Simple";
            this.radSimple.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(63, 412);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 49);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(63, 490);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 49);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(63, 568);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalCost.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(230, 415);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(356, 46);
            this.lblTotalCost.TabIndex = 6;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPictureStats
            // 
            this.lblPictureStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPictureStats.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPictureStats.Location = new System.Drawing.Point(226, 568);
            this.lblPictureStats.Name = "lblPictureStats";
            this.lblPictureStats.Size = new System.Drawing.Size(360, 49);
            this.lblPictureStats.TabIndex = 7;
            this.lblPictureStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPhotos
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(674, 652);
            this.Controls.Add(this.lblPictureStats);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbStyle);
            this.Controls.Add(this.gbMaterial);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.gbFrame);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Name = "frmPhotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWD1100 -- Chapters 14-16 Photos App";
            this.gbFrame.ResumeLayout(false);
            this.gbFrame.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.gbMaterial.ResumeLayout(false);
            this.gbMaterial.PerformLayout();
            this.gbStyle.ResumeLayout(false);
            this.gbStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.GroupBox gbFrame;
        private System.Windows.Forms.RadioButton radFramed;
        private System.Windows.Forms.RadioButton radMatted;
        private System.Windows.Forms.RadioButton radUnframed;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.RadioButton radWhite;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.GroupBox gbMaterial;
        private System.Windows.Forms.RadioButton radGold;
        private System.Windows.Forms.RadioButton radSilver;
        private System.Windows.Forms.RadioButton radSteel;
        private System.Windows.Forms.RadioButton radOak;
        private System.Windows.Forms.RadioButton radPine;
        private System.Windows.Forms.GroupBox gbStyle;
        private System.Windows.Forms.RadioButton radEclectic;
        private System.Windows.Forms.RadioButton radVintage;
        private System.Windows.Forms.RadioButton radAntique;
        private System.Windows.Forms.RadioButton radModern;
        private System.Windows.Forms.RadioButton radSimple;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblPictureStats;
    }
}

