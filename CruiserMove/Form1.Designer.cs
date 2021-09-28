
namespace CruiserMove
{
    partial class cruiserMove
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cruiserMove));
            this.create = new System.Windows.Forms.Button();
            this.pictureBoxCruiser = new System.Windows.Forms.PictureBox();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCruiser)).BeginInit();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(13, 13);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(126, 61);
            this.create.TabIndex = 0;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // pictureBoxCruiser
            // 
            this.pictureBoxCruiser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCruiser.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCruiser.Name = "pictureBoxCruiser";
            this.pictureBoxCruiser.Size = new System.Drawing.Size(1323, 718);
            this.pictureBoxCruiser.TabIndex = 6;
            this.pictureBoxCruiser.TabStop = false;
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDown.Location = new System.Drawing.Point(1049, 619);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(70, 70);
            this.buttonDown.TabIndex = 7;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.moveButtons_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeft.Location = new System.Drawing.Point(973, 619);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(70, 70);
            this.buttonLeft.TabIndex = 6;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.moveButtons_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRight.Location = new System.Drawing.Point(1125, 619);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(70, 70);
            this.buttonRight.TabIndex = 8;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.moveButtons_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUp.Location = new System.Drawing.Point(1049, 543);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(70, 70);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.moveButtons_Click);
            // 
            // cruiserMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 718);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.create);
            this.Controls.Add(this.pictureBoxCruiser);
            this.Name = "cruiserMove";
            this.Text = "Cruiser Move";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCruiser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.PictureBox pictureBoxCruiser;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonUp;
    }
}

