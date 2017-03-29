using System;
using System.Threading.Tasks;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.Streams;

namespace IRCA
{
    class recordPan
    {
        public int _id;
        public string name;
        public string audioFilename;
        public static bool Recording;

        private string filename;
        private MediaCapture capture;
        private InMemoryRandomAccessStream buffer;

        public recordPan(string name)
        {
            audioFilename = name + ".m4a";
        }

        public async Task<bool> init()
        {
            if (buffer != null)
            {
                buffer.Dispose();
            }
            buffer = new InMemoryRandomAccessStream();
            if (capture != null)
            {
                capture.Dispose();
            }
            try
            {
                MediaCaptureInitializationSettings settings = new MediaCaptureInitializationSettings
                {
                    StreamingCaptureMode = StreamingCaptureMode.Audio
                };
                capture = new MediaCapture();
                await capture.InitializeAsync(settings);
                capture.RecordLimitationExceeded += (MediaCapture sender) =>
                {
                    Stop();
                    throw new Exception("Exceeded Record Limitation");
                };
                capture.Failed += (MediaCapture sender, MediaCaptureFailedEventArgs errorEventArgs) =>
                {
                    Recording = false;
                    throw new Exception(string.Format("Code: {0}. {1}", errorEventArgs.Code, errorEventArgs.Message));
                };
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && ex.InnerException.GetType() == typeof(UnauthorizedAccessException))
                {
                    throw ex.InnerException;
                }
                throw;
            }
            return true;
        }

        public async void Record()
        {
            await init();
            await capture.StartRecordToStreamAsync(MediaEncodingProfile.CreateM4a(AudioEncodingQuality.Auto), buffer);
            if (Recording) throw new InvalidOperationException("cannot excute two records at the same time");
            Recording = true;
        }

        //save m4a audio
        public async void Stop()
        {
            await capture.StopRecordAsync();
            Recording = false;


            IRandomAccessStream audio = buffer.CloneStream();
            if (audio == null) throw new ArgumentNullException("buffer");
            StorageFolder storageFolder = await ApplicationData.Current.LocalFolder.CreateFolderAsync("Save", CreationCollisionOption.OpenIfExists);
            storageFolder = await storageFolder.CreateFolderAsync("Audio", CreationCollisionOption.OpenIfExists);
            if (!string.IsNullOrEmpty(filename))
            {
                StorageFile original = await storageFolder.GetFileAsync(filename);
                await original.DeleteAsync();
            }

            StorageFile storageFile = await storageFolder.CreateFileAsync(audioFilename, CreationCollisionOption.ReplaceExisting);
            filename = storageFile.Name;
            using (IRandomAccessStream fileStream = await storageFile.OpenAsync(FileAccessMode.ReadWrite))
            {
                await RandomAccessStream.CopyAndCloseAsync(audio.GetInputStreamAt(0), fileStream.GetOutputStreamAt(0));
                await audio.FlushAsync();
                audio.Dispose();
            }
        }
    }
}
