namespace StoreManagement.Views
{
    partial class WorkerProductsView
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
            this.splitter_worker_products = new System.Windows.Forms.Splitter();
            this.button_availability = new System.Windows.Forms.Button();
            this.button_orders = new System.Windows.Forms.Button();
            this.button_add_employee = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.listBox_products = new System.Windows.Forms.ListBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label_products = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter_worker_products
            // 
            this.splitter_worker_products.BackColor = System.Drawing.Color.Orchid;
            this.splitter_worker_products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter_worker_products.Location = new System.Drawing.Point(0, 0);
            this.splitter_worker_products.Margin = new System.Windows.Forms.Padding(4);
            this.splitter_worker_products.Name = "splitter_worker_products";
            this.splitter_worker_products.Size = new System.Drawing.Size(477, 677);
            this.splitter_worker_products.TabIndex = 0;
            this.splitter_worker_products.TabStop = false;
            // 
            // button_availability
            // 
            this.button_availability.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_availability.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_availability.Location = new System.Drawing.Point(92, 33);
            this.button_availability.Margin = new System.Windows.Forms.Padding(4);
            this.button_availability.Name = "button_availability";
            this.button_availability.Size = new System.Drawing.Size(297, 75);
            this.button_availability.TabIndex = 2;
            this.button_availability.Text = "AVAILABILITY";
            this.button_availability.UseVisualStyleBackColor = false;
            // 
            // button_orders
            // 
            this.button_orders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_orders.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_orders.Location = new System.Drawing.Point(92, 130);
            this.button_orders.Margin = new System.Windows.Forms.Padding(4);
            this.button_orders.Name = "button_orders";
            this.button_orders.Size = new System.Drawing.Size(297, 73);
            this.button_orders.TabIndex = 3;
            this.button_orders.Text = "ORDERS";
            this.button_orders.UseVisualStyleBackColor = false;
            // 
            // button_add_employee
            // 
            this.button_add_employee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_add_employee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_add_employee.Location = new System.Drawing.Point(92, 484);
            this.button_add_employee.Margin = new System.Windows.Forms.Padding(4);
            this.button_add_employee.Name = "button_add_employee";
            this.button_add_employee.Size = new System.Drawing.Size(297, 73);
            this.button_add_employee.TabIndex = 4;
            this.button_add_employee.Text = "ADD EMPLOYEE";
            this.button_add_employee.UseVisualStyleBackColor = false;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_logout.Location = new System.Drawing.Point(92, 580);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(297, 73);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = false;
            // 
            // listBox_products
            // 
            this.listBox_products.FormattingEnabled = true;
            this.listBox_products.ItemHeight = 16;
            this.listBox_products.Location = new System.Drawing.Point(528, 130);
            this.listBox_products.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_products.Name = "listBox_products";
            this.listBox_products.Size = new System.Drawing.Size(917, 356);
            this.listBox_products.TabIndex = 6;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.Orchid;
            this.button_edit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_edit.Location = new System.Drawing.Point(639, 580);
            this.button_edit.Margin = new System.Windows.Forms.Padding(4);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(297, 70);
            this.button_edit.TabIndex = 7;
            this.button_edit.Text = "EDIT PRODUCT";
            this.button_edit.UseVisualStyleBackColor = false;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Orchid;
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_add.Location = new System.Drawing.Point(1028, 580);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(297, 70);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "ADD PRODUCT";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_products
            // 
            this.label_products.AutoSize = true;
            this.label_products.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_products.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_products.ForeColor = System.Drawing.Color.Black;
            this.label_products.Location = new System.Drawing.Point(856, 50);
            this.label_products.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_products.Name = "label_products";
            this.label_products.Size = new System.Drawing.Size(256, 60);
            this.label_products.TabIndex = 9;
            this.label_products.Text = "PRODUCTS";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Orchid;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_delete.Location = new System.Drawing.Point(837, 494);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(297, 70);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "DELETE PRODUCT";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // WorkerProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label_products);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.listBox_products);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_add_employee);
            this.Controls.Add(this.button_orders);
            this.Controls.Add(this.button_availability);
            this.Controls.Add(this.splitter_worker_products);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkerProductsView";
            this.Size = new System.Drawing.Size(1600, 677);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_availability;
        private System.Windows.Forms.Button button_orders;
        private System.Windows.Forms.Button button_add_employee;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.ListBox listBox_products;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_products;
        private System.Windows.Forms.Splitter splitter_worker_products;
        private System.Windows.Forms.Button button_delete;
    }
}