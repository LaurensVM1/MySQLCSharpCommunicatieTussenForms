namespace MySQLdataAdapterApp
{
    partial class invulForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecordtitleLabel = new System.Windows.Forms.Label();
            this.ProductNaamBox = new System.Windows.Forms.TextBox();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.BeschikbaarCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(359, 185);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 31);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(476, 185);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(115, 32);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Bevestigen";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produktnaam : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock : ";
            // 
            // RecordtitleLabel
            // 
            this.RecordtitleLabel.AutoSize = true;
            this.RecordtitleLabel.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordtitleLabel.Location = new System.Drawing.Point(19, 14);
            this.RecordtitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RecordtitleLabel.Name = "RecordtitleLabel";
            this.RecordtitleLabel.Size = new System.Drawing.Size(144, 18);
            this.RecordtitleLabel.TabIndex = 5;
            this.RecordtitleLabel.Text = "Record aanpassen";
            // 
            // ProductNaamBox
            // 
            this.ProductNaamBox.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNaamBox.Location = new System.Drawing.Point(144, 49);
            this.ProductNaamBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProductNaamBox.Multiline = true;
            this.ProductNaamBox.Name = "ProductNaamBox";
            this.ProductNaamBox.Size = new System.Drawing.Size(441, 54);
            this.ProductNaamBox.TabIndex = 6;
            // 
            // StockTextBox
            // 
            this.StockTextBox.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTextBox.Location = new System.Drawing.Point(144, 123);
            this.StockTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.Size = new System.Drawing.Size(75, 25);
            this.StockTextBox.TabIndex = 7;
            // 
            // BeschikbaarCheckBox
            // 
            this.BeschikbaarCheckBox.AutoSize = true;
            this.BeschikbaarCheckBox.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeschikbaarCheckBox.Location = new System.Drawing.Point(144, 165);
            this.BeschikbaarCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.BeschikbaarCheckBox.Name = "BeschikbaarCheckBox";
            this.BeschikbaarCheckBox.Size = new System.Drawing.Size(116, 22);
            this.BeschikbaarCheckBox.TabIndex = 8;
            this.BeschikbaarCheckBox.Text = "Beschikbaar";
            this.BeschikbaarCheckBox.UseVisualStyleBackColor = true;
            this.BeschikbaarCheckBox.CheckedChanged += new System.EventHandler(this.BeschikbaarCheckBox_CheckedChanged);
            // 
            // invulForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 227);
            this.Controls.Add(this.BeschikbaarCheckBox);
            this.Controls.Add(this.StockTextBox);
            this.Controls.Add(this.ProductNaamBox);
            this.Controls.Add(this.RecordtitleLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "invulForm";
            this.Text = "MySQL Databasebeheer - record aanpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ProductNaamBox;
        public System.Windows.Forms.TextBox StockTextBox;
        public System.Windows.Forms.CheckBox BeschikbaarCheckBox;
        public System.Windows.Forms.Label RecordtitleLabel;
    }
}