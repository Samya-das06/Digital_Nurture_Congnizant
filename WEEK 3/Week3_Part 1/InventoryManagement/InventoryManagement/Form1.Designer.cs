//Form 1 Designer

namespace InventoryManagement
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Labels
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelCustomerContact;
        private System.Windows.Forms.Label labelCustomerEmail;
        private System.Windows.Forms.Label labelCustomerAddress;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelItemId;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPlaceOrder;
        private System.Windows.Forms.Label labelPaymentMode;

        // TextBoxes
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerContact;
        private System.Windows.Forms.TextBox textBoxCustomerEmail;
        private System.Windows.Forms.TextBox textBoxCustomerAddress;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxItemId;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPlaceOrder;
        private System.Windows.Forms.TextBox textBoxPaymentMode;

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button buttonShow;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelHeading = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelCustomerContact = new System.Windows.Forms.Label();
            this.labelCustomerEmail = new System.Windows.Forms.Label();
            this.labelCustomerAddress = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelItemId = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPlaceOrder = new System.Windows.Forms.Label();
            this.labelPaymentMode = new System.Windows.Forms.Label();

            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerContact = new System.Windows.Forms.TextBox();
            this.textBoxCustomerEmail = new System.Windows.Forms.TextBox();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxItemId = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxPlaceOrder = new System.Windows.Forms.TextBox();
            this.textBoxPaymentMode = new System.Windows.Forms.TextBox();

            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonShow = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Heading
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelHeading.Location = new System.Drawing.Point(150, 10);
            this.labelHeading.Text = "Inventory Order + Customer Info";

            // Customer Name
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(30, 60);
            this.labelCustomerName.Text = "Customer Name:";
            this.textBoxCustomerName.Location = new System.Drawing.Point(180, 60);
            this.textBoxCustomerName.Size = new System.Drawing.Size(250, 26);
            this.textBoxCustomerName.Text = "";

            // Customer Contact
            this.labelCustomerContact.AutoSize = true;
            this.labelCustomerContact.Location = new System.Drawing.Point(30, 100);
            this.labelCustomerContact.Text = "Contact:";
            this.textBoxCustomerContact.Location = new System.Drawing.Point(180, 100);
            this.textBoxCustomerContact.Size = new System.Drawing.Size(250, 26);
            this.textBoxCustomerContact.Text = "";

            // Customer Email
            this.labelCustomerEmail.AutoSize = true;
            this.labelCustomerEmail.Location = new System.Drawing.Point(30, 140);
            this.labelCustomerEmail.Text = "Email:";
            this.textBoxCustomerEmail.Location = new System.Drawing.Point(180, 140);
            this.textBoxCustomerEmail.Size = new System.Drawing.Size(250, 26);
            this.textBoxCustomerEmail.Text = "";

            // Customer Address
            this.labelCustomerAddress.AutoSize = true;
            this.labelCustomerAddress.Location = new System.Drawing.Point(30, 180);
            this.labelCustomerAddress.Text = "Address:";
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(180, 180);
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(250, 26);
            this.textBoxCustomerAddress.Text = "";

            // Item Name
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(30, 220);
            this.labelItemName.Text = "Item Name:";
            this.textBoxItemName.Location = new System.Drawing.Point(180, 220);
            this.textBoxItemName.Size = new System.Drawing.Size(250, 26);
            this.textBoxItemName.Text = "";

            // Item ID
            this.labelItemId.AutoSize = true;
            this.labelItemId.Location = new System.Drawing.Point(30, 260);
            this.labelItemId.Text = "Item ID:";
            this.textBoxItemId.Location = new System.Drawing.Point(180, 260);
            this.textBoxItemId.Size = new System.Drawing.Size(250, 26);
            this.textBoxItemId.Text = "";

            // Quantity
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(30, 300);
            this.labelQuantity.Text = "Quantity:";
            this.textBoxQuantity.Location = new System.Drawing.Point(180, 300);
            this.textBoxQuantity.Size = new System.Drawing.Size(250, 26);
            this.textBoxQuantity.Text = "";

            // Place Order
            this.labelPlaceOrder.AutoSize = true;
            this.labelPlaceOrder.Location = new System.Drawing.Point(30, 340);
            this.labelPlaceOrder.Text = "Place Order:";
            this.textBoxPlaceOrder.Location = new System.Drawing.Point(180, 340);
            this.textBoxPlaceOrder.Size = new System.Drawing.Size(250, 26);
            this.textBoxPlaceOrder.Text = "";

            // Payment Mode
            this.labelPaymentMode.AutoSize = true;
            this.labelPaymentMode.Location = new System.Drawing.Point(30, 380);
            this.labelPaymentMode.Text = "Payment Mode:";
            this.textBoxPaymentMode.Location = new System.Drawing.Point(180, 380);
            this.textBoxPaymentMode.Size = new System.Drawing.Size(250, 26);
            this.textBoxPaymentMode.Text = "";

            // Product List
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Items.AddRange(new object[] {
                "Laptop", "Mouse", "Keyboard", "Monitor", "Printer"});
            this.listBoxProducts.Location = new System.Drawing.Point(470, 60);
            this.listBoxProducts.Size = new System.Drawing.Size(250, 104);

            // Show Button
            this.buttonShow.Location = new System.Drawing.Point(470, 180);
            this.buttonShow.Size = new System.Drawing.Size(250, 35);
            this.buttonShow.Text = "Show Product Info";
            this.buttonShow.UseVisualStyleBackColor = true;

            // Form Setup
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.labelCustomerContact);
            this.Controls.Add(this.textBoxCustomerContact);
            this.Controls.Add(this.labelCustomerEmail);
            this.Controls.Add(this.textBoxCustomerEmail);
            this.Controls.Add(this.labelCustomerAddress);
            this.Controls.Add(this.textBoxCustomerAddress);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.labelItemId);
            this.Controls.Add(this.textBoxItemId);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelPlaceOrder);
            this.Controls.Add(this.textBoxPlaceOrder);
            this.Controls.Add(this.labelPaymentMode);
            this.Controls.Add(this.textBoxPaymentMode);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.buttonShow);
            this.Name = "Form1";
            this.Text = "Customer and Inventory Order";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
