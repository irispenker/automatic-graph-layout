namespace DXWindowsApplication1
{
    partial class DrawShapeForm
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
            this.widthTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.drawButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.shapeCbox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.colorPickEdit = new DevExpress.XtraEditors.ColorPickEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.heightTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.fontSizeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.shapeIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeCbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeIdTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // widthTextEdit
            // 
            this.widthTextEdit.Location = new System.Drawing.Point(128, 69);
            this.widthTextEdit.Name = "widthTextEdit";
            this.widthTextEdit.Size = new System.Drawing.Size(82, 20);
            this.widthTextEdit.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Width \\ Radius (min. 1)";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(62, 207);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(68, 23);
            this.drawButton.TabIndex = 7;
            this.drawButton.Text = "Draw";
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Choose Fill Color";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(94, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Choose Your Shape";
            // 
            // shapeCbox
            // 
            this.shapeCbox.Location = new System.Drawing.Point(110, 14);
            this.shapeCbox.Name = "shapeCbox";
            this.shapeCbox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shapeCbox.Properties.Items.AddRange(new object[] {
            "Box",
            "Ellipse",
            "Circle",
            "Point",
            "Diamond",
            "Hexagon",
            "Octagon"});
            this.shapeCbox.Size = new System.Drawing.Size(100, 20);
            this.shapeCbox.TabIndex = 10;
            // 
            // colorPickEdit
            // 
            this.colorPickEdit.EditValue = System.Drawing.Color.Empty;
            this.colorPickEdit.Location = new System.Drawing.Point(110, 41);
            this.colorPickEdit.Name = "colorPickEdit";
            this.colorPickEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorPickEdit.Size = new System.Drawing.Size(100, 20);
            this.colorPickEdit.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 97);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Height (min. 1)";
            // 
            // heightTextEdit
            // 
            this.heightTextEdit.Location = new System.Drawing.Point(128, 94);
            this.heightTextEdit.Name = "heightTextEdit";
            this.heightTextEdit.Size = new System.Drawing.Size(82, 20);
            this.heightTextEdit.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 124);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Label";
            // 
            // labelTextEdit
            // 
            this.labelTextEdit.Location = new System.Drawing.Point(128, 121);
            this.labelTextEdit.Name = "labelTextEdit";
            this.labelTextEdit.Size = new System.Drawing.Size(82, 20);
            this.labelTextEdit.TabIndex = 14;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(136, 207);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 171);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 13);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Font Size (min. 1)";
            // 
            // fontSizeTextEdit
            // 
            this.fontSizeTextEdit.Location = new System.Drawing.Point(128, 168);
            this.fontSizeTextEdit.Name = "fontSizeTextEdit";
            this.fontSizeTextEdit.Size = new System.Drawing.Size(82, 20);
            this.fontSizeTextEdit.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 147);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(43, 13);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "Shape Id";
            // 
            // shapeIdTextEdit
            // 
            this.shapeIdTextEdit.Location = new System.Drawing.Point(128, 144);
            this.shapeIdTextEdit.Name = "shapeIdTextEdit";
            this.shapeIdTextEdit.Size = new System.Drawing.Size(82, 20);
            this.shapeIdTextEdit.TabIndex = 19;
            // 
            // DrawShapeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 238);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.shapeIdTextEdit);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.fontSizeTextEdit);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelTextEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.heightTextEdit);
            this.Controls.Add(this.colorPickEdit);
            this.Controls.Add(this.shapeCbox);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.widthTextEdit);
            this.Name = "DrawShapeForm";
            this.Text = "DrawShapeForm";
            ((System.ComponentModel.ISupportInitialize)(this.widthTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeCbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeIdTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit widthTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton drawButton;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit shapeCbox;
        private DevExpress.XtraEditors.ColorPickEdit colorPickEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit heightTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit labelTextEdit;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit fontSizeTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit shapeIdTextEdit;

    }
}