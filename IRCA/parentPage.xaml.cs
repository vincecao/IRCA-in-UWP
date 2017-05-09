using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Graphics.Imaging;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI;
using Windows.UI.Input;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

namespace IRCA
{

    public sealed partial class parentPage : Page
    {
        private string[,] objectData = new string[400,400];
        private List<tagBtn> tagList = new List<tagBtn>();
        private List<myCanvas> mycanvasList = new List<myCanvas>();
        private List<Items> itemsList = new List<Items>();
        private static int objectMax = 15;
        private String[] objectArr = new String[objectMax];
        private static WriteableBitmap image;

        private InkManager _inkKhaled = new Windows.UI.Input.Inking.InkManager();
        private int num;
        private uint _penID;
        private uint _touchID;
        private Point _previousContactPt;
        private Point currentContactPt;
        private double x1;
        private double y1;
        private double x2;
        private double y2;

        private Color _col = Color.FromArgb(0,0,0,0);
        

        private int _actualWidth;
        private int _actualHeight;

        private int _id; //for get current canvas index by tapping tags
        private recordPan recordPan = new recordPan("defalut");

        private suggestionItems suggestions = new suggestionItems();

        private ObservableCollection<string> TextList = new ObservableCollection<string>();

        public parentPage()
        {
            this.InitializeComponent();

            if (ApplicationData.Current.LocalSettings.Values["ChineseLanguage"] != null 
                && (bool)ApplicationData.Current.LocalSettings.Values["ChineseLanguage"] == true)
            {
                TextList.Clear();
                TextList.Add("导入");
                TextList.Add("图层");
                TextList.Add("清除");
                TextList.Add("保存");
                TextList.Add("请先导入或者拖入图像");
                TextList.Add("请选择一种方式导入图片：");
                TextList.Add("相机");
                TextList.Add("相册");
                TextList.Add("请填写标签名字：");
                TextList.Add("命名物体为...");
                TextList.Add("等待中");
                TextList.Add("请导入 .JPG 或者 .PNG 格式的图片文件");
                TextList.Add("拖到这里并放下！");
                TextList.Add("");
            }
            else
            {
                TextList.Clear();
                TextList.Add("Import");
                TextList.Add("Add");
                TextList.Add("Clear");
                TextList.Add("Save");
                TextList.Add("Please import or drag the image.");
                TextList.Add("Please choose one way to import: ");
                TextList.Add("Camera");
                TextList.Add("Gallery");
                TextList.Add("Please enter the objects name: ");
                TextList.Add("Name Objects");
                TextList.Add("Waiting");
                TextList.Add("The file is not in JPG or PNG image format.");
                TextList.Add("Drag and loose here!");
                TextList.Add("");
            }

            ImportLabelTextBlock.Text = TextList[0];
            AddLabelTextBlock.Text = TextList[1];
            ClearLabelTextBlock.Text = TextList[2];
            SaveLabelTextBlock.Text = TextList[3];
            DragTipsTextBlock.Text = TextList[4];
            ImportTipsTextBlock.Text = TextList[5];
            CameraLabelTextBlock.Text = TextList[6];
            GalleryLabelTextBlock.Text = TextList[7];
            EnterObjectsTipsTextBlock.Text = TextList[8];
            nameTextBox.PlaceholderText = TextList[9];
            stepTextBlock.Text = TextList[10];

            initObjectPosition(objectData);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            num = 0;

            if (ApplicationData.Current.LocalSettings.Values["ImageNumber"] == null)
            {
                ApplicationData.Current.LocalSettings.Values["ImageNumber"] = 0;
            }
        }

        private void cameraBtn_Click(object sender, RoutedEventArgs e)
        {
            doClear();
            doCameraPickImage();
            inkCanvasGrid.Visibility = Visibility.Visible;
            DragTipsGrid.Visibility = Visibility.Collapsed;
        }

        private void galleryBtn_Click(object sender, RoutedEventArgs e)
        {
            doClear();
            doGalleryPickImage();
            inkCanvasGrid.Visibility = Visibility.Visible;
            DragTipsGrid.Visibility = Visibility.Collapsed;
        }

        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var autoSuggestBox = (AutoSuggestBox)sender;
            var filtered = suggestions.getSuggestionItems().Where(p => p.StartsWith(autoSuggestBox.Text)).ToArray();
            autoSuggestBox.ItemsSource = filtered;
        }

        private async void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (nameTextBox.Text != "" && imageView.Source != null)
            {
                num++;

                if (args.ChosenSuggestion != null)
                {
                    objectArr[num - 1] = args.ChosenSuggestion.ToString();
                }
                else
                {
                    objectArr[num - 1] = sender.Text;
                }

                nameTextBox.Text = "";

                recordPan = new recordPan(objectArr[num - 1]);
                await recordPan.init();

                Record.Visibility = Visibility.Visible;
                suggestionBox_stackPanel.Visibility = Visibility.Collapsed;
            }

        }

        //record        
        private void Record_Click(object sender, RoutedEventArgs e)
        {
            if (recordPan.Recording)
            {
                recordPan.Stop();
                Record.Icon = new SymbolIcon(Symbol.Microphone);
                nameFlyout.Hide();
                createInkControl();

                Record.Visibility = Visibility.Collapsed;
                suggestionBox_stackPanel.Visibility = Visibility.Visible;
            }
            else
            {
                
                recordPan.Record();
                Record.Icon = new SymbolIcon(Symbol.Stop);
            }
        }

        //create canvas controls with pointerhandler
        private void createInkControl()
        {
            if (num <= objectMax)
            {
                tagBtn tagbtn = new tagBtn(num - 1, objectArr[num - 1]);
                tagList.Add(tagbtn);
                inkListPanel.Children.Insert(num, tagbtn);
                tagbtn.Click += Tag_Click;

                TextBlock txtName = new TextBlock()
                {
                    Text = objectArr[num - 1],
                    FontSize = 12
                };
                inkCanvasGrid.Children.Add(txtName);
                txtName.Visibility = Visibility.Collapsed;

                myCanvas canvas  = new myCanvas(num - 1,tagbtn._color);
                mycanvasList.Add(canvas);

                //form the same size of the image. in case: canvas can not change size
                _actualWidth = (int)imageView.ActualWidth;
                _actualHeight = (int)imageView.ActualHeight;

                canvas.Width = imageView.ActualWidth;
                canvas.Height = imageView.ActualHeight;

                inkCanvasGrid.Children.Add(canvas);

                Tag_Click(tagList[num - 1], new RoutedEventArgs());

                if (num >= objectMax){addObjectBtn.Visibility = Visibility.Collapsed;}
            }
        }

        #region PointerEvents
        private void MyCanvas_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            if (e.Pointer.PointerId == _penID || e.Pointer.PointerId == _touchID)
            {
                PointerPoint pt = e.GetCurrentPoint(GetMyCanvas());

                // Pass the pointer information to the InkManager. 
                _inkKhaled.ProcessPointerUp(pt);
            }

            _touchID = 0;
            _penID = 0;

            e.Handled = true;
        }

        private void MyCanvas_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (e.Pointer.PointerId == _penID || e.Pointer.PointerId == _touchID)
            {
                PointerPoint pt = e.GetCurrentPoint(GetMyCanvas());

                currentContactPt = pt.Position;
                x1 = _previousContactPt.X;
                y1 = _previousContactPt.Y;
                x2 = currentContactPt.X;
                y2 = currentContactPt.Y;

                coordinateLabel.Text = "x:" + (int)(((int)x2 / App._accu) / _actualWidth) + ", y:" + (int)(((int)y2 / App._accu) / _actualHeight);
                
                objectData[(int)(((int)x2 / App._accu) / _actualWidth), (int)(((int)y2 / App._accu) / _actualHeight)] = stepTextBlock.Text;
                
                if (Distance(x1, y1, x2, y2) > 2.0) 
                {
                    Line line = new Line()
                    {
                        X1 = x1,
                        Y1 = y1,
                        X2 = x2,
                        Y2 = y2,
                        StrokeThickness = 20.0,
                        Stroke = new SolidColorBrush(_col)
                    };

                    _previousContactPt = currentContactPt;
                    GetMyCanvas().Children.Add(line);
                    _inkKhaled.ProcessPointerUpdate(pt);
                }
            }
        }

        private void MyCanvas_PointerPressed(object sender, PointerRoutedEventArgs e)
        {

            PointerPoint pt = e.GetCurrentPoint(GetMyCanvas());
            _previousContactPt = pt.Position;

            PointerDeviceType pointerDevType = e.Pointer.PointerDeviceType;
            if (pointerDevType == PointerDeviceType.Pen || pointerDevType == PointerDeviceType.Touch ||
                    pointerDevType == PointerDeviceType.Mouse &&
                    pt.Properties.IsLeftButtonPressed)
            {
                // Pass the pointer information to the InkManager.
                _inkKhaled.ProcessPointerDown(pt);
                _penID = pt.PointerId;

                e.Handled = true;
            }
        }

        private myCanvas GetMyCanvas()
        {
            return mycanvasList[_id];
        }

        public double Distance(double x1, double y1, double x2, double y2)
        {         
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        #endregion

        //tap tag button
        private void Tag_Click(object sender, RoutedEventArgs e)
        {
            _id = tagList.IndexOf((tagBtn)sender);
            _col = mycanvasList[_id]._color;

            try
            {
                for (int i = 0; i < mycanvasList.Count();i++)
                {
                    mycanvasList[i].Visibility = Visibility.Collapsed;
                }

                //inkCanvasGrid.Children[index * 2 - 2].Visibility = Visibility.Visible; //show the name
                stepTextBlock.Text = tagList[_id].Content.ToString();

                mycanvasList[_id].PointerPressed += new PointerEventHandler(MyCanvas_PointerPressed);
                mycanvasList[_id].PointerMoved += new PointerEventHandler(MyCanvas_PointerMoved);
                mycanvasList[_id].PointerReleased += new PointerEventHandler(MyCanvas_PointerReleased);
                mycanvasList[_id].PointerExited += new PointerEventHandler(MyCanvas_PointerReleased);
                
                mycanvasList[_id].Visibility = Visibility.Visible; //show the Canvas
            }
            catch
            {
                throw new NotImplementedException();
            }          
        }        

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            doClear();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            var imageId = (int)ApplicationData.Current.LocalSettings.Values["ImageNumber"];
            doCreateItems(image, imageId, objectArr, objectData);           
        }

        private void doCreateItems(WriteableBitmap image, int imageId, String[] objectArr, string[,] objectData)
        {
            try
            {
                App.imageArr.Add(imageId + "_Picture");

                Items items = new Items(imageId, objectArr, objectData);
                itemsList.Add(items);

                doSave(image, items, imageId);
                doClear();

                ApplicationData.Current.LocalSettings.Values["ImageNumber"] = imageId + 1;
            }
            catch
            {

            }
        }

        private async void doSave(WriteableBitmap image, Items items, int imageId)
        {
            //save as json
            string json = JsonConvert.SerializeObject(items);
            await items.SaveJsonToFileAsync(imageId, json);

            //output image file
            await items.SaveBitmapToFileAsync(image, imageId + "_Picture");

            //output as txt file
            //await items.SaveTxtDataToFileAsync(imageId + "_Position", objectData); 
        }

        private void doClear()
        {
            num = 0;
            tagList.Clear();
            mycanvasList.Clear();
            coordinateLabel.Text = "";
            stepTextBlock.Text = TextList[10];

            SolidColorBrush mySolidColorBrush = new SolidColorBrush()
            {
                Color = Colors.White
            };
            DragTipsRect.Fill = mySolidColorBrush;
            
            DragTipsTextBlock.Text = TextList[4];
            DragTipsGrid.Visibility = Visibility.Visible;

            imageView.Source = null;

            int inkNum = (int)inkListPanel.Children.LongCount() - 1;

            for (int i = 0; i < inkNum * 2; i++)
            {
                inkCanvasGrid.Children.RemoveAt(0); //remove all layers
            }

            for (int i = 0; i < inkNum; i++)
            {
                inkListPanel.Children.RemoveAt(1); //remove all tags
            }
            addObjectBtn.Visibility = Visibility.Visible;

            initObjectPosition(objectData);
        }

        private void initObjectPosition(string[,] objectData)
        {
            for (int i = 0; i < objectData.GetLength(0); i++)
            {
                for (int j = 0; j < objectData.GetLength(1); j++)
                {
                    objectData[i, j] = "null";
                }
            }
        }

        private async void imageDrawingGrid_Drop(object sender, DragEventArgs e)
        {
            if (e.DataView.Contains(StandardDataFormats.StorageItems))
            {
                var items = await e.DataView.GetStorageItemsAsync();

                if (items.Any())
                {
                    var storageFile = items[0] as StorageFile;
                    var contentType = storageFile.ContentType;

                    StorageFolder folder =
                await ApplicationData.Current.LocalFolder.CreateFolderAsync("Cache", CreationCollisionOption.OpenIfExists);                    

                    if (contentType == "image/png" || contentType == "image/jpeg")
                    {
                        doClear();

                        StorageFile newFile = await storageFile.CopyAsync(folder, storageFile.Name, NameCollisionOption.GenerateUniqueName);

                        await ProcessFile(newFile);
                        inkCanvasGrid.Visibility = Visibility.Visible;
                        DragTipsGrid.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                        mySolidColorBrush.Color = Colors.White;
                        DragTipsRect.Fill = mySolidColorBrush;
                        DragTipsTextBlock.Text = TextList[11];
                    }
                }
            }
        }

        private void imageDrawingGrid_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;

            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Colors.Red;
            DragTipsRect.Fill = mySolidColorBrush;
            DragTipsTextBlock.Text = TextList[12];
        }

        private void ImageDrawingGrid_DragLeave(object sender, DragEventArgs e)
        {
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Colors.White;
            DragTipsRect.Fill = mySolidColorBrush;
            DragTipsTextBlock.Text = TextList[4];
        }

        private async void doCameraPickImage()
        {
            var ccu = new CameraCaptureUI();
            var file = await ccu.CaptureFileAsync(CameraCaptureUIMode.Photo);

            if (file != null)
            {
                await ProcessFile(file);
            }
            else
            {

            }

        }

        private async void doGalleryPickImage()
        {
            var openPicker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.Thumbnail,
                SuggestedStartLocation = PickerLocationId.PicturesLibrary
            };
            openPicker.FileTypeFilter.Add(".jpg");
            var file = await openPicker.PickSingleFileAsync();

            if (file != null)
            {
                await ProcessFile(file);
            }
        }

        private async Task ProcessFile(StorageFile file)
        {
            if (file != null)
            {
                var stream = await file.OpenAsync(FileAccessMode.Read);
                //using writeableBitmap
                BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);
                image = new WriteableBitmap((int)decoder.PixelWidth, (int)decoder.PixelHeight);
                //using bitmap
                //var image = new BitmapImage();
                image.SetSource(stream);
                imageView.Source = image;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
