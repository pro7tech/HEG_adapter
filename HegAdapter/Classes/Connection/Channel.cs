using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BxAdapter
{
    public class Channels
    {
        private List<Channel> AllChannels = new List<Channel>();
        private ComboBox DdlVisChannel;
        private ComboBox DdlVolChannel;
        private ComboBox DdlKeyChannel;

        class Channel
        {
            public int Id;
            private string name;

            public string Name {
                get { return name; }
                set {
                    name = value;
                    NormalizedId = Regex.Match(value, "[0-9]+").Value;
                }
            }

            public string NormalizedName {
                get {
                    return "Channel " + NormalizedId;
                }
            }

            private string NormalizedId;
            public Channel(int id, string name) {
                Id = id;
                Name = name;
            }

            public override string ToString() {
                return NormalizedName;
            }
        }

        public Channels(ComboBox ddlVisChannel, ComboBox ddlVolChannel, ComboBox ddlKeyChannel) {
            DdlVisChannel = ddlVisChannel;
            DdlVolChannel = ddlVolChannel;
            DdlKeyChannel = ddlKeyChannel;
        }

        private Channel FindChannelById(int id) {
            foreach (Channel ch in AllChannels) {
                if (ch.Id == id) {
                    return ch;
                }
            }
            return null;
        }

        private Channel FindChannelByNormalizedName(string normalizedName) {
            foreach (Channel ch in AllChannels) {
                if (ch.NormalizedName == normalizedName) {
                    return ch;
                }
            }
            return null;
        }

        public void AddChannel(int channelId, string channelName) {
            AllChannels.Add(new Channel(channelId, channelName));
            PopulateChannelDropdowns();
        }

        public void RemoveAllChannels() {
            AllChannels.Clear();
            PopulateChannelDropdowns();
        }

        public void RemoveChannel(int channelId) {
            AllChannels.Remove(FindChannelById(channelId));
            PopulateChannelDropdowns();
        }

        public void RenameChannel(int channelId, string channelName) {
            string oldName, newName;
            Channel channel = FindChannelById(channelId);
            oldName = channel.NormalizedName;
            channel.Name = channelName;
            newName = channel.NormalizedName;
            PopulateChannelDropdownsAndSetActiveChannelIds(oldName, newName);
        }

        private void PopulateChannelDropdowns() {
            PopulateChannelDropdownsAndSetActiveChannelIds("", "");
        }
        private void PopulateChannelDropdownsAndSetActiveChannelIds(string oldName, string newName) {
            PopulateChannelDropdown(DdlVisChannel, 0, oldName, newName);
            PopulateChannelDropdown(DdlVolChannel, 1, oldName, newName);

        }

        private void PopulateChannelDropdown(ComboBox ddl, int defaultChannelIndex, string oldName, string newName) {
            string selectedText = ddl.SelectedText;
            if (selectedText == oldName) {
                selectedText = newName;
            }

            ddl.Items.Clear();
            foreach (Channel ch in AllChannels) {
                ddl.Items.Add(ch.ToString());
            }

            if (selectedText != "") {
                ddl.SelectedText = selectedText;
            }

            if (ddl.SelectedText == "") {
                if (ddl.Items.Count == 1) {
                    ddl.SelectedIndex = 0;
                } else if (ddl.Items.Count > 1) {
                    ddl.SelectedIndex = defaultChannelIndex;
                }
            }
        }

        private int selectedVisChannelId;
        public int GetSelectedVisChannelId() {
            return selectedVisChannelId;
        }

        private int selectedVolChannelId;
        public int GetSelectedVolChannelId() {
            return selectedVolChannelId;
        }

        private int selectedKeyChannelId;
        public int GetSelectedKeyChannelId() {
            return selectedKeyChannelId;
        }
        public void UpdateSelectedVisChannelId() {
            selectedVisChannelId = FindChannelByNormalizedName(DdlVisChannel.Text).Id;
        }

        public void UpdateSelectedVolChannelId() {
            selectedVolChannelId = FindChannelByNormalizedName(DdlVolChannel.Text).Id;
        }

        public void UpdateSelectedKeyChannelId() {
            selectedKeyChannelId = FindChannelByNormalizedName(DdlKeyChannel.Text).Id;
        }
    }
}
