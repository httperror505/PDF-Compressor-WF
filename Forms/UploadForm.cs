using System.Windows.Forms;
using static PDFCompressor.Services.PDFCompressionService;

namespace PDFCompressor
{
    public partial class UploadForm : Form
    {
        private string selectedPdfPath = "";
        private readonly PdfCompressionService pdfService = new PdfCompressionService();
        public UploadForm()
        {
            InitializeComponent();
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a PDF file";
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedPdfPath = openFileDialog.FileName;

                textBox1.Text = selectedPdfPath; // Display the selected file
                MessageBox.Show("File selected!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedPdfPath))
            {
                MessageBox.Show("Please upload a PDF first.");
                return;
            }

            string inputPath = selectedPdfPath;

            string outputPath = Path.Combine(
                Path.GetDirectoryName(inputPath),
                $"compressed_{Path.GetFileName(inputPath)}"
            );

            pdfService.CompressPdf(inputPath, outputPath);

            MessageBox.Show("Compression complete!\nSaved as: " + outputPath);
        }
    }
}
