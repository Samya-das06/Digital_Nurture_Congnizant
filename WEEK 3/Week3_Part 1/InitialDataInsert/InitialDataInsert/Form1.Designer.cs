//Form 1 Designer

namespace initialdatainsert
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Labels
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelDataBaseName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelInsertvalue;
        private System.Windows.Forms.Label labelInsertID;
        private System.Windows.Forms.Label labelINSERT;
        private System.Windows.Forms.Label labelUPDATE;
        private System.Windows.Forms.Label labelDELETE;
        private System.Windows.Forms.Label labelRETRIEVE;
        private System.Windows.Forms.Label labelSUBMIT;

        // TextBoxes
        private System.Windows.Forms.TextBox textBoxDataBaseName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxInsertvalue;
        private System.Windows.Forms.TextBox textBoxInsertID;
        private System.Windows.Forms.TextBox textBoxINSERT;
        private System.Windows.Forms.TextBox textBoxUPDATE;
        private System.Windows.Forms.TextBox textBoxDELETE;
        private System.Windows.Forms.TextBox textBoxRETRIEVE;
        private System.Windows.Forms.TextBox textBoxSUBMIT;
       
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
            this.labelDataBaseName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelInsertvalue = new System.Windows.Forms.Label();
            this.labelInsertID = new System.Windows.Forms.Label();
            this.labelINSERT = new System.Windows.Forms.Label();
            this.labelUPDATE = new System.Windows.Forms.Label();
            this.labelDELETE = new System.Windows.Forms.Label();
            this.labelRETRIEVE = new System.Windows.Forms.Label();
            this.labelSUBMIT = new System.Windows.Forms.Label();
          

            this.textBoxDataBaseName= new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxInsertvalue= new System.Windows.Forms.TextBox();
            this.textBoxInsertID = new System.Windows.Forms.TextBox();
            this.textBoxINSERT = new System.Windows.Forms.TextBox();
            this.textBoxUPDATE = new System.Windows.Forms.TextBox();
            this.textBoxDELETE = new System.Windows.Forms.TextBox();
            this.textBoxRETRIEVE = new System.Windows.Forms.TextBox();
            this.textBoxSUBMIT = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Heading
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelHeading.Location = new System.Drawing.Point(150, 10);
            this.labelHeading.Text = "INSERT INITIAL VALUE ";

            // DATABASE NAME
            this.labelDataBaseName.AutoSize = true;
            this.labelDataBaseName.Location = new System.Drawing.Point(30, 60);
            this.labelDataBaseName.Text = "DataBase Name:";
            this.textBoxDataBaseName.Location = new System.Drawing.Point(180, 60);
            this.textBoxDataBaseName.Size = new System.Drawing.Size(250, 26);
            this.textBoxDataBaseName.Text = "";

            // ID
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(30, 100);
            this.labelID.Text = "ID:";
            this.textBoxID.Location = new System.Drawing.Point(180, 100);
            this.textBoxID.Size = new System.Drawing.Size(250, 26);
            this.textBoxID.Text = "";

            // Insertvalue
            this.labelInsertvalue.AutoSize = true;
            this.labelInsertvalue.Location = new System.Drawing.Point(30, 140);
            this.labelInsertvalue.Text = "Value:";
            this.textBoxInsertvalue.Location = new System.Drawing.Point(180, 140);
            this.textBoxInsertvalue.Size = new System.Drawing.Size(250, 26);
            this.textBoxInsertvalue.Text = "";

            // InsertID
            this.labelInsertvalue.AutoSize = true;
            this.labelInsertvalue.Location = new System.Drawing.Point(30, 180);
            this.labelInsertvalue.Text = "Insert_ID:";
            this.textBoxInsertvalue.Location = new System.Drawing.Point(180, 180);
            this.textBoxInsertvalue.Size = new System.Drawing.Size(250, 26);
            this.textBoxInsertvalue.Text = "";

            // INSERT
            this.labelINSERT.AutoSize = true;
            this.labelINSERT.Location = new System.Drawing.Point(30, 220);
            this.labelINSERT.Text = "INSERT:";
            this.textBoxINSERT.Location = new System.Drawing.Point(180, 220);
            this.textBoxINSERT.Size = new System.Drawing.Size(250, 26);
            this.textBoxINSERT.Text = "";

            // UPDATE
            this.labelUPDATE.AutoSize = true;
            this.labelUPDATE.Location = new System.Drawing.Point(30, 260);
            this.labelUPDATE.Text = "UPDATE:";
            this.textBoxUPDATE.Location = new System.Drawing.Point(180, 260);
            this.textBoxUPDATE.Size = new System.Drawing.Size(250, 26);
            this.textBoxUPDATE.Text = "";

            // DELETE
            this.labelDELETE.AutoSize = true;
            this.labelDELETE.Location = new System.Drawing.Point(30, 300);
            this.labelDELETE.Text = "DELETE:";
            this.textBoxDELETE.Location = new System.Drawing.Point(180, 300);
            this.textBoxDELETE.Size = new System.Drawing.Size(250, 26);
            this.textBoxDELETE.Text = "";

            // RETRIEVE
            this.labelRETRIEVE.AutoSize = true;
            this.labelRETRIEVE.Location = new System.Drawing.Point(30, 340);
            this.labelRETRIEVE.Text = "RETRIEVE DATA:";
            this.textBoxRETRIEVE.Location = new System.Drawing.Point(180, 340);
            this.textBoxRETRIEVE.Size = new System.Drawing.Size(250, 26);
            this.textBoxRETRIEVE.Text = "";

            // SUBMIT
            this.labelSUBMIT.AutoSize = true;
            this.labelSUBMIT.Location = new System.Drawing.Point(30, 380);
            this.labelSUBMIT.Text = "SUBMIT";
            this.textBoxSUBMIT.Location = new System.Drawing.Point(180, 380);
            this.textBoxSUBMIT.Size = new System.Drawing.Size(250, 26);
            this.textBoxSUBMIT.Text = "";

            
            // Show Button
            this.buttonShow.Location = new System.Drawing.Point(470, 180);
            this.buttonShow.Size = new System.Drawing.Size(250, 35);
            this.buttonShow.Text = "Show Database Info";
            this.buttonShow.UseVisualStyleBackColor = true;

            // Form Setup
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.labelDataBaseName);
            this.Controls.Add(this.textBoxDataBaseName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelInsertvalue);
            this.Controls.Add(this.textBoxInsertvalue);
            this.Controls.Add(this.labelInsertID);
            this.Controls.Add(this.textBoxInsertID);
            this.Controls.Add(this.labelINSERT);
            this.Controls.Add(this.textBoxINSERT);
            this.Controls.Add(this.labelUPDATE);
            this.Controls.Add(this.textBoxUPDATE);
            this.Controls.Add(this.labelDELETE);
            this.Controls.Add(this.textBoxDELETE);
            this.Controls.Add(this.labelRETRIEVE);
            this.Controls.Add(this.textBoxRETRIEVE);
            this.Controls.Add(this.labelSUBMIT);
            this.Controls.Add(this.textBoxSUBMIT);
            this.Controls.Add(this.buttonShow);
            this.Name = "Form1";
            this.Text = "INSERT VALUE FROM";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
