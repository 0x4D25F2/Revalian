namespace Revalian
{
    partial class Revali
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Revali));
            btnSelectChart = new Button();
            lblChartPath = new Label();
            btnSaveChart = new Button();
            tpSpriteImport = new TabPage();
            ckbP1AddEvent = new CheckBox();
            chkP1CopyFile = new CheckBox();
            numP1Room = new NumberBox();
            numP1Depth = new NumberBox();
            numP1Angle = new NumberBox();
            numP1ScaleY = new NumberBox();
            numP1ScaleX = new NumberBox();
            numP1PivotY = new NumberBox();
            numP1PivotX = new NumberBox();
            numP1PositionY = new NumberBox();
            numP1PositionX = new NumberBox();
            label1 = new Label();
            btnP1CopySprite = new Button();
            btnP1DeleteSprite = new Button();
            btnP1AddSprite = new Button();
            lstP1SpriteList = new ListBox();
            lstP1SpritePathList = new ListBox();
            lblAngle = new Label();
            lblP1Pivot = new Label();
            btnP1ImportSprite = new Button();
            lblP1Scale = new Label();
            lblP1Position = new Label();
            chkP1Visibility = new CheckBox();
            lblP1Depth = new Label();
            lblP1Room = new Label();
            btnP1SelectSprite = new Button();
            tabLevelEdit = new TabControl();
            tpSpriteEventCopy = new TabPage();
            numP2Angle = new NumberBox();
            numP2ScaleY = new NumberBox();
            numP2ScaleX = new NumberBox();
            numP2PivotY = new NumberBox();
            numP2PivotX = new NumberBox();
            lblP2Angle = new Label();
            lblP2Pivot = new Label();
            lblP2Scale = new Label();
            numP2PositionOffsetY = new NumberBox();
            numP2PositionOffsetX = new NumberBox();
            lblP2Offset = new Label();
            numP2ParallaxY = new NumberBox();
            numP2ParallaxX = new NumberBox();
            lblP2Parallax = new Label();
            lblP2ToBeat = new Label();
            lblP2FromBeat = new Label();
            nudP2ToBar = new NumericUpDown();
            nudP2FromBar = new NumericUpDown();
            numP2ToBeat = new NumberBox();
            numP2FromBeat = new NumberBox();
            btnP2StartCopy = new Button();
            chkP2IncludeEnd = new CheckBox();
            lblP2To = new Label();
            lblP2From = new Label();
            chkP2IncludeBegin = new CheckBox();
            lblTo = new Label();
            lblFrom = new Label();
            cmbP2SpriteSelect = new ComboBox();
            lstP2SpriteSelect = new ListBox();
            btnReload = new Button();
            tpSpriteImport.SuspendLayout();
            tabLevelEdit.SuspendLayout();
            tpSpriteEventCopy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudP2ToBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudP2FromBar).BeginInit();
            SuspendLayout();
            // 
            // btnSelectChart
            // 
            btnSelectChart.Location = new Point(12, 12);
            btnSelectChart.Name = "btnSelectChart";
            btnSelectChart.Size = new Size(151, 34);
            btnSelectChart.TabIndex = 0;
            btnSelectChart.Text = "打开关卡文件";
            btnSelectChart.UseVisualStyleBackColor = true;
            btnSelectChart.Click += btnSelectChart_Click;
            // 
            // lblChartPath
            // 
            lblChartPath.AutoSize = true;
            lblChartPath.Location = new Point(169, 17);
            lblChartPath.Name = "lblChartPath";
            lblChartPath.Size = new Size(22, 24);
            lblChartPath.TabIndex = 1;
            lblChartPath.Text = "...";
            // 
            // btnSaveChart
            // 
            btnSaveChart.Enabled = false;
            btnSaveChart.Location = new Point(854, 710);
            btnSaveChart.Name = "btnSaveChart";
            btnSaveChart.Size = new Size(112, 34);
            btnSaveChart.TabIndex = 5;
            btnSaveChart.Text = "保存谱面";
            btnSaveChart.UseVisualStyleBackColor = true;
            btnSaveChart.Click += btnSaveChart_Click;
            // 
            // tpSpriteImport
            // 
            tpSpriteImport.Controls.Add(ckbP1AddEvent);
            tpSpriteImport.Controls.Add(chkP1CopyFile);
            tpSpriteImport.Controls.Add(numP1Room);
            tpSpriteImport.Controls.Add(numP1Depth);
            tpSpriteImport.Controls.Add(numP1Angle);
            tpSpriteImport.Controls.Add(numP1ScaleY);
            tpSpriteImport.Controls.Add(numP1ScaleX);
            tpSpriteImport.Controls.Add(numP1PivotY);
            tpSpriteImport.Controls.Add(numP1PivotX);
            tpSpriteImport.Controls.Add(numP1PositionY);
            tpSpriteImport.Controls.Add(numP1PositionX);
            tpSpriteImport.Controls.Add(label1);
            tpSpriteImport.Controls.Add(btnP1CopySprite);
            tpSpriteImport.Controls.Add(btnP1DeleteSprite);
            tpSpriteImport.Controls.Add(btnP1AddSprite);
            tpSpriteImport.Controls.Add(lstP1SpriteList);
            tpSpriteImport.Controls.Add(lstP1SpritePathList);
            tpSpriteImport.Controls.Add(lblAngle);
            tpSpriteImport.Controls.Add(lblP1Pivot);
            tpSpriteImport.Controls.Add(btnP1ImportSprite);
            tpSpriteImport.Controls.Add(lblP1Scale);
            tpSpriteImport.Controls.Add(lblP1Position);
            tpSpriteImport.Controls.Add(chkP1Visibility);
            tpSpriteImport.Controls.Add(lblP1Depth);
            tpSpriteImport.Controls.Add(lblP1Room);
            tpSpriteImport.Controls.Add(btnP1SelectSprite);
            tpSpriteImport.Location = new Point(4, 33);
            tpSpriteImport.Name = "tpSpriteImport";
            tpSpriteImport.Padding = new Padding(3);
            tpSpriteImport.Size = new Size(946, 615);
            tpSpriteImport.TabIndex = 0;
            tpSpriteImport.Text = "导入精灵";
            tpSpriteImport.UseVisualStyleBackColor = true;
            // 
            // ckbP1AddEvent
            // 
            ckbP1AddEvent.AutoSize = true;
            ckbP1AddEvent.Checked = true;
            ckbP1AddEvent.CheckState = CheckState.Checked;
            ckbP1AddEvent.Location = new Point(751, 124);
            ckbP1AddEvent.Name = "ckbP1AddEvent";
            ckbP1AddEvent.Size = new Size(162, 28);
            ckbP1AddEvent.TabIndex = 36;
            ckbP1AddEvent.Text = "添加初始化事件";
            ckbP1AddEvent.UseVisualStyleBackColor = true;
            // 
            // chkP1CopyFile
            // 
            chkP1CopyFile.AutoSize = true;
            chkP1CopyFile.Location = new Point(20, 60);
            chkP1CopyFile.Name = "chkP1CopyFile";
            chkP1CopyFile.Size = new Size(198, 28);
            chkP1CopyFile.TabIndex = 35;
            chkP1CopyFile.Text = "与关卡文件相同路径";
            chkP1CopyFile.UseVisualStyleBackColor = true;
            // 
            // numP1Room
            // 
            numP1Room.DefaultValue = 1F;
            numP1Room.IsCalc = true;
            numP1Room.IsNull = false;
            numP1Room.IsNullable = true;
            numP1Room.Location = new Point(803, 20);
            numP1Room.MaxValue = 4F;
            numP1Room.MinValue = 1F;
            numP1Room.Name = "numP1Room";
            numP1Room.PlaceholderText = "--";
            numP1Room.Size = new Size(126, 30);
            numP1Room.TabIndex = 34;
            numP1Room.Text = "1";
            numP1Room.Value = 1F;
            numP1Room.ValueType = NumberBox.TypeEnum.Integer;
            // 
            // numP1Depth
            // 
            numP1Depth.DefaultValue = 0F;
            numP1Depth.IsCalc = true;
            numP1Depth.IsNull = false;
            numP1Depth.IsNullable = true;
            numP1Depth.Location = new Point(803, 88);
            numP1Depth.MaxValue = float.MaxValue;
            numP1Depth.MinValue = float.MinValue;
            numP1Depth.Name = "numP1Depth";
            numP1Depth.PlaceholderText = "--";
            numP1Depth.Size = new Size(126, 30);
            numP1Depth.TabIndex = 33;
            numP1Depth.Text = "0";
            numP1Depth.Value = 0F;
            numP1Depth.ValueType = NumberBox.TypeEnum.Integer;
            // 
            // numP1Angle
            // 
            numP1Angle.DefaultValue = 0F;
            numP1Angle.IsCalc = true;
            numP1Angle.IsNull = false;
            numP1Angle.IsNullable = true;
            numP1Angle.Location = new Point(803, 227);
            numP1Angle.MaxValue = float.MaxValue;
            numP1Angle.MinValue = float.MinValue;
            numP1Angle.Name = "numP1Angle";
            numP1Angle.PlaceholderText = "--";
            numP1Angle.Size = new Size(126, 30);
            numP1Angle.TabIndex = 25;
            numP1Angle.Text = "0";
            numP1Angle.Value = 0F;
            numP1Angle.ValueType = NumberBox.TypeEnum.Double;
            // 
            // numP1ScaleY
            // 
            numP1ScaleY.DefaultValue = 1F;
            numP1ScaleY.IsCalc = true;
            numP1ScaleY.IsNull = false;
            numP1ScaleY.IsNullable = true;
            numP1ScaleY.Location = new Point(869, 191);
            numP1ScaleY.MaxValue = float.MaxValue;
            numP1ScaleY.MinValue = float.MinValue;
            numP1ScaleY.Name = "numP1ScaleY";
            numP1ScaleY.PlaceholderText = "--";
            numP1ScaleY.Size = new Size(60, 30);
            numP1ScaleY.TabIndex = 24;
            numP1ScaleY.Text = "1";
            numP1ScaleY.Value = 1F;
            numP1ScaleY.ValueType = NumberBox.TypeEnum.Double;
            // 
            // numP1ScaleX
            // 
            numP1ScaleX.DefaultValue = 1F;
            numP1ScaleX.IsCalc = true;
            numP1ScaleX.IsNull = false;
            numP1ScaleX.IsNullable = true;
            numP1ScaleX.Location = new Point(803, 191);
            numP1ScaleX.MaxValue = float.MaxValue;
            numP1ScaleX.MinValue = float.MinValue;
            numP1ScaleX.Name = "numP1ScaleX";
            numP1ScaleX.PlaceholderText = "--";
            numP1ScaleX.Size = new Size(60, 30);
            numP1ScaleX.TabIndex = 23;
            numP1ScaleX.Text = "1";
            numP1ScaleX.Value = 1F;
            numP1ScaleX.ValueType = NumberBox.TypeEnum.Double;
            // 
            // numP1PivotY
            // 
            numP1PivotY.DefaultValue = 50F;
            numP1PivotY.IsCalc = true;
            numP1PivotY.IsNull = false;
            numP1PivotY.IsNullable = true;
            numP1PivotY.Location = new Point(869, 263);
            numP1PivotY.MaxValue = float.MaxValue;
            numP1PivotY.MinValue = float.MinValue;
            numP1PivotY.Name = "numP1PivotY";
            numP1PivotY.PlaceholderText = "--";
            numP1PivotY.Size = new Size(60, 30);
            numP1PivotY.TabIndex = 22;
            numP1PivotY.Text = "50";
            numP1PivotY.Value = 50F;
            numP1PivotY.ValueType = NumberBox.TypeEnum.Double;
            // 
            // numP1PivotX
            // 
            numP1PivotX.DefaultValue = 50F;
            numP1PivotX.IsCalc = true;
            numP1PivotX.IsNull = false;
            numP1PivotX.IsNullable = true;
            numP1PivotX.Location = new Point(803, 263);
            numP1PivotX.MaxValue = float.MaxValue;
            numP1PivotX.MinValue = float.MinValue;
            numP1PivotX.Name = "numP1PivotX";
            numP1PivotX.PlaceholderText = "--";
            numP1PivotX.Size = new Size(60, 30);
            numP1PivotX.TabIndex = 21;
            numP1PivotX.Text = "50";
            numP1PivotX.Value = 50F;
            numP1PivotX.ValueType = NumberBox.TypeEnum.Double;
            // 
            // numP1PositionY
            // 
            numP1PositionY.DefaultValue = 50F;
            numP1PositionY.IsCalc = true;
            numP1PositionY.IsNull = false;
            numP1PositionY.IsNullable = true;
            numP1PositionY.Location = new Point(869, 155);
            numP1PositionY.MaxValue = float.MaxValue;
            numP1PositionY.MinValue = float.MinValue;
            numP1PositionY.Name = "numP1PositionY";
            numP1PositionY.PlaceholderText = "--";
            numP1PositionY.Size = new Size(60, 30);
            numP1PositionY.TabIndex = 20;
            numP1PositionY.Text = "50";
            numP1PositionY.Value = 50F;
            numP1PositionY.ValueType = NumberBox.TypeEnum.Double;
            // 
            // numP1PositionX
            // 
            numP1PositionX.DefaultValue = 50F;
            numP1PositionX.IsCalc = true;
            numP1PositionX.IsNull = false;
            numP1PositionX.IsNullable = true;
            numP1PositionX.Location = new Point(803, 155);
            numP1PositionX.MaxValue = float.MaxValue;
            numP1PositionX.MinValue = float.MinValue;
            numP1PositionX.Name = "numP1PositionX";
            numP1PositionX.PlaceholderText = "--";
            numP1PositionX.Size = new Size(60, 30);
            numP1PositionX.TabIndex = 19;
            numP1PositionX.Text = "50";
            numP1PositionX.Value = 50F;
            numP1PositionX.ValueType = NumberBox.TypeEnum.Double;
            // 
            // label1
            // 
            label1.Location = new Point(539, 20);
            label1.Name = "label1";
            label1.Size = new Size(191, 81);
            label1.TabIndex = 32;
            label1.Text = "你可以输入以\"i\"为变量的表达式来使不同的精灵获得不同的参数。";
            // 
            // btnP1CopySprite
            // 
            btnP1CopySprite.Location = new Point(539, 566);
            btnP1CopySprite.Name = "btnP1CopySprite";
            btnP1CopySprite.Size = new Size(148, 34);
            btnP1CopySprite.TabIndex = 31;
            btnP1CopySprite.Text = "复制选中的精灵";
            btnP1CopySprite.UseVisualStyleBackColor = true;
            btnP1CopySprite.Click += btnP1CopySprite_Click;
            // 
            // btnP1DeleteSprite
            // 
            btnP1DeleteSprite.Location = new Point(539, 526);
            btnP1DeleteSprite.Name = "btnP1DeleteSprite";
            btnP1DeleteSprite.Size = new Size(148, 34);
            btnP1DeleteSprite.TabIndex = 30;
            btnP1DeleteSprite.Text = "删除选中的精灵";
            btnP1DeleteSprite.UseVisualStyleBackColor = true;
            btnP1DeleteSprite.Click += btnP1DeleteSprite_Click;
            // 
            // btnP1AddSprite
            // 
            btnP1AddSprite.Location = new Point(20, 566);
            btnP1AddSprite.Name = "btnP1AddSprite";
            btnP1AddSprite.Size = new Size(230, 34);
            btnP1AddSprite.TabIndex = 29;
            btnP1AddSprite.Text = "添加所有选中的精灵图";
            btnP1AddSprite.UseVisualStyleBackColor = true;
            btnP1AddSprite.Click += btnP1AddSprite_Click;
            // 
            // lstP1SpriteList
            // 
            lstP1SpriteList.AllowDrop = true;
            lstP1SpriteList.FormattingEnabled = true;
            lstP1SpriteList.ItemHeight = 24;
            lstP1SpriteList.Location = new Point(265, 20);
            lstP1SpriteList.Name = "lstP1SpriteList";
            lstP1SpriteList.SelectionMode = SelectionMode.MultiExtended;
            lstP1SpriteList.Size = new Size(268, 580);
            lstP1SpriteList.TabIndex = 28;
            // 
            // lstP1SpritePathList
            // 
            lstP1SpritePathList.AllowDrop = true;
            lstP1SpritePathList.FormattingEnabled = true;
            lstP1SpritePathList.ItemHeight = 24;
            lstP1SpritePathList.Location = new Point(20, 92);
            lstP1SpritePathList.Name = "lstP1SpritePathList";
            lstP1SpritePathList.SelectionMode = SelectionMode.MultiExtended;
            lstP1SpritePathList.Size = new Size(230, 460);
            lstP1SpritePathList.TabIndex = 27;
            // 
            // lblAngle
            // 
            lblAngle.AutoSize = true;
            lblAngle.Location = new Point(751, 230);
            lblAngle.Name = "lblAngle";
            lblAngle.Size = new Size(46, 24);
            lblAngle.TabIndex = 26;
            lblAngle.Text = "角度";
            // 
            // lblP1Pivot
            // 
            lblP1Pivot.AutoSize = true;
            lblP1Pivot.Location = new Point(751, 266);
            lblP1Pivot.Name = "lblP1Pivot";
            lblP1Pivot.Size = new Size(46, 24);
            lblP1Pivot.TabIndex = 18;
            lblP1Pivot.Text = "轴点";
            // 
            // btnP1ImportSprite
            // 
            btnP1ImportSprite.Location = new Point(751, 566);
            btnP1ImportSprite.Name = "btnP1ImportSprite";
            btnP1ImportSprite.Size = new Size(178, 34);
            btnP1ImportSprite.TabIndex = 15;
            btnP1ImportSprite.Text = "导入";
            btnP1ImportSprite.UseVisualStyleBackColor = true;
            btnP1ImportSprite.Click += btnP1ImportSprite_Click;
            // 
            // lblP1Scale
            // 
            lblP1Scale.AutoSize = true;
            lblP1Scale.Location = new Point(751, 194);
            lblP1Scale.Name = "lblP1Scale";
            lblP1Scale.Size = new Size(46, 24);
            lblP1Scale.TabIndex = 14;
            lblP1Scale.Text = "缩放";
            // 
            // lblP1Position
            // 
            lblP1Position.AutoSize = true;
            lblP1Position.Location = new Point(751, 158);
            lblP1Position.Name = "lblP1Position";
            lblP1Position.Size = new Size(46, 24);
            lblP1Position.TabIndex = 11;
            lblP1Position.Text = "位置";
            // 
            // chkP1Visibility
            // 
            chkP1Visibility.AutoSize = true;
            chkP1Visibility.Location = new Point(751, 56);
            chkP1Visibility.Name = "chkP1Visibility";
            chkP1Visibility.Size = new Size(90, 28);
            chkP1Visibility.TabIndex = 7;
            chkP1Visibility.Text = "可见性";
            chkP1Visibility.UseVisualStyleBackColor = true;
            // 
            // lblP1Depth
            // 
            lblP1Depth.AutoSize = true;
            lblP1Depth.Location = new Point(751, 91);
            lblP1Depth.Name = "lblP1Depth";
            lblP1Depth.Size = new Size(46, 24);
            lblP1Depth.TabIndex = 6;
            lblP1Depth.Text = "深度";
            // 
            // lblP1Room
            // 
            lblP1Room.AutoSize = true;
            lblP1Room.Location = new Point(751, 22);
            lblP1Room.Name = "lblP1Room";
            lblP1Room.Size = new Size(46, 24);
            lblP1Room.TabIndex = 5;
            lblP1Room.Text = "房间";
            // 
            // btnP1SelectSprite
            // 
            btnP1SelectSprite.Location = new Point(20, 20);
            btnP1SelectSprite.Name = "btnP1SelectSprite";
            btnP1SelectSprite.Size = new Size(230, 34);
            btnP1SelectSprite.TabIndex = 2;
            btnP1SelectSprite.Text = "选择精灵图片数据";
            btnP1SelectSprite.UseVisualStyleBackColor = true;
            btnP1SelectSprite.Click += btnP1SelectSprite_Click;
            // 
            // tabLevelEdit
            // 
            tabLevelEdit.Controls.Add(tpSpriteImport);
            tabLevelEdit.Controls.Add(tpSpriteEventCopy);
            tabLevelEdit.Enabled = false;
            tabLevelEdit.Location = new Point(12, 52);
            tabLevelEdit.Name = "tabLevelEdit";
            tabLevelEdit.SelectedIndex = 0;
            tabLevelEdit.Size = new Size(954, 652);
            tabLevelEdit.TabIndex = 4;
            // 
            // tpSpriteEventCopy
            // 
            tpSpriteEventCopy.Controls.Add(numP2Angle);
            tpSpriteEventCopy.Controls.Add(numP2ScaleY);
            tpSpriteEventCopy.Controls.Add(numP2ScaleX);
            tpSpriteEventCopy.Controls.Add(numP2PivotY);
            tpSpriteEventCopy.Controls.Add(numP2PivotX);
            tpSpriteEventCopy.Controls.Add(lblP2Angle);
            tpSpriteEventCopy.Controls.Add(lblP2Pivot);
            tpSpriteEventCopy.Controls.Add(lblP2Scale);
            tpSpriteEventCopy.Controls.Add(numP2PositionOffsetY);
            tpSpriteEventCopy.Controls.Add(numP2PositionOffsetX);
            tpSpriteEventCopy.Controls.Add(lblP2Offset);
            tpSpriteEventCopy.Controls.Add(numP2ParallaxY);
            tpSpriteEventCopy.Controls.Add(numP2ParallaxX);
            tpSpriteEventCopy.Controls.Add(lblP2Parallax);
            tpSpriteEventCopy.Controls.Add(lblP2ToBeat);
            tpSpriteEventCopy.Controls.Add(lblP2FromBeat);
            tpSpriteEventCopy.Controls.Add(nudP2ToBar);
            tpSpriteEventCopy.Controls.Add(nudP2FromBar);
            tpSpriteEventCopy.Controls.Add(numP2ToBeat);
            tpSpriteEventCopy.Controls.Add(numP2FromBeat);
            tpSpriteEventCopy.Controls.Add(btnP2StartCopy);
            tpSpriteEventCopy.Controls.Add(chkP2IncludeEnd);
            tpSpriteEventCopy.Controls.Add(lblP2To);
            tpSpriteEventCopy.Controls.Add(lblP2From);
            tpSpriteEventCopy.Controls.Add(chkP2IncludeBegin);
            tpSpriteEventCopy.Controls.Add(lblTo);
            tpSpriteEventCopy.Controls.Add(lblFrom);
            tpSpriteEventCopy.Controls.Add(cmbP2SpriteSelect);
            tpSpriteEventCopy.Controls.Add(lstP2SpriteSelect);
            tpSpriteEventCopy.Location = new Point(4, 33);
            tpSpriteEventCopy.Name = "tpSpriteEventCopy";
            tpSpriteEventCopy.Padding = new Padding(3);
            tpSpriteEventCopy.Size = new Size(946, 615);
            tpSpriteEventCopy.TabIndex = 1;
            tpSpriteEventCopy.Text = "复制精灵事件";
            tpSpriteEventCopy.UseVisualStyleBackColor = true;
            // 
            // numP2Angle
            // 
            numP2Angle.DefaultValue = null;
            numP2Angle.IsCalc = true;
            numP2Angle.IsNull = true;
            numP2Angle.IsNullable = true;
            numP2Angle.Location = new Point(384, 202);
            numP2Angle.MaxValue = float.MaxValue;
            numP2Angle.MinValue = float.MinValue;
            numP2Angle.Name = "numP2Angle";
            numP2Angle.PlaceholderText = "--";
            numP2Angle.Size = new Size(126, 30);
            numP2Angle.TabIndex = 42;
            numP2Angle.Value = null;
            numP2Angle.ValueType = NumberBox.TypeEnum.Double;
            // 
            // numP2ScaleY
            // 
            numP2ScaleY.DefaultValue = null;
            numP2ScaleY.IsCalc = true;
            numP2ScaleY.IsNull = true;
            numP2ScaleY.IsNullable = true;
            numP2ScaleY.Location = new Point(450, 166);
            numP2ScaleY.MaxValue = float.MaxValue;
            numP2ScaleY.MinValue = float.MinValue;
            numP2ScaleY.Name = "numP2ScaleY";
            numP2ScaleY.PlaceholderText = "--";
            numP2ScaleY.Size = new Size(60, 30);
            numP2ScaleY.TabIndex = 41;
            numP2ScaleY.Value = null;
            numP2ScaleY.ValueType = NumberBox.TypeEnum.Double;
            // 
            // numP2ScaleX
            // 
            numP2ScaleX.DefaultValue = null;
            numP2ScaleX.IsCalc = true;
            numP2ScaleX.IsNull = true;
            numP2ScaleX.IsNullable = true;
            numP2ScaleX.Location = new Point(384, 166);
            numP2ScaleX.MaxValue = float.MaxValue;
            numP2ScaleX.MinValue = float.MinValue;
            numP2ScaleX.Name = "numP2ScaleX";
            numP2ScaleX.PlaceholderText = "--";
            numP2ScaleX.Size = new Size(60, 30);
            numP2ScaleX.TabIndex = 40;
            numP2ScaleX.Value = null;
            numP2ScaleX.ValueType = NumberBox.TypeEnum.Double;
            // 
            // numP2PivotY
            // 
            numP2PivotY.DefaultValue = null;
            numP2PivotY.IsCalc = true;
            numP2PivotY.IsNull = true;
            numP2PivotY.IsNullable = true;
            numP2PivotY.Location = new Point(450, 238);
            numP2PivotY.MaxValue = float.MaxValue;
            numP2PivotY.MinValue = float.MinValue;
            numP2PivotY.Name = "numP2PivotY";
            numP2PivotY.PlaceholderText = "--";
            numP2PivotY.Size = new Size(60, 30);
            numP2PivotY.TabIndex = 39;
            numP2PivotY.Value = null;
            numP2PivotY.ValueType = NumberBox.TypeEnum.Double;
            // 
            // numP2PivotX
            // 
            numP2PivotX.DefaultValue = null;
            numP2PivotX.IsCalc = true;
            numP2PivotX.IsNull = true;
            numP2PivotX.IsNullable = true;
            numP2PivotX.Location = new Point(384, 238);
            numP2PivotX.MaxValue = float.MaxValue;
            numP2PivotX.MinValue = float.MinValue;
            numP2PivotX.Name = "numP2PivotX";
            numP2PivotX.PlaceholderText = "--";
            numP2PivotX.Size = new Size(60, 30);
            numP2PivotX.TabIndex = 38;
            numP2PivotX.Value = null;
            numP2PivotX.ValueType = NumberBox.TypeEnum.Double;
            // 
            // lblP2Angle
            // 
            lblP2Angle.AutoSize = true;
            lblP2Angle.Location = new Point(294, 205);
            lblP2Angle.Name = "lblP2Angle";
            lblP2Angle.Size = new Size(46, 24);
            lblP2Angle.TabIndex = 43;
            lblP2Angle.Text = "角度";
            // 
            // lblP2Pivot
            // 
            lblP2Pivot.AutoSize = true;
            lblP2Pivot.Location = new Point(294, 241);
            lblP2Pivot.Name = "lblP2Pivot";
            lblP2Pivot.Size = new Size(46, 24);
            lblP2Pivot.TabIndex = 35;
            lblP2Pivot.Text = "轴点";
            // 
            // lblP2Scale
            // 
            lblP2Scale.AutoSize = true;
            lblP2Scale.Location = new Point(294, 169);
            lblP2Scale.Name = "lblP2Scale";
            lblP2Scale.Size = new Size(46, 24);
            lblP2Scale.TabIndex = 34;
            lblP2Scale.Text = "缩放";
            // 
            // numP2PositionOffsetY
            // 
            numP2PositionOffsetY.DefaultValue = 0F;
            numP2PositionOffsetY.IsCalc = true;
            numP2PositionOffsetY.IsNull = false;
            numP2PositionOffsetY.IsNullable = false;
            numP2PositionOffsetY.Location = new Point(450, 129);
            numP2PositionOffsetY.MaxValue = float.MaxValue;
            numP2PositionOffsetY.MinValue = float.MinValue;
            numP2PositionOffsetY.Name = "numP2PositionOffsetY";
            numP2PositionOffsetY.PlaceholderText = "--";
            numP2PositionOffsetY.Size = new Size(60, 30);
            numP2PositionOffsetY.TabIndex = 32;
            numP2PositionOffsetY.Text = "0";
            numP2PositionOffsetY.Value = 0F;
            numP2PositionOffsetY.ValueType = NumberBox.TypeEnum.Double;
            // 
            // numP2PositionOffsetX
            // 
            numP2PositionOffsetX.DefaultValue = 0F;
            numP2PositionOffsetX.IsCalc = true;
            numP2PositionOffsetX.IsNull = false;
            numP2PositionOffsetX.IsNullable = false;
            numP2PositionOffsetX.Location = new Point(384, 129);
            numP2PositionOffsetX.MaxValue = float.MaxValue;
            numP2PositionOffsetX.MinValue = float.MinValue;
            numP2PositionOffsetX.Name = "numP2PositionOffsetX";
            numP2PositionOffsetX.PlaceholderText = "--";
            numP2PositionOffsetX.Size = new Size(60, 30);
            numP2PositionOffsetX.TabIndex = 31;
            numP2PositionOffsetX.Text = "0";
            numP2PositionOffsetX.Value = 0F;
            numP2PositionOffsetX.ValueType = NumberBox.TypeEnum.Double;
            // 
            // lblP2Offset
            // 
            lblP2Offset.AutoSize = true;
            lblP2Offset.Location = new Point(294, 132);
            lblP2Offset.Name = "lblP2Offset";
            lblP2Offset.Size = new Size(82, 24);
            lblP2Offset.TabIndex = 30;
            lblP2Offset.Text = "视差偏移";
            // 
            // numP2ParallaxY
            // 
            numP2ParallaxY.DefaultValue = 0F;
            numP2ParallaxY.IsCalc = true;
            numP2ParallaxY.IsNull = false;
            numP2ParallaxY.IsNullable = false;
            numP2ParallaxY.Location = new Point(450, 93);
            numP2ParallaxY.MaxValue = float.MaxValue;
            numP2ParallaxY.MinValue = float.MinValue;
            numP2ParallaxY.Name = "numP2ParallaxY";
            numP2ParallaxY.PlaceholderText = "--";
            numP2ParallaxY.Size = new Size(60, 30);
            numP2ParallaxY.TabIndex = 26;
            numP2ParallaxY.Text = "0";
            numP2ParallaxY.Value = 0F;
            numP2ParallaxY.ValueType = NumberBox.TypeEnum.Double;
            // 
            // numP2ParallaxX
            // 
            numP2ParallaxX.DefaultValue = 0F;
            numP2ParallaxX.IsCalc = true;
            numP2ParallaxX.IsNull = false;
            numP2ParallaxX.IsNullable = false;
            numP2ParallaxX.Location = new Point(384, 93);
            numP2ParallaxX.MaxValue = float.MaxValue;
            numP2ParallaxX.MinValue = float.MinValue;
            numP2ParallaxX.Name = "numP2ParallaxX";
            numP2ParallaxX.PlaceholderText = "--";
            numP2ParallaxX.Size = new Size(60, 30);
            numP2ParallaxX.TabIndex = 25;
            numP2ParallaxX.Text = "0";
            numP2ParallaxX.Value = 0F;
            numP2ParallaxX.ValueType = NumberBox.TypeEnum.Double;
            // 
            // lblP2Parallax
            // 
            lblP2Parallax.AutoSize = true;
            lblP2Parallax.Location = new Point(294, 96);
            lblP2Parallax.Name = "lblP2Parallax";
            lblP2Parallax.Size = new Size(79, 24);
            lblP2Parallax.TabIndex = 24;
            lblP2Parallax.Text = "视差 (%)";
            // 
            // lblP2ToBeat
            // 
            lblP2ToBeat.AutoSize = true;
            lblP2ToBeat.Location = new Point(440, 50);
            lblP2ToBeat.Name = "lblP2ToBeat";
            lblP2ToBeat.Size = new Size(46, 24);
            lblP2ToBeat.TabIndex = 23;
            lblP2ToBeat.Text = "节拍";
            // 
            // lblP2FromBeat
            // 
            lblP2FromBeat.AutoSize = true;
            lblP2FromBeat.Location = new Point(440, 16);
            lblP2FromBeat.Name = "lblP2FromBeat";
            lblP2FromBeat.Size = new Size(46, 24);
            lblP2FromBeat.TabIndex = 22;
            lblP2FromBeat.Text = "节拍";
            // 
            // nudP2ToBar
            // 
            nudP2ToBar.Location = new Point(364, 48);
            nudP2ToBar.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudP2ToBar.Name = "nudP2ToBar";
            nudP2ToBar.Size = new Size(70, 30);
            nudP2ToBar.TabIndex = 21;
            nudP2ToBar.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudP2FromBar
            // 
            nudP2FromBar.Location = new Point(364, 13);
            nudP2FromBar.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudP2FromBar.Name = "nudP2FromBar";
            nudP2FromBar.Size = new Size(70, 30);
            nudP2FromBar.TabIndex = 20;
            nudP2FromBar.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numP2ToBeat
            // 
            numP2ToBeat.DefaultValue = 1F;
            numP2ToBeat.IsCalc = false;
            numP2ToBeat.IsNull = false;
            numP2ToBeat.IsNullable = false;
            numP2ToBeat.Location = new Point(492, 47);
            numP2ToBeat.MaxValue = 999F;
            numP2ToBeat.MinValue = 1F;
            numP2ToBeat.Name = "numP2ToBeat";
            numP2ToBeat.PlaceholderText = "1";
            numP2ToBeat.Size = new Size(70, 30);
            numP2ToBeat.TabIndex = 18;
            numP2ToBeat.Text = "1";
            numP2ToBeat.Value = 1F;
            numP2ToBeat.ValueType = NumberBox.TypeEnum.Double;
            // 
            // numP2FromBeat
            // 
            numP2FromBeat.DefaultValue = 1F;
            numP2FromBeat.IsCalc = false;
            numP2FromBeat.IsNull = false;
            numP2FromBeat.IsNullable = false;
            numP2FromBeat.Location = new Point(492, 12);
            numP2FromBeat.MaxValue = 999F;
            numP2FromBeat.MinValue = 1F;
            numP2FromBeat.Name = "numP2FromBeat";
            numP2FromBeat.PlaceholderText = "1";
            numP2FromBeat.Size = new Size(70, 30);
            numP2FromBeat.TabIndex = 17;
            numP2FromBeat.Text = "1";
            numP2FromBeat.Value = 1F;
            numP2FromBeat.ValueType = NumberBox.TypeEnum.Double;
            // 
            // btnP2StartCopy
            // 
            btnP2StartCopy.Location = new Point(762, 571);
            btnP2StartCopy.Name = "btnP2StartCopy";
            btnP2StartCopy.Size = new Size(178, 34);
            btnP2StartCopy.TabIndex = 16;
            btnP2StartCopy.Text = "复制";
            btnP2StartCopy.UseVisualStyleBackColor = true;
            btnP2StartCopy.Click += btnP2StartCopy_Click;
            // 
            // chkP2IncludeEnd
            // 
            chkP2IncludeEnd.AutoSize = true;
            chkP2IncludeEnd.Location = new Point(568, 50);
            chkP2IncludeEnd.Name = "chkP2IncludeEnd";
            chkP2IncludeEnd.Size = new Size(108, 28);
            chkP2IncludeEnd.TabIndex = 11;
            chkP2IncludeEnd.Text = "包含结尾";
            chkP2IncludeEnd.UseVisualStyleBackColor = true;
            // 
            // lblP2To
            // 
            lblP2To.AutoSize = true;
            lblP2To.Location = new Point(294, 51);
            lblP2To.Name = "lblP2To";
            lblP2To.Size = new Size(64, 24);
            lblP2To.TabIndex = 10;
            lblP2To.Text = "到小节";
            // 
            // lblP2From
            // 
            lblP2From.AutoSize = true;
            lblP2From.Location = new Point(294, 14);
            lblP2From.Name = "lblP2From";
            lblP2From.Size = new Size(64, 24);
            lblP2From.TabIndex = 7;
            lblP2From.Text = "从小节";
            // 
            // chkP2IncludeBegin
            // 
            chkP2IncludeBegin.AutoSize = true;
            chkP2IncludeBegin.Checked = true;
            chkP2IncludeBegin.CheckState = CheckState.Checked;
            chkP2IncludeBegin.Location = new Point(568, 15);
            chkP2IncludeBegin.Name = "chkP2IncludeBegin";
            chkP2IncludeBegin.Size = new Size(108, 28);
            chkP2IncludeBegin.TabIndex = 6;
            chkP2IncludeBegin.Text = "包含开头";
            chkP2IncludeBegin.UseVisualStyleBackColor = true;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(15, 46);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(118, 24);
            lblTo.TabIndex = 3;
            lblTo.Text = "将事件复制到";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(15, 14);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(82, 24);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "复制目标";
            // 
            // cmbP2SpriteSelect
            // 
            cmbP2SpriteSelect.FormattingEnabled = true;
            cmbP2SpriteSelect.Location = new Point(103, 11);
            cmbP2SpriteSelect.Name = "cmbP2SpriteSelect";
            cmbP2SpriteSelect.Size = new Size(182, 32);
            cmbP2SpriteSelect.TabIndex = 1;
            // 
            // lstP2SpriteSelect
            // 
            lstP2SpriteSelect.FormattingEnabled = true;
            lstP2SpriteSelect.ItemHeight = 24;
            lstP2SpriteSelect.Location = new Point(15, 73);
            lstP2SpriteSelect.Name = "lstP2SpriteSelect";
            lstP2SpriteSelect.SelectionMode = SelectionMode.MultiExtended;
            lstP2SpriteSelect.Size = new Size(270, 532);
            lstP2SpriteSelect.TabIndex = 0;
            // 
            // btnReload
            // 
            btnReload.Enabled = false;
            btnReload.Location = new Point(16, 710);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(112, 34);
            btnReload.TabIndex = 6;
            btnReload.Text = "重载谱面";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // Revali
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 756);
            Controls.Add(btnReload);
            Controls.Add(btnSaveChart);
            Controls.Add(tabLevelEdit);
            Controls.Add(lblChartPath);
            Controls.Add(btnSelectChart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Revali";
            Text = "Revalian";
            tpSpriteImport.ResumeLayout(false);
            tpSpriteImport.PerformLayout();
            tabLevelEdit.ResumeLayout(false);
            tpSpriteEventCopy.ResumeLayout(false);
            tpSpriteEventCopy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudP2ToBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudP2FromBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectChart;
        private Label lblChartPath;
        private Button btnSaveChart;
        private TabPage tpSpriteImport;
        private NumberBox numP1Room;
        private NumberBox numP1Depth;
        private NumberBox numP1Angle;
        private NumberBox numP1ScaleY;
        private NumberBox numP1ScaleX;
        private NumberBox numP1PivotY;
        private NumberBox numP1PivotX;
        private NumberBox numP1PositionY;
        private NumberBox numP1PositionX;
        private Label label1;
        private Button btnP1CopySprite;
        private Button btnP1DeleteSprite;
        private Button btnP1AddSprite;
        private ListBox lstP1SpriteList;
        private ListBox lstP1SpritePathList;
        private Label lblAngle;
        private Label lblP1Pivot;
        private Button btnP1ImportSprite;
        private Label lblP1Scale;
        private Label lblP1Position;
        private CheckBox chkP1Visibility;
        private Label lblP1Depth;
        private Label lblP1Room;
        private Button btnP1SelectSprite;
        private TabControl tabLevelEdit;
        private TabPage tpSpriteEventCopy;
        private ListBox lstP2SpriteSelect;
        private ComboBox cmbP2SpriteSelect;
        private Label lblTo;
        private Label lblFrom;
        private CheckBox chkP1CopyFile;
        private Label lblP2To;
        private Label lblP2From;
        private CheckBox chkP2IncludeBegin;
        private NumericUpDown nudP2FromBar;
        private NumericUpDown nudP2ToBar;
        private CheckBox chkP2IncludeEnd;
        private Button btnP2StartCopy;
        private NumberBox numP2FromBeat;
        private NumberBox numP2ToBeat;
        private Label lblP2ToBeat;
        private Label lblP2FromBeat;
        private Label lblP2Parallax;
        private NumberBox numP2ParallaxY;
        private NumberBox numP2ParallaxX;
        private NumberBox numP2PositionOffsetY;
        private NumberBox numP2PositionOffsetX;
        private Label lblP2Offset;
        private NumberBox numP2Angle;
        private NumberBox numP2ScaleY;
        private NumberBox numP2ScaleX;
        private NumberBox numP2PivotY;
        private NumberBox numP2PivotX;
        private Label lblP2Angle;
        private Label lblP2Pivot;
        private Label lblP2Scale;
        private Button btnReload;
        private CheckBox ckbP1AddEvent;
    }
}
