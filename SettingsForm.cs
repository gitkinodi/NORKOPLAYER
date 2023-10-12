using System.Windows.Forms;

namespace NORKOPLAYER
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
