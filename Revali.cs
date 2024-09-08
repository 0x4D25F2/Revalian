using RhythmBase.Components;
using static Revalian.Ian;

namespace Revalian
{
    public partial class Revali : System.Windows.Forms.Form
    {
        public RDLevel chart;

        public Revali()
        {
            InitializeComponent();
        }

        private void btnSelectChart_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "《节奏医生》关卡文件|*.rdlevel";
            dialog.Title = "打开《节奏医生》关卡";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string chartPath = dialog.FileName;
                try
                {
                    chart = RDLevel.LoadFile(chartPath);
                    tabLevelEdit.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("在尝试打开关卡文件时出现了以下问题：\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblChartPath.Text = chartPath;

            }
        }

        private void btnP1SelectSprite_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON 文件|*.jpeg;*.jpg;*.png;*.gif;*.json";
            dialog.Title = "选择精灵图片数据";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string p1SpritePath = dialog.FileName;
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show("在尝试打开精灵图片数据时出现了以下问题：\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblP1SpritePath.Text = p1SpritePath;
            }
        }

        private void txtP1PositionX_LostFocus(object sender, EventArgs e)
        {
            bool result = double.TryParse(txtP1PositionX.Text, out double _);
            if (!result) txtP1PositionY.Text = "50";
        }

        private void txtP1PositionY_LostFocus(object sender, EventArgs e)
        {
            bool result = double.TryParse(txtP1PositionY.Text, out double _);
            if (!result) txtP1PositionY.Text = "50";
        }

        private void txtP1ScaleX_LostFocus(object sender, EventArgs e)
        {
            bool result = double.TryParse(txtP1ScaleX.Text, out double _);
            if (!result) txtP1ScaleX.Text = "100";
        }

        private void txtP1ScaleY_LostFocus(object sender, EventArgs e)
        {
            bool result = double.TryParse(txtP1ScaleY.Text, out double _);
            if (!result) txtP1ScaleY.Text = "100";
        }

        private void btnSaveChart_Click(object sender, EventArgs e)
        {
            
        }
    }
}
