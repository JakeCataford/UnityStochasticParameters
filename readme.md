Stochastic Parameters For Unity
--------------------

Stochastic parameters are a fancy word for random variables. These are a little special in the sense that once you obtain a value from a stochastic parameter, the value remains constant until you call `Reset()` on the parameter.

How to use them:

```c#
public class MyBehaviour : MonoBehaviour {
  // These are serializable objects with custom property drawer so they are initialized for you
  public StochasticInteger RandomInt;
  public StochasticInteger RandomFloat;

  private void Start() {
    RandomInt.MinValue = 0;
    RandomInt.MaxValue = 10;
    RandomInt.Value //=> 5
    RandomInt.Value //=> ...still 5

    RandomFloat.MinValue = 0f;
    RandomFloat.MaxValue = 10.0f;
    RandomFloat.Value //=> 5.0f
    RandomFloat.Value //=> ...still 5.0f
  }
}
```

They are also pretty easy to extend, but you will have to define your own property drawer as well:

```c#
public class MyStochasticValue : StochasticIntervalValue<MyType> {
  public override MyType GetNewValue() {
    // Do something with MinValue and MaxValue to get your random thing
  }
}
```
