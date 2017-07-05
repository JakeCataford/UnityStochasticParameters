using System.Collections;
using System.Collections.Generic;
using SVBLM.StochasticParameters;
using UnityEngine;

namespace SVBLM.StochasticParameters {
    [System.Serializable]
    public abstract class StochasticIntervalValue<T> : IStochasticParameter<T> {
        [SerializeField] public T MinValue;
        [SerializeField] public T MaxValue;

        private T _value;
        private bool _hasValue;

        public T Value {
            get {
                if (!_hasValue) {
                    _value = GetNewValue();
                    _hasValue = true;
                }

                return _value;
            }
        }

        public abstract T GetNewValue();

        public void Reset() {
            _hasValue = false;
        }
    }
}