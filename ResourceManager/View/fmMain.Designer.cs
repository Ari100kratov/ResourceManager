namespace ResourceManager
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.lcHeader = new DevExpress.XtraLayout.LayoutControl();
            this.pcHeader = new DevExpress.XtraEditors.PanelControl();
            this.peHeader = new DevExpress.XtraEditors.PictureEdit();
            this.lbHeader = new DevExpress.XtraEditors.LabelControl();
            this.lbDescription = new DevExpress.XtraEditors.LabelControl();
            this.lcgHeader = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciHeader = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcGridView = new DevExpress.XtraLayout.LayoutControl();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.gcResourceItems = new DevExpress.XtraGrid.GridControl();
            this.gvResourceItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCurrentVlaue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNewValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcgGridView = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciResourceItems = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lueLanguge = new DevExpress.XtraEditors.LookUpEdit();
            this.lueSource = new DevExpress.XtraEditors.LookUpEdit();
            this.slueResource = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.slueLibrary = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bePath = new DevExpress.XtraEditors.ButtonEdit();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPath = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLibrary = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciResource = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSource = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLanguage = new DevExpress.XtraLayout.LayoutControlItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.lcHeader)).BeginInit();
            this.lcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcHeader)).BeginInit();
            this.pcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGridView)).BeginInit();
            this.lcGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResourceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResourceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResourceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueLanguge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueLibrary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // lcHeader
            // 
            this.lcHeader.Controls.Add(this.pcHeader);
            resources.ApplyResources(this.lcHeader, "lcHeader");
            this.lcHeader.Name = "lcHeader";
            this.lcHeader.Root = this.lcgHeader;
            // 
            // pcHeader
            // 
            this.pcHeader.Controls.Add(this.peHeader);
            this.pcHeader.Controls.Add(this.lbHeader);
            this.pcHeader.Controls.Add(this.lbDescription);
            resources.ApplyResources(this.pcHeader, "pcHeader");
            this.pcHeader.Name = "pcHeader";
            // 
            // peHeader
            // 
            this.peHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.peHeader.EditValue = global::ResourceManager.Properties.Resources.kservices1;
            resources.ApplyResources(this.peHeader, "peHeader");
            this.peHeader.Name = "peHeader";
            this.peHeader.Properties.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("peHeader.Properties.Appearance.BackColor")));
            this.peHeader.Properties.Appearance.Options.UseBackColor = true;
            this.peHeader.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peHeader.Properties.ShowMenu = false;
            this.peHeader.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peHeader.Properties.ZoomAccelerationFactor = 1D;
            // 
            // lbHeader
            // 
            this.lbHeader.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbHeader.Appearance.Font")));
            this.lbHeader.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lbHeader, "lbHeader");
            this.lbHeader.Name = "lbHeader";
            // 
            // lbDescription
            // 
            this.lbDescription.AllowHtmlString = true;
            resources.ApplyResources(this.lbDescription, "lbDescription");
            this.lbDescription.Appearance.Options.UseTextOptions = true;
            this.lbDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lbDescription.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbDescription.LineLocation = DevExpress.XtraEditors.LineLocation.Top;
            this.lbDescription.LineVisible = true;
            this.lbDescription.Name = "lbDescription";
            // 
            // lcgHeader
            // 
            this.lcgHeader.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgHeader.GroupBordersVisible = false;
            this.lcgHeader.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciHeader});
            this.lcgHeader.Location = new System.Drawing.Point(0, 0);
            this.lcgHeader.Name = "lcgHeader";
            this.lcgHeader.Size = new System.Drawing.Size(734, 120);
            this.lcgHeader.TextVisible = false;
            // 
            // lciHeader
            // 
            this.lciHeader.Control = this.pcHeader;
            this.lciHeader.Location = new System.Drawing.Point(0, 0);
            this.lciHeader.Name = "lciHeader";
            this.lciHeader.Size = new System.Drawing.Size(714, 100);
            this.lciHeader.TextSize = new System.Drawing.Size(0, 0);
            this.lciHeader.TextVisible = false;
            // 
            // lcGridView
            // 
            resources.ApplyResources(this.lcGridView, "lcGridView");
            this.lcGridView.Controls.Add(this.sbSave);
            this.lcGridView.Controls.Add(this.gcResourceItems);
            this.lcGridView.Name = "lcGridView";
            this.lcGridView.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(928, 287, 461, 523);
            this.lcGridView.Root = this.lcgGridView;
            // 
            // sbSave
            // 
            this.sbSave.Image = global::ResourceManager.Properties.Resources.save;
            resources.ApplyResources(this.sbSave, "sbSave");
            this.sbSave.Name = "sbSave";
            this.sbSave.StyleController = this.lcGridView;
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // gcResourceItems
            // 
            resources.ApplyResources(this.gcResourceItems, "gcResourceItems");
            this.gcResourceItems.MainView = this.gvResourceItems;
            this.gcResourceItems.Name = "gcResourceItems";
            this.gcResourceItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResourceItems});
            // 
            // gvResourceItems
            // 
            this.gvResourceItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcKey,
            this.gcCurrentVlaue,
            this.gcNewValue});
            this.gvResourceItems.GridControl = this.gcResourceItems;
            this.gvResourceItems.Name = "gvResourceItems";
            this.gvResourceItems.OptionsFind.AlwaysVisible = true;
            this.gvResourceItems.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gvResourceItems.OptionsFind.FindNullPrompt = "Введите текст для поиска...";
            this.gvResourceItems.OptionsView.ShowGroupPanel = false;
            // 
            // gcKey
            // 
            resources.ApplyResources(this.gcKey, "gcKey");
            this.gcKey.FieldName = "Key";
            this.gcKey.Name = "gcKey";
            this.gcKey.OptionsColumn.AllowEdit = false;
            // 
            // gcCurrentVlaue
            // 
            resources.ApplyResources(this.gcCurrentVlaue, "gcCurrentVlaue");
            this.gcCurrentVlaue.FieldName = "CurrentValue";
            this.gcCurrentVlaue.Name = "gcCurrentVlaue";
            this.gcCurrentVlaue.OptionsColumn.AllowEdit = false;
            // 
            // gcNewValue
            // 
            resources.ApplyResources(this.gcNewValue, "gcNewValue");
            this.gcNewValue.FieldName = "NewValue";
            this.gcNewValue.Name = "gcNewValue";
            // 
            // lcgGridView
            // 
            this.lcgGridView.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgGridView.GroupBordersVisible = false;
            this.lcgGridView.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciResourceItems,
            this.lciSave,
            this.emptySpaceItem1});
            this.lcgGridView.Location = new System.Drawing.Point(0, 0);
            this.lcgGridView.Name = "Root";
            this.lcgGridView.Size = new System.Drawing.Size(734, 301);
            this.lcgGridView.TextVisible = false;
            // 
            // lciResourceItems
            // 
            this.lciResourceItems.Control = this.gcResourceItems;
            this.lciResourceItems.Location = new System.Drawing.Point(0, 0);
            this.lciResourceItems.Name = "lciResourceItems";
            this.lciResourceItems.Size = new System.Drawing.Size(714, 255);
            this.lciResourceItems.TextSize = new System.Drawing.Size(0, 0);
            this.lciResourceItems.TextVisible = false;
            // 
            // lciSave
            // 
            this.lciSave.Control = this.sbSave;
            this.lciSave.Location = new System.Drawing.Point(611, 255);
            this.lciSave.MaxSize = new System.Drawing.Size(103, 26);
            this.lciSave.MinSize = new System.Drawing.Size(103, 26);
            this.lciSave.Name = "lciSave";
            this.lciSave.Size = new System.Drawing.Size(103, 26);
            this.lciSave.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSave.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 255);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(611, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lcMain
            // 
            resources.ApplyResources(this.lcMain, "lcMain");
            this.lcMain.Controls.Add(this.lueLanguge);
            this.lcMain.Controls.Add(this.lueSource);
            this.lcMain.Controls.Add(this.slueResource);
            this.lcMain.Controls.Add(this.slueLibrary);
            this.lcMain.Controls.Add(this.bePath);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(712, 69, 250, 350);
            this.lcMain.Root = this.lcgMain;
            // 
            // lueLanguge
            // 
            resources.ApplyResources(this.lueLanguge, "lueLanguge");
            this.lueLanguge.Name = "lueLanguge";
            this.lueLanguge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lookUpEdit1.Properties.Buttons"))))});
            this.lueLanguge.StyleController = this.lcMain;
            // 
            // lueSource
            // 
            resources.ApplyResources(this.lueSource, "lueSource");
            this.lueSource.Name = "lueSource";
            this.lueSource.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lueSource.Properties.Buttons"))))});
            this.lueSource.Properties.DisplayMember = "Value";
            this.lueSource.Properties.ShowHeader = false;
            this.lueSource.Properties.ValueMember = "Key";
            this.lueSource.StyleController = this.lcMain;
            this.lueSource.EditValueChanged += new System.EventHandler(this.lueSource_EditValueChanged);
            // 
            // slueResource
            // 
            resources.ApplyResources(this.slueResource, "slueResource");
            this.slueResource.Name = "slueResource";
            this.slueResource.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("slueResource.Properties.Buttons"))))});
            this.slueResource.Properties.NullValuePrompt = resources.GetString("slueResource.Properties.NullValuePrompt");
            this.slueResource.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("slueResource.Properties.NullValuePromptShowForEmptyValue")));
            this.slueResource.Properties.PopupFormSize = new System.Drawing.Size(650, 0);
            this.slueResource.Properties.View = this.gridView1;
            this.slueResource.StyleController = this.lcMain;
            this.slueResource.EditValueChanged += new System.EventHandler(this.slueResource_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // slueLibrary
            // 
            resources.ApplyResources(this.slueLibrary, "slueLibrary");
            this.slueLibrary.Name = "slueLibrary";
            this.slueLibrary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("slueLibrary.Properties.Buttons"))))});
            this.slueLibrary.Properties.NullValuePrompt = resources.GetString("slueLibrary.Properties.NullValuePrompt");
            this.slueLibrary.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("slueLibrary.Properties.NullValuePromptShowForEmptyValue")));
            this.slueLibrary.Properties.PopupFormSize = new System.Drawing.Size(650, 0);
            this.slueLibrary.Properties.View = this.searchLookUpEdit1View;
            this.slueLibrary.StyleController = this.lcMain;
            this.slueLibrary.EditValueChanged += new System.EventHandler(this.slueLibrary_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // bePath
            // 
            resources.ApplyResources(this.bePath, "bePath");
            this.bePath.Name = "bePath";
            this.bePath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bePath.Properties.NullValuePrompt = resources.GetString("bePath.Properties.NullValuePrompt");
            this.bePath.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("bePath.Properties.NullValuePromptShowForEmptyValue")));
            this.bePath.StyleController = this.lcMain;
            this.bePath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bePath_ButtonClick);
            this.bePath.EditValueChanged += new System.EventHandler(this.bePath_EditValueChanged);
            // 
            // lcgMain
            // 
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPath,
            this.lciLibrary,
            this.lciResource,
            this.lciSource,
            this.lciLanguage});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.Size = new System.Drawing.Size(734, 142);
            this.lcgMain.TextVisible = false;
            // 
            // lciPath
            // 
            this.lciPath.Control = this.bePath;
            this.lciPath.Location = new System.Drawing.Point(0, 48);
            this.lciPath.Name = "lciPath";
            this.lciPath.Size = new System.Drawing.Size(714, 24);
            resources.ApplyResources(this.lciPath, "lciPath");
            this.lciPath.TextSize = new System.Drawing.Size(79, 13);
            // 
            // lciLibrary
            // 
            this.lciLibrary.Control = this.slueLibrary;
            this.lciLibrary.Location = new System.Drawing.Point(0, 72);
            this.lciLibrary.Name = "lciLibrary";
            this.lciLibrary.Size = new System.Drawing.Size(714, 24);
            resources.ApplyResources(this.lciLibrary, "lciLibrary");
            this.lciLibrary.TextSize = new System.Drawing.Size(79, 13);
            // 
            // lciResource
            // 
            this.lciResource.Control = this.slueResource;
            this.lciResource.Location = new System.Drawing.Point(0, 96);
            this.lciResource.Name = "lciResource";
            this.lciResource.Size = new System.Drawing.Size(714, 26);
            resources.ApplyResources(this.lciResource, "lciResource");
            this.lciResource.TextSize = new System.Drawing.Size(79, 13);
            // 
            // lciSource
            // 
            this.lciSource.Control = this.lueSource;
            this.lciSource.Location = new System.Drawing.Point(0, 24);
            this.lciSource.Name = "lciSource";
            this.lciSource.Size = new System.Drawing.Size(714, 24);
            resources.ApplyResources(this.lciSource, "lciSource");
            this.lciSource.TextSize = new System.Drawing.Size(79, 13);
            // 
            // lciLanguage
            // 
            this.lciLanguage.Control = this.lueLanguge;
            this.lciLanguage.Location = new System.Drawing.Point(0, 0);
            this.lciLanguage.Name = "lciLanguage";
            this.lciLanguage.Size = new System.Drawing.Size(714, 24);
            resources.ApplyResources(this.lciLanguage, "lciLanguage");
            this.lciLanguage.TextSize = new System.Drawing.Size(79, 13);
            // 
            // fmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.lcGridView);
            this.Controls.Add(this.lcHeader);
            this.Name = "fmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcHeader)).EndInit();
            this.lcHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcHeader)).EndInit();
            this.pcHeader.ResumeLayout(false);
            this.pcHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGridView)).EndInit();
            this.lcGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcResourceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResourceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResourceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueLanguge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueLibrary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLanguage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcHeader;
        private DevExpress.XtraEditors.PanelControl pcHeader;
        private DevExpress.XtraEditors.PictureEdit peHeader;
        private DevExpress.XtraEditors.LabelControl lbHeader;
        private DevExpress.XtraEditors.LabelControl lbDescription;
        private DevExpress.XtraLayout.LayoutControlGroup lcgHeader;
        private DevExpress.XtraLayout.LayoutControlItem lciHeader;
        private DevExpress.XtraLayout.LayoutControl lcGridView;
        private DevExpress.XtraGrid.GridControl gcResourceItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gvResourceItems;
        private DevExpress.XtraLayout.LayoutControlGroup lcgGridView;
        private DevExpress.XtraLayout.LayoutControlItem lciResourceItems;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.SearchLookUpEdit slueResource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit slueLibrary;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.ButtonEdit bePath;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciPath;
        private DevExpress.XtraLayout.LayoutControlItem lciLibrary;
        private DevExpress.XtraLayout.LayoutControlItem lciResource;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraLayout.LayoutControlItem lciSave;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gcKey;
        private DevExpress.XtraGrid.Columns.GridColumn gcCurrentVlaue;
        private DevExpress.XtraGrid.Columns.GridColumn gcNewValue;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private DevExpress.XtraEditors.LookUpEdit lueSource;
        private DevExpress.XtraLayout.LayoutControlItem lciSource;
        private DevExpress.XtraEditors.LookUpEdit lueLanguge;
        private DevExpress.XtraLayout.LayoutControlItem lciLanguage;
    }
}