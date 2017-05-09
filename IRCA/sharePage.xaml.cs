using System.Collections.ObjectModel;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace IRCA
{
    public sealed partial class sharePage : Page
    {
        private ObservableCollection<string> TextList = new ObservableCollection<string>();

        public sharePage()
        {
            this.InitializeComponent();

            if (ApplicationData.Current.LocalSettings.Values["ChineseLanguage"] != null && (bool)ApplicationData.Current.LocalSettings.Values["ChineseLanguage"] == true)
            {
                TextList.Clear();
                TextList.Add("请拷贝路径地址并且在文件管理器中打开。移动Save文件夹到新设备，所有的数据将会同步");
                TextList.Add("拷贝");
            }
            else
            {
                TextList.Clear();
                TextList.Add("Please copy the path and open in folder. Move the entire Save Folder. All the files in this device is well design to share with others.");
                TextList.Add("Copy");
            }

            InstructionTextBlock.Text = TextList[0];
            CopyBtn.Content = TextList[1];

            StorageFolder folder = ApplicationData.Current.LocalFolder;

            FolderPath.Text = folder.Path;
            
        }

        private void FolderPath_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            FolderPath.SelectAll();
        }

        private void Button_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(FolderPath.Text);
            //dataPackage.RequestedOperation = DataPackageOperation.Copy;
            Clipboard.SetContent(dataPackage);
        }

        private void FolderPath_GotFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            FolderPath.SelectAll();
        }
    }
}
