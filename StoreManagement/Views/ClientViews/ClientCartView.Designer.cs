namespace StoreManagement.Views
{
    partial class ClientCartView
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
            this.label_price = new System.Windows.Forms.Label();
            this.label_cart = new System.Windows.Forms.Label();
            this.button_purchase = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.listBox_cart = new System.Windows.Forms.ListBox();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_my_orders = new System.Windows.Forms.Button();
            this.button_cart = new System.Windows.Forms.Button();
            this.button_shopping = new System.Windows.Forms.Button();
            this.splitter_client_products = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.BackColor = System.Drawing.Color.White;
            this.label_price.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_price.Location = new System.Drawing.Point(1014, 407);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(71, 30);
            this.label_price.TabIndex = 36;
            this.label_price.Text = "PRICE";
            // 
            // label_cart
            // 
            this.label_cart.AutoSize = true;
            this.label_cart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_cart.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cart.ForeColor = System.Drawing.Color.Black;
            this.label_cart.Location = new System.Drawing.Point(692, 41);
            this.label_cart.Name = "label_cart";
            this.label_cart.Size = new System.Drawing.Size(110, 47);
            this.label_cart.TabIndex = 35;
            this.label_cart.Text = "CART";
            // 
            // button_purchase
            // 
            this.button_purchase.BackColor = System.Drawing.Color.Orchid;
            this.button_purchase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_purchase.Location = new System.Drawing.Point(756, 473);
            this.button_purchase.Name = "button_purchase";
            this.button_purchase.Size = new System.Drawing.Size(223, 57);
            this.button_purchase.TabIndex = 34;
            this.button_purchase.Text = "PURCHASE";
            this.button_purchase.UseVisualStyleBackColor = false;
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.Orchid;
            this.button_remove.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_remove.Location = new System.Drawing.Point(509, 473);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(223, 57);
            this.button_remove.TabIndex = 33;
            this.button_remove.Text = "REMOVE PRODUCT";
            this.button_remove.UseVisualStyleBackColor = false;
            // 
            // listBox_cart
            // 
            this.listBox_cart.FormattingEnabled = true;
            this.listBox_cart.Location = new System.Drawing.Point(396, 106);
            this.listBox_cart.Name = "listBox_cart";
            this.listBox_cart.Size = new System.Drawing.Size(689, 290);
            this.listBox_cart.TabIndex = 32;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.Location = new System.Drawing.Point(86, 471);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(223, 59);
            this.button_logout.TabIndex = 31;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = false;
            // 
            // button_my_orders
            // 
            this.button_my_orders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_my_orders.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_my_orders.Location = new System.Drawing.Point(86, 393);
            this.button_my_orders.Name = "button_my_orders";
            this.button_my_orders.Size = new System.Drawing.Size(223, 59);
            this.button_my_orders.TabIndex = 30;
            this.button_my_orders.Text = "MY ORDERS";
            this.button_my_orders.UseVisualStyleBackColor = false;
            // 
            // button_cart
            // 
            this.button_cart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_cart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cart.Location = new System.Drawing.Point(86, 106);
            this.button_cart.Name = "button_cart";
            this.button_cart.Size = new System.Drawing.Size(223, 59);
            this.button_cart.TabIndex = 29;
            this.button_cart.Text = "CART";
            this.button_cart.UseVisualStyleBackColor = false;
            // 
            // button_shopping
            // 
            this.button_shopping.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_shopping.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_shopping.Location = new System.Drawing.Point(86, 27);
            this.button_shopping.Name = "button_shopping";
            this.button_shopping.Size = new System.Drawing.Size(223, 61);
            this.button_shopping.TabIndex = 28;
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
            this.splitter_client_products.TabIndex = 27;
            this.splitter_client_products.TabStop = false;
            // 
            // ClientCartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_cart);
            this.Controls.Add(this.button_purchase);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.listBox_cart);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_my_orders);
            this.Controls.Add(this.button_cart);
            this.Controls.Add(this.button_shopping);
            this.Controls.Add(this.splitter_client_products);
            this.Name = "ClientCartView";
            this.Text = "ClientCartView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_cart;
        private System.Windows.Forms.Button button_purchase;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.ListBox listBox_cart;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_my_orders;
        private System.Windows.Forms.Button button_cart;
        private System.Windows.Forms.Button button_shopping;
        private System.Windows.Forms.Splitter splitter_client_products;
    }
}