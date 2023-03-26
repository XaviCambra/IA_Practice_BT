using UnityEngine;
using BTs;

public class ACTION_PayJewel : Action
{
    public override Status OnTick()
    {
        gameObject.GetComponent<BOB_Blackboard>().PayJewel();
        return Status.SUCCEEDED;
    }
}
