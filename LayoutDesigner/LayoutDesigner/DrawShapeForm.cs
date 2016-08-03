using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;


namespace DXWindowsApplication1
{
    public partial class DrawShapeForm : Form
    {
        public System.Drawing.Color ChosenColor { get; set; }
        public string ShapeLabel { get;  set; }
        public double ShapeWidth { get;  set; }
        public double  ShapeHeight { get;  set; }
        public double FontSize { get; set; }
        public Shape ChosenShape { get;  set; }
        public string ShapeId { get; set; }
        //public bool BackgroundNode { get; set; }
        public bool AllowIDEdit { get; set; }

        public DrawShapeForm()
        {
            InitializeComponent();

            ChosenShape = Shape.Box;
            FontSize = 1;
            ShapeHeight = 1;
            ShapeWidth = 1;
            ShapeLabel = "ShapeName";

            labelTextEdit.DataBindings.Add(new Binding
            ("Text", this, "ShapeLabel"));

            widthTextEdit.DataBindings.Add(new Binding
           ("Text", this, "ShapeWidth"));

            heightTextEdit.DataBindings.Add(new Binding
           ("Text", this, "ShapeHeight"));

            fontSizeTextEdit.DataBindings.Add(new Binding
           ("Text", this, "FontSize"));

            colorPickEdit.DataBindings.Add(new Binding
            ("Color", this, "ChosenColor"));

            shapeIdTextEdit.DataBindings.Add(new Binding
                ("Text", this, "ShapeId"));

            shapeIdTextEdit.DataBindings.Add(new Binding
                ("Enabled", this, "AllowIDEdit"));

            //isBackgroundCheckBox.DataBindings.Add(new Binding
            //  ("Checked", this, "BackgroundNode"));

            shapeCbox.SelectedItem = ChosenShape.ToString();
            

        }

        
        private void drawButton_Click(object sender, EventArgs e)
        {
            if (shapeCbox.SelectedText != null)
                ChosenShape = (Shape)Enum.Parse(typeof(Shape), shapeCbox.SelectedItem.ToString());
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
             
            
        }


    }
}
