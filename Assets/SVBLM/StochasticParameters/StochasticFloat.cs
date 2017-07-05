using UnityEngine;

namespace SVBLM.StochasticParameters {
    [System.Serializable]
    public class StochasticFloat : StochasticIntervalValue<float> {
        public override float GetNewValue() {
            return Random.Range(MinValue, MaxValue);
        }
    }
}