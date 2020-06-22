using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace SpotifyConnector
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ShowPlaylist(object sender, EventArgs e)
        {
            PlaylistPage playlistPage = new PlaylistPage();
            Navigation.PushModalAsync(playlistPage);
        }
    }
}
