using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
using Directory = MetadataExtractor.Directory;
using MetadataExtractor;
using System.Drawing;

namespace ExifViewerCSharp
{
    public class utility
    {
        public bool hasGeo;
        public static string gmapURL = "";
        public static string osmapURL = "";
        public string BuildString(exifData exd)
        {
           string exifString = "";
            exifString = exifString + constants.filenameString + exd.FileName + System.Environment.NewLine;
            exifString = exifString + constants.dateCapturedString + exd.ExifSubIFD_DateTimeOriginal + System.Environment.NewLine;
            exifString = exifString + constants.cameraString + exd.ExifIFD0_Model + System.Environment.NewLine;
            exifString = exifString + constants.lensString + exd.ExifSubIFD_LensModel + System.Environment.NewLine;
            exifString = exifString + constants.shutterSpeedString + exd.ExifSubIFD_ShutterSpeed + System.Environment.NewLine;
            exifString = exifString + constants.ISOstring + exd.ExifSubIFD_ISOSpeedRating + System.Environment.NewLine;
            exifString = exifString + constants.apertureString + exd.ExifSubIFD_MaxApertureValue + System.Environment.NewLine;
            exifString = exifString + constants.exposureCompString + exd.ExifSubIFD_ExposureBias + System.Environment.NewLine;
            exifString = exifString + constants.meteringModeString + exd.ExifSubIFD_MeteringMode + System.Environment.NewLine;
            exifString = exifString + constants.flashString + exd.ExifSubIFD_Flash + System.Environment.NewLine;
            exifString = exifString + constants.colorSpaceString + exd.ExifSubIFD_ColorSpace + System.Environment.NewLine;
           
            if (exd.GPS_Latitude != null && exd.GPS_Longitude != null)
            {
                exifString = exifString + constants.coordinatesString + exd.GPS_Latitude + "," + exd.GPS_Longitude;
                hasGeo = true;
                gmapURL = "https://www.google.com/maps/search/?api=1&zoom=20&query=" + exd.GPS_Latitude + "," + exd.GPS_Longitude;
                osmapURL = "https://www.openstreetmap.org/?mlat=" + exd.GPS_Latitude + "&mlon=" + exd.GPS_Longitude + "&zoom=15";
            }

            return exifString;
        }
        public string getRawExifData (string imagePath)
        {
            string rawExif ="" ;
            IEnumerable<Directory> directories = ImageMetadataReader.ReadMetadata(imagePath);
            foreach (var directory in directories)
                foreach (var tag in directory.Tags)
                {
                    Console.WriteLine($"{directory.Name} - {tag.Name} = {tag.Description}");
                    rawExif = rawExif + $"{directory.Name} - {tag.Name} = {tag.Description}" +System.Environment.NewLine;
                }
           
                return rawExif;
        }
      
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
