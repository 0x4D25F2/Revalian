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
            btnP1SelectSprite = new Button();
            tabLevelEdit = new TabControl();
            tpSpriteImport = new TabPage();
            numP1Room = new NumberBox();
            numP1Depth = new NumberBox();
            label1 = new Label();
            btnP1CopySprite = new Button();
            btnP1DeleteSprite = new Button();
            btnP1AddSprite = new Button();
            lstP1SpriteList = new ListBox();
            lstP1SpritePathList = new ListBox();
            lblAngle = new Label();
            numP1Angle = new NumberBox();
            numP1ScaleY = new NumberBox();
            numP1ScaleX = new NumberBox();
            numP1PivotY = new NumberBox();
            numP1PivotX = new NumberBox();
            numP1PositionY = new NumberBox();
            numP1PositionX = new NumberBox();
            lblP1Pivot = new Label();
            btnP1ImportSprite = new Button();
            lblP1Scale = new Label();
            lblP1Position = new Label();
            chkP1Visibility = new CheckBox();
            lblP1Depth = new Label();
            lblP1Room = new Label();
            tabPage2 = new TabPage();
            btnSaveChart = new Button();
            tabLevelEdit.SuspendLayout();
            tpSpriteImport.SuspendLayout();
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
            tabLevelEdit.Controls.Add(tabPage2);
            tabLevelEdit.Enabled = false;
            tabLevelEdit.Location = new Point(12, 52);
            tabLevelEdit.Name = "tabLevelEdit";
            tabLevelEdit.SelectedIndex = 0;
            tabLevelEdit.Size = new Size(954, 652);
            tabLevelEdit.TabIndex = 4;
            // 
            // tpSpriteImport
            // 
            tpSpriteImport.Controls.Add(numP1Room);
            tpSpriteImport.Controls.Add(numP1Depth);
            tpSpriteImport.Controls.Add(label1);
            tpSpriteImport.Controls.Add(btnP1CopySprite);
            tpSpriteImport.Controls.Add(btnP1DeleteSprite);
            tpSpriteImport.Controls.Add(btnP1AddSprite);
            tpSpriteImport.Controls.Add(lstP1SpriteList);
            tpSpriteImport.Controls.Add(lstP1SpritePathList);
            tpSpriteImport.Controls.Add(lblAngle);
            tpSpriteImport.Controls.Add(numP1Angle);
            tpSpriteImport.Controls.Add(numP1ScaleY);
            tpSpriteImport.Controls.Add(numP1ScaleX);
            tpSpriteImport.Controls.Add(numP1PivotY);
            tpSpriteImport.Controls.Add(numP1PivotX);
            tpSpriteImport.Controls.Add(numP1PositionY);
            tpSpriteImport.Controls.Add(numP1PositionX);
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
            lstP1SpritePathList.Location = new Point(20, 68);
            lstP1SpritePathList.Name = "lstP1SpritePathList";
            lstP1SpritePathList.SelectionMode = SelectionMode.MultiExtended;
            lstP1SpritePathList.Size = new Size(230, 484);
            lstP1SpritePathList.TabIndex = 27;
            // 
            // lblAngle
            // 
            lblAngle.AutoSize = true;
            lblAngle.Location = new Point(751, 200);
            lblAngle.Name = "lblAngle";
            lblAngle.Size = new Size(46, 24);
            lblAngle.TabIndex = 26;
            lblAngle.Text = "角度";
            // 
            // numP1Angle
            // 
            numP1Angle.DefaultValue = 0F;
            numP1Angle.IsCalc = true;
            numP1Angle.IsNull = false;
            numP1Angle.IsNullable = true;
            numP1Angle.Location = new Point(803, 197);
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
            numP1ScaleY.Location = new Point(869, 161);
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
            numP1ScaleX.Location = new Point(803, 161);
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
            numP1PivotY.Location = new Point(869, 233);
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
            numP1PivotX.Location = new Point(803, 233);
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
            numP1PositionY.Location = new Point(869, 125);
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
            numP1PositionX.Location = new Point(803, 125);
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
            // lblP1Pivot
            // 
            lblP1Pivot.AutoSize = true;
            lblP1Pivot.Location = new Point(751, 236);
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
            lblP1Scale.Location = new Point(751, 164);
            lblP1Scale.Name = "lblP1Scale";
            lblP1Scale.Size = new Size(46, 24);
            lblP1Scale.TabIndex = 14;
            lblP1Scale.Text = "缩放";
            // 
            // lblP1Position
            // 
            lblP1Position.AutoSize = true;
            lblP1Position.Location = new Point(751, 128);
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(946, 615);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            // Revali
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 756);
            Controls.Add(btnSaveChart);
            Controls.Add(tabLevelEdit);
            Controls.Add(lblChartPath);
            Controls.Add(btnSelectChart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Revali";
            Text = "Revalian";
            tabLevelEdit.ResumeLayout(false);
            tpSpriteImport.ResumeLayout(false);
            tpSpriteImport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectChart;
        private Label lblChartPath;
        private Button btnP1SelectSprite;
        private TabControl tabLevelEdit;
        private TabPage tpSpriteImport;
        private TabPage tabPage2;
        private Label lblP1Room;
        private CheckBox chkP1Visibility;
        private Label lblP1Depth;
        private Label lblP1Position;
        private Label lblP1Scale;
        private Button btnP1ImportSprite;
        private Button btnSaveChart;
        private Label lblP1Pivot;
        private NumberBox numP1PositionX;
        private NumberBox numP1PositionY;
        private NumberBox numP1ScaleY;
        private NumberBox numP1ScaleX;
        private NumberBox numP1PivotY;
        private NumberBox numP1PivotX;
        private NumberBox numP1Angle;
        private Label lblAngle;
        private ListBox lstP1SpritePathList;
        private ListBox lstP1SpriteList;
        private Button btnP1AddSprite;
        private Button btnP1DeleteSprite;
        private Button btnP1CopySprite;
        private Label label1;
        private NumberBox numP1Depth;
        private NumberBox numP1Room;
    }
}
