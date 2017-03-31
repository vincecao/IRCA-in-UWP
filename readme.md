## IRCA in UWP
A small project in UWP
![](https://github.com/vincecao/IRCA-in-UWP/blob/master/screenshots/2.gif?raw=true)


---
References and Notes:
## audio capture
[Windows 10 Universal Windows Platform – Audio Recorder](https://comentsys.wordpress.com/2015/05/21/windows-10-universal-windows-platform-audio-recorder/)

### audio playBack
[UWP How to play sound from wav file/resource?](https://social.msdn.microsoft.com/Forums/windowsapps/en-US/ddb1b7f1-e988-40c7-8e1e-eaf6d8573ec2/uwp-how-to-play-sound-from-wav-fileresource?forum=wpdevelop)

## JOSN/json.NET
### Saving data into JSON
[Introducing JSON](http://www.json.org)
[Json.NET](http://www.newtonsoft.com/json)
[Using JSON.NET to write Json file in UWP](http://stackoverflow.com/questions/41325362/using-json-net-to-write-json-file-in-uwp)
```cs
Items items = new Items(imageId, objectArr, objectData, App.image);

string json = JsonConvert.SerializeObject(items);
var file = await ApplicationData.Current.LocalFolder.CreateFileAsync(imageId + "myconfig.json");

```

### JsonConvert DeserializeObject using Josn.Net
[Deserializing JSON object into a C# list](http://stackoverflow.com/questions/16019729/deserializing-json-object-into-a-c-sharp-list)
```cs
public void TestMethod1()
    {
        var items = new List<Item>
                        {
                            new Item { Att1 = "ABC", Att2 = "123" }, 
                            new Item { Att1 = "EFG", Att2 = "456" }, 
                            new Item { Att1 = "HIJ", Att2 = "789" }
                        };
        var root = new Root() { Items = items };
        var itemsSerialized = JsonConvert.SerializeObject(items);
        var rootSerialized = JsonConvert.SerializeObject(root);

        //This works
        var deserializedItemsFromItems = JsonConvert.DeserializeObject<List<Item>>(itemsSerialized); 

        //This works
        var deserializedRootFromRoot = JsonConvert.DeserializeObject<Root>(rootSerialized); 

        //This will fail.  YOu serialized it as root and tried to deserialize as List<Item>
        var deserializedItemsFromRoot = JsonConvert.DeserializeObject<List<Item>>(rootSerialized);

        //This will fail also for the same reason 
        var deserializedRootFromItems = JsonConvert.DeserializeObject<Root>(itemsSerialized);
    }

class Root
{
    public IEnumerable<Item> Items { get; set; } 
}

class Item
{
    public string Att1 { get; set; }
    public string Att2 { get; set; }
}
```

### 使用JSON代码片段改写/Using JSON to store and then read from LocalFolder 
```cs
public class Product
{
    public string Name { get; set; }
    //public string Expiry { get; set; }
    public string[] Sizes { get; set; }
    public int Int { get; set; }
    public string[,] MulArr { get; set; }
}

public sealed partial class MainPage : Page
{

    private static string JsonFile = "myconfig.json";    //your file name
    public Product NEW;

    public MainPage()
    {
        this.InitializeComponent();
        
    }

    protected async override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        Product product = new Product()
        {
            Name = "Apple",
            //product.Expiry = new DateTime(2008, 12, 28);
            Sizes = new string[] { "Small" },
            Int = 40,
            MulArr = new string[5, 4]
        };
        product.MulArr[0, 1] = "vg";
        product.MulArr[1, 1] = "ni";
        product.MulArr[0, 2] = "ge";

        saveJson(product);

        NEW = await LoadFromJsonAsync();
	 }

    public async void saveJson(Product product)
    {
        // serialize JSON to a string
        string json = JsonConvert.SerializeObject(product);

        // write string to a file
        var file = await ApplicationData.Current.LocalFolder.CreateFileAsync("myconfig.json");
        await FileIO.WriteTextAsync(file, json);
    }
    

    public async Task<Product> LoadFromJsonAsync()
    {
        string JsonString = await DeserializeFileAsync(JsonFile);
        if (JsonString != null)
            //return (List<Product>)JsonConvert.DeserializeObject(JsonString, typeof(List<Product>));
            return JsonConvert.DeserializeObject<Product>(JsonString);
        return null;
    }

    private static async Task<string> DeserializeFileAsync(string fileName)
    {
        try
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
            return await FileIO.ReadTextAsync(localFile);
        }
        catch (FileNotFoundException)
        {
            return null;
        }
    }
}
```

## Local setting store
[Roaming and Local Settings in UWP](http://pmichaels.net/2016/05/06/roaming-and-local-settings-in-uwp/)
[读书笔记4：uwp应用设置储存](http://www.cnblogs.com/by-admini22/p/5460176.html)
[如何将自定义对象集合保存至本地存储区](https://code.msdn.microsoft.com/windowsapps/CSWinStoreAppSaveCollection-bed5d6e6)

[Printing 2D array in matrix format](http://stackoverflow.com/questions/12826760/printing-2d-array-in-matrix-format)

[how to read a text file in windows universal app](http://stackoverflow.com/questions/34583303/how-to-read-a-text-file-in-windows-universal-app)
[Getting all files in UWP app folder](http://stackoverflow.com/questions/33742696/getting-all-files-in-uwp-app-folder)
[Store and retrieve settings and other app data](https://docs.microsoft.com/en-us/windows/uwp/app-settings/store-and-retrieve-app-data)
**中文版**[快速入门：本地应用数据 (XAML)](https://msdn.microsoft.com/zh-cn/library/windows/apps/xaml/hh700361)

 - UInt8, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double
 - Boolean
 - Char16, String
 - DateTime, TimeSpan
 - GUID, Point, Size, Rect
```cs
string mySetting = Windows.Storage.ApplicationData.Current.LocalSettings.Values["MySetting"]?.ToString();
Windows.Storage.ApplicationData.Current.LocalSettings.Values["MySetting"] = "1";`
```
## Save writeableBitmapImage
[Storing a BitmapImage in LocalFolder - UWP](http://stackoverflow.com/questions/34362838/storing-a-bitmapimage-in-localfolder-uwp)
```cs
public static async Task SaveBitmapToFileAsync(WriteableBitmap image, string imageId)
{
	StorageFolder pictureFolder = await ApplicationData.Current.LocalFolder.CreateFolderAsync("ProfilePictures", CreationCollisionOption.OpenIfExists);
	var file = await pictureFolder.CreateFileAsync(imageId + ".jpg", CreationCollisionOption.ReplaceExisting);

	using (var stream = await file.OpenStreamForWriteAsync())
	{
		BitmapEncoder encoder = await BitmapEncoder.CreateAsync(BitmapEncoder.JpegEncoderId, stream.AsRandomAccessStream());
		var pixelStream = image.PixelBuffer.AsStream();
		byte[] pixels = new byte[image.PixelBuffer.Length];

		await pixelStream.ReadAsync(pixels, 0, pixels.Length);

		encoder.SetPixelData(BitmapPixelFormat.Bgra8, BitmapAlphaMode.Ignore, (uint)image.PixelWidth, (uint)image.PixelHeight, 96, 96, pixels);

		await encoder.FlushAsync();
	}
}
```
serveral other reference:
[UWP: Save a BitmapImage as File](https://codedocu.com/Details?d=1592&a=9&f=181&l=0&v=d&t=UWP:-Save-a-BitmapImage--as-File)
[c# UWP Save StorageFile Without Dialog](http://stackoverflow.com/questions/35911448/c-sharp-uwp-save-storagefile-without-dialog)
[win10 uwp 读取保存WriteableBitmap 、BitmapImage](http://codecloud.net/135976.html)
[Storing a BitmapImage in LocalFolder - UWP](http://stackoverflow.com/questions/34362838/storing-a-bitmapimage-in-localfolder-uwp)

## count all file in local data
```cs
try
{
	StorageFolder save = await ApplicationData.Current.LocalFolder.GetFolderAsync("Save");
	var files = await save.GetFilesAsync();
	imageId = files.Count;                
}
catch
{
}
```

## output String into TXT
[Create, write, and read a file](https://docs.microsoft.com/en-us/windows/uwp/files/quickstart-reading-and-writing-files)
```cs
Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
Windows.Storage.StorageFile sampleFile = await storageFolder.CreateFileAsync(@"\\\Assets\sample.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);
await Windows.Storage.FileIO.WriteTextAsync(sampleFile, "abc");
```
## import photos
[Choosing an image from gallery or camera a bit better in Universal Windows apps](https://blog.kulman.sk/choosing-an-image-from-gallery-or-camera-in-uwp)
### Capture photo from camera
```cs
protected override void OnNavigatedTo(NavigationEventArgs e)
{
    base.OnNavigatedTo(e);
    doPickImage();
}

    private async void doPickImage()
{
    var ccu = new CameraCaptureUI();
    var file = await ccu.CaptureFileAsync(CameraCaptureUIMode.Photo);

    if (file != null)
    {
        await ProcessFile(file);
    }else{
        throw new NotImplementedException();
    }

}

private async Task ProcessFile(StorageFile file)
{
    if (file != null){
        var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
        //using writeableBitmap
        BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);
        App.image = new WriteableBitmap((int)decoder.PixelWidth, (int)decoder.PixelHeight);
        //using bitmap
        //var image = new BitmapImage();
        App.image.SetSource(stream);
        imageView.Source = App.image;
    }else{
        throw new NotImplementedException();
    }
}
```

### Import photo from gallery
```cs
protected override void OnNavigatedTo(NavigationEventArgs e)
{
    base.OnNavigatedTo(e);
    doPickImage();
}

    private async void doPickImage()
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
    else
    {
        throw new NotImplementedException();
    }
}

private async Task ProcessFile(StorageFile file)
{
    if (file != null){
        var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
        //using writeableBitmap
        BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);
        App.image = new WriteableBitmap((int)decoder.PixelWidth, (int)decoder.PixelHeight);
        //using bitmap
        //var image = new BitmapImage();
        App.image.SetSource(stream);
        imageView.Source = App.image;
    }else{
        throw new NotImplementedException();
    }
}
```

## Adaptive gird view
need to NuGet `Microsoft.Toolkit.Uwp.UI.Controls`
```xaml
<Page.Resources>
    <DataTemplate x:Key="MyPhotos">
        <Grid
            Background="White"
            BorderBrush="Black"
            BorderThickness="1">
            <Image
                Source="{Binding ImageUrl}"
                Stretch="UniformToFill"
                HorizontalAlignment="Center"
                VerticalAlignment="Center"/>
        </Grid>
    </DataTemplate>
</Page.Resources>
<Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
    <UWPTookit:AdaptiveGridView x:Name="myAdaptiveGridView"
                               ItemHeight="300"
                               DesiredWidth="300"
                               SelectionMode="Single"
                               IsItemClickEnabled="True"
                               ItemTemplate="{StaticResource MyPhotos}"
                               ItemClick="myAdaptiveGridView_ItemClick"/>
</Grid>
```


```cs
public sealed partial class childPage : Page
{
    public childPage()
    {
        this.InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);

        List<MyImage> data = new List<MyImage>
        {
            new MyImage()
            {
                ImageUrl = "ms-appx:///Assets/sample/1.jpg"
            },
            new MyImage()
            {
                ImageUrl = "ms-appx:///Assets/sample/2.jpg"
            },
            new MyImage()
            {
                ImageUrl = "ms-appx:///Assets/sample/3.jpg"
            },
            new MyImage()
            {
                ImageUrl = "ms-appx:///Assets/sample/4.jpg"
            }
        };
        myAdaptiveGridView.ItemsSource = data;
    }

    class MyImage
    {
        public string ImageUrl { get; set; }
    }
    
    private void myAdaptiveGridView_ItemClick(object sender, ItemClickEventArgs e)
   {
      //int _id = data.IndexOf((MyImage)sender);
      //int _id = 2;
      //App.imageSource = "ms-appdata:///local/Save/" + App.imageArr[_id] + ".jpg";
      var item = e.ClickedItem as MyImage;
      var index = data.IndexOf(item);
      App.imageSource = "ms-appdata:///local/Save/" + App.imageArr[index] + ".jpg";
      //App.imageSource = ((MyImage)sender).ImageUrl;
      this.Frame.Navigate(typeof(fullScreenImage));
   }
}
```

## Using inkCanvas
[Digital Ink - Ink Interaction in Windows 10](https://msdn.microsoft.com/en-us/magazine/mt590975.aspx)
[Use inking and speech to support natural input (10 by 10)](https://blogs.windows.com/buildingapps/2015/09/08/going-beyond-keyboard-mouse-and-touch-with-natural-input-10-by-10/#C5dey9hbXhuGHr4R.97)
[How to render InkCanvas to an image in UWP Windows 10 application?](http://stackoverflow.com/questions/32153880/how-to-render-inkcanvas-to-an-image-in-uwp-windows-10-application)
[Save InkCanvas strokes as png /jpg image in Windows 10](http://stackoverflow.com/questions/33523831/save-inkcanvas-strokes-as-png-jpg-image-in-windows-10)
```cs
Color col = radomColor();
SolidColorBrush colBrush = new SolidColorBrush(col);

InkDrawingAttributes inkDrawingAttributes = new InkDrawingAttributes();
inkDrawingAttributes.Color = col;
inkDrawingAttributes.IgnorePressure = false;
inkDrawingAttributes.FitToCurve = true;
inkDrawingAttributes.Size = new Size(20, 20);
MyCanvas.InkPresenter.UpdateDefaultDrawingAttributes(inkDrawingAttributes);
MyCanvas.InkPresenter.InputDeviceTypes = Windows.UI.Core.CoreInputDeviceTypes.Mouse | Windows.UI.Core.CoreInputDeviceTypes.Pen | Windows.UI.Core.CoreInputDeviceTypes.Touch;
```

## Random Color
`Color.Fromarg()` the first item is alpha 1~254
```cs
private Color radomColor()
{
    Random rnd = new Random();
    Byte[] b = new Byte[4];
    rnd.NextBytes(b);
    Color color = Color.FromArgb(b[0], b[1], b[2], b[3]);
    return color;
}
```

## Drawing on the Canvas
Canvas need to set the height or width in advence
```xaml
<Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
    <StackPanel>
        <StackPanel Orientation="Horizontal" Background="AliceBlue">
            <TextBlock Name="label1" />
            <TextBlock Name="label2" Margin="15,0,0,0" />
        </StackPanel>
        <Canvas Name="MyCanvas" Margin="0,0,0,0" Background="White" Height="300" HorizontalAlignment="Stretch" VerticalAlignment="Stretch"/>
        <!--<InkCanvas Name="MyCanvas" Margin="0,50,0,0" Height="300" HorizontalAlignment="Stretch" VerticalAlignment="Stretch"/>-->
    </StackPanel>
</Grid>
```

```cs
public sealed partial class MainPage : Page
{
    InkManager _inkKhaled = new Windows.UI.Input.Inking.InkManager();
    private uint _penID;
    private uint _touchID;
    private Point _previousContactPt;
    private Point currentContactPt;
    private double x1;
    private double y1;
    private double x2;
    private double y2;


    public MainPage()
    {
        this.InitializeComponent();

        //MyCanvas.AddHandler(InkCanvas.PointerMovedEvent, new PointerEventHandler(InkCanvas_PointerMoving), true);
        //MyCanvas.PointerMoved += new PointerEventHandler(InkCanvas_PointerMoving);
        MyCanvas.PointerPressed += new PointerEventHandler(MyCanvas_PointerPressed);
        MyCanvas.PointerMoved += new PointerEventHandler(MyCanvas_PointerMoved);
        MyCanvas.PointerReleased += new PointerEventHandler(MyCanvas_PointerReleased);
        MyCanvas.PointerExited += new PointerEventHandler(MyCanvas_PointerReleased);

    }

    private void InkCanvas_PointerMoving(object sender, PointerRoutedEventArgs e)
    {
        try
        {
            label1.Text = "X: " + e.GetCurrentPoint(this).Position.X;
            label2.Text = "Y: " + e.GetCurrentPoint(this).Position.Y;
        }
        catch
        {

        }
    }

    #region PointerEvents
    private void MyCanvas_PointerReleased(object sender, PointerRoutedEventArgs e)
    {
        if (e.Pointer.PointerId == _penID)
        {
            Windows.UI.Input.PointerPoint pt = e.GetCurrentPoint(MyCanvas);

            // Pass the pointer information to the InkManager. 
            _inkKhaled.ProcessPointerUp(pt);
        }

        else if (e.Pointer.PointerId == _touchID)
        {
            // Process touch input
        }

        _touchID = 0;
        _penID = 0;

        // Call an application-defined function to render the ink strokes.


        e.Handled = true;
    }

    private void MyCanvas_PointerMoved(object sender, PointerRoutedEventArgs e)
    {
        if (e.Pointer.PointerId == _penID)
        {
            PointerPoint pt = e.GetCurrentPoint(MyCanvas);

            currentContactPt = pt.Position;
            x1 = _previousContactPt.X;
            y1 = _previousContactPt.Y;
            x2 = currentContactPt.X;
            y2 = currentContactPt.Y;

            label1.Text = "x:" + x1 + ", y:" + y1;
            label2.Text = "x:" + x2 + ", y:" + y2;

            if (Distance(x1, y1, x2, y2) > 2.0) // We need to developp this method now 
            {
                Line line = new Line()
                {
                    X1 = x1,
                    Y1 = y1,
                    X2 = x2,
                    Y2 = y2,
                    StrokeThickness = 4.0,
                    Stroke = new SolidColorBrush(Colors.Green)
                };

                _previousContactPt = currentContactPt;

                // Draw the line on the canvas by adding the Line object as
                // a child of the Canvas object.
                MyCanvas.Children.Add(line);

                // Pass the pointer information to the InkManager.
                _inkKhaled.ProcessPointerUpdate(pt);
            }
        }

        else if (e.Pointer.PointerId == _touchID)
        {
            // Process touch input
        }

    }

    private double Distance(double x1, double y1, double x2, double y2)
    {
        double d = 0;
        d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        return d;
    }

    private void MyCanvas_PointerPressed(object sender, PointerRoutedEventArgs e)
    {
        // Get information about the pointer location.
        PointerPoint pt = e.GetCurrentPoint(MyCanvas);
        _previousContactPt = pt.Position;

        // Accept input only from a pen or mouse with the left button pressed. 
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

        //else if (pointerDevType == PointerDeviceType.Touch)
        //{
        //    // Process touch input
        //}
    }

    #endregion

    /// <summary>
    /// Invoked when this page is about to be displayed in a Frame.
    /// </summary>
    /// <param name="e">Event data that describes how this page was reached.  The Parameter
    /// property is typically used to configure the page.</param>
    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
    }

    private Color radomColor()
    {
        Random rnd = new Random();
        Byte[] b = new Byte[4];
        rnd.NextBytes(b);
        Color color = Color.FromArgb(b[0], b[1], b[2], b[3]);
        return color;
    }
}
```

## InputTextDialogAsync

```cs
private async void InputTextDialogAsync(string title)
{
    TextBox inputTextBox = new TextBox();
    inputTextBox.AcceptsReturn = false;
    inputTextBox.Height = 32;
    ContentDialog dialog = new ContentDialog();
    dialog.Content = inputTextBox;
    dialog.Title = title;
    dialog.IsSecondaryButtonEnabled = true;
    dialog.PrimaryButtonText = "Enter";
    dialog.SecondaryButtonText = "Cancel";
    if (await dialog.ShowAsync() == ContentDialogResult.Primary && inputTextBox.Text == App.passWord)
    {
        headerTitle.Text = "Parent Configuration";
        myFrame.Navigate(typeof(parentPage));
    }
    else
    {
        ChildListBoxItem.IsSelected = true;
        headerTitle.Text = "Child";
        myFrame.Navigate(typeof(childPage));
    }
}
```

## AutoSuggestBox - 
[UWP开发随笔——UWP新控件！AutoSuggestBox！](http://www.tuicool.com/articles/7NfMb2)
```cs
private void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
		{
			if (args.ChosenSuggestion != null)
				textBlock.Text = args.ChosenSuggestion.ToString();
			else
				textBlock.Text = sender.Text;
		}
```
