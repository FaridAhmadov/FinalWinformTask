namespace WinformFinal
{
    partial class CreateConsumers
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
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDrivingLicence = new System.Windows.Forms.Label();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDrivingLicence = new System.Windows.Forms.TextBox();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.consumerDgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFillFields = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consumerDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(12, 443);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(909, 52);
            this.btnCreateEmployee.TabIndex = 41;
            this.btnCreateEmployee.Text = "Create Consumer";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(741, 375);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 17);
            this.lblAge.TabIndex = 40;
            this.lblAge.Text = "Age";
            // 
            // lblDrivingLicence
            // 
            this.lblDrivingLicence.AutoSize = true;
            this.lblDrivingLicence.Location = new System.Drawing.Point(500, 374);
            this.lblDrivingLicence.Name = "lblDrivingLicence";
            this.lblDrivingLicence.Size = new System.Drawing.Size(105, 17);
            this.lblDrivingLicence.TabIndex = 39;
            this.lblDrivingLicence.Text = "Driving Licence";
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Location = new System.Drawing.Point(254, 375);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(107, 17);
            this.lblIdentity.TabIndex = 38;
            this.lblIdentity.Text = "Identity Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 375);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 17);
            this.lblName.TabIndex = 37;
            this.lblName.Text = "Full Name";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(744, 395);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(177, 22);
            this.txtAge.TabIndex = 36;
            // 
            // txtDrivingLicence
            // 
            this.txtDrivingLicence.Location = new System.Drawing.Point(503, 394);
            this.txtDrivingLicence.Name = "txtDrivingLicence";
            this.txtDrivingLicence.Size = new System.Drawing.Size(162, 22);
            this.txtDrivingLicence.TabIndex = 35;
            // 
            // txtIdentity
            // 
            this.txtIdentity.Location = new System.Drawing.Point(257, 395);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(161, 22);
            this.txtIdentity.TabIndex = 34;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 395);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 22);
            this.txtName.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(396, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Consumers";
            // 
            // consumerDgv
            // 
            this.consumerDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.consumerDgv.BackgroundColor = System.Drawing.Color.Tomato;
            this.consumerDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consumerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consumerDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.consumerDgv.Location = new System.Drawing.Point(12, 51);
            this.consumerDgv.Name = "consumerDgv";
            this.consumerDgv.RowHeadersWidth = 51;
            this.consumerDgv.RowTemplate.Height = 24;
            this.consumerDgv.Size = new System.Drawing.Size(909, 311);
            this.consumerDgv.TabIndex = 31;
            this.consumerDgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.consumerDgv_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Full Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Identity Number";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Driving Licence";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Age";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 443);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(446, 52);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(475, 443);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(446, 52);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblFillFields
            // 
            this.lblFillFields.AutoSize = true;
            this.lblFillFields.ForeColor = System.Drawing.Color.Red;
            this.lblFillFields.Location = new System.Drawing.Point(12, 423);
            this.lblFillFields.Name = "lblFillFields";
            this.lblFillFields.Size = new System.Drawing.Size(183, 17);
            this.lblFillFields.TabIndex = 45;
            this.lblFillFields.Text = "Please fill all required fields!";
            this.lblFillFields.Visible = false;
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.ForeColor = System.Drawing.Color.Red;
            this.lblRight.Location = new System.Drawing.Point(12, 423);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(173, 17);
            this.lblRight.TabIndex = 55;
            this.lblRight.Text = "Please enter a right value!";
            this.lblRight.Visible = false;
            // 
            // CreateConsumers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 506);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblFillFields);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreateEmployee);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblDrivingLicence);
            this.Controls.Add(this.lblIdentity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtDrivingLicence);
            this.Controls.Add(this.txtIdentity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consumerDgv);
            this.Name = "CreateConsumers";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.consumerDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDrivingLicence;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDrivingLicence;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView consumerDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFillFields;
        private System.Windows.Forms.Label lblRight;
    }
}

