namespace Contacts.Maui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		
		//after Make contact page as a main page then we registered route 
		Routing.RegisterRoute(nameof(Contact),typeof(Contact));
		Routing.RegisterRoute(nameof(EditContactsPage),typeof(EditContactsPage));
		Routing.RegisterRoute(nameof(AddContactPage),typeof(AddContactPage));
	}
}
