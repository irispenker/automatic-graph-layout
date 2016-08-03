using System.Windows.Forms;
using Microsoft.Msagl.GraphViewerGdi;

namespace DXWindowsApplication1
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.infoLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.propertyGridControl = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.snapDockManager1 = new DevExpress.Snap.Extensions.SnapDockManager(this.components);
            this.fieldListDockPanel1 = new DevExpress.Snap.Extensions.UI.FieldListDockPanel();
            this.fieldListDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.reportExplorerDockPanel1 = new DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel();
            this.reportExplorerDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapDockManager1)).BeginInit();
            this.fieldListDockPanel1.SuspendLayout();
            this.reportExplorerDockPanel1.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(3, 3);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(35, 13);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 778);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(200, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.infoLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1300, 812);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.TabIndex = 1;
            // 
            // propertyGridControl
            // 
            this.propertyGridControl.AutoGenerateRows = true;
            this.propertyGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.propertyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridControl.Location = new System.Drawing.Point(0, 0);
            this.propertyGridControl.Name = "propertyGridControl";
            this.propertyGridControl.OptionsMenu.EnableContextMenu = true;
            this.propertyGridControl.OptionsView.AutoScaleBands = true;
            this.propertyGridControl.ScrollsStyle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.propertyGridControl.Size = new System.Drawing.Size(192, 785);
            this.propertyGridControl.TabIndex = 0;
            this.propertyGridControl.Leave += new System.EventHandler(this.OnPropertyControlLeave);
            // 
            // snapDockManager1
            // 
            this.snapDockManager1.Form = this;
            this.snapDockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.fieldListDockPanel1,
            this.reportExplorerDockPanel1});
            this.snapDockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.snapDockManager1.SnapControl = null;
            this.snapDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // fieldListDockPanel1
            // 
            this.fieldListDockPanel1.Controls.Add(this.fieldListDockPanel1_Container);
            this.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.fieldListDockPanel1.ID = new System.Guid("fed85fc1-3395-4db6-95e6-6c92640294b6");
            this.fieldListDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.fieldListDockPanel1.Name = "fieldListDockPanel1";
            this.fieldListDockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.fieldListDockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.fieldListDockPanel1.SavedIndex = 0;
            this.fieldListDockPanel1.SavedParent = this.reportExplorerDockPanel1;
            this.fieldListDockPanel1.Size = new System.Drawing.Size(200, 406);
            this.fieldListDockPanel1.SnapControl = null;
            this.fieldListDockPanel1.Text = "Field List";
            this.fieldListDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // fieldListDockPanel1_Container
            // 
            this.fieldListDockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container";
            this.fieldListDockPanel1_Container.Size = new System.Drawing.Size(192, 379);
            this.fieldListDockPanel1_Container.TabIndex = 0;
            // 
            // reportExplorerDockPanel1
            // 
            this.reportExplorerDockPanel1.Controls.Add(this.reportExplorerDockPanel1_Container);
            this.reportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.reportExplorerDockPanel1.ID = new System.Guid("f0ccc239-6c61-4ce7-a6a1-8823b8df233d");
            this.reportExplorerDockPanel1.Location = new System.Drawing.Point(1300, 0);
            this.reportExplorerDockPanel1.Name = "reportExplorerDockPanel1";
            this.reportExplorerDockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.reportExplorerDockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.reportExplorerDockPanel1.SavedIndex = 0;
            this.reportExplorerDockPanel1.Size = new System.Drawing.Size(200, 812);
            this.reportExplorerDockPanel1.SnapControl = null;
            this.reportExplorerDockPanel1.Text = "Report Explorer";
            this.reportExplorerDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // reportExplorerDockPanel1_Container
            // 
            this.reportExplorerDockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container";
            this.reportExplorerDockPanel1_Container.Size = new System.Drawing.Size(192, 785);
            this.reportExplorerDockPanel1_Container.TabIndex = 0;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("0a21e540-858c-4894-9120-a425b8b179be");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 812);
            this.dockPanel1.Text = "Properties ";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.propertyGridControl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 785);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1500, 812);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dockPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Shape Drawer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapDockManager1)).EndInit();
            this.fieldListDockPanel1.ResumeLayout(false);
            this.reportExplorerDockPanel1.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl;
        private DevExpress.Snap.Extensions.SnapDockManager snapDockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.Snap.Extensions.UI.FieldListDockPanel fieldListDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer fieldListDockPanel1_Container;
        private DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel reportExplorerDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer reportExplorerDockPanel1_Container;
    }
}