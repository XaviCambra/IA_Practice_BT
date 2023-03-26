using UnityEngine;
using BTs;

[CreateAssetMenu(fileName = "BT_WorkForMoney", menuName = "Behaviour Trees/BT_WorkForMoney", order = 1)]
public class BT_WorkForMoney : BehaviourTree
{
    public BT_WorkForMoney()  
    {

    }
    
    public override void OnConstruction()
    {
        RepeatUntilSuccessDecorator work = new RepeatUntilSuccessDecorator(
            new Selector(
                new CONDITION_EnoughMoney(),
                new Sequence(
                    new ACTION_Work(),
                    new ACTION_GetPaid(),
                    new ACTION_Fail()
                    )
                )
        );

        root = work;
    }
}
