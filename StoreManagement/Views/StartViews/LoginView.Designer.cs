namespace StoreManagement.Views.StartViews
{
    partial class LoginView
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitter_login = new System.Windows.Forms.Splitter();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label_username = new System.Windows.Forms.Label();
            this.button_log_in = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.maskedTextBox_password = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // splitter_login
            // 
            this.splitter_login.BackColor = System.Drawing.Color.Orchid;
            this.splitter_login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter_login.Location = new System.Drawing.Point(0, 0);
            this.splitter_login.Name = "splitter_login";
            this.splitter_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitter_login.Size = new System.Drawing.Size(365, 565);
            this.splitter_login.TabIndex = 0;
            this.splitter_login.TabStop = false;
            this.splitter_login.UseWaitCursor = true;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(621, 165);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(238, 20);
            this.textBox_username.TabIndex = 1;
            //this.textBox_username.TextChanged += new System.EventHandler(this.textBox_nazwa_uzytkownika_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_username.Location = new System.Drawing.Point(476, 165);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(91, 20);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "USERNAME";
            // 
            // button_log_in
            // 
            this.button_log_in.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_log_in.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_log_in.Location = new System.Drawing.Point(69, 178);
            this.button_log_in.Name = "button_log_in";
            this.button_log_in.Size = new System.Drawing.Size(223, 61);
            this.button_log_in.TabIndex = 4;
            this.button_log_in.Text = "LOG IN";
            this.button_log_in.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_create.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_create.Location = new System.Drawing.Point(69, 318);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(223, 61);
            this.button_create.TabIndex = 5;
            this.button_create.Text = "CREATE ACCOUNT";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_login.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_login.ForeColor = System.Drawing.Color.Black;
            this.label_login.Location = new System.Drawing.Point(613, 57);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(128, 47);
            this.label_login.TabIndex = 6;
            this.label_login.Text = "LOGIN";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_password.Location = new System.Drawing.Point(476, 218);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(98, 21);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "PASSWORD";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Orchid;
            this.button_login.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_login.ForeColor = System.Drawing.Color.Black;
            this.button_login.Location = new System.Drawing.Point(561, 318);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(223, 60);
            this.button_login.TabIndex = 9;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox_password
            // 
            this.maskedTextBox_password.Location = new System.Drawing.Point(621, 219);
            this.maskedTextBox_password.Name = "maskedTextBox_password";
            this.maskedTextBox_password.Size = new System.Drawing.Size(238, 20);
            this.maskedTextBox_password.TabIndex = 10;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.maskedTextBox_password);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.button_log_in);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.splitter_login);
            this.Name = "LoginView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter_login;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_log_in;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_password;
    }
}

