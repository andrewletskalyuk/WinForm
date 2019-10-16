namespace Using_Text_Box
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbpassword);
            this.panel1.Controls.Add(this.tbLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 138);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вхід";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbpassword
            // 
            this.tbpassword.AutoCompleteCustomSource.AddRange(new string[] {
            "111",
            "222",
            "333"});
            this.tbpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbpassword.Location = new System.Drawing.Point(28, 58);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(372, 20);
            this.tbpassword.TabIndex = 1;
            this.tbpassword.Leave += new System.EventHandler(this.tbpassword_Leave);
            this.tbpassword.MouseHover += new System.EventHandler(this.tbpassword_MouseHover);
            // 
            // tbLogin
            // 
            this.tbLogin.AutoCompleteCustomSource.AddRange(new string[] {
            "admin",
            "user",
            "any",
            "bill"});
            this.tbLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbLogin.Location = new System.Drawing.Point(28, 13);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(372, 20);
            this.tbLogin.TabIndex = 0;
            this.tbLogin.Leave += new System.EventHandler(this.tbLogin_Leave);
            this.tbLogin.MouseHover += new System.EventHandler(this.tbLogin_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "підказка";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 257);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

