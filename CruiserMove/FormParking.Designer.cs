
namespace CruiserMove
{
    partial class FormParking
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
            this.setSimpleCruiser = new System.Windows.Forms.Button();
            this.setWarCruiser = new System.Windows.Forms.Button();
            this.takeCruiser = new System.Windows.Forms.GroupBox();
            this.place = new System.Windows.Forms.Label();
            this.parkingPlace = new System.Windows.Forms.MaskedTextBox();
            this.getCruiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBox)).BeginInit();
            this.takeCruiser.SuspendLayout();
            this.SuspendLayout();
            // 
            // parkingBox
            // 
            this.parkingBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.parkingBox.Location = new System.Drawing.Point(0, 0);
            this.parkingBox.Name = "parkingBox";
            this.parkingBox.Size = new System.Drawing.Size(1067, 682);
            this.parkingBox.TabIndex = 0;
            this.parkingBox.TabStop = false;
            // 
            // setSimpleCruiser
            // 
            this.setSimpleCruiser.Location = new System.Drawing.Point(1087, 12);
            this.setSimpleCruiser.Name = "setSimpleCruiser";
            this.setSimpleCruiser.Size = new System.Drawing.Size(158, 68);
            this.setSimpleCruiser.TabIndex = 1;
            this.setSimpleCruiser.Text = "Set Simple Cruiser";
            this.setSimpleCruiser.UseVisualStyleBackColor = true;
            this.setSimpleCruiser.Click += new System.EventHandler(this.setSimpleCruiser_Click);
            // 
            // setWarCruiser
            // 
            this.setWarCruiser.Location = new System.Drawing.Point(1087, 96);
            this.setWarCruiser.Name = "setWarCruiser";
            this.setWarCruiser.Size = new System.Drawing.Size(158, 68);
            this.setWarCruiser.TabIndex = 2;
            this.setWarCruiser.Text = "Set War Cruiser";
            this.setWarCruiser.UseVisualStyleBackColor = true;
            this.setWarCruiser.Click += new System.EventHandler(this.setWarCruiser_Click);
            // 
            // takeCruiser
            // 
            this.takeCruiser.Controls.Add(this.getCruiser);
            this.takeCruiser.Controls.Add(this.parkingPlace);
            this.takeCruiser.Controls.Add(this.place);
            this.takeCruiser.Location = new System.Drawing.Point(1087, 197);
            this.takeCruiser.Name = "takeCruiser";
            this.takeCruiser.Size = new System.Drawing.Size(158, 126);
            this.takeCruiser.TabIndex = 3;
            this.takeCruiser.TabStop = false;
            this.takeCruiser.Text = "Take Cruiser";
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
            // parkingPlace
            // 
            this.parkingPlace.Location = new System.Drawing.Point(81, 46);
            this.parkingPlace.Mask = "00";
            this.parkingPlace.Name = "parkingPlace";
            this.parkingPlace.Size = new System.Drawing.Size(58, 22);
            this.parkingPlace.TabIndex = 1;
            this.parkingPlace.ValidatingType = typeof(int);
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
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 682);
            this.Controls.Add(this.takeCruiser);
            this.Controls.Add(this.setWarCruiser);
            this.Controls.Add(this.setSimpleCruiser);
            this.Controls.Add(this.parkingBox);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.parkingBox)).EndInit();
            this.takeCruiser.ResumeLayout(false);
            this.takeCruiser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox parkingBox;
        private System.Windows.Forms.Button setSimpleCruiser;
        private System.Windows.Forms.Button setWarCruiser;
        private System.Windows.Forms.GroupBox takeCruiser;
        private System.Windows.Forms.Button getCruiser;
        private System.Windows.Forms.MaskedTextBox parkingPlace;
        private System.Windows.Forms.Label place;
    }
}