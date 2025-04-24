namespace CW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numShift_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            string userInput = txtInput.Text.ToUpper();
            int shift = (int)numShift.Value;

            try
            {
                StringProcessing sp = new StringProcessing(userInput, shift);
                sp.Encode();

                lblOutput.Text = "Encoded: " + sp.Print();
                LstDetails.Items.Clear();
                LstDetails.Items.Add("Input ASCII: " + string.Join(", ", sp.InputCode()));
                LstDetails.Items.Add("Output ASCII: " + string.Join(", ", sp.OutputCode()));
                LstDetails.Items.Add("Sorted Input: " + sp.Sort());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
