using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class GrassGrowingState : GrassBaseState
{
    Vector3 startingGrassPos = new Vector3(1.76f,-5.73f,0.0f);
    Vector3 growGrassScalor = new Vector3(0.0f, 0.1f,0.0f);

    public override void EnterState(GrassStatesManager grass)
    {
        grass.transform.localPosition = startingGrassPos;
    }

    public override void UpdateState(GrassStatesManager grass)
    {
        if (grass.transform.localPosition.y < -4.20)
        {
            grass.transform.localPosition += growGrassScalor * Time.deltaTime;
        }
        else
        {
            grass.SwitchState(grass.WholeState);
        }
    }

    public override void OnCollisionEnter(GrassStatesManager grass)
    {

    }
}
