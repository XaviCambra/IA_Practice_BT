using UnityEngine;
using BTs;

public class ACTION_ActivateNecklace : Action
{
    
    public override Status OnTick ()
    {
        gameObject.GetComponent<BOB_Blackboard>().ActivateNecklace();
        return Status.SUCCEEDED;

    }
}
