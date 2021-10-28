
namespace CruiserMove
{
    partial class FormDock
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
            this.parkingBox = new System.Windows.Forms.PictureBox();
            this.takeCruiser = new System.Windows.Forms.GroupBox();
            this.getCruiser = new System.Windows.Forms.Button();
            this.parkingPlace = new System.Windows.Forms.MaskedTextBox();
            this.place = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parkingName = new System.Windows.Forms.TextBox();
            this.addParking = new System.Windows.Forms.Button();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.removeParking = new System.Windows.Forms.Button();
            this.setCruiserButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBox)).BeginInit();
            this.takeCruiser.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parkingBox
            // 
            this.parkingBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.parkingBox.Location = new System.Drawing.Point(0, 28);
            this.parkingBox.Name = "parkingBox";
            this.parkingBox.Size = new System.Drawing.Size(1067, 654);
            this.parkingBox.TabIndex = 0;
            this.parkingBox.TabStop = false;
            // 
            // takeCruiser
            // 
            this.takeCruiser.Controls.Add(this.getCruiser);
            this.takeCruiser.Controls.Add(this.parkingPlace);
            this.takeCruiser.Controls.Add(this.place);
            this.takeCruiser.Location = new System.Drawing.Point(1088, 503);
            this.takeCruiser.Name = "takeCruiser";
            this.takeCruiser.Size = new System.Drawing.Size(158, 126);
            this.takeCruiser.TabIndex = 3;
            this.takeCruiser.TabStop = false;
            this.takeCruiser.Text = "Take Cruiser";
            // 
            // getCruiser
            // 
            this.getCruiser.Location = new System.Drawing.Point(40, 86);
            this.getCruiser.Name = "getCruiser";
            this.getCruiser.Size = new System.Drawing.Size(75, 23);
            this.getCruiser.TabIndex = 2;
            this.getCruiser.Text = "Get";
            this.getCruiser.UseVisualStyleBackColor = true;
            this.getCruiser.Click += new System.EventHandler(this.getCruiser_Click);
            // 
            // parkingPlace
            // 
            this.parkingPlace.Location = new System.Drawing.Point(81, 46);
            this.parkingPlace.Mask = "00";
            this.parkingPlace.Name = "parkingPlace";
            this.parkingPlace.Size = new System.Drawing.Size(58, 22);
            this.parkingPlace.TabIndex = 1;
            this.parkingPlace.ValidatingType = typeof(int);
            // 
            // place
            // 
            this.place.AutoSize = true;
            this.place.Location = new System.Drawing.Point(11, 49);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(47, 17);
            this.place.TabIndex = 0;
            this.place.Text = "Place:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1140, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parkings";
            // 
            // parkingName
            // 
            this.parkingName.Location = new System.Drawing.Point(1088, 20);
            this.parkingName.Name = "parkingName";
            this.parkingName.Size = new System.Drawing.Size(158, 22);
            this.parkingName.TabIndex = 5;
            // 
            // addParking
            // 
            this.addParking.Location = new System.Drawing.Point(1088, 49);
            this.addParking.Name = "addParking";
            this.addParking.Size = new System.Drawing.Size(158, 28);
            this.addParking.TabIndex = 6;
            this.addParking.Text = "Add Parking";
            this.addParking.UseVisualStyleBackColor = true;
            this.addParking.Click += new System.EventHandler(this.addParking_Click);
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.ItemHeight = 16;
            this.listBoxParkings.Location = new System.Drawing.Point(1088, 83);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(158, 148);
            this.listBoxParkings.TabIndex = 7;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // removeParking
            // 
            this.removeParking.Location = new System.Drawing.Point(1088, 237);
            this.removeParking.Name = "removeParking";
            this.removeParking.Size = new System.Drawing.Size(158, 28);
            this.removeParking.TabIndex = 8;
            this.removeParking.Text = "Remove Parking";
            this.removeParking.UseVisualStyleBackColor = true;
            this.removeParking.Click += new System.EventHandler(this.removeParking_Click);
            // 
            // setCruiserButton
            // 
            this.setCruiserButton.Location = new System.Drawing.Point(1088, 398);
            this.setCruiserButton.Name = "setCruiserButton";
            this.setCruiserButton.Size = new System.Drawing.Size(158, 68);
            this.setCruiserButton.TabIndex = 9;
            this.setCruiserButton.Text = "Set Cruiser";
            this.setCruiserButton.UseVisualStyleBackColor = true;
            this.setCruiserButton.Click += new System.EventHandler(this.setCruiserButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1268, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 682);
            this.Controls.Add(this.setCruiserButton);
            this.Controls.Add(this.removeParking);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.addParking);
            this.Controls.Add(this.parkingName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.takeCruiser);
            this.Controls.Add(this.parkingBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDock";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.parkingBox)).EndInit();
            this.takeCruiser.ResumeLayout(false);
            this.takeCruiser.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox parkingBox;
        private System.Windows.Forms.GroupBox takeCruiser;
        private System.Windows.Forms.Button getCruiser;
        private System.Windows.Forms.MaskedTextBox parkingPlace;
        private System.Windows.Forms.Label place;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parkingName;
        private System.Windows.Forms.Button addParking;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Button removeParking;
        private System.Windows.Forms.Button setCruiserButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}