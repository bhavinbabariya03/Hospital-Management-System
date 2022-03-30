
namespace HospitalManagementClient
{
    partial class AddInventory
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
            this.button1 = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.TextBox();
            this.inv_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 31);
            this.button1.TabIndex = 74;
            this.button1.Text = "Add Inventory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(349, 82);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(224, 22);
            this.quantity.TabIndex = 73;
            // 
            // inv_name
            // 
            this.inv_name.Location = new System.Drawing.Point(348, 29);
            this.inv_name.Name = "inv_name";
            this.inv_name.Size = new System.Drawing.Size(224, 22);
            this.inv_name.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 65;
            this.label8.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Inventory Name";
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.inv_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "AddInventory";
            this.Text = "AddInventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox inv_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}