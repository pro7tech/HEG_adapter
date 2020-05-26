using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Drawing;

namespace BxAdapter
{
    public class SignalSimulator
    {
        private class SimulatedText
        {
            public const string StartSimulation = "Simulate Signal";
            public const string StopSimulation = "Stop Simulation";
        }

        BxAdapter bx;
        public SignalSimulator(BxAdapter bx) {
            this.bx = bx;
        }

        private void SimulateIfNoSignal() {
            if (!bx.TmrSimulation.Enabled) {
                ToggleSimulation();
            }
        }

        public void DisableSimulation() {
            //bx.SignalProcessor.ShowSimSignalStatus(SignalProcessor.SignalState.NoSignal);
            bx.TmrSimulation.Enabled = false;
            bx.BtnStopSimulation.Visible = false;
            
        }

        public void ToggleSimulation() {
            if (bx.TmrSimulation.Enabled == true) {
                DisableSimulation();
            } else {
                if (bx.Connection.CurrentConnectionStatus != ConnectionStatus.Playing) {
                    bx.BtnStopSimulation.Visible = true;
                    bx.TmrSimulation.Interval = 10;
                    bx.TmrSimulation.Enabled = true;
                   }
            }
        }

        //signal simulation
        private int NumberContinuousSignals = 0;
        private int SimulatedSignal = 0;
        private Random RanSim = new Random();

        private int GetSimulatedSignal() {
            if (SimulatedSignal == 0) {
                return 1;
            } else {
                return 0;
            }
        }

        private int MinSimChange = 5;
        private int MaxSimChange = 25;

        private int MinSimChangeTarget = 5;
        private int MaxSimChangeTarget = 25;

        private bool AdjustToTarget = true;

        public void SetSimChangeConstant() {
            MinSimChange = 55;
            MaxSimChange = 75;
            AdjustToTarget = true;
        }

        public void SimulationTick() {
            if (NumberContinuousSignals == 0) {
                SimulatedSignal = GetSimulatedSignal();
                NumberContinuousSignals = RanSim.Next(MinSimChange, MaxSimChange);

                if (AdjustToTarget ) {
                    if (MinSimChange > MinSimChangeTarget) {
                        MinSimChange--;
                    }

                    if (MaxSimChange > MaxSimChangeTarget) {
                        MaxSimChangeTarget--;
                    }
                }

                if (SimulatedSignal == 0) {
                    NumberContinuousSignals += 3;
                }
                bx.SignalProcessor.PerformDiscreteSignalAction(SimulatedSignal, FeedbackType.Audio);
                bx.SignalProcessor.PerformDiscreteSignalAction(SimulatedSignal, FeedbackType.Keyboard);
                bx.SignalProcessor.PerformDiscreteSignalAction(SimulatedSignal, FeedbackType.Visual);
            } else if (NumberContinuousSignals > 0) {
                if (SimulatedSignal < 0 || SimulatedSignal > 1) {
                    SimulatedSignal = GetSimulatedSignal();
                }
                bx.SignalProcessor.PerformDiscreteSignalAction(SimulatedSignal, FeedbackType.Audio);
                bx.SignalProcessor.PerformDiscreteSignalAction(SimulatedSignal, FeedbackType.Keyboard);
                bx.SignalProcessor.PerformDiscreteSignalAction(SimulatedSignal, FeedbackType.Visual);
                Thread.BeginCriticalRegion();
                if (NumberContinuousSignals > 0) {
                    NumberContinuousSignals--;
                    Thread.EndCriticalRegion();
                }
            } else {
                throw new ApplicationException("Simulator error");
            }
        }
    }
}
