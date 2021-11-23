using MetadataExtractor;
using System;
using System.Collections.Generic;
using System.IO;
using Directory = MetadataExtractor.Directory;

namespace ExifViewerCSharp
{
    internal class exifEngine
    {
        public  string getExifString(string imagePath)
        {
            IEnumerable<Directory> directories = ImageMetadataReader.ReadMetadata(imagePath);
            foreach (var directory in directories)
                foreach (var tag in directory.Tags)
                    Console.WriteLine($"{directory.Name} - {tag.Name} = {tag.Description}");
            return "meh";
        }
        public exifData getExifData(string imagePath)
        {
            exifData results = new exifData();
            IEnumerable<Directory> directories = ImageMetadataReader.ReadMetadata(imagePath);
            foreach (var directory in directories)
                foreach (var tag in directory.Tags)
                {
                    switch (tag.Name)
                    {
                        case "Compression Type":
                            results.jpgCompressionType = tag.Description;
                            break;
                        case "Data Precision":
                            results.jpgPrecision = tag.Description;
                            break;
                        case "Image Height":
                            results.imgHeight = tag.Description;
                            break;
                        case "Image Width":
                            results.imgWidth = tag.Description;
                            break;
                        case "Number of Components":
                            results.nbrOfComponents = tag.Description;
                            break;
                        case "Component 1":
                            results.component1 = tag.Description;
                            break;
                        case "Component 2":
                            results.component2 = tag.Description;
                            break;
                        case "Component 3":
                            results.component3 = tag.Description;
                            break;
                        case "Version":
                            results.jfifVersion = tag.Description;
                            break;
                        case "Resolution Units":
                            results.jfifResUnits = tag.Description;
                            break;
                        case "X Resolution":
                            if (directory.Name == "JFIF")
                                results.jfifXRes = tag.Description;
                            else
                                results.ExifIFD0_XResolution = tag.Description;
                            break;
                        case "Y Resolution":
                            if (directory.Name == "JFIF")
                                results.jfifYRes = tag.Description;
                            else
                                results.ExifIFD0_YResolution = tag.Description;
                            break;
                        case "Thumbnail Width Pixels":
                            results.jfifThumbnailWidthPixels = tag.Description;
                            break;
                        case "Thumbnail Height Pixels":
                            results.jfifThumbnailHeightPixels = tag.Description;
                            break;
                        case "Make":
                            results.ExifIFD0_Make = tag.Description;
                            break;
                        case "Model":
                            results.ExifIFD0_Model = tag.Description;
                            break;
                        case "Software":
                            results.ExifIFD0_Software = tag.Description;
                            break;
                        case "Date/Time":
                            results.ExifIFD0_DateTime = tag.Description;
                            break;
                        case "Artist":
                            results.ExifIFD0_Artist = tag.Description;
                            break;

                        case "Copyright":
                            results.ExifIFD0_copyright = tag.Description;
                            break;
                        case "Exposure Time":
                            results.ExifSubIFD_ExposureTime = tag.Description;
                            break;
                        case "ISO Speed Ratings":
                            results.ExifSubIFD_ISOSpeedRating= tag.Description;
                            break;
                        case "Exif Version":
                            results.ExifSubIFD_ExifVersion = tag.Description;
                            break;
                        case "Date/Time Original":
                            results.ExifSubIFD_DateTimeOriginal = tag.Description;
                            break;
                        case "Date/Time Digitized":
                            results.ExifSubIFD_DateTimeDigitized = tag.Description;
                            break;
                        case "Time Zone":
                            results.ExifSubIFD_TimeZone = tag.Description;
                            break;
                        case "Shutter Speed Value":
                            results.ExifSubIFD_ShutterSpeed = tag.Description;
                            break;
                        default:
                            continue;
                    }
                }
            return results;

        }
    }
}