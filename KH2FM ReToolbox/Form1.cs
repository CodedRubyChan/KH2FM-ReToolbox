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
            MetroSetMessageBox.Show(this, "Du elendiger Hurensohn", "HS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}