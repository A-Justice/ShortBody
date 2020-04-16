using System.Windows;
using System.Windows.Documents;

namespace ShortBody.Windows
{
    /// <summary>
    /// Interaction logic for PrintPreviewWindow.xaml
    /// </summary>
    public partial class PrintPreviewWindow : Window
    {
        public PrintPreviewWindow(IDocumentPaginatorSource document)
        {
            InitializeComponent();
            PreviewDocument.Document = document;
        }
    }
}
