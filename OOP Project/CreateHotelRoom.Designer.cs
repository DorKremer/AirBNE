namespace OOP_Project
{
    partial class CreateHotelRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateHotelRoom));
            this.successText = new System.Windows.Forms.Label();
            this.wifiBox = new System.Windows.Forms.CheckBox();
            this.poolBox = new System.Windows.Forms.CheckBox();
            this.zipCodeBox = new System.Windows.Forms.NumericUpDown();
            this.pensionBox = new System.Windows.Forms.NumericUpDown();
            this.roomNumberBox = new System.Windows.Forms.NumericUpDown();
            this.residentsBox = new System.Windows.Forms.NumericUpDown();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.petsBox = new System.Windows.Forms.CheckBox();
            this.createBox = new System.Windows.Forms.Button();
            this.hotelNameBox = new System.Windows.Forms.TextBox();
            this.gymBox = new System.Windows.Forms.CheckBox();
            this.hotelGrade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pensionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // successText
            // 
            this.successText.AutoSize = true;
            this.successText.ForeColor = System.Drawing.Color.Lime;
            this.successText.Location = new System.Drawing.Point(54, 330);
            this.successText.Name = "successText";
            this.successText.Size = new System.Drawing.Size(0, 13);
            this.successText.TabIndex = 28;
            // 
            // wifiBox
            // 
            this.wifiBox.AutoSize = true;
            this.wifiBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.wifiBox.Location = new System.Drawing.Point(249, 123);
            this.wifiBox.Name = "wifiBox";
            this.wifiBox.Size = new System.Drawing.Size(119, 19);
            this.wifiBox.TabIndex = 25;
            this.wifiBox.Text = "Is There Wifi?";
            this.wifiBox.UseVisualStyleBackColor = true;
            // 
            // poolBox
            // 
            this.poolBox.AutoSize = true;
            this.poolBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.poolBox.Location = new System.Drawing.Point(249, 71);
            this.poolBox.Name = "poolBox";
            this.poolBox.Size = new System.Drawing.Size(136, 19);
            this.poolBox.TabIndex = 24;
            this.poolBox.Text = "Is There A Pool?";
            this.poolBox.UseVisualStyleBackColor = true;
            // 
            // zipCodeBox
            // 
            this.zipCodeBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.zipCodeBox.Location = new System.Drawing.Point(57, 198);
            this.zipCodeBox.Name = "zipCodeBox";
            this.zipCodeBox.Size = new System.Drawing.Size(186, 21);
            this.zipCodeBox.TabIndex = 23;
            // 
            // pensionBox
            // 
            this.pensionBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.pensionBox.Location = new System.Drawing.Point(57, 172);
            this.pensionBox.Name = "pensionBox";
            this.pensionBox.Size = new System.Drawing.Size(186, 21);
            this.pensionBox.TabIndex = 22;
            // 
            // roomNumberBox
            // 
            this.roomNumberBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.roomNumberBox.Location = new System.Drawing.Point(57, 146);
            this.roomNumberBox.Name = "roomNumberBox";
            this.roomNumberBox.Size = new System.Drawing.Size(186, 21);
            this.roomNumberBox.TabIndex = 21;
            // 
            // residentsBox
            // 
            this.residentsBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.residentsBox.Location = new System.Drawing.Point(57, 120);
            this.residentsBox.Name = "residentsBox";
            this.residentsBox.Size = new System.Drawing.Size(186, 21);
            this.residentsBox.TabIndex = 20;
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.White;
            this.priceBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.priceBox.ForeColor = System.Drawing.Color.Black;
            this.priceBox.Location = new System.Drawing.Point(57, 94);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(186, 21);
            this.priceBox.TabIndex = 19;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.descriptionBox.Location = new System.Drawing.Point(57, 68);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(186, 21);
            this.descriptionBox.TabIndex = 18;
            this.descriptionBox.Text = "Enter Description...";
            this.descriptionBox.Enter += new System.EventHandler(this.descriptionBox_Enter);
            this.descriptionBox.Leave += new System.EventHandler(this.descriptionBox_Leave);
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.addressBox.Location = new System.Drawing.Point(57, 42);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(186, 21);
            this.addressBox.TabIndex = 17;
            this.addressBox.Text = "Enter Address...";
            this.addressBox.Enter += new System.EventHandler(this.addressBox_Enter);
            this.addressBox.Leave += new System.EventHandler(this.addressBox_Leave);
            // 
            // petsBox
            // 
            this.petsBox.AutoSize = true;
            this.petsBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.petsBox.Location = new System.Drawing.Point(249, 19);
            this.petsBox.Name = "petsBox";
            this.petsBox.Size = new System.Drawing.Size(145, 19);
            this.petsBox.TabIndex = 16;
            this.petsBox.Text = "Are Pets Allowed?";
            this.petsBox.UseVisualStyleBackColor = true;
            // 
            // createBox
            // 
            this.createBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.createBox.Location = new System.Drawing.Point(57, 261);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(186, 61);
            this.createBox.TabIndex = 15;
            this.createBox.Text = "Add Hotel Room";
            this.createBox.UseVisualStyleBackColor = true;
            this.createBox.Click += new System.EventHandler(this.createBox_Click);
            this.createBox.Leave += new System.EventHandler(this.createBox_Leave);
            // 
            // hotelNameBox
            // 
            this.hotelNameBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.hotelNameBox.Location = new System.Drawing.Point(57, 16);
            this.hotelNameBox.Name = "hotelNameBox";
            this.hotelNameBox.Size = new System.Drawing.Size(186, 21);
            this.hotelNameBox.TabIndex = 29;
            this.hotelNameBox.Text = "Enter Hotel Name...";
            this.hotelNameBox.Enter += new System.EventHandler(this.hotelNameBox_Enter);
            this.hotelNameBox.Leave += new System.EventHandler(this.hotelNameBox_Leave);
            // 
            // gymBox
            // 
            this.gymBox.AutoSize = true;
            this.gymBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.gymBox.Location = new System.Drawing.Point(249, 175);
            this.gymBox.Name = "gymBox";
            this.gymBox.Size = new System.Drawing.Size(138, 19);
            this.gymBox.TabIndex = 30;
            this.gymBox.Text = "Is There A Gym?";
            this.gymBox.UseVisualStyleBackColor = true;
            // 
            // hotelGrade
            // 
            this.hotelGrade.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.hotelGrade.Location = new System.Drawing.Point(57, 225);
            this.hotelGrade.Name = "hotelGrade";
            this.hotelGrade.Size = new System.Drawing.Size(186, 21);
            this.hotelGrade.TabIndex = 31;
            // 
            // CreateHotelRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(416, 384);
            this.Controls.Add(this.hotelGrade);
            this.Controls.Add(this.gymBox);
            this.Controls.Add(this.hotelNameBox);
            this.Controls.Add(this.successText);
            this.Controls.Add(this.wifiBox);
            this.Controls.Add(this.poolBox);
            this.Controls.Add(this.zipCodeBox);
            this.Controls.Add(this.pensionBox);
            this.Controls.Add(this.roomNumberBox);
            this.Controls.Add(this.residentsBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.petsBox);
            this.Controls.Add(this.createBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateHotelRoom";
            this.Text = "Create A Hotel Room!";
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pensionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label successText;
        private System.Windows.Forms.CheckBox wifiBox;
        private System.Windows.Forms.CheckBox poolBox;
        private System.Windows.Forms.NumericUpDown zipCodeBox;
        private System.Windows.Forms.NumericUpDown pensionBox;
        private System.Windows.Forms.NumericUpDown roomNumberBox;
        private System.Windows.Forms.NumericUpDown residentsBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.CheckBox petsBox;
        private System.Windows.Forms.Button createBox;
        private System.Windows.Forms.TextBox hotelNameBox;
        private System.Windows.Forms.CheckBox gymBox;
        private System.Windows.Forms.NumericUpDown hotelGrade;
    }
}