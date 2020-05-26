using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BxAdapter
{
    public enum FeedbackType { Visual, Audio, Keyboard }

    public class SignalProcessor
    {
        public enum SignalState { NoSignal, PassSignal, FailSignal, UnknownSignal }

        RewardSetter RewardSetter;

        public void ShowNoSignal() {
            //ShowSignalStatus(SignalState.NoSignal);
        }
        
        private SignalType VisPanelType = SignalType.None;
        private SignalType VolPanelType = SignalType.None;

        private class SignalText {
            public const string NoSignal = "none";
            public const string Pass = "PASS";
            public const string Fail = "FAIL";
        }

        BxAdapter bx;
        public SignalProcessor(BxAdapter bxAdapter) {
            bx = bxAdapter;
            RewardSetter = bx.RewardSetter;
        }

        
        Dictionary<int, Boolean> IsVariableChannel = new Dictionary<int, bool>();
        //public void NewSignal()
        //{

        //    int channelID = e.channelID;
        //    int sampleCount = e.sampleCount;
        //    double sample = e.samples;

        //    if (!IsVariableChannel.ContainsKey(channelID))
        //    {
        //        IsVariableChannel[channelID] = false;
        //    }

        //    if (bx.AllChanels.GetSelectedVisChannelId() == channelID && bx.ControlVisibility)
        //    {
        //        ProcessSignalWithEffectSetter(channelID, sample, FeedbackType.Visual);
        //    }

        //    if (bx.AllChanels.GetSelectedVolChannelId() == channelID && bx.ControlVolume)
        //    {
        //        ProcessSignalWithEffectSetter(channelID, sample, FeedbackType.Audio);
        //    }

        //    if (bx.AllChanels.GetSelectedKeyChannelId() == channelID && bx.ControlSendKey)
        //    {
        //        ProcessSignalWithEffectSetter(channelID, sample, FeedbackType.Keyboard);
        //    }
        //}

        //private void ProcessSignalWithEffectSetter(int channelID, double sample, FeedbackType feedbackType) {
        //    if (!IsVariableChannel[channelID] && (sample == 1.0 || sample == 0)) {
        //        IsVariableChannel[channelID] = false;
        //        PerformDiscreteSignalAction((int)sample, feedbackType);
        //    } else {
        //        IsVariableChannel[channelID] = true;
        //        if (feedbackType == FeedbackType.Visual) {
        //            PerformVariableSignalAction(sample, feedbackType, Globals.VariableVisSamples.AddSample(sample));
        //        } else if (feedbackType == FeedbackType.Audio) {
        //            Globals.VariableVolSamples.AddSample(sample);
        //            PerformVariableSignalAction(sample, feedbackType, Globals.VariableVolSamples.AddSample(sample));
        //        }
        //    }
        //}

        void PerformVariableSignalAction(double sample, FeedbackType feedbackType, VariableSamples variableSamples) {
            if (feedbackType == FeedbackType.Visual) {
                ActivateVisEffectSetter(SignalType.Variable);
                bx.variableVisibility.ProcessSample(sample, bx.TrackVis, variableSamples);

            } else if (feedbackType == FeedbackType.Audio) {
                ActivateVolEffectSetter(SignalType.Variable);
                bx.variableVolume.ProcessSample(sample, bx.TrackVol, variableSamples);
            }
        }

        public void PerformDiscreteSignalAction(int signal, FeedbackType feedbackType) {
            if (feedbackType == FeedbackType.Visual) {
                ActivateVisEffectSetter(SignalType.Discrete);
            } else if (feedbackType == FeedbackType.Audio) {
                ActivateVolEffectSetter(SignalType.Discrete);
            }

            if (signal == 0) {
                //PerformFailSignalActions(feedbackType);
            } else if (signal == 1) {
                //PerformPassSignalActions(feedbackType);
            }
        }

        public void ActivateVisEffectSetter(SignalType correctType) {
            if (VisPanelType != correctType) {
                bx.VisibilityPanel.Controls.Clear();
                if (correctType == SignalType.Discrete) {
                    bx.VisibilityPanel.Controls.Add(bx.discreteVisibility);
                } else if (correctType == SignalType.Variable) {
                    bx.VisibilityPanel.Controls.Add(bx.variableVisibility);
                }
            }
            VisPanelType = correctType;
        }

        public void ActivateVolEffectSetter(SignalType correctType) {
            if (VolPanelType != correctType) {
                bx.VolumePanel.Controls.Clear();
                if (correctType == SignalType.Discrete) {
                    bx.VolumePanel.Controls.Add(bx.discreteVolume);
                } else if (correctType == SignalType.Variable) {
                        bx.VolumePanel.Controls.Add(bx.variableVolume);
                    } else {
                        bx.VolumePanel.Controls.Add(bx.variableVolFeedbackNotAvailable);
                    }
                }
            }
            //VolPanelType = correctType;
        }

        //void PerformPassSignalActions(FeedbackType feedbackType) {
        //    ShowSignalStatus(SignalState.PassSignal);

        //    if (feedbackType == FeedbackType.Visual) {
        //        RewardSetter.SetValueForPassSignal(bx.TrackVis, bx.discreteVisibility.PassChange);
        //    }

        //    if (feedbackType == FeedbackType.Audio) {
        //        RewardSetter.SetValueForPassSignal(bx.TrackVol, bx.discreteVolume.PassChange);
        //    }

        //    if (feedbackType == FeedbackType.Keyboard) {
        //        //string stat = RewardKeySender.DoPassSignal();
        //        //if (stat != "") {
        //        //    txtKeyPressStat.Text = stat;
        //        //}
        //    }
        //}

        //void PerformFailSignalActions(FeedbackType feedbackType) {
        //    ShowSignalStatus(SignalState.FailSignal);

        //    if (feedbackType == FeedbackType.Visual) {
        //        RewardSetter.SetValueForFailSignal(bx.TrackVis, bx.discreteVisibility.FailChange);
        //    }

        //    if (feedbackType == FeedbackType.Audio) {
        //        RewardSetter.SetValueForFailSignal(bx.TrackVol, bx.discreteVolume.FailChange);
        //    }

        //    if (feedbackType == FeedbackType.Keyboard) {
        //        //RewardKeySender.DoFailSignal();
        //    }
        //}

        //private void ShowSignalStatus(SignalState signalState) {
        //    bx.SignalStatusButton.BackColor = Color.Transparent;

        //    switch (signalState) {
        //        case SignalState.NoSignal:
        //            bx.SignalStatusButton.Text = SignalText.NoSignal;
        //            bx.SignalStatusButton.LinkColor = Color.Black;
        //            bx.SignalStatusButton.BackColor = Color.Transparent;
        //            break;
        //        case SignalState.PassSignal:
        //            bx.SignalStatusButton.Text = "PASS";
        //            bx.SignalStatusButton.LinkColor = C.PassColor;
        //            bx.SignalStatusButton.BackColor = Color.Transparent;
        //            break;
        //        case SignalState.FailSignal:
        //            bx.SignalStatusButton.Text = "FAIL";
        //            bx.SignalStatusButton.LinkColor = C.FailColor;
        //            bx.SignalStatusButton.BackColor = Color.Transparent;
        //            break;
        //    }
        //}


    }

