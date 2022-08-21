namespace OOP_Project
{
    partial class CreateApartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateApartment));
            this.createBox = new System.Windows.Forms.Button();
            this.petsBox = new System.Windows.Forms.CheckBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.residentsBox = new System.Windows.Forms.NumericUpDown();
            this.roomCountBox = new System.Windows.Forms.NumericUpDown();
            this.floorBox = new System.Windows.Forms.NumericUpDown();
            this.zipCodeBox = new System.Windows.Forms.NumericUpDown();
            this.poolBox = new System.Windows.Forms.CheckBox();
            this.wifiBox = new System.Windows.Forms.CheckBox();
            this.elevatorBox = new System.Windows.Forms.CheckBox();
            this.porchBox = new System.Windows.Forms.CheckBox();
            this.successText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createBox
            // 
            this.createBox.Location = new System.Drawing.Point(75, 245);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(186, 61);
            this.createBox.TabIndex = 0;
            this.createBox.Text = "Add Apartment";
            this.createBox.UseVisualStyleBackColor = true;
            this.createBox.Click += new System.EventHandler(this.createBox_Click);
            this.createBox.Leave += new System.EventHandler(this.createBox_Leave);
            // 
            // petsBox
            // 
            this.petsBox.AutoSize = true;
            this.petsBox.Location = new System.Drawing.Point(267, 39);
            this.petsBox.Name = "petsBox";
            this.petsBox.Size = new System.Drawing.Size(112, 17);
            this.petsBox.TabIndex = 1;
            this.petsBox.Text = "Are Pets Allowed?";
            this.petsBox.UseVisualStyleBackColor = true;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(75, 39);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(186, 20);
            this.addressBox.TabIndex = 3;
            this.addressBox.Text = "Enter Address...";
            this.addressBox.Click += new System.EventHandler(this.addressBox_Enter);
            this.addressBox.Leave += new System.EventHandler(this.addressBox_Leave);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(75, 65);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(186, 20);
            this.descriptionBox.TabIndex = 4;
            this.descriptionBox.Text = "Enter Description...";
            this.descriptionBox.Enter += new System.EventHandler(this.descriptionBox_Enter);
            this.descriptionBox.Leave += new System.EventHandler(this.descriptionBox_Leave);
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.White;
            this.priceBox.ForeColor = System.Drawing.Color.Black;
            this.priceBox.Location = new System.Drawing.Point(75, 91);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(186, 20);
            this.priceBox.TabIndex = 5;
            // 
            // residentsBox
            // 
            this.residentsBox.Location = new System.Drawing.Point(75, 117);
            this.residentsBox.Name = "residentsBox";
            this.residentsBox.Size = new System.Drawing.Size(186, 20);
            this.residentsBox.TabIndex = 6;
            // 
            // roomCountBox
            // 
            this.roomCountBox.Location = new System.Drawing.Point(75, 143);
            this.roomCountBox.Name = "roomCountBox";
            this.roomCountBox.Size = new System.Drawing.Size(186, 20);
            this.roomCountBox.TabIndex = 7;
            // 
            // floorBox
            // 
            this.floorBox.Location = new System.Drawing.Point(75, 169);
            this.floorBox.Name = "floorBox";
            this.floorBox.Size = new System.Drawing.Size(186, 20);
            this.floorBox.TabIndex = 8;
            // 
            // zipCodeBox
            // 
            this.zipCodeBox.Location = new System.Drawing.Point(75, 195);
            this.zipCodeBox.Name = "zipCodeBox";
            this.zipCodeBox.Size = new System.Drawing.Size(186, 20);
            this.zipCodeBox.TabIndex = 9;
            // 
            // poolBox
            // 
            this.poolBox.AutoSize = true;
            this.poolBox.Location = new System.Drawing.Point(267, 91);
            this.poolBox.Name = "poolBox";
            this.poolBox.Size = new System.Drawing.Size(105, 17);
            this.poolBox.TabIndex = 10;
            this.poolBox.Text = "Is There A Pool?";
            this.poolBox.UseVisualStyleBackColor = true;
            // 
            // wifiBox
            // 
            this.wifiBox.AutoSize = true;
            this.wifiBox.Location = new System.Drawing.Point(267, 143);
            this.wifiBox.Name = "wifiBox";
            this.wifiBox.Size = new System.Drawing.Size(92, 17);
            this.wifiBox.TabIndex = 11;
            this.wifiBox.Text = "Is There Wifi?";
            this.wifiBox.UseVisualStyleBackColor = true;
            // 
            // elevatorBox
            // 
            this.elevatorBox.AutoSize = true;
            this.elevatorBox.Location = new System.Drawing.Point(267, 195);
            this.elevatorBox.Name = "elevatorBox";
            this.elevatorBox.Size = new System.Drawing.Size(129, 17);
            this.elevatorBox.TabIndex = 12;
            this.elevatorBox.Text = "Is There An Elevator?";
            this.elevatorBox.UseVisualStyleBackColor = true;
            // 
            // porchBox
            // 
            this.porchBox.AutoSize = true;
            this.porchBox.Location = new System.Drawing.Point(267, 245);
            this.porchBox.Name = "porchBox";
            this.porchBox.Size = new System.Drawing.Size(112, 17);
            this.porchBox.TabIndex = 13;
            this.porchBox.Text = "Is There A Porch?";
            this.porchBox.UseVisualStyleBackColor = true;
            // 
            // successText
            // 
            this.successText.AutoSize = true;
            this.successText.ForeColor = System.Drawing.Color.Lime;
            this.successText.Location = new System.Drawing.Point(72, 327);
            this.successText.Name = "successText";
            this.successText.Size = new System.Drawing.Size(0, 13);
            this.successText.TabIndex = 14;
            // 
            // CreateApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(439, 386);
            this.Controls.Add(this.successText);
            this.Controls.Add(this.porchBox);
            this.Controls.Add(this.elevatorBox);
            this.Controls.Add(this.wifiBox);
            this.Controls.Add(this.poolBox);
            this.Controls.Add(this.zipCodeBox);
            this.Controls.Add(this.floorBox);
            this.Controls.Add(this.roomCountBox);
            this.Controls.Add(this.residentsBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.petsBox);
            this.Controls.Add(this.createBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateApartment";
            this.Text = "Add An Apartment!";
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBox;
        private System.Windows.Forms.CheckBox petsBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.NumericUpDown residentsBox;
        private System.Windows.Forms.NumericUpDown roomCountBox;
        private System.Windows.Forms.NumericUpDown floorBox;
        private System.Windows.Forms.NumericUpDown zipCodeBox;
        private System.Windows.Forms.CheckBox poolBox;
        private System.Windows.Forms.CheckBox wifiBox;
        private System.Windows.Forms.CheckBox elevatorBox;
        private System.Windows.Forms.CheckBox porchBox;
        private System.Windows.Forms.Label successText;
    }
}