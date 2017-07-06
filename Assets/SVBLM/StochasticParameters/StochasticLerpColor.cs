using UnityEngine;

namespace SVBLM.StochasticParameters {
    [System.Serializable]
    public class StochasticLerpColor : StochasticIntervalValue<Color> {
        public override Color GetNewValue() {
            return Color.Lerp(MinValue, MaxValue, Random.value);
        }
    }
}
