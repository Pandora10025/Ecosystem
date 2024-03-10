using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassStatesManager : MonoBehaviour
{
    GrassBaseState currentState;
    public GrassGrowingState GrowingState = new GrassGrowingState();
    public GrassWholeState WholeState = new GrassWholeState();
    public GrassDyingState DyingState = new GrassDyingState();

    // Start is called before the first frame update
    void Start()
    {
        currentState = GrowingState;

        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {

        currentState.UpdateState(this);

    }
    
   public void SwitchState(GrassBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
