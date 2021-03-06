﻿using System;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;

namespace IRCA
{
    class Items
    {
        public int _id;

        public string[] objectArr;
        public string[,] objectData;

        public Items(int _id, string[] objectArr, string[,] objectData)
        {
            this._id = _id;

            this.objectArr = objectArr;
            this.objectData = objectData; //position
            
        }

        //save the image file
        public async Task SaveBitmapToFileAsync(WriteableBitmap image, string imageId)
        {
            StorageFolder pictureFolder =
                await ApplicationData.Current.LocalFolder.CreateFolderAsync("Save", CreationCollisionOption.OpenIfExists);

            pictureFolder = 
                await pictureFolder.CreateFolderAsync("Image", CreationCollisionOption.OpenIfExists);

            var file =
                await pictureFolder.CreateFileAsync(imageId + ".jpg", CreationCollisionOption.ReplaceExisting);

            using (var stream = await file.OpenStreamForWriteAsync())
            {
                BitmapEncoder encoder = 
                    await BitmapEncoder.CreateAsync(BitmapEncoder.JpegEncoderId, stream.AsRandomAccessStream());
                var pixelStream = image.PixelBuffer.AsStream();
                byte[] pixels = new byte[image.PixelBuffer.Length];
                await pixelStream.ReadAsync(pixels, 0, pixels.Length);
                encoder.SetPixelData(BitmapPixelFormat.Bgra8, BitmapAlphaMode.Ignore, (uint)image.PixelWidth, (uint)image.PixelHeight, 96, 96, pixels);

                await encoder.FlushAsync();
            }
        }

        //save to txt file, not used
        public async Task SaveTxtDataToFileAsync(string imageIdNmae, string[,] objectData)
        {
            try
            {
                StringBuilder abc = new StringBuilder();
                StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
                StorageFile sampleFile = 
                    await storageFolder.CreateFileAsync(@"\\\" + imageIdNmae + "PositionData.txt", CreationCollisionOption.ReplaceExisting);

                int rowLength = objectData.GetLength(0);
                int colLength = objectData.GetLength(1);

                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        abc.Append(objectData[i, j] + "\t");
                    }
                    abc.Append("\n");
                }
                await FileIO.WriteTextAsync(sampleFile, abc.ToString());
            }
            catch
            {

            }
        }

        private void setSetting(string imageIdNmae, string[,] objectData)
        {
            var localStorage = ApplicationData.Current.LocalSettings;
            localStorage.Values[imageIdNmae + "PositionData"] = objectData;
        }

        public async Task SaveJsonToFileAsync(string FileName, StringBuilder json)
        {
            StorageFolder storageFolder = await ApplicationData.Current.LocalFolder.CreateFolderAsync("Save", CreationCollisionOption.OpenIfExists);
            if(FileName == "imagenumberconfig")
            {

            }
            else
            {
                storageFolder = await storageFolder.CreateFolderAsync("Json", CreationCollisionOption.OpenIfExists);
            }
            
            //var file = await storageFolder.CreateFileAsync("myconfig_" + imageId + ".json", CreationCollisionOption.ReplaceExisting);
            var file = await storageFolder.CreateFileAsync(FileName + ".json", CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, json.ToString()); //out put as json
        }
    }
}
