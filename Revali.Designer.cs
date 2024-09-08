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
            btnSelectChart = new Button();
            lblChartPath = new Label();
            btnP1SelectSprite = new Button();
            tabLevelEdit = new TabControl();
            tpSpriteImport = new TabPage();
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
            nudP1Depth = new NumericUpDown();
            chkP1Visibility = new CheckBox();
            lblP1Depth = new Label();
            lblP1Room = new Label();
            nudP1Room = new NumericUpDown();
            lblP1SpritePath = new Label();
            tabPage2 = new TabPage();
            btnSaveChart = new Button();
            tabLevelEdit.SuspendLayout();
            tpSpriteImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudP1Depth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudP1Room).BeginInit();
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
            btnP1SelectSprite.Size = new Size(178, 34);
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
            tabLevelEdit.Size = new Size(754, 446);
            tabLevelEdit.TabIndex = 4;
            // 
            // tpSpriteImport
            // 
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
            tpSpriteImport.Controls.Add(nudP1Depth);
            tpSpriteImport.Controls.Add(chkP1Visibility);
            tpSpriteImport.Controls.Add(lblP1Depth);
            tpSpriteImport.Controls.Add(lblP1Room);
            tpSpriteImport.Controls.Add(nudP1Room);
            tpSpriteImport.Controls.Add(lblP1SpritePath);
            tpSpriteImport.Controls.Add(btnP1SelectSprite);
            tpSpriteImport.Location = new Point(4, 33);
            tpSpriteImport.Name = "tpSpriteImport";
            tpSpriteImport.Padding = new Padding(3);
            tpSpriteImport.Size = new Size(746, 409);
            tpSpriteImport.TabIndex = 0;
            tpSpriteImport.Text = "导入精灵";
            tpSpriteImport.UseVisualStyleBackColor = true;
            // 
            // lblAngle
            // 
            lblAngle.AutoSize = true;
            lblAngle.Location = new Point(20, 260);
            lblAngle.Name = "lblAngle";
            lblAngle.Size = new Size(46, 24);
            lblAngle.TabIndex = 26;
            lblAngle.Text = "角度";
            // 
            // numP1Angle
            // 
            numP1Angle.DefaultValue = 0F;
            numP1Angle.IsNull = false;
            numP1Angle.IsNullable = true;
            numP1Angle.Location = new Point(72, 257);
            numP1Angle.Name = "numP1Angle";
            numP1Angle.PlaceholderText = "--";
            numP1Angle.Size = new Size(126, 30);
            numP1Angle.TabIndex = 25;
            numP1Angle.Text = "0";
            numP1Angle.Value = 0F;
            // 
            // numP1ScaleY
            // 
            numP1ScaleY.DefaultValue = 1F;
            numP1ScaleY.IsNull = false;
            numP1ScaleY.IsNullable = true;
            numP1ScaleY.Location = new Point(138, 221);
            numP1ScaleY.Name = "numP1ScaleY";
            numP1ScaleY.PlaceholderText = "--";
            numP1ScaleY.Size = new Size(60, 30);
            numP1ScaleY.TabIndex = 24;
            numP1ScaleY.Text = "1";
            numP1ScaleY.Value = 1F;
            // 
            // numP1ScaleX
            // 
            numP1ScaleX.DefaultValue = 1F;
            numP1ScaleX.IsNull = false;
            numP1ScaleX.IsNullable = true;
            numP1ScaleX.Location = new Point(72, 221);
            numP1ScaleX.Name = "numP1ScaleX";
            numP1ScaleX.PlaceholderText = "--";
            numP1ScaleX.Size = new Size(60, 30);
            numP1ScaleX.TabIndex = 23;
            numP1ScaleX.Text = "1";
            numP1ScaleX.Value = 1F;
            // 
            // numP1PivotY
            // 
            numP1PivotY.DefaultValue = 50F;
            numP1PivotY.IsNull = false;
            numP1PivotY.IsNullable = true;
            numP1PivotY.Location = new Point(138, 293);
            numP1PivotY.Name = "numP1PivotY";
            numP1PivotY.PlaceholderText = "--";
            numP1PivotY.Size = new Size(60, 30);
            numP1PivotY.TabIndex = 22;
            numP1PivotY.Text = "50";
            numP1PivotY.Value = 50F;
            // 
            // numP1PivotX
            // 
            numP1PivotX.DefaultValue = 50F;
            numP1PivotX.IsNull = false;
            numP1PivotX.IsNullable = true;
            numP1PivotX.Location = new Point(72, 293);
            numP1PivotX.Name = "numP1PivotX";
            numP1PivotX.PlaceholderText = "--";
            numP1PivotX.Size = new Size(60, 30);
            numP1PivotX.TabIndex = 21;
            numP1PivotX.Text = "50";
            numP1PivotX.Value = 50F;
            // 
            // numP1PositionY
            // 
            numP1PositionY.DefaultValue = 50F;
            numP1PositionY.IsNull = false;
            numP1PositionY.IsNullable = true;
            numP1PositionY.Location = new Point(138, 185);
            numP1PositionY.Name = "numP1PositionY";
            numP1PositionY.PlaceholderText = "--";
            numP1PositionY.Size = new Size(60, 30);
            numP1PositionY.TabIndex = 20;
            numP1PositionY.Text = "50";
            numP1PositionY.Value = 50F;
            // 
            // numP1PositionX
            // 
            numP1PositionX.DefaultValue = 50F;
            numP1PositionX.IsNull = false;
            numP1PositionX.IsNullable = true;
            numP1PositionX.Location = new Point(72, 185);
            numP1PositionX.Name = "numP1PositionX";
            numP1PositionX.PlaceholderText = "--";
            numP1PositionX.Size = new Size(60, 30);
            numP1PositionX.TabIndex = 19;
            numP1PositionX.Text = "50";
            numP1PositionX.Value = 50F;
            // 
            // lblP1Pivot
            // 
            lblP1Pivot.AutoSize = true;
            lblP1Pivot.Location = new Point(20, 296);
            lblP1Pivot.Name = "lblP1Pivot";
            lblP1Pivot.Size = new Size(46, 24);
            lblP1Pivot.TabIndex = 18;
            lblP1Pivot.Text = "轴点";
            // 
            // btnP1ImportSprite
            // 
            btnP1ImportSprite.Location = new Point(562, 369);
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
            lblP1Scale.Location = new Point(20, 224);
            lblP1Scale.Name = "lblP1Scale";
            lblP1Scale.Size = new Size(46, 24);
            lblP1Scale.TabIndex = 14;
            lblP1Scale.Text = "缩放";
            // 
            // lblP1Position
            // 
            lblP1Position.AutoSize = true;
            lblP1Position.Location = new Point(20, 188);
            lblP1Position.Name = "lblP1Position";
            lblP1Position.Size = new Size(46, 24);
            lblP1Position.TabIndex = 11;
            lblP1Position.Text = "位置";
            // 
            // nudP1Depth
            // 
            nudP1Depth.Location = new Point(72, 149);
            nudP1Depth.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            nudP1Depth.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            nudP1Depth.Name = "nudP1Depth";
            nudP1Depth.Size = new Size(126, 30);
            nudP1Depth.TabIndex = 8;
            // 
            // chkP1Visibility
            // 
            chkP1Visibility.AutoSize = true;
            chkP1Visibility.Location = new Point(20, 116);
            chkP1Visibility.Name = "chkP1Visibility";
            chkP1Visibility.Size = new Size(90, 28);
            chkP1Visibility.TabIndex = 7;
            chkP1Visibility.Text = "可见性";
            chkP1Visibility.UseVisualStyleBackColor = true;
            // 
            // lblP1Depth
            // 
            lblP1Depth.AutoSize = true;
            lblP1Depth.Location = new Point(20, 151);
            lblP1Depth.Name = "lblP1Depth";
            lblP1Depth.Size = new Size(46, 24);
            lblP1Depth.TabIndex = 6;
            lblP1Depth.Text = "深度";
            // 
            // lblP1Room
            // 
            lblP1Room.AutoSize = true;
            lblP1Room.Location = new Point(20, 82);
            lblP1Room.Name = "lblP1Room";
            lblP1Room.Size = new Size(46, 24);
            lblP1Room.TabIndex = 5;
            lblP1Room.Text = "房间";
            // 
            // nudP1Room
            // 
            nudP1Room.Location = new Point(72, 80);
            nudP1Room.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudP1Room.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudP1Room.Name = "nudP1Room";
            nudP1Room.Size = new Size(126, 30);
            nudP1Room.TabIndex = 4;
            nudP1Room.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblP1SpritePath
            // 
            lblP1SpritePath.AutoSize = true;
            lblP1SpritePath.Location = new Point(204, 25);
            lblP1SpritePath.Name = "lblP1SpritePath";
            lblP1SpritePath.Size = new Size(22, 24);
            lblP1SpritePath.TabIndex = 3;
            lblP1SpritePath.Text = "...";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(746, 409);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveChart
            // 
            btnSaveChart.Enabled = false;
            btnSaveChart.Location = new Point(654, 504);
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
            ClientSize = new Size(778, 544);
            Controls.Add(btnSaveChart);
            Controls.Add(tabLevelEdit);
            Controls.Add(lblChartPath);
            Controls.Add(btnSelectChart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Revali";
            Text = "Revalian";
            tabLevelEdit.ResumeLayout(false);
            tpSpriteImport.ResumeLayout(false);
            tpSpriteImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudP1Depth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudP1Room).EndInit();
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
        private Label lblP1SpritePath;
        private NumericUpDown nudP1Room;
        private Label lblP1Room;
        private CheckBox chkP1Visibility;
        private Label lblP1Depth;
        private NumericUpDown nudP1Depth;
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
    }
}
