namespace Topic_14._5___clicker_game
{
    partial class FormClicker
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
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnUpgrade1 = new System.Windows.Forms.Button();
            this.btnUpgrade2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.upgrades = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnChickenLay = new System.Windows.Forms.Button();
            this.btnCoinLay = new System.Windows.Forms.Button();
            this.lblRP = new System.Windows.Forms.Label();
            this.imgBread = new System.Windows.Forms.PictureBox();
            this.radChicken = new System.Windows.Forms.RadioButton();
            this.radCoin = new System.Windows.Forms.RadioButton();
            this.radBread = new System.Windows.Forms.RadioButton();
            this.upgrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBread)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(125, 33);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(40, 13);
            this.lblPoints.TabIndex = 1;
            this.lblPoints.Text = "bread: ";
            // 
            // btnUpgrade1
            // 
            this.btnUpgrade1.Enabled = false;
            this.btnUpgrade1.Location = new System.Drawing.Point(12, 41);
            this.btnUpgrade1.Name = "btnUpgrade1";
            this.btnUpgrade1.Size = new System.Drawing.Size(75, 23);
            this.btnUpgrade1.TabIndex = 2;
            this.btnUpgrade1.Text = "2x bread";
            this.btnUpgrade1.UseVisualStyleBackColor = true;
            this.btnUpgrade1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpgrade2
            // 
            this.btnUpgrade2.Enabled = false;
            this.btnUpgrade2.Location = new System.Drawing.Point(12, 97);
            this.btnUpgrade2.Name = "btnUpgrade2";
            this.btnUpgrade2.Size = new System.Drawing.Size(75, 23);
            this.btnUpgrade2.TabIndex = 3;
            this.btnUpgrade2.Text = "4x bread";
            this.btnUpgrade2.UseVisualStyleBackColor = true;
            this.btnUpgrade2.Click += new System.EventHandler(this.upgrade2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(382, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // upgrades
            // 
            this.upgrades.Controls.Add(this.btnReset);
            this.upgrades.Controls.Add(this.btnUpgrade1);
            this.upgrades.Controls.Add(this.btnUpgrade2);
            this.upgrades.Location = new System.Drawing.Point(555, 33);
            this.upgrades.Name = "upgrades";
            this.upgrades.Size = new System.Drawing.Size(101, 203);
            this.upgrades.TabIndex = 6;
            this.upgrades.TabStop = false;
            this.upgrades.Text = "Bread Multiplyers";
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(12, 151);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnChickenLay
            // 
            this.btnChickenLay.Enabled = false;
            this.btnChickenLay.Location = new System.Drawing.Point(147, 415);
            this.btnChickenLay.Name = "btnChickenLay";
            this.btnChickenLay.Size = new System.Drawing.Size(75, 23);
            this.btnChickenLay.TabIndex = 8;
            this.btnChickenLay.Text = "Chicken";
            this.btnChickenLay.UseVisualStyleBackColor = true;
            this.btnChickenLay.Click += new System.EventHandler(this.btnChickenLay_Click);
            // 
            // btnCoinLay
            // 
            this.btnCoinLay.Enabled = false;
            this.btnCoinLay.Location = new System.Drawing.Point(228, 415);
            this.btnCoinLay.Name = "btnCoinLay";
            this.btnCoinLay.Size = new System.Drawing.Size(75, 23);
            this.btnCoinLay.TabIndex = 9;
            this.btnCoinLay.Text = "Coin";
            this.btnCoinLay.UseVisualStyleBackColor = true;
            this.btnCoinLay.Click += new System.EventHandler(this.btnCoinLay_Click);
            // 
            // lblRP
            // 
            this.lblRP.AutoSize = true;
            this.lblRP.Location = new System.Drawing.Point(12, 420);
            this.lblRP.Name = "lblRP";
            this.lblRP.Size = new System.Drawing.Size(34, 13);
            this.lblRP.TabIndex = 10;
            this.lblRP.Text = "RP: 0";
            // 
            // imgBread
            // 
            this.imgBread.Image = global::Topic_14._5___clicker_game.Properties.Resources.WhiteBread;
            this.imgBread.Location = new System.Drawing.Point(12, 52);
            this.imgBread.Name = "imgBread";
            this.imgBread.Size = new System.Drawing.Size(285, 213);
            this.imgBread.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBread.TabIndex = 0;
            this.imgBread.TabStop = false;
            this.imgBread.Click += new System.EventHandler(this.imgBread_Click);
            this.imgBread.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgBread_MouseDown);
            // 
            // radChicken
            // 
            this.radChicken.AutoSize = true;
            this.radChicken.Location = new System.Drawing.Point(153, 417);
            this.radChicken.Name = "radChicken";
            this.radChicken.Size = new System.Drawing.Size(64, 17);
            this.radChicken.TabIndex = 11;
            this.radChicken.TabStop = true;
            this.radChicken.Text = "Chicken";
            this.radChicken.UseVisualStyleBackColor = true;
            this.radChicken.Visible = false;
            this.radChicken.CheckedChanged += new System.EventHandler(this.radChicken_CheckedChanged);
            // 
            // radCoin
            // 
            this.radCoin.AutoSize = true;
            this.radCoin.Location = new System.Drawing.Point(242, 417);
            this.radCoin.Name = "radCoin";
            this.radCoin.Size = new System.Drawing.Size(45, 17);
            this.radCoin.TabIndex = 12;
            this.radCoin.TabStop = true;
            this.radCoin.Text = "coin";
            this.radCoin.UseVisualStyleBackColor = true;
            this.radCoin.Visible = false;
            this.radCoin.CheckedChanged += new System.EventHandler(this.radCoin_CheckedChanged);
            // 
            // radBread
            // 
            this.radBread.AutoSize = true;
            this.radBread.Location = new System.Drawing.Point(76, 418);
            this.radBread.Name = "radBread";
            this.radBread.Size = new System.Drawing.Size(53, 17);
            this.radBread.TabIndex = 13;
            this.radBread.TabStop = true;
            this.radBread.Text = "Bread";
            this.radBread.UseVisualStyleBackColor = true;
            this.radBread.CheckedChanged += new System.EventHandler(this.radBread_CheckedChanged);
            // 
            // FormClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.radBread);
            this.Controls.Add(this.radCoin);
            this.Controls.Add(this.radChicken);
            this.Controls.Add(this.lblRP);
            this.Controls.Add(this.btnCoinLay);
            this.Controls.Add(this.btnChickenLay);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.upgrades);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.imgBread);
            this.Name = "FormClicker";
            this.Text = "Clicker Game";
            this.upgrades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBread)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBread;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnUpgrade1;
        private System.Windows.Forms.Button btnUpgrade2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox upgrades;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnChickenLay;
        private System.Windows.Forms.Button btnCoinLay;
        private System.Windows.Forms.Label lblRP;
        private System.Windows.Forms.RadioButton radChicken;
        private System.Windows.Forms.RadioButton radCoin;
        private System.Windows.Forms.RadioButton radBread;
    }
}

