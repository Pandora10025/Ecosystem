using UnityEngine;

public class GrassGrowingState : GrassBaseState
{
    public override void EnterState(GrassStatesManager apple)
    {
        Debug.Log("Hello from the growing state!");
    }

    public override void UpdateState(GrassStatesManager apple)
    {

    }

    public override void OnCollisionEnter(GrassStatesManager apple)
    {

    }
}
