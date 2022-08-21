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
            this.apartmentButton = new System.Windows.Forms.Button();
            this.houseButton = new System.Windows.Forms.Button();
            this.hotelRoomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apartmentButton
            // 
            this.apartmentButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmentButton.Location = new System.Drawing.Point(185, 31);
            this.apartmentButton.Name = "apartmentButton";
            this.apartmentButton.Size = new System.Drawing.Size(179, 100);
            this.apartmentButton.TabIndex = 3;
            this.apartmentButton.Text = "Apartment";
            this.apartmentButton.UseVisualStyleBackColor = true;
            this.apartmentButton.Click += new System.EventHandler(this.apartmentButton_Click);
            // 
            // houseButton
            // 
            this.houseButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.houseButton.Location = new System.Drawing.Point(185, 153);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(179, 100);
            this.houseButton.TabIndex = 4;
            this.houseButton.Text = "House";
            this.houseButton.UseVisualStyleBackColor = true;
            this.houseButton.Click += new System.EventHandler(this.houseButton_Click);
            // 
            // hotelRoomButton
            // 
            this.hotelRoomButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.hotelRoomButton.Location = new System.Drawing.Point(185, 275);
            this.hotelRoomButton.Name = "hotelRoomButton";
            this.hotelRoomButton.Size = new System.Drawing.Size(179, 100);
            this.hotelRoomButton.TabIndex = 5;
            this.hotelRoomButton.Text = "Hotel Room";
            this.hotelRoomButton.UseVisualStyleBackColor = true;
            this.hotelRoomButton.Click += new System.EventHandler(this.hotelRoomButton_Click);
            // 
            // ItemChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(583, 427);
            this.Controls.Add(this.hotelRoomButton);
            this.Controls.Add(this.houseButton);
            this.Controls.Add(this.apartmentButton);
            this.Name = "ItemChoice";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button apartmentButton;
        private System.Windows.Forms.Button houseButton;
        private System.Windows.Forms.Button hotelRoomButton;
    }
}