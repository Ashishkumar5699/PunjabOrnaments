using Microsoft.Maui.Graphics.Text;
using Punjab_Ornaments.Infrastructure.Interface;

namespace Punjab_Ornaments.Infrastructure.Implementations
{
    public class SaveAndOpen : ISaveAndOpen
    {
        public Task<bool> SaveAndView(string filename, string contentType, MemoryStream stream)
        {
            return Task.FromResult(false);
            //StorageFile storageFile = null;
            //FileSavePicker savePicker = new FileSavePicker();
            //savePicker.SuggestedStartLocation = PickerLocationId.Desktop;
            //savePicker.SuggestedFileName = filename;
            //switch (contentType)
            //{
            //    case "application/vnd.openxmlformats-officedocument.presentationml.presentation":
            //        savePicker.FileTypeChoices.Add("PowerPoint Presentation", new List<string>() { ".pptx", });
            //        break;

            //    case "application/msexcel":
            //        savePicker.FileTypeChoices.Add("Excel Files", new List<string>() { ".xlsx", });
            //        break;

            //    case "application/msword":
            //        savePicker.FileTypeChoices.Add("Word Document", new List<string>() { ".docx" });
            //        break;

            //    case "application/pdf":
            //        savePicker.FileTypeChoices.Add("Adobe PDF Document", new List<string>() { ".pdf" });
            //        break;
            //    case "application/html":
            //        savePicker.FileTypeChoices.Add("HTML Files", new List<string>() { ".html" });
            //        break;
            //    case "application/csv":
            //        savePicker.FileTypeChoices.Add("Csv Files", new List<string>() { ".csv" });
            //        break;
            //}

            //storageFile = await savePicker.PickSaveFileAsync();

            //if (storageFile == null)
            //{
            //    return false;
            //}
            //using (Stream outStream = await storageFile.OpenStreamForWriteAsync())
            //{
            //    outStream.Write(stream.ToArray(), 0, (int)stream.Length);
            //}

            //return true;
        }
    }
}
