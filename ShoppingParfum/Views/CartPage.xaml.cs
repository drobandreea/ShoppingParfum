namespace ShoppingParfum;

public partial class CartPage : ContentPage
{
    public CartPage(ProductPageViewModel productPageViewModel)
    {
        InitializeComponent();
        BindingContext = productPageViewModel;
    }

}