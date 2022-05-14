using MetroSet_UI;
using MetroSet_UI.Forms;

namespace KH2FM_ReToolbox
{
    public partial class Form1 : MetroSetForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Test Message");
        }
    }
}