namespace WinFormsApp2
{
    public partial class frmClasses : Form
    {
        public frmClasses()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Medal country;
            if (txtCountry.Text == "")
            {
                MessageBox.Show("??????? ????? ??????");
                return;
            }

            if (txtAthletes.Text != "")
            {
                if (txtGold.Text != "")
                {
                    if (txtSilver.Text != "" && txtBronze.Text != "")
                    {
                        country = new Medal(
                            txtCountry.Text,
                            Convert.ToInt32(txtAthletes.Text),
                            Convert.ToInt32(txtGold.Text),
                            Convert.ToInt32(txtSilver.Text),
                            Convert.ToInt32(txtBronze.Text)
                        );
                    }
                    else
                    {
                        country = new Medal(
                            txtCountry.Text,
                            Convert.ToInt32(txtAthletes.Text),
                            Convert.ToInt32(txtGold.Text)
                        );
                    }
                }
                else
                {
                    country = new Medal(
                        txtCountry.Text,
                        Convert.ToInt32(txtAthletes.Text)
                    );
                }
            }
            else
            {
                country = new Medal(txtCountry.Text);
            }

            txtResult.Text += country.GetInformation();
        }
    }
}
