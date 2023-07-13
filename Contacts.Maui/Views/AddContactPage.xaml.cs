using Contacts.Maui.Models;

namespace Contacts.Maui;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

    private void backbtn_Clicked(object sender, EventArgs e)
    {
        //GoToAsync("..") code for parent page and this GoToAsync("..") code for refresh.

        Shell.Current.GoToAsync("..");
    }

    private void contactCtrl_OnSave(object sender, EventArgs e)
    {
        ContactRepository.AddContact(new Models.Contact
        {
            Name = contactCtrl.Name,
            Email = contactCtrl.Email,
            Phone = contactCtrl.Phone,
            Address = contactCtrl.Address,
        }) ;
        Shell.Current.GoToAsync("..");
    }

    private void contactCtrl_OnCancle(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void contactCtrl_OnError(object sender, string e)
    {
        DisplayAlert("Error", e, "ok");
    }
}