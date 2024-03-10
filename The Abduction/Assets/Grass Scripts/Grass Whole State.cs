using UnityEngine;

public class GrassWholeState : GrassBaseState
{
    public override void EnterState(GrassStatesManager grass)
    {
        Debug.Log("I am Whole");
    }

    public override void UpdateState(GrassStatesManager grass)
    {

    }

    public override void OnCollisionEnter(GrassStatesManager grass)
    {

    }
}
