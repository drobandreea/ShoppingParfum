namespace ShoppingParfum;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(ProductPageViewModel item)
	{
		InitializeComponent();
		BindingContext = item;
	}
}