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
            this.hotelRoomButton = new System.Windows.Forms.Button();
            this.houseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apartmentButton
            // 
            this.apartmentButton.BackgroundImage = global::OOP_Project.Properties.Resources._267316381;
            this.apartmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.apartmentButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apartmentButton.Location = new System.Drawing.Point(13, 13);
            this.apartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.apartmentButton.Name = "apartmentButton";
            this.apartmentButton.Size = new System.Drawing.Size(387, 500);
            this.apartmentButton.TabIndex = 3;
            this.apartmentButton.Text = "Apartment";
            this.apartmentButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.apartmentButton.UseVisualStyleBackColor = true;
            this.apartmentButton.Click += new System.EventHandler(this.apartmentButton_Click);
            // 
            // hotelRoomButton
            // 
            this.hotelRoomButton.BackgroundImage = global::OOP_Project.Properties.Resources.this_is_a_photo_of_a;
            this.hotelRoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hotelRoomButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.hotelRoomButton.Location = new System.Drawing.Point(881, 13);
            this.hotelRoomButton.Margin = new System.Windows.Forms.Padding(4);
            this.hotelRoomButton.Name = "hotelRoomButton";
            this.hotelRoomButton.Size = new System.Drawing.Size(387, 500);
            this.hotelRoomButton.TabIndex = 5;
            this.hotelRoomButton.Text = "Hotel Room";
            this.hotelRoomButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotelRoomButton.UseVisualStyleBackColor = true;
            this.hotelRoomButton.Click += new System.EventHandler(this.hotelRoomButton_Click);
            // 
            // houseButton
            // 
            this.houseButton.BackgroundImage = global::OOP_Project.Properties.Resources.pexels_photo_106399;
            this.houseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.houseButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.houseButton.Location = new System.Drawing.Point(448, 13);
            this.houseButton.Margin = new System.Windows.Forms.Padding(4);
            this.houseButton.Name = "houseButton";
            this.houseButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.houseButton.Size = new System.Drawing.Size(387, 500);
            this.houseButton.TabIndex = 4;
            this.houseButton.Text = "House";
            this.houseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.houseButton.UseVisualStyleBackColor = true;
            this.houseButton.Click += new System.EventHandler(this.houseButton_Click);
            // 
            // ItemChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::OOP_Project.Properties.Resources.milky_way_2695569_1280;
            this.ClientSize = new System.Drawing.Size(1364, 518);
            this.Controls.Add(this.apartmentButton);
            this.Controls.Add(this.hotelRoomButton);
            this.Controls.Add(this.houseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemChoice";
            this.Text = "Choose Item Type";
            this.Load += new System.EventHandler(this.ItemChoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button apartmentButton;
        private System.Windows.Forms.Button houseButton;
        private System.Windows.Forms.Button hotelRoomButton;
    }
}