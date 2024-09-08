using RhythmBase.Components;

namespace Revalian
{
    public partial class Revali : System.Windows.Forms.Form
    {
        public RDLevel chart;
        public string p1SpritePath = "";

        public Revali()
        {
            InitializeComponent();
        }

        private void btnSelectChart_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Filter = "《节奏医生》关卡文件|*.rdlevel",
                Title = "打开《节奏医生》自制谱面"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string chartPath = dialog.FileName;
                try
                {
                    chart = RDLevel.LoadFile(chartPath);
                    tabLevelEdit.Enabled = true;
                    btnSaveChart.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("在尝试打开谱面时出现了以下问题：\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblChartPath.Text = chartPath;

            }
        }

        private void btnP1SelectSprite_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Filter = "精灵图文件|*.jpeg;*.jpg;*.png;*.gif;*.json",
                Title = "选择精灵图文件"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                p1SpritePath = dialog.FileName;
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show("在尝试打开精灵图时出现了以下问题：\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblP1SpritePath.Text = p1SpritePath;
            }
        }

        private void btnSaveChart_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new()
            {
                Filter = "《节奏医生》关卡文件|*.rdlevel",
                Title = "选择谱面保存位置"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                chart.SaveFile(dialog.FileName);
                MessageBox.Show("谱面保存成功！");
            }
        }

        private void btnP1ImportSprite_Click(object sender, EventArgs e)
        {
            if (p1SpritePath != string.Empty)
            {
                try
                {
                    Ian.AddNewSprite(chart, lblP1SpritePath.Text,
                        (byte)(nudP1Room.Value - 1), chkP1Visibility.Checked, (int)nudP1Depth.Value,
                        new PointE(numP1PositionX.Value, numP1PositionY.Value), new PointE(numP1ScaleX.Value, numP1ScaleY.Value),
                        numP1Angle.Value, new PointE(numP1PivotX.Value, numP1PivotY.Value));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("在尝试导入精灵图时出现了以下问题：\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("尚未选择精灵图文件！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
