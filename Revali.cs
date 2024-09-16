using RhythmBase.Components;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Revalian
{
    public partial class Revali : System.Windows.Forms.Form
    {
        public RDLevel chart;
        public List<string> p1SpriteList = new();

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
                Title = "选择精灵图文件",
                Multiselect = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lstP1SpritePathList.Items.Clear();
                    foreach (String spritePath in dialog.FileNames)
                    {
                        lstP1SpritePathList.Items.Add(spritePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("在尝试打开精灵图时出现了以下问题：\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
            if (p1SpriteList.Count != 0)
            {
                try
                {
                    for (int i = 0; i < p1SpriteList.Count; i++)
                    {
                        Ian.AddNewSprite(chart, p1SpriteList[i],
                            (byte)(numP1Room.Calc(i)-1), chkP1Visibility.Checked, (int)numP1Depth.Calc(i),
                            new PointE(numP1PositionX.Calc(i), numP1PositionY.Calc(i)), new PointE(numP1ScaleX.Calc(i), numP1ScaleY.Calc(i)),
                            numP1Angle.Calc(i), new PointE(numP1PivotX.Calc(i), numP1PivotY.Calc(i)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("在尝试导入精灵图时出现了以下问题：\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("精灵图导入成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("尚未选择精灵图文件！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnP1AddSprite_Click(object sender, EventArgs e)
        {
            foreach (String spritePath in lstP1SpritePathList.SelectedItems)
            {
                p1SpriteList.Add(spritePath);
            }
            UpdateListIndex(lstP1SpriteList, p1SpriteList);
        }

        private void btnP1DeleteSprite_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstP1SpriteList.SelectedItems.Count; i++)
            {
                p1SpriteList.RemoveAt(lstP1SpriteList.SelectedIndices[i]);
            }
            UpdateListIndex(lstP1SpriteList, p1SpriteList);
        }

        private void btnP1CopySprite_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstP1SpriteList.SelectedItems.Count; i++)
            {
                p1SpriteList.Add(p1SpriteList[lstP1SpriteList.SelectedIndices[i]]);
            }
            UpdateListIndex(lstP1SpriteList, p1SpriteList);
        }

        private void UpdateListIndex(ListBox listBox, List<string> list)
        {
            listBox.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                listBox.Items.Add(i.ToString() + ". " + Regex.Match(list[i], @"[^/\\]+$").Value);
            }
        }
    }
}


// @"(?<=^.*\. ).*"