namespace WinformFinal
{
    partial class CreateCars
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
            this.lblConsumption = new System.Windows.Forms.Label();
            this.txtFuelC = new System.Windows.Forms.TextBox();
            this.lblEngine = new System.Windows.Forms.Label();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblMade = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.carDGV = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCarUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblFillFields = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsumption
            // 
            this.lblConsumption.AutoSize = true;
            this.lblConsumption.Location = new System.Drawing.Point(762, 385);
            this.lblConsumption.Name = "lblConsumption";
            this.lblConsumption.Size = new System.Drawing.Size(121, 17);
            this.lblConsumption.TabIndex = 47;
            this.lblConsumption.Text = "Fuel Consumption";
            // 
            // txtFuelC
            // 
            this.txtFuelC.Location = new System.Drawing.Point(765, 405);
            this.txtFuelC.Name = "txtFuelC";
            this.txtFuelC.Size = new System.Drawing.Size(130, 22);
            this.txtFuelC.TabIndex = 46;
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Location = new System.Drawing.Point(421, 385);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(83, 17);
            this.lblEngine.TabIndex = 45;
            this.lblEngine.Text = "Engine Size";
            // 
            // txtEngine
            // 
            this.txtEngine.Location = new System.Drawing.Point(424, 405);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(106, 22);
            this.txtEngine.TabIndex = 44;
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(22, 475);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(1039, 46);
            this.btnCreateEmployee.TabIndex = 43;
            this.btnCreateEmployee.Text = "Create Car";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click_1);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(565, 385);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 17);
            this.lblYear.TabIndex = 42;
            this.lblYear.Text = "Year";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(232, 385);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(42, 17);
            this.lblMake.TabIndex = 41;
            this.lblMake.Text = "Make";
            // 
            // lblMade
            // 
            this.lblMade.AutoSize = true;
            this.lblMade.Location = new System.Drawing.Point(9, 385);
            this.lblMade.Name = "lblMade";
            this.lblMade.Size = new System.Drawing.Size(43, 17);
            this.lblMade.TabIndex = 40;
            this.lblMade.Text = "Made";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(568, 405);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(138, 22);
            this.txtYear.TabIndex = 39;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(235, 405);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(134, 22);
            this.txtMake.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 39);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cars";
            // 
            // carDGV
            // 
            this.carDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carDGV.BackgroundColor = System.Drawing.Color.Green;
            this.carDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8});
            this.carDGV.Location = new System.Drawing.Point(12, 61);
            this.carDGV.Name = "carDGV";
            this.carDGV.RowHeadersWidth = 51;
            this.carDGV.RowTemplate.Height = 24;
            this.carDGV.Size = new System.Drawing.Size(1049, 311);
            this.carDGV.TabIndex = 35;
            this.carDGV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.carDGV_RowHeaderMouseDoubleClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ID";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MadeID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Made";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Make";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Engine Size";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Year";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fuel Consumption";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Price";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 401);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 24);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.Text = "Choose...";
            // 
            // btnCarUpdate
            // 
            this.btnCarUpdate.Location = new System.Drawing.Point(12, 475);
            this.btnCarUpdate.Name = "btnCarUpdate";
            this.btnCarUpdate.Size = new System.Drawing.Size(476, 46);
            this.btnCarUpdate.TabIndex = 49;
            this.btnCarUpdate.Text = "Update";
            this.btnCarUpdate.UseVisualStyleBackColor = true;
            this.btnCarUpdate.Visible = false;
            this.btnCarUpdate.Click += new System.EventHandler(this.btnCarUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(587, 475);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(474, 46);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(928, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(931, 401);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(130, 22);
            this.txtPrice.TabIndex = 51;
            // 
            // lblFillFields
            // 
            this.lblFillFields.AutoSize = true;
            this.lblFillFields.ForeColor = System.Drawing.Color.Red;
            this.lblFillFields.Location = new System.Drawing.Point(9, 442);
            this.lblFillFields.Name = "lblFillFields";
            this.lblFillFields.Size = new System.Drawing.Size(183, 17);
            this.lblFillFields.TabIndex = 53;
            this.lblFillFields.Text = "Please fill all required fields!";
            this.lblFillFields.Visible = false;
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.ForeColor = System.Drawing.Color.Red;
            this.lblRight.Location = new System.Drawing.Point(12, 442);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(170, 17);
            this.lblRight.TabIndex = 54;
            this.lblRight.Text = "Please enter a right value";
            this.lblRight.Visible = false;
            // 
            // CreateCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 533);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblFillFields);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCarUpdate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblConsumption);
            this.Controls.Add(this.txtFuelC);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.txtEngine);
            this.Controls.Add(this.btnCreateEmployee);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblMade);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carDGV);
            this.Name = "CreateCars";
            this.Text = "CreateCars";
            ((System.ComponentModel.ISupportInitialize)(this.carDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsumption;
        private System.Windows.Forms.TextBox txtFuelC;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblMade;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView carDGV;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCarUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblFillFields;
        private System.Windows.Forms.Label lblRight;
    }
}