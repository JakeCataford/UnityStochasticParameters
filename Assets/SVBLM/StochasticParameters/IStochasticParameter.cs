using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVBLM.StochasticParameters {
    public interface IStochasticParameter<T> {
        T Value { get; }
        void Reset();
    }
}
