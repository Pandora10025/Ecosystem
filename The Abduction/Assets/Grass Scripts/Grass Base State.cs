using UnityEngine;

public abstract class GrassBaseState 
{
   public abstract void EnterState(GrassStatesManager apple);

   public abstract void UpdateState(GrassStatesManager apple);

   public abstract void OnCollisionEnter(GrassStatesManager apple);

}
