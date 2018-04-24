namespace WindowsFormsExample3_1
{
    partial class frmSales
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
            this.lblState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalesOrderID = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtSalesOrderNumber = new System.Windows.Forms.TextBox();
            this.txtRowguid = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.White;
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Location = new System.Drawing.Point(47, 204);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(2, 15);
            this.lblState.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SalesOrderID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "OrderDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SalesOrderNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rowguid";
            // 
            // txtSalesOrderID
            // 
            this.txtSalesOrderID.BackColor = System.Drawing.Color.White;
            this.txtSalesOrderID.Location = new System.Drawing.Point(168, 24);
            this.txtSalesOrderID.Multiline = true;
            this.txtSalesOrderID.Name = "txtSalesOrderID";
            this.txtSalesOrderID.ReadOnly = true;
            this.txtSalesOrderID.Size = new System.Drawing.Size(239, 20);
            this.txtSalesOrderID.TabIndex = 5;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.BackColor = System.Drawing.Color.White;
            this.txtOrderDate.Location = new System.Drawing.Point(168, 63);
            this.txtOrderDate.Multiline = true;
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(239, 20);
            this.txtOrderDate.TabIndex = 6;
            // 
            // txtSalesOrderNumber
            // 
            this.txtSalesOrderNumber.BackColor = System.Drawing.Color.White;
            this.txtSalesOrderNumber.Location = new System.Drawing.Point(168, 106);
            this.txtSalesOrderNumber.Multiline = true;
            this.txtSalesOrderNumber.Name = "txtSalesOrderNumber";
            this.txtSalesOrderNumber.ReadOnly = true;
            this.txtSalesOrderNumber.Size = new System.Drawing.Size(239, 20);
            this.txtSalesOrderNumber.TabIndex = 7;
            // 
            // txtRowguid
            // 
            this.txtRowguid.BackColor = System.Drawing.Color.White;
            this.txtRowguid.Location = new System.Drawing.Point(168, 148);
            this.txtRowguid.Multiline = true;
            this.txtRowguid.Name = "txtRowguid";
            this.txtRowguid.ReadOnly = true;
            this.txtRowguid.Size = new System.Drawing.Size(239, 20);
            this.txtRowguid.TabIndex = 8;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(467, 24);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 9;
            this.btnFirst.Text = "&First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(467, 63);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(467, 106);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(467, 155);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 12;
            this.btnLast.Text = "&Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 238);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txtRowguid);
            this.Controls.Add(this.txtSalesOrderNumber);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtSalesOrderID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblState);
            this.Name = "frmSales";
            this.Text = "Sales Orders";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalesOrderID;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtSalesOrderNumber;
        private System.Windows.Forms.TextBox txtRowguid;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
    }
}

