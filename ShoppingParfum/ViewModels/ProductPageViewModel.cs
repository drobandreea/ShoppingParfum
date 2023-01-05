using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Input;

namespace ShoppingParfum
{
    public class ProductPageViewModel
    {
        public ObservableCollection<Itemi> Itemi { get; set; }
        public ObservableCollection<Itemi> CosItemi { get; set; }   
        public Itemi SelectedItem { get; set; }
        public ICommand Itemclick { get; set; }
        public ICommand CosItemclick { get; set; }
        public ProductPageViewModel(INavigation navigation)
        {
            Itemi = new ObservableCollection<Itemi>
            {
                new Itemi
                {
                    Imagine="a.png",
                    Nume = "Cool Watch",
                    Cantitate = "1",
                    Pret = "$99"
                },
                new Itemi
                {
                    Imagine="b.png",
                    Nume = "Cool Watch",
                    Cantitate = "1",
                    Pret = "$99"
                },
                new Itemi
                {
                    Imagine="c.png",
                    Nume = "Cool Watch",
                    Cantitate = "1",
                    Pret = "$99"
                },
                new Itemi
                {
                    Imagine="d.png",
                    Nume = "Cool Watch",
                    Cantitate = "1",
                    Pret = "$99"
                },
                new Itemi
                {
                    Imagine="e.png",
                    Nume = "Cool Watch",
                    Cantitate = "1",
                    Pret = "$99"
                },
                
            };

            CosItemi = new ObservableCollection<Itemi> { };
            Itemclick = new Command<Itemi>(executeitemclickcommand);
            CosItemclick = new Command<Itemi>(executeCositemclickcommand);
            this.navigation = navigation;
        }
        private INavigation navigation;

        async void executeitemclickcommand(Itemi item)
        {
            this.SelectedItem = item;
            await navigation.PushModalAsync(new DetailsPage(this));
        }

        async void executeCositemclickcommand(Itemi item)
        {
            this.CosItemi.Add(this.SelectedItem);
            await navigation.PushModalAsync(new CartPage(this));

        }
    }
}

