using UnityEngine;

public abstract class GrassBaseState 
{
   public abstract void EnterState(GrassStatesManager grass);

   public abstract void UpdateState(GrassStatesManager grass);

   public abstract void OnCollisionEnter(GrassStatesManager grass);

}
