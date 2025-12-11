using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDFCompressor.Services
{
    public class PDFCompressionService
    {
        public class PdfCompressionService
        {
            public void CompressPdf(string input, string output)
            {
                using var inputDoc = PdfReader.Open(input, PdfDocumentOpenMode.Import);
                using var outputDoc = new PdfDocument();

                outputDoc.Options.FlateEncodeMode = PdfFlateEncodeMode.BestCompression;
                outputDoc.Options.UseFlateDecoderForJpegImages = PdfUseFlateDecoderForJpegImages.Automatic;
                outputDoc.Options.CompressContentStreams = true;

                foreach (var page in inputDoc.Pages)
                    outputDoc.AddPage(page);

                outputDoc.Save(output);

            }
        }
    }
}
