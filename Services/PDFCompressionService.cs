using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDFCompressor.Services
{
    public class PDFCompressionService
    {
        public class PdfCompressionService
        {
            public void CompressPdf(string input, string output, IProgress<int>? progress = null)
            {
                using var inputDoc = PdfReader.Open(input, PdfDocumentOpenMode.Import);
                using var outputDoc = new PdfDocument();

                int totalPages = inputDoc.PageCount;
                int pagesProcessed = 0;

                outputDoc.Options.FlateEncodeMode = PdfFlateEncodeMode.BestCompression;
                outputDoc.Options.UseFlateDecoderForJpegImages = PdfUseFlateDecoderForJpegImages.Automatic;
                outputDoc.Options.CompressContentStreams = true;

                foreach (PdfPage page in inputDoc.Pages)
                {
                    outputDoc.AddPage(page);
                    pagesProcessed++;

                    if (progress != null)
                    {
                        int percentComplete = (int)((pagesProcessed / (double)totalPages) * 100);
                        progress.Report(percentComplete);
                    }
                }

                outputDoc.Save(output);

            }
        }
    }
}
