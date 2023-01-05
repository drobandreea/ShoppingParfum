namespace ShoppingParfum;

public partial class ProductPage : ContentPage
{
	ProductPageViewModel productPageViewModel;
	public ProductPage()
	{
		InitializeComponent();
        productPageViewModel = new ProductPageViewModel(this.Navigation);
        BindingContext = productPageViewModel;
	}

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}