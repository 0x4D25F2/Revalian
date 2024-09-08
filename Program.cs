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
                MessageBox.Show("出现了未经处理的异常：\n"+ex, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}