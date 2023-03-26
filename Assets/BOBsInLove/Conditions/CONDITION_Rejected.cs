using UnityEngine;
using BTs;

public class CONDITION_Rejected : Condition
{

    // Constructor
    public CONDITION_Rejected()  {
        /* Receive function parameters and set them */
    }

    public override bool Check ()
    {
        return ((BOB_Blackboard)blackboard).rejected;
    }

}
