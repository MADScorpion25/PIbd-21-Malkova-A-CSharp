
namespace CruiserMove
{
    partial class FormCruiserConfig
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
            this.pictureCruiserPanel = new System.Windows.Forms.Panel();
            this.pictureBoxCruiser = new System.Windows.Forms.PictureBox();
            this.specs = new System.Windows.Forms.GroupBox();
            this.setWeapons = new System.Windows.Forms.CheckBox();
            this.setHelicopterStation = new System.Windows.Forms.CheckBox();
            this.setLocator = new System.Windows.Forms.CheckBox();
            this.numericWeight = new System.Windows.Forms.NumericUpDown();
            this.numericMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bodyType = new System.Windows.Forms.GroupBox();
            this.labelWarCruiser = new System.Windows.Forms.Label();
            this.labelCruiser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAdditionColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelPaleTurquoise = new System.Windows.Forms.Panel();
            this.panelGradientActiveCaption = new System.Windows.Forms.Panel();
            this.panelActiveCaptionText = new System.Windows.Forms.Panel();
            this.panelControlDark = new System.Windows.Forms.Panel();
            this.panelMediumPurple = new System.Windows.Forms.Panel();
            this.panelActiveCaption = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelActiveBorder = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pictureCruiserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCruiser)).BeginInit();
            this.specs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxSpeed)).BeginInit();
            this.bodyType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureCruiserPanel
            // 
            this.pictureCruiserPanel.AllowDrop = true;
            this.pictureCruiserPanel.Controls.Add(this.pictureBoxCruiser);
            this.pictureCruiserPanel.Location = new System.Drawing.Point(409, 22);
            this.pictureCruiserPanel.Name = "pictureCruiserPanel";
            this.pictureCruiserPanel.Size = new System.Drawing.Size(320, 236);
            this.pictureCruiserPanel.TabIndex = 5;
            this.pictureCruiserPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureCruiserPanel_DragDrop);
            this.pictureCruiserPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureCruiserPanel_DragEnter);
            // 
            // pictureBoxCruiser
            // 
            this.pictureBoxCruiser.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCruiser.Name = "pictureBoxCruiser";
            this.pictureBoxCruiser.Size = new System.Drawing.Size(314, 230);
            this.pictureBoxCruiser.TabIndex = 0;
            this.pictureBoxCruiser.TabStop = false;
            // 
            // specs
            // 
            this.specs.Controls.Add(this.setWeapons);
            this.specs.Controls.Add(this.setHelicopterStation);
            this.specs.Controls.Add(this.setLocator);
            this.specs.Controls.Add(this.numericWeight);
            this.specs.Controls.Add(this.numericMaxSpeed);
            this.specs.Controls.Add(this.label2);
            this.specs.Controls.Add(this.label1);
            this.specs.Location = new System.Drawing.Point(65, 306);
            this.specs.Name = "specs";
            this.specs.Size = new System.Drawing.Size(664, 169);
            this.specs.TabIndex = 4;
            this.specs.TabStop = false;
            this.specs.Text = "Параметры";
            // 
            // setWeapons
            // 
            this.setWeapons.AutoSize = true;
            this.setWeapons.Checked = true;
            this.setWeapons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.setWeapons.Location = new System.Drawing.Point(202, 118);
            this.setWeapons.Name = "setWeapons";
            this.setWeapons.Size = new System.Drawing.Size(80, 21);
            this.setWeapons.TabIndex = 6;
            this.setWeapons.Text = "Орудия";
            this.setWeapons.UseVisualStyleBackColor = true;
            // 
            // setHelicopterStation
            // 
            this.setHelicopterStation.AutoSize = true;
            this.setHelicopterStation.Checked = true;
            this.setHelicopterStation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.setHelicopterStation.Location = new System.Drawing.Point(202, 77);
            this.setHelicopterStation.Name = "setHelicopterStation";
            this.setHelicopterStation.Size = new System.Drawing.Size(187, 21);
            this.setHelicopterStation.TabIndex = 5;
            this.setHelicopterStation.Text = "Вертолетная площадка";
            this.setHelicopterStation.UseVisualStyleBackColor = true;
            // 
            // setLocator
            // 
            this.setLocator.AutoSize = true;
            this.setLocator.Checked = true;
            this.setLocator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.setLocator.Location = new System.Drawing.Point(202, 41);
            this.setLocator.Name = "setLocator";
            this.setLocator.Size = new System.Drawing.Size(86, 21);
            this.setLocator.TabIndex = 4;
            this.setLocator.Text = "Локатор";
            this.setLocator.UseVisualStyleBackColor = true;
            // 
            // numericWeight
            // 
            this.numericWeight.Location = new System.Drawing.Point(6, 126);
            this.numericWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericWeight.Name = "numericWeight";
            this.numericWeight.Size = new System.Drawing.Size(120, 22);
            this.numericWeight.TabIndex = 3;
            this.numericWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericMaxSpeed
            // 
            this.numericMaxSpeed.Location = new System.Drawing.Point(7, 57);
            this.numericMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericMaxSpeed.Name = "numericMaxSpeed";
            this.numericMaxSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericMaxSpeed.TabIndex = 2;
            this.numericMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес крейсера";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Макс. скорость";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // bodyType
            // 
            this.bodyType.Controls.Add(this.labelWarCruiser);
            this.bodyType.Controls.Add(this.labelCruiser);
            this.bodyType.Location = new System.Drawing.Point(65, 22);
            this.bodyType.Name = "bodyType";
            this.bodyType.Size = new System.Drawing.Size(323, 236);
            this.bodyType.TabIndex = 3;
            this.bodyType.TabStop = false;
            this.bodyType.Text = "Тип кузова";
            // 
            // labelWarCruiser
            // 
            this.labelWarCruiser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWarCruiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWarCruiser.Location = new System.Drawing.Point(42, 130);
            this.labelWarCruiser.Name = "labelWarCruiser";
            this.labelWarCruiser.Size = new System.Drawing.Size(223, 69);
            this.labelWarCruiser.TabIndex = 9;
            this.labelWarCruiser.Text = "Военный крейсер";
            this.labelWarCruiser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWarCruiser.UseCompatibleTextRendering = true;
            this.labelWarCruiser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelWarCruiser_MouseDown);
            // 
            // labelCruiser
            // 
            this.labelCruiser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCruiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCruiser.Location = new System.Drawing.Point(42, 27);
            this.labelCruiser.Name = "labelCruiser";
            this.labelCruiser.Size = new System.Drawing.Size(223, 69);
            this.labelCruiser.TabIndex = 8;
            this.labelCruiser.Text = "Обычный крейсер";
            this.labelCruiser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCruiser.UseCompatibleTextRendering = true;
            this.labelCruiser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCruiser_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAdditionColor);
            this.groupBox1.Controls.Add(this.labelMainColor);
            this.groupBox1.Controls.Add(this.panelPaleTurquoise);
            this.groupBox1.Controls.Add(this.panelGradientActiveCaption);
            this.groupBox1.Controls.Add(this.panelActiveCaptionText);
            this.groupBox1.Controls.Add(this.panelControlDark);
            this.groupBox1.Controls.Add(this.panelMediumPurple);
            this.groupBox1.Controls.Add(this.panelActiveCaption);
            this.groupBox1.Controls.Add(this.panelRed);
            this.groupBox1.Controls.Add(this.panelActiveBorder);
            this.groupBox1.Location = new System.Drawing.Point(761, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 257);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цвет";
            // 
            // labelAdditionColor
            // 
            this.labelAdditionColor.AllowDrop = true;
            this.labelAdditionColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdditionColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdditionColor.Location = new System.Drawing.Point(284, 28);
            this.labelAdditionColor.Name = "labelAdditionColor";
            this.labelAdditionColor.Size = new System.Drawing.Size(155, 39);
            this.labelAdditionColor.TabIndex = 11;
            this.labelAdditionColor.Text = "Дополнительный цвет";
            this.labelAdditionColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAdditionColor.UseCompatibleTextRendering = true;
            this.labelAdditionColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelAdditionColor_DragDrop);
            this.labelAdditionColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelAdditionColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainColor.Location = new System.Drawing.Point(29, 28);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(155, 39);
            this.labelMainColor.TabIndex = 10;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.UseCompatibleTextRendering = true;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelPaleTurquoise
            // 
            this.panelPaleTurquoise.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelPaleTurquoise.Location = new System.Drawing.Point(379, 173);
            this.panelPaleTurquoise.Name = "panelPaleTurquoise";
            this.panelPaleTurquoise.Size = new System.Drawing.Size(60, 60);
            this.panelPaleTurquoise.TabIndex = 3;
            // 
            // panelGradientActiveCaption
            // 
            this.panelGradientActiveCaption.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelGradientActiveCaption.Location = new System.Drawing.Point(124, 173);
            this.panelGradientActiveCaption.Name = "panelGradientActiveCaption";
            this.panelGradientActiveCaption.Size = new System.Drawing.Size(60, 60);
            this.panelGradientActiveCaption.TabIndex = 1;
            // 
            // panelActiveCaptionText
            // 
            this.panelActiveCaptionText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelActiveCaptionText.Location = new System.Drawing.Point(284, 173);
            this.panelActiveCaptionText.Name = "panelActiveCaptionText";
            this.panelActiveCaptionText.Size = new System.Drawing.Size(60, 60);
            this.panelActiveCaptionText.TabIndex = 4;
            // 
            // panelControlDark
            // 
            this.panelControlDark.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelControlDark.Location = new System.Drawing.Point(29, 173);
            this.panelControlDark.Name = "panelControlDark";
            this.panelControlDark.Size = new System.Drawing.Size(60, 60);
            this.panelControlDark.TabIndex = 1;
            // 
            // panelMediumPurple
            // 
            this.panelMediumPurple.BackColor = System.Drawing.Color.MediumPurple;
            this.panelMediumPurple.Location = new System.Drawing.Point(379, 85);
            this.panelMediumPurple.Name = "panelMediumPurple";
            this.panelMediumPurple.Size = new System.Drawing.Size(60, 60);
            this.panelMediumPurple.TabIndex = 5;
            // 
            // panelActiveCaption
            // 
            this.panelActiveCaption.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelActiveCaption.Location = new System.Drawing.Point(124, 85);
            this.panelActiveCaption.Name = "panelActiveCaption";
            this.panelActiveCaption.Size = new System.Drawing.Size(60, 60);
            this.panelActiveCaption.TabIndex = 1;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(284, 85);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(60, 60);
            this.panelRed.TabIndex = 2;
            // 
            // panelActiveBorder
            // 
            this.panelActiveBorder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelActiveBorder.Location = new System.Drawing.Point(29, 85);
            this.panelActiveBorder.Name = "panelActiveBorder";
            this.panelActiveBorder.Size = new System.Drawing.Size(60, 60);
            this.panelActiveBorder.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(946, 296);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 63);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(946, 402);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 63);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // FormCruiserConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 507);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureCruiserPanel);
            this.Controls.Add(this.specs);
            this.Controls.Add(this.bodyType);
            this.Name = "FormCruiserConfig";
            this.Text = "FormCruiserConfig";
            this.pictureCruiserPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCruiser)).EndInit();
            this.specs.ResumeLayout(false);
            this.specs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxSpeed)).EndInit();
            this.bodyType.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pictureCruiserPanel;
        private System.Windows.Forms.PictureBox pictureBoxCruiser;
        private System.Windows.Forms.GroupBox specs;
        private System.Windows.Forms.CheckBox setWeapons;
        private System.Windows.Forms.CheckBox setHelicopterStation;
        private System.Windows.Forms.CheckBox setLocator;
        private System.Windows.Forms.NumericUpDown numericWeight;
        private System.Windows.Forms.NumericUpDown numericMaxSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox bodyType;
        private System.Windows.Forms.Label labelWarCruiser;
        private System.Windows.Forms.Label labelCruiser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAdditionColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelPaleTurquoise;
        private System.Windows.Forms.Panel panelGradientActiveCaption;
        private System.Windows.Forms.Panel panelActiveCaptionText;
        private System.Windows.Forms.Panel panelControlDark;
        private System.Windows.Forms.Panel panelMediumPurple;
        private System.Windows.Forms.Panel panelActiveCaption;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelActiveBorder;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}