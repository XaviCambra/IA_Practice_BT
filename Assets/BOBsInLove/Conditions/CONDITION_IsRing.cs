using UnityEngine;
using BTs;

public class CONDITION_IsRing : Condition
{
    public override bool Check ()
    {
        return ((BOB_Blackboard)blackboard).IsRing();
    }

}
