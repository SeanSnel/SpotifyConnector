using System;
using System.ComponentModel;
using SpotifyConnector.DataAccess;
using Xamarin.Forms;

namespace SpotifyConnector
{
    [DesignTimeVisible(false)]
    public partial class PlaylistPage : ContentPage
    {
        private readonly IConnector _spotifyConnector;

        public PlaylistPage(IConnector spotifyConnector)
        {
            _spotifyConnector = spotifyConnector;
            InitializeComponent();
            GetPlaylist();
        }

        private void GetPlaylist()
        {
            Console.WriteLine("Arrived at get playlists!");
        }
    }
}