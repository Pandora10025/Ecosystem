using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassStatesManager : MonoBehaviour
{
    GrassBaseState currentState;
    GrassGrowingState GrowingState = new GrassGrowingState();
    GrassWholeState WholeState = new GrassWholeState();
    GrassDyingState DyingState = new GrassDyingState();

    // Start is called before the first frame update
    void Start()
    {
        currentState = GrowingState;

        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
