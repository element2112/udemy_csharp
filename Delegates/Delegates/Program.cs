using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        /*        public delegate void PhotoFilterHandler(Photo photo); - custom delegate

                public void Process(string path, PhotoFilterHandler filterHandler)
                {
                    var photo = Photo.Load(path);

                    filterHandler(photo);

                    photo.Save();
                }*/

        public void Process(string path, Action<Photo> filterHandler)
        {
            // System.Action<> -- .net's delegate (points to a method that returns void)
            // System.Func<> -- .net's delegate (points to a method that returns something)


            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }

    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply Brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }

    public class Photo
    {
        public static Photo Load(string path)
        {
           // Console.WriteLine("Loading..");
            return new Photo();
        }

        public void Save()
        {
           // Console.WriteLine("Saving photo");
        }
    }

    // delegate is a pointer to a method with a specific signature
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            // custom
            // PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness; // adding a reference to a method

            Action<Photo> filterHandler = filters.ApplyBrightness;

            filterHandler += filters.ApplyContrast; // adding another reference to the method

            processor.Process("photo.jpg", filterHandler);

            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}
