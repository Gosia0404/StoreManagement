namespace StoreManagement.Views
{
    partial class ClientOrdersView
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
            this.button_logout = new System.Windows.Forms.Button();
            this.button_my_orders = new System.Windows.Forms.Button();
            this.button_cart = new System.Windows.Forms.Button();
            this.button_shopping = new System.Windows.Forms.Button();
            this.splitter_client_products = new System.Windows.Forms.Splitter();
            this.label_orders = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.listBox_orders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.Location = new System.Drawing.Point(80, 471);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(223, 59);
            this.button_logout.TabIndex = 21;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = false;
            // 
            // button_my_orders
            // 
            this.button_my_orders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_my_orders.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_my_orders.Location = new System.Drawing.Point(80, 393);
            this.button_my_orders.Name = "button_my_orders";
            this.button_my_orders.Size = new System.Drawing.Size(223, 59);
            this.button_my_orders.TabIndex = 20;
            this.button_my_orders.Text = "MY ORDERS";
            this.button_my_orders.UseVisualStyleBackColor = false;
            // 
            // button_cart
            // 
            this.button_cart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_cart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cart.Location = new System.Drawing.Point(80, 106);
            this.button_cart.Name = "button_cart";
            this.button_cart.Size = new System.Drawing.Size(223, 59);
            this.button_cart.TabIndex = 19;
            this.button_cart.Text = "CART";
            this.button_cart.UseVisualStyleBackColor = false;
            // 
            // button_shopping
            // 
            this.button_shopping.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_shopping.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_shopping.Location = new System.Drawing.Point(80, 27);
            this.button_shopping.Name = "button_shopping";
            this.button_shopping.Size = new System.Drawing.Size(223, 61);
            this.button_shopping.TabIndex = 18;
            this.button_shopping.Text = "SHOPPING";
            this.button_shopping.UseVisualStyleBackColor = false;
            // 
            // splitter_client_products
            // 
            this.splitter_client_products.BackColor = System.Drawing.Color.Orchid;
            this.splitter_client_products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter_client_products.Location = new System.Drawing.Point(0, 0);
            this.splitter_client_products.Name = "splitter_client_products";
            this.splitter_client_products.Size = new System.Drawing.Size(365, 562);
            this.splitter_client_products.TabIndex = 17;
            this.splitter_client_products.TabStop = false;
            // 
            // label_orders
            // 
            this.label_orders.AutoSize = true;
            this.label_orders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_orders.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_orders.ForeColor = System.Drawing.Color.Black;
            this.label_orders.Location = new System.Drawing.Point(627, 41);
            this.label_orders.Name = "label_orders";
            this.label_orders.Size = new System.Drawing.Size(223, 47);
            this.label_orders.TabIndex = 25;
            this.label_orders.Text = "MY ORDERS";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Orchid;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_cancel.Location = new System.Drawing.Point(627, 473);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(223, 57);
            this.button_cancel.TabIndex = 23;
            this.button_cancel.Text = "CANCEL ORDER";
            this.button_cancel.UseVisualStyleBackColor = false;
            // 
            // listBox_orders
            // 
            this.listBox_orders.FormattingEnabled = true;
            this.listBox_orders.Location = new System.Drawing.Point(390, 106);
            this.listBox_orders.Name = "listBox_orders";
            this.listBox_orders.Size = new System.Drawing.Size(689, 290);
            this.listBox_orders.TabIndex = 22;
            // 
            // ClientOrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.label_orders);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.listBox_orders);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_my_orders);
            this.Controls.Add(this.button_cart);
            this.Controls.Add(this.button_shopping);
            this.Controls.Add(this.splitter_client_products);
            this.Name = "ClientOrdersView";
            this.Text = "ClientOrdersView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_my_orders;
        private System.Windows.Forms.Button button_cart;
        private System.Windows.Forms.Button button_shopping;
        private System.Windows.Forms.Splitter splitter_client_products;
        private System.Windows.Forms.Label label_orders;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ListBox listBox_orders;
    }
}