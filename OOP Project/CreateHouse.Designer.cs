namespace OOP_Project
{
    partial class CreateHouse
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
            this.successText = new System.Windows.Forms.Label();
            this.wifiBox = new System.Windows.Forms.CheckBox();
            this.poolBox = new System.Windows.Forms.CheckBox();
            this.zipCodeBox = new System.Windows.Forms.NumericUpDown();
            this.roomCountBox = new System.Windows.Forms.NumericUpDown();
            this.residentsBox = new System.Windows.Forms.NumericUpDown();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.petsBox = new System.Windows.Forms.CheckBox();
            this.createBox = new System.Windows.Forms.Button();
            this.floorsBox = new System.Windows.Forms.NumericUpDown();
            this.yardBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // successText
            // 
            this.successText.AutoSize = true;
            this.successText.ForeColor = System.Drawing.Color.Lime;
            this.successText.Location = new System.Drawing.Point(45, 316);
            this.successText.Name = "successText";
            this.successText.Size = new System.Drawing.Size(0, 13);
            this.successText.TabIndex = 28;
            // 
            // wifiBox
            // 
            this.wifiBox.AutoSize = true;
            this.wifiBox.Location = new System.Drawing.Point(240, 132);
            this.wifiBox.Name = "wifiBox";
            this.wifiBox.Size = new System.Drawing.Size(92, 17);
            this.wifiBox.TabIndex = 25;
            this.wifiBox.Text = "Is There Wifi?";
            this.wifiBox.UseVisualStyleBackColor = true;
            // 
            // poolBox
            // 
            this.poolBox.AutoSize = true;
            this.poolBox.Location = new System.Drawing.Point(240, 80);
            this.poolBox.Name = "poolBox";
            this.poolBox.Size = new System.Drawing.Size(105, 17);
            this.poolBox.TabIndex = 24;
            this.poolBox.Text = "Is There A Pool?";
            this.poolBox.UseVisualStyleBackColor = true;
            // 
            // zipCodeBox
            // 
            this.zipCodeBox.Location = new System.Drawing.Point(48, 184);
            this.zipCodeBox.Name = "zipCodeBox";
            this.zipCodeBox.Size = new System.Drawing.Size(186, 20);
            this.zipCodeBox.TabIndex = 23;
            // 
            // roomCountBox
            // 
            this.roomCountBox.Location = new System.Drawing.Point(48, 132);
            this.roomCountBox.Name = "roomCountBox";
            this.roomCountBox.Size = new System.Drawing.Size(186, 20);
            this.roomCountBox.TabIndex = 21;
            // 
            // residentsBox
            // 
            this.residentsBox.Location = new System.Drawing.Point(48, 106);
            this.residentsBox.Name = "residentsBox";
            this.residentsBox.Size = new System.Drawing.Size(186, 20);
            this.residentsBox.TabIndex = 20;
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.White;
            this.priceBox.ForeColor = System.Drawing.Color.Black;
            this.priceBox.Location = new System.Drawing.Point(48, 80);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(186, 20);
            this.priceBox.TabIndex = 19;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(48, 54);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(186, 20);
            this.descriptionBox.TabIndex = 18;
            this.descriptionBox.Text = "Enter Description...";
            this.descriptionBox.Enter += new System.EventHandler(this.descriptionBox_Enter);
            this.descriptionBox.Leave += new System.EventHandler(this.descriptionBox_Leave);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(48, 28);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(186, 20);
            this.addressBox.TabIndex = 17;
            this.addressBox.Text = "Enter Address...";
            this.addressBox.Enter += new System.EventHandler(this.addressBox_Enter);
            this.addressBox.Leave += new System.EventHandler(this.addressBox_Leave);
            // 
            // petsBox
            // 
            this.petsBox.AutoSize = true;
            this.petsBox.Location = new System.Drawing.Point(240, 28);
            this.petsBox.Name = "petsBox";
            this.petsBox.Size = new System.Drawing.Size(112, 17);
            this.petsBox.TabIndex = 16;
            this.petsBox.Text = "Are Pets Allowed?";
            this.petsBox.UseVisualStyleBackColor = true;
            // 
            // createBox
            // 
            this.createBox.Location = new System.Drawing.Point(48, 234);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(186, 61);
            this.createBox.TabIndex = 15;
            this.createBox.Text = "Add House";
            this.createBox.UseVisualStyleBackColor = true;
            this.createBox.Click += new System.EventHandler(this.createBox_Click);
            this.createBox.Leave += new System.EventHandler(this.createBox_Leave);
            // 
            // floorsBox
            // 
            this.floorsBox.Location = new System.Drawing.Point(48, 158);
            this.floorsBox.Name = "floorsBox";
            this.floorsBox.Size = new System.Drawing.Size(186, 20);
            this.floorsBox.TabIndex = 22;
            // 
            // yardBox
            // 
            this.yardBox.AutoSize = true;
            this.yardBox.Location = new System.Drawing.Point(240, 184);
            this.yardBox.Name = "yardBox";
            this.yardBox.Size = new System.Drawing.Size(106, 17);
            this.yardBox.TabIndex = 26;
            this.yardBox.Text = "Is There A Yard?";
            this.yardBox.UseVisualStyleBackColor = true;
            // 
            // CreateHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(392, 371);
            this.Controls.Add(this.successText);
            this.Controls.Add(this.yardBox);
            this.Controls.Add(this.wifiBox);
            this.Controls.Add(this.poolBox);
            this.Controls.Add(this.zipCodeBox);
            this.Controls.Add(this.floorsBox);
            this.Controls.Add(this.roomCountBox);
            this.Controls.Add(this.residentsBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.petsBox);
            this.Controls.Add(this.createBox);
            this.Name = "CreateHouse";
            this.Text = "Create A House!";
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label successText;
        private System.Windows.Forms.CheckBox wifiBox;
        private System.Windows.Forms.CheckBox poolBox;
        private System.Windows.Forms.NumericUpDown zipCodeBox;
        private System.Windows.Forms.NumericUpDown roomCountBox;
        private System.Windows.Forms.NumericUpDown residentsBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.CheckBox petsBox;
        private System.Windows.Forms.Button createBox;
        private System.Windows.Forms.NumericUpDown floorsBox;
        private System.Windows.Forms.CheckBox yardBox;
    }
}