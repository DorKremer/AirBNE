namespace OOP_Project
{
    partial class AirBNE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirBNE));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewItemsButton = new System.Windows.Forms.Button();
            this.addItemsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.welcomeText = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::OOP_Project.Properties.Resources.BETransparentBlackLogocopy;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(140, 153);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 267);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // viewItemsButton
            // 
            this.viewItemsButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.viewItemsButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.viewItemsButton.Location = new System.Drawing.Point(79, 58);
            this.viewItemsButton.Name = "viewItemsButton";
            this.viewItemsButton.Size = new System.Drawing.Size(634, 41);
            this.viewItemsButton.TabIndex = 43;
            this.viewItemsButton.Text = "View Items";
            this.viewItemsButton.UseVisualStyleBackColor = false;
            this.viewItemsButton.Click += new System.EventHandler(this.itemViewButton_Click);
            // 
            // addItemsButton
            // 
            this.addItemsButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addItemsButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.addItemsButton.Location = new System.Drawing.Point(79, 105);
            this.addItemsButton.Name = "addItemsButton";
            this.addItemsButton.Size = new System.Drawing.Size(634, 41);
            this.addItemsButton.TabIndex = 42;
            this.addItemsButton.Text = "Add Items";
            this.addItemsButton.UseVisualStyleBackColor = false;
            this.addItemsButton.Click += new System.EventHandler(this.itemChoiceButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(25, 188);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 29);
            this.saveButton.TabIndex = 45;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(25, 237);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(88, 29);
            this.loadButton.TabIndex = 46;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.BackgroundImage = global::OOP_Project.Properties.Resources.BETransparentBlackLogocopy;
            this.orderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.orderButton.Location = new System.Drawing.Point(656, 213);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(93, 37);
            this.orderButton.TabIndex = 47;
            this.orderButton.Text = "My Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackgroundImage = global::OOP_Project.Properties.Resources.BETransparentBlackLogocopy;
            this.registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.registerButton.Location = new System.Drawing.Point(656, 278);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(93, 37);
            this.registerButton.TabIndex = 48;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.BackColor = System.Drawing.Color.Transparent;
            this.welcomeText.ForeColor = System.Drawing.Color.Gold;
            this.welcomeText.Location = new System.Drawing.Point(375, 21);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(55, 13);
            this.welcomeText.TabIndex = 49;
            this.welcomeText.Text = "Welcome!";
            // 
            // loginButton
            // 
            this.loginButton.BackgroundImage = global::OOP_Project.Properties.Resources.BETransparentBlackLogocopy;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginButton.Location = new System.Drawing.Point(656, 344);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(93, 37);
            this.loginButton.TabIndex = 50;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // AirBNE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::OOP_Project.Properties.Resources.milky_way_2695569_1280;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.viewItemsButton);
            this.Controls.Add(this.addItemsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AirBNE";
            this.Text = "AirBNE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button viewItemsButton;
        private System.Windows.Forms.Button addItemsButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Button loginButton;
    }
}

