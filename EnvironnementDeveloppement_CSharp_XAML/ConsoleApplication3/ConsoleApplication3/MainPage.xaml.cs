using System;
using Model;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ConsoleApplication3
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Contact> listContacts = new List<Contact>()
        {
            new Contact("Charlier","Isabelle","isabelle.charlier@henallux.be"),
            new Contact("Scholtes","Samuel","samuel.scholtes@henallux.be")
        };

        public MainPage()
        {
            this.InitializeComponent();
            DataContext = listContacts;
        }

        private void AddContact_Click(object sender, RoutedEventArgs e)
        {
            Contact newContact = new Contact("Scholtes", "Samuel", "samuel.scholtes@henallux.be");
            listContacts.Add(newContact);
        }
    }
}
