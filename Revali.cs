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
                Filter = "������ҽ�����ؿ��ļ�|*.rdlevel",
                Title = "�򿪡�����ҽ������������"
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
                    MessageBox.Show("�ڳ��Դ�����ʱ�������������⣺\n" + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblChartPath.Text = chartPath;

            }
        }

        private void btnP1SelectSprite_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Filter = "����ͼ�ļ�|*.jpeg;*.jpg;*.png;*.gif;*.json",
                Title = "ѡ����ͼ�ļ�"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                p1SpritePath = dialog.FileName;
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show("�ڳ��Դ򿪾���ͼʱ�������������⣺\n" + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblP1SpritePath.Text = p1SpritePath;
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
                chart.SaveFile(dialog.FileName);
                MessageBox.Show("���汣��ɹ���");
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
                    MessageBox.Show("�ڳ��Ե��뾫��ͼʱ�������������⣺\n" + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("��δѡ����ͼ�ļ���", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
