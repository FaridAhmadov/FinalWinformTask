namespace WinformFinal
{
    partial class CreateNewOrder
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
            this.txtCarMake = new System.Windows.Forms.Label();
            this.cbCarMake = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dd = new System.Windows.Forms.Label();
            this.txtTill = new System.Windows.Forms.Label();
            this.cbFrom = new System.Windows.Forms.Label();
            this.txtCarMade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTill = new System.Windows.Forms.DateTimePicker();
            this.cbConsumerName = new System.Windows.Forms.ComboBox();
            this.cbCarMade = new System.Windows.Forms.ComboBox();
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCarMake
            // 
            this.txtCarMake.AutoSize = true;
            this.txtCarMake.Location = new System.Drawing.Point(8, 191);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(68, 17);
            this.txtCarMake.TabIndex = 31;
            this.txtCarMake.Text = "Car Make";
            // 
            // cbCarMake
            // 
            this.cbCarMake.FormattingEnabled = true;
            this.cbCarMake.Location = new System.Drawing.Point(11, 211);
            this.cbCarMake.Name = "cbCarMake";
            this.cbCarMake.Size = new System.Drawing.Size(207, 24);
            this.cbCarMake.TabIndex = 30;
            this.cbCarMake.Text = "Choose...";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(483, 47);
            this.button2.TabIndex = 29;
            this.button2.Text = "Add Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 27);
            this.button1.TabIndex = 28;
            this.button1.Text = "Manage Consumers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dd.ForeColor = System.Drawing.Color.Tomato;
            this.dd.Location = new System.Drawing.Point(153, 9);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(203, 39);
            this.dd.TabIndex = 27;
            this.dd.Text = "-New Order-";
            // 
            // txtTill
            // 
            this.txtTill.AutoSize = true;
            this.txtTill.Location = new System.Drawing.Point(381, 191);
            this.txtTill.Name = "txtTill";
            this.txtTill.Size = new System.Drawing.Size(26, 17);
            this.txtTill.TabIndex = 26;
            this.txtTill.Text = "Till";
            // 
            // cbFrom
            // 
            this.cbFrom.AutoSize = true;
            this.cbFrom.Location = new System.Drawing.Point(253, 193);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(40, 17);
            this.cbFrom.TabIndex = 25;
            this.cbFrom.Text = "From";
            // 
            // txtCarMade
            // 
            this.txtCarMade.AutoSize = true;
            this.txtCarMade.Location = new System.Drawing.Point(8, 136);
            this.txtCarMade.Name = "txtCarMade";
            this.txtCarMade.Size = new System.Drawing.Size(69, 17);
            this.txtCarMade.TabIndex = 24;
            this.txtCarMade.Text = "Car Made";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Consumer Name";
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(256, 213);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(120, 22);
            this.dtFrom.TabIndex = 22;
            // 
            // dtTill
            // 
            this.dtTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTill.Location = new System.Drawing.Point(384, 213);
            this.dtTill.Name = "dtTill";
            this.dtTill.Size = new System.Drawing.Size(110, 22);
            this.dtTill.TabIndex = 21;
            // 
            // cbConsumerName
            // 
            this.cbConsumerName.FormattingEnabled = true;
            this.cbConsumerName.Location = new System.Drawing.Point(11, 94);
            this.cbConsumerName.Name = "cbConsumerName";
            this.cbConsumerName.Size = new System.Drawing.Size(207, 24);
            this.cbConsumerName.TabIndex = 20;
            this.cbConsumerName.Text = "Choose...";
            // 
            // cbCarMade
            // 
            this.cbCarMade.FormattingEnabled = true;
            this.cbCarMade.Location = new System.Drawing.Point(11, 156);
            this.cbCarMade.Name = "cbCarMade";
            this.cbCarMade.Size = new System.Drawing.Size(207, 24);
            this.cbCarMade.TabIndex = 19;
            this.cbCarMade.Text = "Choose...";
            this.cbCarMade.SelectedIndexChanged += new System.EventHandler(this.cbCarMade_SelectedIndexChanged);
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Location = new System.Drawing.Point(256, 153);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(238, 27);
            this.btnCreateCar.TabIndex = 32;
            this.btnCreateCar.Text = "Manage Cars";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // CreateNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 317);
            this.Controls.Add(this.btnCreateCar);
            this.Controls.Add(this.txtCarMake);
            this.Controls.Add(this.cbCarMake);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.txtTill);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.txtCarMade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.dtTill);
            this.Controls.Add(this.cbConsumerName);
            this.Controls.Add(this.cbCarMade);
            this.Name = "CreateNewOrder";
            this.Text = "CreateNewOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCarMake;
        private System.Windows.Forms.ComboBox cbCarMake;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.Label txtTill;
        private System.Windows.Forms.Label cbFrom;
        private System.Windows.Forms.Label txtCarMade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTill;
        private System.Windows.Forms.ComboBox cbConsumerName;
        private System.Windows.Forms.ComboBox cbCarMade;
        private System.Windows.Forms.Button btnCreateCar;
    }
}