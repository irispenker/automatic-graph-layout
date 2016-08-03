using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraRichEdit.Commands;
using Microsoft.Msagl.Core.Geometry;
using Microsoft.Msagl.Drawing;
using Color = System.Drawing.Color;

namespace DXWindowsApplication1
{

    public interface IPropertiesWrapper
    {
        
    }

    public static class PropertiesWrapperFactory
    {
        private static Dictionary<string, IPropertiesWrapper> objectWrappers =
            new Dictionary<string, IPropertiesWrapper>();

        public static IPropertiesWrapper Getwrapper(object obj)
        {
            var node = obj as Node;
            var edge = obj as Edge;
            IPropertiesWrapper wrapper = null;
            if (node != null)
            {
                if(!objectWrappers.ContainsKey(node.Id))
                     objectWrappers[node.Id] = new NodeWrapper(node);
                wrapper = objectWrappers[node.Id];
            }
            else if (edge != null)
            {
                if (!objectWrappers.ContainsKey(edge.ToString()))
                    objectWrappers[edge.ToString()] = new EdgeWrapper(edge);
                wrapper = objectWrappers[edge.ToString()];
            }
            return wrapper;
        }



    }

    public class NodeWrapper : IPropertiesWrapper
    {

        private bool edited = false;

        public NodeWrapper(Node node)
        {
            Node = node;
            NodeWidth = node.Width;
            NodeHeight = node.Height;
        }


        [Category("General")]
        [Browsable(true)] 
        public Node Node { get;  private set; }

        [Browsable(false)]
        public bool Edited
        {
            get
            {
                return edited ||
                    (NodeWidth != Node.Width) || (NodeHeight != Node.Height); 
            }
            set { edited = value;  }
        }

        [Category("Node")]
        [DisplayName("Width")]
        public double NodeWidth { get; set; }


        [Category("Node")]
        [DisplayName("Height")]
        public double NodeHeight { get; set; }

        [Category("Node")]
        [DisplayName("Fill Color")] 
        public System.Drawing.Color FillColor
        {
            set
            {
                Node.Attr.FillColor = new Microsoft.Msagl.Drawing.Color(value.A,
                                                          value.R,
                                                          value.G,
                                                          value.B);
                Edited = true;
            }
            get { return Color.Transparent;}
        }

        [Category("Node")]
        [DisplayName("Shape")]
        public Shape NodeShape
        {
            get { return Node.Attr.Shape; }
            set
            {
                Node.Attr.Shape = value;
                Edited = true;
            }
        }

        [Category("Node")]
        [DisplayName("Line Width")] 
        public double LineWidth
        {
            set
            {
                Node.Attr.LineWidth = value;
                Edited = true;
            }
            get { return Node.Attr.LineWidth; }
        }

        [Category("Node Label")]
        [DisplayName("Font Size")]
        public double FontSize
        {
            set
            {
                Node.Label.FontSize = value;
                Edited = true;
            }
            get { return Node.Label.FontSize; }
        }

        [Category("Node Label")]
        [DisplayName("Label Text")]
        public string LabelText
        {
            set
            {
                Node.Label.Text = value;
                Edited = true;
            }
            get { return Node.Label.Text; }
        }


        [Category("Node")]
        [DisplayName("User Data")]
        public string UserData
        {
            set
            {
                Node.UserData = value;
            }
            get { return (Node.UserData != null) ? Node.UserData.ToString() : string.Empty; }
        }

    }

    public class EdgeWrapper : IPropertiesWrapper
    {
       
        public EdgeWrapper(Edge edge)
        {
            Edge = edge;
        }

        [Category("General")]
        [Browsable(true)] 
        public Edge Edge { get;  set; }


        [Category("Edge")]
        [DisplayName("Color")]
        public System.Drawing.Color EdgeColor
        {
            set
            {
                Edge.Attr.Color = new Microsoft.Msagl.Drawing.Color(value.A,
                                                          value.R,
                                                          value.G,
                                                          value.B); 
            }
            get { return Color.Transparent; }
        }

        [Category("Edge")]
        [DisplayName("Width")]
        public double LineWidth
        {
            set
            {
                Edge.Attr.LineWidth = value;
               
            }
            get { return Edge.Attr.LineWidth; }
        }

        [Category("Edge")]
        [DisplayName("Arrowhead Style")]
        public ArrowStyle ArrowheadStyle
        {
            set
            {
                Edge.Attr.ArrowheadAtTarget = value;

            }
            get { return Edge.Attr.ArrowheadAtTarget; }
        }

        [Category("Edge")]
        [DisplayName("Arrowhead Length")]
        public double ArrowheadLength
        {
            set
            {
                Edge.Attr.ArrowheadLength = value;
            }
            get { return Edge.Attr.ArrowheadLength; }
        }

        [Category("Edge")]
        [DisplayName("Arrowhead Weight")]
        public int ArrowheadWeight
        {
            set
            {
                 Edge.Attr.Weight  = value;
            }
            get { return Edge.Attr.Weight; }
        }

        [Category("Edge")]
        [DisplayName("User Data")]
        public string UserData
        {
            set
            {
                Edge.UserData = value;
            }
            get { return  (Edge.UserData != null) ? Edge.UserData.ToString() : string.Empty; }
        }

        [Category("Edge")]
        [DisplayName("Edge Id")]
        public string EdgeId
        {
            set
            {
                Edge.Attr.Id = value;
            }
            get { return Edge.Attr.Id; }
        }

    }
}
