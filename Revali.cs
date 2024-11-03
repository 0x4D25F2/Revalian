using RhythmBase.Components;
using RhythmBase.Events;
using RhythmBase.Extensions;
using RhythmBase.Utils;
using System.IO;
using System.Security.Policy;
using System.Text.RegularExpressions;


namespace Revalian
{
    public partial class Revali : System.Windows.Forms.Form
    {
        public RDLevel chart;
        public List<string> p1SpritePathList = new();
        public List<DecorationEventCollection> chartSpriteList = new();

        public Revali()
        {
            InitializeComponent();
        }

        private void UpdateListIndex(ListBox listBox, List<string> list)
        {
            listBox.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string relative_path = Path.GetRelativePath(chart.Path, list[i]);
                listBox.Items.Add(i.ToString() + ". " + relative_path.Substring(3, relative_path.Length - 3));
            }
        }

        private void UpdateChartInfo()
        {
            chartSpriteList = Ian.GetSprite(chart);
            List<string> sprites_string = Ian.SpriteListToString(chartSpriteList);
            cmbP2SpriteSelect.Items.Clear();
            lstP2SpriteSelect.Items.Clear();
            foreach (string sprite in sprites_string)
            {
                cmbP2SpriteSelect.Items.Add(sprite);
                lstP2SpriteSelect.Items.Add(sprite);
            }
            nudP2FromBar.Maximum = chart.Length.BarBeat.bar + 1;
            nudP2ToBar.Maximum = chart.Length.BarBeat.bar + 1;
            nudP2ToBar.Value = nudP2ToBar.Maximum;
        }

        private void btnSelectChart_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Filter = "������ҽ�����ؿ��ļ�|*.rdlevel",
                Title = "�򿪡�����ҽ������������"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string chartPath = dialog.FileName;
                try
                {
                    chart = RDLevel.Read(chartPath);
                    tabLevelEdit.Enabled = true;
                    btnSaveChart.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("�ڳ��Դ�����ʱ�������������⣺\n" + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblChartPath.Text = chartPath;
                UpdateChartInfo();
            }
        }

        private void btnP1SelectSprite_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Filter = "����ͼ�ļ�|*.jpeg;*.jpg;*.png;*.gif;*.json",
                Title = "ѡ����ͼ�ļ�",
                Multiselect = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lstP1SpritePathList.Items.Clear();
                foreach (String spritePath in dialog.FileNames)
                {
                    if (chkP1CopyFile.Checked && Path.GetDirectoryName(spritePath) != Path.GetDirectoryName(chart.Path))
                    {
                        string oldSpritePath = $"{Path.GetDirectoryName(spritePath)}\\{Path.GetFileNameWithoutExtension(spritePath)}";
                        string newSpritePath = $"{Path.GetDirectoryName(chart.Path)}\\{Path.GetFileNameWithoutExtension(spritePath)}";
                        try
                        {
                            if (Path.GetExtension(spritePath) == ".json")
                                if (File.Exists($"{oldSpritePath}.png"))
                                    File.Copy($"{oldSpritePath}.png", $"{newSpritePath}.png");
                                else
                                    throw new IOException($"δ���ҵ��ļ�{oldSpritePath}.png");
                            File.Copy(spritePath, newSpritePath + Path.GetExtension(spritePath));
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show($"�ڳ��Ը���{spritePath}ʱ�������������⣺\n{ex.Message}\n���������ִ�����ļ�...", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        lstP1SpritePathList.Items.Add(newSpritePath + Path.GetExtension(spritePath));
                    }
                    else
                    {
                        lstP1SpritePathList.Items.Add(spritePath);
                    }
                }
            }
        }

        private void btnSaveChart_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new()
            {
                Filter = "������ҽ�����ؿ��ļ�|*.rdlevel",
                Title = "ѡ�����汣��λ��"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                chart.Write(path);
                MessageBox.Show("���汣��ɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnP1ImportSprite_Click(object sender, EventArgs e)
        {
            if (p1SpritePathList.Count != 0)
            {
                try
                {
                    for (int i = 0; i < p1SpritePathList.Count; i++)
                        Ian.AddNewSprite(chart, p1SpritePathList[i],
                            (byte)(numP1Room.Calc(i) - 1), chkP1Visibility.Checked, (int)numP1Depth.Calc(i),
                            new RDPointE(numP1PositionX.Calc(i), numP1PositionY.Calc(i)), new RDPointE(numP1ScaleX.Calc(i), numP1ScaleY.Calc(i)),
                            numP1Angle.Calc(i), new RDPointE(numP1PivotX.Calc(i), numP1PivotY.Calc(i)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"�ڳ��Ե��뾫��ͼʱ�������������⣺\n{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("����ͼ����ɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("��δѡ����ͼ�ļ���", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnP1AddSprite_Click(object sender, EventArgs e)
        {
            foreach (String spritePath in lstP1SpritePathList.SelectedItems)
                p1SpritePathList.Add(spritePath);
            UpdateListIndex(lstP1SpriteList, p1SpritePathList);
        }

        private void btnP1DeleteSprite_Click(object sender, EventArgs e)
        {
            for (int i = lstP1SpriteList.SelectedItems.Count - 1; i >= 0; i--)
                p1SpritePathList.RemoveAt(lstP1SpriteList.SelectedIndices[i]);
            UpdateListIndex(lstP1SpriteList, p1SpritePathList);
        }

        private void btnP1CopySprite_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstP1SpriteList.SelectedItems.Count; i++)
                p1SpritePathList.Add(p1SpritePathList[lstP1SpriteList.SelectedIndices[i]]);
            UpdateListIndex(lstP1SpriteList, p1SpritePathList);
        }

        private void btnP2StartCopy_Click(object sender, EventArgs e)
        {
            if (cmbP2SpriteSelect.SelectedIndex != -1)
            {
                List<DecorationEventCollection> decos = Ian.GetSprite(chart);
                List<BaseDecorationAction> events = Ian.GetSpriteEvent(decos[cmbP2SpriteSelect.SelectedIndex],
                    chart.BeatOf((uint)nudP2FromBar.Value, (float)numP2FromBeat.Value),
                    chart.BeatOf((uint)nudP2ToBar.Value, (float)numP2ToBeat.Value), chkP2IncludeBegin.Checked, chkP2IncludeEnd.Checked);
                for (int i = 0; i < lstP2SpriteSelect.SelectedItems.Count; i++)
                    Ian.AddSpriteEvent(chart, decos[lstP2SpriteSelect.SelectedIndices[i]], events, numP2ParallaxX.Calc(i), numP2ParallaxY.Calc(i),
                        numP2PositionOffsetX.Calc(i), numP2PositionOffsetY.Calc(i),
                        [numP2ScaleX.Calc(i), numP2ScaleY.Calc(i)], numP2Angle.Calc(i), [numP2PivotX.Calc(i), numP2PivotY.Calc(i)]);
                MessageBox.Show("���Ƴɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("��δѡ��Ҫ���Ƶľ���ͼ��", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void numP2ParallaxX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}