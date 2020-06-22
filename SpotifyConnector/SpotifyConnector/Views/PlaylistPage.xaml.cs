using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace SpotifyConnector
{
    [DesignTimeVisible(false)]
    public partial class PlaylistPage : ContentPage
    {
        public PlaylistPage()
        {
            InitializeComponent();
            GetPlaylist();
        }

        private void GetPlaylist()
        {
            Console.WriteLine("Arrived at get playlists!");
        }
    }
}