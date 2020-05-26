using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BxAdapter {
    public enum KeyInteractType { TapKey, HoldKey, NotSet }
    
    public class RewardKeySender {
        enum PassKeyState { KeyDown, KeyUp, NotSet }
        
        TextBox KeyDisplay;
        KeyInfo RewardKey;

        public KeyInteractType KeyInteractType;

        //private KeyInteractType MyKeyInteractType = KeyInteractType.NotSet;
        private PassKeyState PreviousKeyState = PassKeyState.NotSet;
        private DateTime NextValidTapKeyTime;
        private DateTime KeyTapKeyUpTime;
        private bool KeyTapIsDown;
        private int TapKeyCount = 0;
        private int HoldKeyCount = 0;

        public RewardKeySender(TextBox keyDisplay, Label keyStateLog, KeyInteractType keyInteractType) {
            KeyDisplay = keyDisplay;
            KeyInteractType = keyInteractType;
            PreviousKeyState = PassKeyState.KeyUp;
            NextValidTapKeyTime = DateTime.Now;
        }

        public void SetKey(KeyEventArgs key) {
            RewardKey = new KeyInfo(key.KeyCode, key.KeyValue);
        }

        public string GetReadableKeyName() {
            return RewardKey.Name;
        }

        public string DoPassSignal() {
            CleanupKeyTap();

            if (RewardKey != null && Globals.GameWindow != null) {
                if (KeyInteractType == KeyInteractType.TapKey && NextValidTapKeyTime <= DateTime.Now) {
                    TapKeyCount++;
                    Globals.GameWindow.KeyDown(RewardKey);
                    KeyTapIsDown = true;
                    KeyTapKeyUpTime = DateTime.Now.AddMilliseconds(50);
                    NextValidTapKeyTime = DateTime.Now.AddMilliseconds(Globals.RepeatRate);
                    if (NextValidTapKeyTime < KeyTapKeyUpTime) {
                        NextValidTapKeyTime = KeyTapKeyUpTime.AddMilliseconds(10);
                    }
                    return "Tap: " + TapKeyCount.ToString();
                } else if (KeyInteractType == KeyInteractType.HoldKey && PreviousKeyState == PassKeyState.KeyUp) {
                    HoldKeyCount++;
                    PreviousKeyState = PassKeyState.KeyDown;
                    Globals.GameWindow.KeyDown(RewardKey);
                    return "Hold: " + HoldKeyCount.ToString();
                }
            }
            return "";
        }

        private void CleanupKeyTap() {
            if (DateTime.Now > KeyTapKeyUpTime && KeyTapIsDown) {
                Globals.GameWindow.KeyUp(RewardKey);
                KeyTapIsDown = false;
            }
        }

        public void DoFailSignal() {
            CleanupKeyTap();

            if (RewardKey != null && Globals.GameWindow != null) {
                if (KeyInteractType == KeyInteractType.HoldKey && PreviousKeyState == PassKeyState.KeyDown) {
                    Globals.GameWindow.KeyUp(RewardKey);
                    PreviousKeyState = PassKeyState.KeyUp;
                }
            }
        }
    }
}
