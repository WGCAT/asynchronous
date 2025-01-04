namespace asynchronous
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void RunAnythingAsync(Label lbl)
        {
            for (int i = 0; i < 50; i++)
            {
                await Task.Delay(50);
                lbl.Text = i.ToString();
                lbl.Refresh();
            }
        }

        private void btnWalking_Click(object sender, EventArgs e)
        {
            RunAnythingAsync(lblWalking);
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            RunAnythingAsync(lblPhone);
        }

        private void btnTalking_Click(object sender, EventArgs e)
        {
            RunAnythingAsync(lblTalking);
        }
    }
}
