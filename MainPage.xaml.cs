using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DragDropWobblyRepro
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Border_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = Windows.ApplicationModel.DataTransfer.DataPackageOperation.Link;
        }
    }
}
