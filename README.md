# CustomEventSystem
It is a simple but useful custom event that can invoke multiple parameters.

# Usage

###### 1) You need to invoke an event

```C#
using UnityEngine;
using CustomEventSystem;

public class ExampleInvokerScript : MonoBehaviour
{
    private void Start()
    {
        CalculateSomething();    
    }
    
    private void CalculateSomething()
    {
        int result = 7 + 3;
        Events.IntegerEvent.Invoke(result);
    }
}
```

###### 2) Then add a listener for the event that you have invoked.

```C#
using UnityEngine;
using CustomEventSystem;

public class ExampleListenerScript : MonoBehaviour
{
    private void OnEnable()
    {
        Events.IntegerEvent.AddListener(DoSomething);
    }

    private void OnDisable()
    {
        Events.IntegerEvent.AddListener(DoSomething);
    }

    private void DoSomething(int i)
    {
        Debug.Log(i);
    }
}
```
