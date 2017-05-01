using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Input;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

namespace IRCA
{

    public sealed partial class parentPage : Page
    {
        //private Color[] colorArr = new Color[10];
        private string[,] objectData = new string[400,400];
        private List<tagBtn> tagList = new List<tagBtn>();
        private List<myCanvas> mycanvasList = new List<myCanvas>();
        private List<Items> itemsList = new List<Items>();
        private String[] objectArr = new String[10];

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
        private int objectMax = 15;
        //private int imageId  = 0;

        private int _id; //for get current canvas index by tapping tags
        private recordPan recordPan = new recordPan("defalut");

        suggestionItems suggestions = new suggestionItems();

        public parentPage()
        {
            this.InitializeComponent();
            initObjectPosition();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            imageFrame.Navigate(typeof(imageGuidePage));
            num = 0;

            if (ApplicationData.Current.LocalSettings.Values["ImageNumber"] == null)
            {
                ApplicationData.Current.LocalSettings.Values["ImageNumber"] = 0;
            }
        }
        private void cameraBtn_Click(object sender, RoutedEventArgs e)
        {
            doClear();
            imageFrame.Navigate(typeof(cameraCapture));
            inkCanvasGrid.Visibility = Visibility.Visible;
        }

        private void galleryBtn_Click(object sender, RoutedEventArgs e)
        {
            doClear();
            imageFrame.Navigate(typeof(galleryImport));
            inkCanvasGrid.Visibility = Visibility.Visible;
        }

        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var autoSuggestBox = (AutoSuggestBox)sender;
            var filtered = suggestions.getSuggestionItems().Where(p => p.StartsWith(autoSuggestBox.Text)).ToArray();
            autoSuggestBox.ItemsSource = filtered;
        }

        private async void AutoSuggestBox_QuerySubmittedAsync(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (nameTextBox.Text != "")
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
        private void Record_ClickAsync(object sender, RoutedEventArgs e)
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

                TextBlock txtName = new TextBlock();
                txtName.Text = objectArr[num - 1];
                txtName.FontSize = 12;
                inkCanvasGrid.Children.Add(txtName);
                txtName.Visibility = Visibility.Collapsed;

                myCanvas canvas  = new myCanvas(num - 1,tagbtn._color);
                mycanvasList.Add(canvas);
                //canvas.Height = imageFrame.Height;
                canvas.Width = imageFrame.ActualWidth;
                inkCanvasGrid.Children.Add(canvas);

                Tag_Click(tagList[num - 1], new RoutedEventArgs());

                if (num == objectMax){addObjectBtn.Visibility = Visibility.Collapsed;}
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

                coordinateLabel.Text = "x:" + (int)(x2 / App._accu) + ", y:" + (int)(y2 / App._accu);

                objectData[(int)(x2 / App._accu), (int)(y2 / App._accu)] = stepTextBlock.Text;

                if (Distance(x1, y1, x2, y2) > 2.0) // We need to developp this method now 
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

        private double Distance(double x1, double y1, double x2, double y2)
        {
            double d = 0;
            d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return d;
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
            doCreateItems();           
        }

        private void doCreateItems()
        {
            try
            {
                var imageId = (int)ApplicationData.Current.LocalSettings.Values["ImageNumber"];

                App.imageArr.Add(imageId + "_Picture");

                Items items = new Items(imageId, objectArr, objectData);
                itemsList.Add(items);

                doSave(items, imageId);
                doClear();

                ApplicationData.Current.LocalSettings.Values["ImageNumber"] = imageId + 1;
            }
            catch
            {

            }
        }

        private async void doSave(Items items, int imageId)
        {
            //save as json
            string json = JsonConvert.SerializeObject(items);
            await items.SaveJsonToFileAsync(imageId, json);

            //output image file
            await items.SaveBitmapToFileAsync(App.image, imageId + "_Picture");

            //output as txt file
            //await items.SaveTxtDataToFileAsync(imageId + "", objectData); 
        }

        private void doClear()
        {
            num = 0;
            tagList.Clear();
            mycanvasList.Clear();
            coordinateLabel.Text = "";
            stepTextBlock.Text = "Waiting";
            imageFrame.Navigate(typeof(imageGuidePage));
            int inkNum = (int)inkListPanel.Children.LongCount() - 2;

            for (int i = 0; i < inkNum * 2; i++)
            {
                inkCanvasGrid.Children.RemoveAt(0); //remove all layers
            }

            for (int i = 0; i < inkNum; i++)
            {
                inkListPanel.Children.RemoveAt(1); //remove all tags
            }
            addObjectBtn.Visibility = Visibility.Visible;

            initObjectPosition();
        }

        private void initObjectPosition()
        {
            for (int i = 0; i < objectData.GetLength(0); i++)
            {
                for (int j = 0; j < objectData.GetLength(1); j++)
                {
                    objectData[i, j] = "null";
                }
            }
        }

        
    }
}
