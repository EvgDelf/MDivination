using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Input;
using MDivination.Models;
using Xamarin.Forms;
using MDivination.Views;
using System.Runtime.InteropServices.ComTypes;

namespace MDivination.ViewModels
{
    internal class MemViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        static Random random = new Random();
        public Mem mem { get; set; }
        public ICommand DivinationCommand { get; set; }
        public ICommand BackCommand { get; set; }
        public INavigation Navigation;
        public MemViewModel()
        {
            mem = new Mem();
            DivinationCommand = new Command(Divination);
            BackCommand = new Command(Back);

        }

       //static string path = $"D:\\VSprojects\\MDivination\\MDivination\\MDivination\\Interpretation\\{_mem}.txt";
        static int _mem = random.Next(0, 2);
        public ImageSource _image = FileImageSource.FromFile($"MDivination.Images.{_mem}");
        //public string interp = File.ReadAllText($"Interpretation\\{_mem}.txt");
      //  public string _hist= File.ReadAllText($"MDivination.History.{_mem}");
        public int id
        {
            get { return _mem; }
            set
            {
                if (_mem != value)
                    _mem = value;
                OnPropertyChanged("id");
            }
        }
        public ImageSource image
        {
            get { return _image; }
            set
            {
                if (_image != value)

                  _image= value;
                OnPropertyChanged("image");
            }
        }

        //public string interpretation
        //{
        //    get { return interp; }
        //    set
        //    {
        //        if (interp != value)
        //            interp = value;
        //        OnPropertyChanged("interpretation");
        //    }
        //}
        //public string history
        //{
        //    get=>_hist;
        //    set
        //    {
        //        if (_hist != value)
        //            _hist = value;
        //        OnPropertyChanged("history");
        //    }
            
        //}

        

        void Divination(object sender)
        {
            Navigation.PushAsync(new DivinationResult());
        }
        void Back(object sender)
        {
            Navigation.PopAsync();
        }



    }
}
