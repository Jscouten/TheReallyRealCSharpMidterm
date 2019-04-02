namespace CSharpMidterm
{
    partial class ATMPIN
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
            this.ATMPIN_OKButton_SubmitUsernameAndPIN = new System.Windows.Forms.Button();
            this.PleaseInsertUsernameandPIN = new System.Windows.Forms.Label();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PINLabel = new System.Windows.Forms.Label();
            this.PINText = new System.Windows.Forms.TextBox();
            this.OutputTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ATMPIN_OKButton_SubmitUsernameAndPIN
            // 
            this.ATMPIN_OKButton_SubmitUsernameAndPIN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ATMPIN_OKButton_SubmitUsernameAndPIN.Location = new System.Drawing.Point(326, 222);
            this.ATMPIN_OKButton_SubmitUsernameAndPIN.Name = "ATMPIN_OKButton_SubmitUsernameAndPIN";
            this.ATMPIN_OKButton_SubmitUsernameAndPIN.Size = new System.Drawing.Size(56, 22);
            this.ATMPIN_OKButton_SubmitUsernameAndPIN.TabIndex = 2;
            this.ATMPIN_OKButton_SubmitUsernameAndPIN.Text = "OK";
            this.ATMPIN_OKButton_SubmitUsernameAndPIN.UseVisualStyleBackColor = true;
            this.ATMPIN_OKButton_SubmitUsernameAndPIN.Click += new System.EventHandler(this.button1_Click);
            // 
            // PleaseInsertUsernameandPIN
            // 
            this.PleaseInsertUsernameandPIN.AutoSize = true;
            this.PleaseInsertUsernameandPIN.Location = new System.Drawing.Point(272, 139);
            this.PleaseInsertUsernameandPIN.Name = "PleaseInsertUsernameandPIN";
            this.PleaseInsertUsernameandPIN.Size = new System.Drawing.Size(164, 13);
            this.PleaseInsertUsernameandPIN.TabIndex = 1;
            this.PleaseInsertUsernameandPIN.Text = "Please Insert Username and PIN:";
            this.PleaseInsertUsernameandPIN.Click += new System.EventHandler(this.label1_Click);
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(306, 165);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(100, 20);
            this.UsernameText.TabIndex = 0;
            this.UsernameText.TextChanged += new System.EventHandler(this.UsernameText_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(242, 168);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username:";
            // 
            // PINLabel
            // 
            this.PINLabel.AutoSize = true;
            this.PINLabel.Location = new System.Drawing.Point(272, 199);
            this.PINLabel.Name = "PINLabel";
            this.PINLabel.Size = new System.Drawing.Size(28, 13);
            this.PINLabel.TabIndex = 4;
            this.PINLabel.Text = "PIN:";
            // 
            // PINText
            // 
            this.PINText.Location = new System.Drawing.Point(306, 196);
            this.PINText.Name = "PINText";
            this.PINText.Size = new System.Drawing.Size(100, 20);
            this.PINText.TabIndex = 1;
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Location = new System.Drawing.Point(107, 87);
            this.OutputTextbox.Multiline = true;
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.Size = new System.Drawing.Size(517, 20);
            this.OutputTextbox.TabIndex = 5;
            // 
            // ATMPIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.PINText);
            this.Controls.Add(this.PINLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.PleaseInsertUsernameandPIN);
            this.Controls.Add(this.ATMPIN_OKButton_SubmitUsernameAndPIN);
            this.Name = "ATMPIN";
            this.Text = "ATMPIN";
            this.Load += new System.EventHandler(this.ATMPIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ATMPIN_OKButton_SubmitUsernameAndPIN;
        private System.Windows.Forms.Label PleaseInsertUsernameandPIN;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PINLabel;
        private System.Windows.Forms.TextBox PINText;
        private System.Windows.Forms.TextBox OutputTextbox;
    }
}

