using System;
using System.Collections.Generic;
using System.Text;

namespace BxAdapter
{
    class BxClientHost
    {
        //private AxBIOEXPLORERCLIENTLib.AxBioExplorerClient BxClient;
        private bool AbleToRegiserBxComClient = true;

        private BxAdapter bx;
        public BxClientHost(BxAdapter bxAdapter) {
            this.bx = bxAdapter;
        }

        public void Shutdown() {
            if (AbleToRegiserBxComClient) {
                //if (BxClient != null) {
                //    BxClient.Shutdown();
                //}
            }
        }

        private bool AttemptedToLoadClient = false;
        public void LoadBxClient() {
            if (AttemptedToLoadClient) {
                return;
            }
            AttemptedToLoadClient = true;

            //bx client
            //BxClient = new AxBIOEXPLORERCLIENTLib.AxBioExplorerClient();
            try {
                //BxClient.CreateControl();
                //BxClient.ShowLogWindow(false);
                //BxClient.BeginInit();
                //BxClient.Initialize();
                //BxClient.Visible = false;
                //BxClient.SetAutoConnect(true);
                //BxClient.OnConnect += new AxBIOEXPLORERCLIENTLib._DBioExplorerClientEvents_OnConnectEventHandler(BxClient_OnConnect);
                //BxClient.OnChannelSamples += new AxBIOEXPLORERCLIENTLib._DBioExplorerClientEvents_OnChannelSamplesEventHandler(BxClient_OnChannelSamples);
                //BxClient.OnPlay += new EventHandler(BxClient_OnPlay);
                //BxClient.OnPause += new EventHandler(BxClient_OnPause);
                //BxClient.OnStop += new EventHandler(BxClient_OnStop);
                //BxClient.OnDisconnect += new EventHandler(BxClient_OnDisconnect);
                //BxClient.OnChannelAdded += new AxBIOEXPLORERCLIENTLib._DBioExplorerClientEvents_OnChannelAddedEventHandler(BxClient_OnChannelAdded);
                //BxClient.OnChannelNameChanged += new AxBIOEXPLORERCLIENTLib._DBioExplorerClientEvents_OnChannelNameChangedEventHandler(BxClient_OnChannelNameChanged);
                //BxClient.OnChannelRemoved += new AxBIOEXPLORERCLIENTLib._DBioExplorerClientEvents_OnChannelRemovedEventHandler(BxClient_OnChannelRemoved);
            } catch {
                AbleToRegiserBxComClient = false;
                bx.ShowNoBioexplorer();
            }
            Windows.HideOneWindowByTitle("LogWindow [BEClient.dll]");
        }

        //void BxClient_OnChannelRemoved(object sender, AxBIOEXPLORERCLIENTLib._DBioExplorerClientEvents_OnChannelRemovedEvent e) {
        //    bx.AllChanels.RemoveChannel(e.channelID);
        //}

        //void BxClient_OnChannelNameChanged(object sender, AxBIOEXPLORERCLIENTLib._DBioExplorerClientEvents_OnChannelNameChangedEvent e) {
        //    bx.AllChanels.RenameChannel(e.channelID, e.name);
        //}

        //void BxClient_OnChannelAdded(object sender, AxBIOEXPLORERCLIENTLib._DBioExplorerClientEvents_OnChannelAddedEvent e) {
        //    bx.AllChanels.AddChannel(e.channelID, e.name);
        //}

        //void BxClient_OnStop(object sender, EventArgs e) {
        //    bx.SetConditionsBackToNormal();
        //    bx.Connection.ShowStatus(ConnectionStatus.Stopped);
        //    bx.SignalProcessor.ShowNoSignal();
        //}

        void BxClient_OnPause(object sender, EventArgs e) {
            bx.SetConditionsBackToNormal();
            bx.Connection.ShowStatus(ConnectionStatus.Paused);
            bx.SignalProcessor.ShowNoSignal();
        }

        void BxClient_OnPlay(object sender, EventArgs e) {
            bx.Connection.ShowStatus(ConnectionStatus.Playing);
        }

        //void BxClient_OnConnect(object sender, AxBIOEXPLORERCLIENTLib._DBioExplorerClientEvents_OnConnectEvent e) {
        //    bx.Connection.ShowStatus(ConnectionStatus.Connected);
        //    bx.SignalProcessor.ShowNoSignal();
        //}

        void BxClient_OnDisconnect(object sender, EventArgs e) {
            bx.SetConditionsBackToNormal();
            bx.AllChanels.RemoveAllChannels();
            bx.Connection.ShowStatus(ConnectionStatus.NotConnected);
            bx.SignalProcessor.ShowNoSignal();
        }

        //void BxClient_OnChannelSamples(object sender, AxBIOEXPLORERCLIENTLib._DBioExplorerClientEvents_OnChannelSamplesEvent e) {
        //    bx.SignalProcessor.NewSignal(e);            
        //}
    }
}
