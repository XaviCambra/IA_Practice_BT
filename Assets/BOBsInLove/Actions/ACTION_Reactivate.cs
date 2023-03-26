using UnityEngine;
using BTs;

public class ACTION_Reactivate : Action
{
    public string keyTarget;

    // construtor
    public ACTION_Reactivate()
    {

    }

    public ACTION_Reactivate(string keyTarget)
    {
        this.keyTarget = keyTarget;
    }

    public override Status OnTick ()
    {
        blackboard.Get<GameObject>(keyTarget).SetActive(false);
        blackboard.Get<GameObject>(keyTarget).SetActive(true);
        return Status.SUCCEEDED;
    }
}
