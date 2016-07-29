using System;
using Atalasoft.Imaging.Codec;
using Atalasoft.Imaging.Codec.Pdf;

namespace WebDocumentViewer
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // Enable PDF rendering
            RegisteredDecoders.Decoders.Add(new PdfDecoder());
        }
    }
}