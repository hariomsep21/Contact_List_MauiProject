using Contacts.Maui.Models;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui;

//this line help when data move contact to edit page
//and this line pass property name ContactId every time when previours page pass Id .

[QueryProperty(nameof(ContactId),"Id")]
public partial class EditContactsPage : ContentPage
{
	private Contact contact;
	public EditContactsPage()
	{
		InitializeComponent();

		
	}

    private void btnCancle_Clicked(object sender, EventArgs e)
    {
		//Both line work same so weare using any one .
		Shell.Current.GoToAsync("..");
       // Shell.Current.GoToAsync($"//{nameof(Contact)}");
    }
	public string ContactId
	{
		set
		{
			contact=ContactRepository.GetContactById(int.Parse(value));
			if(contact != null) 
			{
				contactCtrl.Name= contact.Name;
                contactCtrl.Email = contact.Email;
				contactCtrl.Phone = contact.Phone;
                contactCtrl.Address = contact.Address;
			
			}
		}
	}

    private void btnUpdate_Clicked(object sender, EventArgs e)
    {
		
		contact.Name = contactCtrl.Name; 
		contact.Email = contactCtrl.Email;
		contact.Phone = contactCtrl.Phone;
		contact.Address = contactCtrl.Address;

		ContactRepository.UpdateContact(contact.ContactId, contact);
        Shell.Current.GoToAsync("..");
    }

    private void contactCtrl_OnError(object sender, string e)
    {
		DisplayAlert("Error", e, "ok");
    }
}