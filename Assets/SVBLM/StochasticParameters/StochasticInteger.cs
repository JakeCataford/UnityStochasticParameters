using UnityEngine;

namespace SVBLM.StochasticParameters {
    [System.Serializable]
    public class StochasticInteger : StochasticIntervalValue<int> {
        public override int GetNewValue() {
            return Random.Range(MinValue, MaxValue);
        }
    }
}