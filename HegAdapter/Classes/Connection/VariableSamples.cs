using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BxAdapter
{
    public class VariableSamples
    {
        private class Sample : IComparable<Sample>
        {
            public DateTime SampleTime;
            public Double Value;

            public Sample(double sample) {
                Value = sample;
                SampleTime = DateTime.Now;
            }

            public int CompareTo(Sample otherSample) {
                return Value.CompareTo(otherSample.Value);
            }

            public override string ToString() {
                return string.Format("Time: {0},  Value: {1}", SampleTime, Value);
            }
        }

        private List<Sample> Samples = new List<Sample>(1234567);
        private DateTime NextRecalculationTime = DateTime.Now;
        private List<Sample> CachedSortedSamples;
        private double CachedMaxSignal;
        private double CachedMinSignal;

        public VariableSamples AddSample(double sample) {
            Samples.Add(new Sample(sample));
            return this;
        }

        public string FormulaDebug = "notSet";

        private void RegenerateCachedSortedSamples(int periodInSeconds) {
            int i = Samples.Count;
            DateTime earliestAllowablePeriod = DateTime.Now.Subtract(new TimeSpan(0, 0, periodInSeconds));
            CachedSortedSamples = new List<Sample>(12345);
            do {
                i--;
                CachedSortedSamples.Add(Samples[i]);
            } while ((i > 0) && (Samples[i].SampleTime > earliestAllowablePeriod));
            CachedSortedSamples.Sort();
        }

        private double GetSignalForPercentileForPeriod(int percentile) {
            int index = (int)((CachedSortedSamples.Count * (percentile / 100.0)));
            return CachedSortedSamples[index].Value;
        }

        private string DebugList(List<Sample> list, string name) {
            string nl = Environment.NewLine;
            string s = name + "Total: " + list.Count + nl;
            foreach (Sample sample in list) {
                s += sample.ToString() + nl;
            }
            return s;
        }

        public string AllSampleDebug() {
            return DebugList(Samples, "All Samples");
        }

        public string SortedSampleDebug() {
            return DebugList(CachedSortedSamples, "Cached Sorted Samples");
        }

        public float GetRewardLevelForSample(double sample,
            int periodInSeconds,
            int maximumThresholdPercent,
            int minimumThresholdPercent,
            bool reverseDesiredSignalAmount,
            bool forceRecalculation) {

            if ((DateTime.Now >= NextRecalculationTime) || forceRecalculation) {
                NextRecalculationTime = NextRecalculationTime.AddSeconds(1);
                RegenerateCachedSortedSamples(periodInSeconds);
                CachedMaxSignal = GetSignalForPercentileForPeriod(maximumThresholdPercent);
                CachedMinSignal = GetSignalForPercentileForPeriod(minimumThresholdPercent);
            }

            double rewardPercent;
            if (sample >= CachedMaxSignal) {
                rewardPercent = 1.0;
            } else if (sample <= CachedMinSignal) {
                rewardPercent = 0.0;
            } else {
                rewardPercent = ((sample - CachedMinSignal) / (CachedMaxSignal - CachedMinSignal));
            }

            if (reverseDesiredSignalAmount) {
                rewardPercent = 1.0 - rewardPercent;
            }

            string nl = Environment.NewLine;
            string s = String.Format("Period in seconds: {0}", periodInSeconds) + nl;
            s += String.Format("value: {0}", sample) + nl;
            s += String.Format("minSignal: {0}", CachedMinSignal) + nl;
            s += String.Format("maxSignal: {0}", CachedMaxSignal) + nl;
            s += String.Format("Reward Percent: {0}", rewardPercent * 100.0);
            FormulaDebug = s;

            return (float)rewardPercent;
        }
    }
}
