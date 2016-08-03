using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.Core.DataStructures;
using Microsoft.Msagl.Core.Geometry;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Routing;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Color = Microsoft.Msagl.Drawing.Color;
using DrawingNode = Microsoft.Msagl.Drawing.Node;


namespace DXWindowsApplication1
{
    public partial class Main : Form
    {

        private DrawShapeForm drawForm = new DrawShapeForm();
        private ToolTip toolTip = new ToolTip();
        private GViewer gViewer;
        private object selectedObject;
        private AttributeBase selectedObjectAttr;

        private Graph graph;
        private int idcounter = 0;
        private double NodeWidth { set; get; }
        private double NodeHeight { set; get; }
        private double NodeRadius { set; get; }
        internal const int MinSize = 1;
        internal const float RadiusRatio = 0.3f;
       
        /// <summary>
        /// The point where the user called up the context menu.
        /// </summary>
        private Microsoft.Msagl.Core.Geometry.Point mouseButtonDownPoint;

        public Main()
        {
            InitializeComponent();

            //Initiate a GViewer for this window. Register for it's events
            gViewer = new GViewer() { Dock = DockStyle.Fill, AutoSize = true, LayoutAlgorithmSettingsButtonVisible = false };
            gViewer.ObjectUnderMouseCursorChanged += new EventHandler<ObjectUnderMouseCursorChangedEventArgs>(gViewer_ObjectUnderMouseCursorChanged);
            (gViewer as IViewer).MouseDown += viewer_MouseDown;
            gViewer.GraphSavingStarted += gViewer_GraphSavingStarted;
            gViewer.ZoomWhenMouseWheelScroll = true;
            
            //add gviewer to window
            this.SuspendLayout();
            this.panel2.Controls.Add(gViewer);
            this.ResumeLayout();

            InitGraph();
            InitContextMenu();
        }

        /// <summary>
        /// Create Shape Context manu
        /// </summary>
        private void InitContextMenu()
        {
            MenuItem deleteItem = new MenuItem("Delete Shape", DeleteItemOnClick);
            this.ContextMenu = new ContextMenu(new[] {deleteItem});
        }

        /// <summary>
        /// Edit Shape properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void OnPropertyControlLeave(object sender, EventArgs eventArgs)
        {
            var selectedNode = propertyGridControl.SelectedObject as NodeWrapper;
            if (selectedNode != null && selectedNode.Edited) //if not Edge
            {
                selectedObjectAttr = selectedNode.Node.Attr.Clone();

                NodeWidth = selectedNode.NodeWidth;
                NodeHeight = selectedNode.NodeHeight;
                NodeCenter = selectedNode.Node.Pos;

                selectedObjectAttr = selectedNode.Node.Attr.Clone();
                selectedNode.Node.GeometryNode.BoundaryCurve = DrawCurve(selectedNode.Node);
                //replace the current gemoetrix curve}
                selectedNode.Edited = false;
                
            }
            else
            {
                //var selectedEdge = propertyGridControl.SelectedObject as EdgeWrapper;
                //if (selectedEdge != null )//&& selectedEdge.Edited) //if not Edge
                //{
                //    selectedEdge.Edge.GeometryEdge = 
                //}
            }

            gViewer.Refresh();
        }

        /// <summary>
        /// Delete Shape and his Edges - Copied code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void DeleteItemOnClick(object sender, EventArgs eventArgs)
        {
            var al = new ArrayList();
            foreach (IViewerObject ob in gViewer.Entities)
                if (ob.MarkedForDragging)
                    al.Add(ob);
            foreach (IViewerObject ob in al)
            {
                var edge = ob.DrawingObject as IViewerEdge;
                if (edge != null)
                    gViewer.RemoveEdge(edge, true);
                else
                {
                    var node = ob as IViewerNode;
                    if (node != null)
                        gViewer.RemoveNode(node, true);
                }
            }
        }

        /// <summary>
        /// Before saving pin all to the same layer, so the nodes will be saved in current location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void gViewer_GraphSavingStarted(object sender, EventArgs e)
        {
            graph.LayerConstraints.PinNodesToSameLayer(graph.Nodes.ToArray());
        }

        /// <summary>
        /// Load defualt graph for allowing edit.
        /// </summary>
        private void InitGraph()
        {
            graph = new Graph("graph");
            var sugiyamaSettings = (Microsoft.Msagl.Layout.Layered.SugiyamaLayoutSettings)graph.LayoutAlgorithmSettings;
            sugiyamaSettings.NodeSeparation *= 2;
            
            #region Change Defult settings of the graph 
            
            graph.Attr.MinNodeWidth = MinSize;
            graph.Attr.MinNodeHeight = MinSize;
            graph.Attr.LineWidth = 0.1;
            //graph.Attr.BackgroundColor = Color.Transparent;
            
            #endregion Change Defult settings of the graph

          
            gViewer.Graph = graph;
            gViewer.Refresh();

        }

   
        /// <summary>
        /// If right click on empty space - open new node creation form.
        /// If right click on existing node - allow delete this node
        /// if left click and selected object is not null - show its proprties in grid and allow edit those.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void viewer_MouseDown(object sender, MsaglMouseEventArgs e)
        {
            mouseButtonDownPoint = (gViewer).ScreenToSource(e);
            if(gViewer.SelectedObject != null)
                selectedObject = PropertiesWrapperFactory.Getwrapper(gViewer.SelectedObject);

            
            //if clicked on object - open its properties for watch\edit.
            if (e.LeftButtonIsPressed && selectedObject != null)//&& !e.Handled)
            {
                propertyGridControl.SelectedObject = selectedObject;
            }
            //if right click - ask to delete if not edge (edge has its own menu)
            else if (e.RightButtonIsPressed && !e.Handled)
            {
                if (gViewer.SelectedObject == null)
                {
                    drawForm.ShapeId = GetNewId();
                    drawForm.AllowIDEdit = true;
                    DialogResult result = drawForm.ShowDialog(this);
                    if (result != DialogResult.Cancel)
                        Draw(mouseButtonDownPoint);
                }
                else
                {
                    var node = selectedObject as NodeWrapper;
                    //if selected node. for edge there is its own menu
                    if (node != null)
                    {
                        this.ContextMenu.Show(this, new System.Drawing.Point(e.X, e.Y));
                    }
                }
           
            }
        }

        
       

      
        private Microsoft.Msagl.Core.Geometry.Point NodeCenter { set; get; }

        /// <summary>
        /// Draw new shape
        /// </summary>
        /// <param name="centerLocation"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private Microsoft.Msagl.Drawing.Node Draw(Microsoft.Msagl.Core.Geometry.Point centerLocation)
        {
           
            graph = gViewer.Graph;
            var id = drawForm.ShapeId;
            Microsoft.Msagl.Drawing.Node node = graph.AddNode(id);
            node.Label.Text = drawForm.ShapeLabel;
            node.Attr.Shape = drawForm.ChosenShape;
            node.Attr.Color = Color.Black;
            node.Attr.FillColor = new Microsoft.Msagl.Drawing.Color(drawForm.ChosenColor.A,
                                                            drawForm.ChosenColor.R,
                                                            drawForm.ChosenColor.G,
                                                            drawForm.ChosenColor.B);
            node.Attr.LineWidth = MinSize/5;
            node.Attr.XRadius = node.Attr.YRadius = MinSize/2;
            node.Label.FontColor = Color.Black;
            node.Label.FontSize = drawForm.FontSize;
            
            NodeWidth = drawForm.ShapeWidth; 
            NodeHeight = drawForm.ShapeHeight;
            NodeCenter = centerLocation;
            node.NodeBoundaryDelegate = new DelegateToSetNodeBoundary(DrawCurve);
            //if (drawForm.BackgroundNode)
            //{
            //    node.NodeBoundaryDelegate = new DelegateToSetNodeBoundary(GetNodeBoundary);
            //    node.DrawNodeDelegate = new DelegateToOverrideNodeRendering(DrawImageNode);
            //    drawForm.BackgroundNode = false;
            //}
            IViewerNode dNode = gViewer.CreateIViewerNode(node, centerLocation, null);
            
            gViewer.AddNode(dNode, true);
           // gViewer.ResizeNodeToLabel(node);
            return node;
         
        }


        /// <summary>
        /// Controlling the draw because a need to control the size.
        /// 
        /// Supporting these shapes :
        /// Box
        /// Ellipse
        /// Circle
        /// Plaintext
        /// Point
        /// </summary>
        /// <param name="node"></param>
        /// <param name="centerLocation"></param>
        /// <param name="width"></param>
        /// <param name="hight"></param>
        /// <returns></returns>
        ICurve DrawCurve(Microsoft.Msagl.Drawing.Node node)
        {
            ICurve shape = null;
            switch (node.Attr.Shape)
            {
                case Shape.Box:
                    shape = CurveFactory.CreateRectangle(NodeWidth, NodeHeight, NodeCenter);
                    break;
                case Shape.Ellipse:
                    shape = CurveFactory.CreateEllipse(NodeWidth,NodeHeight, NodeCenter);
                    break;
                case Shape.Circle:
                    shape = CurveFactory.CreateCircle(NodeWidth,  NodeCenter);
                    break;
                case Shape.Point:
                    shape = CurveFactory.CreateCircle(0.5, NodeCenter);
                    break;
                case Shape.Diamond:
                    shape = CurveFactory.CreateDiamond(NodeWidth,NodeHeight, NodeCenter);
                    break;
                case Shape.Hexagon:
                    shape = CurveFactory.CreateHexagon(NodeWidth, NodeHeight, NodeCenter);
                    break;
                case Shape.Octagon:
                    shape = CurveFactory.CreateOctagon(NodeWidth, NodeHeight, NodeCenter);
                    break;
            }
            return shape;
        }

        #region Copied code
     

        string GetNewId()
        {
            string ret = "ID-" + idcounter++;
            if (gViewer.Graph.FindNode(ret) != null)
                return GetNewId();
            return ret;
        }

        void gViewer_ObjectUnderMouseCursorChanged(object sender, ObjectUnderMouseCursorChangedEventArgs e)
        {
            selectedObject = e.OldObject != null ? e.OldObject.DrawingObject : null;

            if (selectedObject != null)
            {
                RestoreSelectedObjAttr();
                gViewer.Invalidate(e.OldObject);
                selectedObject = null;
            }

            if (gViewer.SelectedObject == null)
            {
                infoLabel.Text = "No object under the mouse";
                gViewer.SetToolTip(toolTip, "");
            }
            else
            {
                selectedObject = gViewer.SelectedObject;
                var edge = selectedObject as Edge;
                if (edge != null)
                {
                    selectedObjectAttr = edge.Attr.Clone();
                    edge.Attr.Color = Color.Blue;
                    gViewer.Invalidate(e.NewObject);

                    //         here we can use e.Attr.Id or e.UserData to get back to the user data
                    gViewer.SetToolTip(toolTip, String.Format("edge from {0} to {1}", edge.Source, edge.Target));
                }
                else if (selectedObject is Microsoft.Msagl.Drawing.Node)
                {
                    selectedObjectAttr = (gViewer.SelectedObject as Microsoft.Msagl.Drawing.Node).Attr.Clone();
                    (selectedObject as Microsoft.Msagl.Drawing.Node).Attr.Color = Color.Green;
                    // //   here you can use e.Attr.Id to get back to your data
                    gViewer.SetToolTip(toolTip,
                                       String.Format("node {0}",
                                                     (selectedObject as Microsoft.Msagl.Drawing.Node).Attr.Id));
                    gViewer.Invalidate(e.NewObject);
                }
                infoLabel.Text = selectedObject.ToString();
            }

        }

        void RestoreSelectedObjAttr()
        {
            var edge = selectedObject as Edge;
            if (edge != null)
            {
                edge.Attr = (EdgeAttr)selectedObjectAttr;
            }
            else
            {
                var node = selectedObject as Microsoft.Msagl.Drawing.Node;
                if (node != null)
                    node.Attr = (NodeAttr)selectedObjectAttr;

            }

        }
        #endregion Copied code

      
    }
}
