namespace EasyBank
{
    partial class MainForm
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
            this.labelDeposit1 = new System.Windows.Forms.Label();
            this.labelDeposit3 = new System.Windows.Forms.Label();
            this.labelDeposit2 = new System.Windows.Forms.Label();
            this.buttonAddInvestor = new System.Windows.Forms.Button();
            this.labelHelp = new System.Windows.Forms.Label();
            this.labelShowInvestors = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDeposit1
            // 
            this.labelDeposit1.BackColor = System.Drawing.Color.Transparent;
            this.labelDeposit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDeposit1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeposit1.Location = new System.Drawing.Point(477, 15);
            this.labelDeposit1.Name = "labelDeposit1";
            this.labelDeposit1.Size = new System.Drawing.Size(303, 79);
            this.labelDeposit1.TabIndex = 0;
            this.labelDeposit1.Text = "Депозит1";
            this.labelDeposit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDeposit3
            // 
            this.labelDeposit3.BackColor = System.Drawing.Color.Transparent;
            this.labelDeposit3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDeposit3.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeposit3.Location = new System.Drawing.Point(477, 215);
            this.labelDeposit3.Name = "labelDeposit3";
            this.labelDeposit3.Size = new System.Drawing.Size(303, 79);
            this.labelDeposit3.TabIndex = 1;
            this.labelDeposit3.Text = "Депозит3";
            this.labelDeposit3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDeposit2
            // 
            this.labelDeposit2.BackColor = System.Drawing.Color.Transparent;
            this.labelDeposit2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDeposit2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeposit2.Location = new System.Drawing.Point(477, 120);
            this.labelDeposit2.Name = "labelDeposit2";
            this.labelDeposit2.Size = new System.Drawing.Size(303, 79);
            this.labelDeposit2.TabIndex = 2;
            this.labelDeposit2.Text = "Депозит2";
            this.labelDeposit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddInvestor
            // 
            this.buttonAddInvestor.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddInvestor.Location = new System.Drawing.Point(592, 327);
            this.buttonAddInvestor.Name = "buttonAddInvestor";
            this.buttonAddInvestor.Size = new System.Drawing.Size(75, 23);
            this.buttonAddInvestor.TabIndex = 3;
            this.buttonAddInvestor.Text = "Выбрать";
            this.buttonAddInvestor.UseVisualStyleBackColor = false;
            // 
            // labelHelp
            // 
            this.labelHelp.BackColor = System.Drawing.Color.Transparent;
            this.labelHelp.Image = global::EasyBank.Properties.Resources.help;
            this.labelHelp.Location = new System.Drawing.Point(12, 9);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(43, 34);
            this.labelHelp.TabIndex = 4;
            // 
            // labelShowInvestors
            // 
            this.labelShowInvestors.BackColor = System.Drawing.Color.Transparent;
            this.labelShowInvestors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelShowInvestors.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowInvestors.Location = new System.Drawing.Point(95, 199);
            this.labelShowInvestors.Name = "labelShowInvestors";
            this.labelShowInvestors.Size = new System.Drawing.Size(247, 79);
            this.labelShowInvestors.TabIndex = 6;
            this.labelShowInvestors.Text = "Активные вклады";
            this.labelShowInvestors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShowInvestors.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Image = global::EasyBank.Properties.Resources.nameIMG;
            this.labelName.Location = new System.Drawing.Point(12, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(459, 128);
            this.labelName.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EasyBank.Properties.Resources.mainFon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 442);
            this.Controls.Add(this.labelShowInvestors);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.buttonAddInvestor);
            this.Controls.Add(this.labelDeposit2);
            this.Controls.Add(this.labelDeposit3);
            this.Controls.Add(this.labelDeposit1);
            this.Name = "MainForm";
            this.Text = "Easy Bank";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDeposit1;
        private System.Windows.Forms.Label labelDeposit3;
        private System.Windows.Forms.Label labelDeposit2;
        private System.Windows.Forms.Button buttonAddInvestor;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelShowInvestors;
    }
}