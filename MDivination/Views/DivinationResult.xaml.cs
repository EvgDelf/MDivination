using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MDivination.ViewModels;

namespace MDivination.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DivinationResult : ContentPage
    {
        public DivinationResult()
        {
            InitializeComponent();
            this. BindingContext = new MemViewModel() { Navigation=this.Navigation};
        }
    }
}