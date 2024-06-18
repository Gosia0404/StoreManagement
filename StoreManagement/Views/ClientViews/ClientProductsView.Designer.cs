using Org.BouncyCastle.Ocsp;
using Org.BouncyCastle.Utilities;
using System;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    partial class ClientProductsView
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
            this.splitter_client_products = new System.Windows.Forms.Splitter();
            this.button_shopping = new System.Windows.Forms.Button();
            this.button_cart = new System.Windows.Forms.Button();
            this.button_my_orders = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.listBox_client_product = new System.Windows.Forms.ListBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.comboBox_price = new System.Windows.Forms.ComboBox();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.button_sort = new System.Windows.Forms.Button();
            this.button_add_cart = new System.Windows.Forms.Button();
            this.label_type = new System.Windows.Forms.Label();
            this.label_color = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splitter_client_products
            // 
            this.splitter_client_products.BackColor = System.Drawing.Color.Orchid;
            this.splitter_client_products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter_client_products.Location = new System.Drawing.Point(0, 0);
            this.splitter_client_products.Name = "splitter_client_products";
            this.splitter_client_products.Size = new System.Drawing.Size(365, 562);
            this.splitter_client_products.TabIndex = 1;
            this.splitter_client_products.TabStop = false;
            // 
            // button_shopping
            // 
            this.button_shopping.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_shopping.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_shopping.Location = new System.Drawing.Point(69, 27);
            this.button_shopping.Name = "button_shopping";
            this.button_shopping.Size = new System.Drawing.Size(223, 61);
            this.button_shopping.TabIndex = 2;
            this.button_shopping.Text = "SHOPPING";
            this.button_shopping.UseVisualStyleBackColor = false;
            // 
            // button_cart
            // 
            this.button_cart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_cart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cart.Location = new System.Drawing.Point(69, 106);
            this.button_cart.Name = "button_cart";
            this.button_cart.Size = new System.Drawing.Size(223, 59);
            this.button_cart.TabIndex = 3;
            this.button_cart.Text = "CART";
            this.button_cart.UseVisualStyleBackColor = false;
            this.button_cart.Click += new System.EventHandler(this.button_cart_Click);
            // 
            // button_my_orders
            // 
            this.button_my_orders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_my_orders.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_my_orders.Location = new System.Drawing.Point(69, 393);
            this.button_my_orders.Name = "button_my_orders";
            this.button_my_orders.Size = new System.Drawing.Size(223, 59);
            this.button_my_orders.TabIndex = 4;
            this.button_my_orders.Text = "MY ORDERS";
            this.button_my_orders.UseVisualStyleBackColor = false;
            this.button_my_orders.Click += new System.EventHandler(this.button_my_orders_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.Location = new System.Drawing.Point(69, 471);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(223, 59);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // listBox_client_product
            // 
            this.listBox_client_product.FormattingEnabled = true;
            this.listBox_client_product.Location = new System.Drawing.Point(393, 171);
            this.listBox_client_product.Name = "listBox_client_product";
            this.listBox_client_product.Size = new System.Drawing.Size(675, 212);
            this.listBox_client_product.TabIndex = 6;
            // 
            // comboBox_type
            // 
            this.comboBox_type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(393, 106);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(121, 29);
            this.comboBox_type.TabIndex = 7;
            this.comboBox_type.Items.AddRange(new object[]
            {
                "trousers", "dress", "tshirt", "skirt", "shorts", "sweater", "hoodie", "blouse"
            });
            // 
            // comboBox_color
            // 
            this.comboBox_color.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Location = new System.Drawing.Point(520, 106);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(121, 29);
            this.comboBox_color.TabIndex = 8;
            this.comboBox_color.Items.AddRange(new object[]
            {
                "white", "black", "green", "red", "blue", "orange", "yellow", "purple", "pink", "gray", "brown"
            });
            // 
            // comboBox_price
            // 
            this.comboBox_price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_price.FormattingEnabled = true;
            this.comboBox_price.Location = new System.Drawing.Point(647, 106);
            this.comboBox_price.Name = "comboBox_price";
            this.comboBox_price.Size = new System.Drawing.Size(121, 29);
            this.comboBox_price.TabIndex = 9;
            /*this.comboBox_price.Items.AddRange(new object[]
            {
                "white", "black", "green", "red", "blue", "orange", "yellow", "purple", "pink", "gray", "brown"
            });*/
            // 
            // comboBox_size
            // 
            this.comboBox_size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Location = new System.Drawing.Point(774, 106);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(121, 29);
            this.comboBox_size.TabIndex = 10;
            this.comboBox_size.Items.AddRange(new object[]
            {
                "s", "l", "m"
            });
            // 
            // button_sort
            // 
            this.button_sort.BackColor = System.Drawing.Color.Orchid;
            this.button_sort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_sort.Location = new System.Drawing.Point(901, 106);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(167, 29);
            this.button_sort.TabIndex = 11;
            this.button_sort.Text = "SORT";
            this.button_sort.UseVisualStyleBackColor = false;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // button_add_cart
            // 
            this.button_add_cart.BackColor = System.Drawing.Color.Orchid;
            this.button_add_cart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add_cart.Location = new System.Drawing.Point(845, 471);
            this.button_add_cart.Name = "button_add_cart";
            this.button_add_cart.Size = new System.Drawing.Size(223, 59);
            this.button_add_cart.TabIndex = 12;
            this.button_add_cart.Text = "ADD TO CART";
            this.button_add_cart.UseVisualStyleBackColor = false;
            this.button_add_cart.Click += new System.EventHandler(this.button_add_cart_Click);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_type.Location = new System.Drawing.Point(429, 82);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(48, 21);
            this.label_type.TabIndex = 13;
            this.label_type.Text = "TYPE";
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_color.Location = new System.Drawing.Point(552, 83);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(58, 20);
            this.label_color.TabIndex = 14;
            this.label_color.Text = "COLOR";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_price.Location = new System.Drawing.Point(681, 82);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(54, 21);
            this.label_price.TabIndex = 15;
            this.label_price.Text = "PRICE";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_size.Location = new System.Drawing.Point(813, 82);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(43, 21);
            this.label_size.TabIndex = 16;
            this.label_size.Text = "SIZE";
            // 
            // ClientProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_color);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.button_add_cart);
            this.Controls.Add(this.button_sort);
            this.Controls.Add(this.comboBox_size);
            this.Controls.Add(this.comboBox_price);
            this.Controls.Add(this.comboBox_color);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.listBox_client_product);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_my_orders);
            this.Controls.Add(this.button_cart);
            this.Controls.Add(this.button_shopping);
            this.Controls.Add(this.splitter_client_products);
            this.Name = "ClientProductsView";
            this.Text = "ClientProductsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter_client_products;
        private System.Windows.Forms.Button button_shopping;
        private System.Windows.Forms.Button button_cart;
        private System.Windows.Forms.Button button_my_orders;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.ListBox listBox_client_product;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.ComboBox comboBox_price;
        private System.Windows.Forms.ComboBox comboBox_size;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.Button button_add_cart;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_size;
    }
}