using MetadataExtractor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Directory = MetadataExtractor.Directory;

namespace ExifViewerCSharp
{
    internal class exifEngine
    {
       
        public exifData getExifData(string imagePath)
        {
            exifData results = new exifData();
            IEnumerable<Directory> directories = ImageMetadataReader.ReadMetadata(imagePath);
            var gpsdirectory = directories.OfType<MetadataExtractor.Formats.Exif.GpsDirectory>().FirstOrDefault();
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
                        case "Exposure Bias Value":
                            results.ExifSubIFD_ExposureBias = tag.Description;
                            break;
                        case "Max Aperture Value":
                            results.ExifSubIFD_MaxApertureValue = tag.Description;
                            break;
                        case "Metering Mode":
                            results.ExifSubIFD_MeteringMode = tag.Description;
                            break;
                        case "White Balance":
                            results.ExifSubIFD_WhiteBalance = tag.Description;
                            break;
                        case "Flash":
                            results.ExifSubIFD_Flash = tag.Description;
                            break;
                        case "Focal Length":
                            results.ExifSubIFD_FocalLength = tag.Description;
                            break;
                        case "Color Space":
                            results.ExifSubIFD_ColorSpace = tag.Description;
                            break;
                        case "Focal Plane X Resolution":
                            results.ExifSubIFD_FocalPlaneXResolution = tag.Description;
                            break;
                        case "Focal Plane Y Resolution":
                            results.ExifSubIFD_FocalPlaneYResolution = tag.Description;
                            break;
                        case "Focal Plane Resolution Unit":
                            results.ExifSubIFD_FocalPlaneResolutionUnit = tag.Description;
                            break;
                        case "Sensing Method":
                            results.ExifSubIFD_SensingMethod = tag.Description;
                            break;
                        case "File Source":
                            results.ExifSubIFD_FileSource = tag.Description;
                            break;
                        case "Scene Type":
                            results.ExifSubIFD_SceneType = tag.Description;
                            break;
                        case "Custom Rendered":
                            results.ExifSubIFD_CustomRendered = tag.Description;
                            break;
                        case "Exposure Mode":
                            results.ExifSubIFD_ExposureMode = tag.Description;
                            break;
                        case "White Balance Mode":
                            results.ExifSubIFD_WhiteBalanceMode = tag.Description;
                            break;
                        case "Digital Zoom Ratio":
                            results.ExifSubIFD_DigitalZoomRatio = tag.Description;
                            break;
                        case "Focal Length 35":
                            results.ExifSubIFD_FocalLength35 = tag.Description;
                            break;
                        case "Scene Capture Type":
                            results.ExifSubIFD_SceneCaptureType = tag.Description;
                            break;
                        case "Gain Control":
                            results.ExifSubIFD_GainControl = tag.Description;
                            break;
                        case "Contrast":
                            results.ExifSubIFD_Contrast = tag.Description;
                            break;
                        case "Saturation":
                            results.ExifSubIFD_Saturation = tag.Description;
                            break;
                        case "Sharpness":
                            results.ExifSubIFD_Sharpness = tag.Description;
                            break;
                        case "Body Serial Number":
                            results.ExifSubIFD_BodySerialNumber = tag.Description;
                            break;
                        case "Lens Model":
                            results.ExifSubIFD_LensModel = tag.Description;
                            break;
                        case "GPS Latitude Ref":
                            results.GPS_LatitudeRef = tag.Description;
                            break;
                        case "GPS Latitude":
                            //results.GPS_Latitude = tag.Description;
                            results.GPS_Latitude = gpsdirectory.GetGeoLocation().Latitude.ToString();
                            break;
                        case "GPS Longitude Ref":
                            results.GPS_LongitudeRef = tag.Description;
                            break;
                        case "GPS Longitude":
                            //results.GPS_Longitude = tag.Description;
                            results.GPS_Longitude = gpsdirectory.GetGeoLocation().Longitude.ToString();
                            break;
                        case "GPS Speed Ref":
                            results.GPS_SpeedRef = tag.Description;
                            break;
                        case "GPS Speed":
                            results.GPS_Speed = tag.Description;
                            break;
                        case "GPS Track Ref":
                            results.GPS_TrackRef = tag.Description;
                            break;
                        case "GPS Track":
                            results.GPS_Track = tag.Description;
                            break;
                        case "Coded Character Set":
                            results.IPTC_CharSet = tag.Description;
                            break;
                        case "Object Name":
                            results.IPTC_ObjectName = tag.Description;
                            break;
                        case "Keywords":
                            results.IPTC_Keywords = tag.Description;
                            break;
                        case "By-line":
                            results.IPTC_Byline = tag.Description;
                            break;
                        case "City":
                            results.IPTC_City = tag.Description;
                            break;
                        case "Province/State":
                            results.IPTC_ProvinceState = tag.Description;
                            break;
                        case "Country/Primary Location Code":
                            results.IPTC_CountryPrimaryLocationCode = tag.Description;
                            break;
                        case "Country/Primary Location Name":
                            results.IPTC_CountryPrimaryLocationName = tag.Description;
                            break;
                        case "Copyright Notice":
                            results.IPTC_Notice = tag.Description;
                            break;
                        case "File Name":
                            results.FileName = tag.Description;
                            break;
                        case "Thumbnail Offset":
                            results.thumbOffset = Int32.Parse( tag.Description.Replace("bytes",null));
                            break;
                        case "Thumbnail Length":
                            results.thumbLen = Int32.Parse(tag.Description.Replace("bytes",null));
                            break;
                        default:
                            continue;

                    }
                }
            return results;

        }
    }
}