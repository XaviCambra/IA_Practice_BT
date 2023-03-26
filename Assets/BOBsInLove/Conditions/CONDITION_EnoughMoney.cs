using UnityEngine;
using BTs;

public class CONDITION_EnoughMoney : Condition
{
    public override bool Check()
    {
        return ((BOB_Blackboard)blackboard).EnoughMoney();
    }
}
