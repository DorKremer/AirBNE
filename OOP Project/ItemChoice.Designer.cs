namespace OOP_Project
{
    partial class ItemChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemChoice));
            this.apartmentButton = new System.Windows.Forms.Button();
            this.houseButton = new System.Windows.Forms.Button();
            this.hotelRoomButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // apartmentButton
            // 
            this.apartmentButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmentButton.Location = new System.Drawing.Point(47, 48);
            this.apartmentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apartmentButton.Name = "apartmentButton";
            this.apartmentButton.Size = new System.Drawing.Size(239, 123);
            this.apartmentButton.TabIndex = 3;
            this.apartmentButton.Text = "Apartment";
            this.apartmentButton.UseVisualStyleBackColor = true;
            this.apartmentButton.Click += new System.EventHandler(this.apartmentButton_Click);
            // 
            // houseButton
            // 
            this.houseButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.houseButton.Location = new System.Drawing.Point(47, 219);
            this.houseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(239, 123);
            this.houseButton.TabIndex = 4;
            this.houseButton.Text = "House";
            this.houseButton.UseVisualStyleBackColor = true;
            this.houseButton.Click += new System.EventHandler(this.houseButton_Click);
            // 
            // hotelRoomButton
            // 
            this.hotelRoomButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.hotelRoomButton.Location = new System.Drawing.Point(47, 364);
            this.hotelRoomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hotelRoomButton.Name = "hotelRoomButton";
            this.hotelRoomButton.Size = new System.Drawing.Size(239, 123);
            this.hotelRoomButton.TabIndex = 5;
            this.hotelRoomButton.Text = "Hotel Room";
            this.hotelRoomButton.UseVisualStyleBackColor = true;
            this.hotelRoomButton.Click += new System.EventHandler(this.hotelRoomButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(378, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 509);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select where you want yor vaction";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ItemChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(777, 526);
            this.Controls.Add(this.apartmentButton);
            this.Controls.Add(this.hotelRoomButton);
            this.Controls.Add(this.houseButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ItemChoice";
            this.Text = "Choose Item Type";
            this.Load += new System.EventHandler(this.ItemChoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button apartmentButton;
        private System.Windows.Forms.Button houseButton;
        private System.Windows.Forms.Button hotelRoomButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}