namespace Revalian
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // see https://aka.ms/applicationconfiguration.

            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Revali());
            }
            catch (Exception ex)
            {
                MessageBox.Show("������δ��������쳣��\n"+ex, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}