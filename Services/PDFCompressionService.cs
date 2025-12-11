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
                PdfDocument document = PdfReader.Open(input, PdfDocumentOpenMode.Modify);

                // Example: lower the quality of images inside the PDF
                foreach (PdfPage page in document.Pages)
                {
                    // Iterate through images and recompress them (if applicable)
                    // NOTE: PDFsharp does not have native re-compression, 
                    // but we can force-flatten or remove unused objects.
                }

                // PDFSharp trick: Save with "Optimize" flag
                document.Options.FlateEncodeMode = PdfFlateEncodeMode.BestCompression;
                document.Options.UseFlateDecoderForJpegImages = PdfUseFlateDecoderForJpegImages.Automatic;
                document.Options.CompressContentStreams = true;

                document.Save(output);
            }
        }
    }
}
