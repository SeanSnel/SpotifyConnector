using System;
using System.ComponentModel;
using SpotifyConnector.DataAccess;
using Xamarin.Forms;

namespace SpotifyConnector
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly IConnector _spotifyConnector;

        public MainPage()
        {
            _spotifyConnector = new Connector();
            InitializeComponent();
        }

        private void ShowPlaylist(object sender, EventArgs e)
        {
            PlaylistPage playlistPage = new PlaylistPage(_spotifyConnector);
            Navigation.PushModalAsync(playlistPage);
        }
    }
}
