using GoiaAlexandruLab7.Models;

namespace GoiaAlexandruLab7;

public partial class ShopEntryPage : ContentPage
{
	public ShopEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetShopsAsync();
    }

    async void OnShopAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ShopPage
        {
            BindingContext = new Shop()
        });
    }

    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ShopPage {
                BindingContext = e.SelectedItem as Shop
            });
        }
    }

    async void OnDeleteShop(object sender, EventArgs e)
    {
		var button = (Button)sender;
        Shop shop = (Shop)button.BindingContext;

        await App.Database.DeleteShopAsync(shop);
        listView.ItemsSource = await App.Database.GetShopsAsync();
    }
}