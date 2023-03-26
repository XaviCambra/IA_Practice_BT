using UnityEngine;
using BTs;

public class ACTION_ActivateRing : Action
{
    public override Status OnTick()
    {
        gameObject.GetComponent<BOB_Blackboard>().ActivateRing();
        return Status.SUCCEEDED;

    }
}
