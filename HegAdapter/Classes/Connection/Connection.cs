using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BxAdapter
{
    public enum ConnectionStatus { NotConnected, Paused, Playing, Stopped, Connected, BioExplorerNotInstalled }

    public class Connection
    {
        public ConnectionStatus CurrentConnectionStatus;

        Label lblConnectionStatus;
        BxAdapter BxAdapter;


        private static string GetConnectionStatusText(ConnectionStatus connectionStatus) {
            switch (connectionStatus) {
                case ConnectionStatus.NotConnected: return "Not Connected";
                //case ConnectionStatus.BioExplorerNotInstalled: return "BioExplorer Not Installed";
                default: return connectionStatus.ToString();
            }
        }

        public bool IsPlaying {
            get {
                if (CurrentConnectionStatus == ConnectionStatus.Playing) {
                    return true;
                } else {
                    return false;
                }
            }
        }

        public void ShowStatus(ConnectionStatus connectionStatus) {
            if (connectionStatus == ConnectionStatus.Connected) {
                BxAdapter.SetHasConnectionToBioExplorer();
            }

            CurrentConnectionStatus = connectionStatus;
            string connectionText = GetConnectionStatusText(connectionStatus);
            lblConnectionStatus.Text = connectionText;
        }
    }
}
