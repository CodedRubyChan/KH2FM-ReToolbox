using MetroSet_UI;
using MetroSet_UI.Forms;
using KHMemLibrary.KH2FMLib;
using KHMemLibrary;

namespace KH2FM_ReToolbox
{
    public partial class Form1 : MetroSetForm
    {
        KH2FM KH2 = new KH2FM();
        public Form1()
        {
            InitializeComponent();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            MetroSetMessageBox.Show(this, "Du elendiger Hurensohn", "HS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* public void ReadPlaytime()
        {
            TimeSpan time = TimeSpan.FromSeconds(Convert.ToDouble(KH2.GetPlayTime()));
            string igntime = $"{(int)time.TotalHours}:{time:mm}:{time:ss}";
        }

        string world = await KH2.GetWorldText(); */

        
        
    }
}