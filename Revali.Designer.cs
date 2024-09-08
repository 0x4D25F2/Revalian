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
            lblP1Scale = new Label();
            txtP1ScaleX = new TextBox();
            txtP1ScaleY = new TextBox();
            lblP1Position = new Label();
            txtP1PositionY = new TextBox();
            txtP1PositionX = new TextBox();
            nudP1Depth = new NumericUpDown();
            chkP1Visibility = new CheckBox();
            lblP1Depth = new Label();
            lblP1Room = new Label();
            nudP1Room = new NumericUpDown();
            lblP1SpritePath = new Label();
            tabPage2 = new TabPage();
            btnP1ImportSprite = new Button();
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
            tpSpriteImport.Controls.Add(btnP1ImportSprite);
            tpSpriteImport.Controls.Add(lblP1Scale);
            tpSpriteImport.Controls.Add(txtP1ScaleX);
            tpSpriteImport.Controls.Add(txtP1ScaleY);
            tpSpriteImport.Controls.Add(lblP1Position);
            tpSpriteImport.Controls.Add(txtP1PositionY);
            tpSpriteImport.Controls.Add(txtP1PositionX);
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
            // lblP1Scale
            // 
            lblP1Scale.AutoSize = true;
            lblP1Scale.Location = new Point(20, 225);
            lblP1Scale.Name = "lblP1Scale";
            lblP1Scale.Size = new Size(46, 24);
            lblP1Scale.TabIndex = 14;
            lblP1Scale.Text = "缩放";
            // 
            // txtP1ScaleX
            // 
            txtP1ScaleX.Location = new Point(138, 222);
            txtP1ScaleX.Name = "txtP1ScaleX";
            txtP1ScaleX.Size = new Size(60, 30);
            txtP1ScaleX.TabIndex = 13;
            txtP1ScaleX.Text = "100";
            txtP1ScaleX.LostFocus += txtP1ScaleX_LostFocus;
            // 
            // txtP1ScaleY
            // 
            txtP1ScaleY.Location = new Point(72, 222);
            txtP1ScaleY.Name = "txtP1ScaleY";
            txtP1ScaleY.Size = new Size(60, 30);
            txtP1ScaleY.TabIndex = 12;
            txtP1ScaleY.Text = "100";
            txtP1ScaleY.LostFocus += txtP1ScaleY_LostFocus;
            // 
            // lblP1Position
            // 
            lblP1Position.AutoSize = true;
            lblP1Position.Location = new Point(20, 189);
            lblP1Position.Name = "lblP1Position";
            lblP1Position.Size = new Size(46, 24);
            lblP1Position.TabIndex = 11;
            lblP1Position.Text = "位置";
            // 
            // txtP1PositionY
            // 
            txtP1PositionY.Location = new Point(138, 186);
            txtP1PositionY.Name = "txtP1PositionY";
            txtP1PositionY.Size = new Size(60, 30);
            txtP1PositionY.TabIndex = 10;
            txtP1PositionY.Text = "50";
            txtP1PositionY.LostFocus += txtP1PositionY_LostFocus;
            // 
            // txtP1PositionX
            // 
            txtP1PositionX.Location = new Point(72, 186);
            txtP1PositionX.Name = "txtP1PositionX";
            txtP1PositionX.Size = new Size(60, 30);
            txtP1PositionX.TabIndex = 9;
            txtP1PositionX.Text = "50";
            txtP1PositionX.LostFocus += txtP1PositionX_LostFocus;
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
            tabPage2.Size = new Size(746, 443);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnP1ImportSprite
            // 
            btnP1ImportSprite.Location = new Point(20, 258);
            btnP1ImportSprite.Name = "btnP1ImportSprite";
            btnP1ImportSprite.Size = new Size(178, 34);
            btnP1ImportSprite.TabIndex = 15;
            btnP1ImportSprite.Text = "导入";
            btnP1ImportSprite.UseVisualStyleBackColor = true;
            // 
            // btnSaveChart
            // 
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
        private TextBox txtP1PositionX;
        private TextBox txtP1PositionY;
        private Label lblP1Position;
        private Label lblP1Scale;
        private TextBox txtP1ScaleX;
        private TextBox txtP1ScaleY;
        private Button btnP1ImportSprite;
        private Button btnSaveChart;
    }
}
