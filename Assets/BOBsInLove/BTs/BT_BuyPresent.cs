using UnityEngine;
using BTs;

[CreateAssetMenu(fileName = "BT_BuyPresent", menuName = "Behaviour Trees/BT_BuyPresent", order = 1)]
public class BT_BuyPresent : BehaviourTree
{
    
    public BT_BuyPresent()  { 
        
    }
    
    public override void OnConstruction()
    {
        new Sequence(
            new ACTION_Arrive("TheJewellery", "1.0"),
            new Selector(
                new Sequence(
                    new CONDITION_IsRing(),
                    new ACTION_PayJewel(),
                    new ACTION_ActivateRing()
                ),
                new Sequence(
                    new ACTION_PayJewel(),
                    new ACTION_ActivateNecklace()
                )
            )
        );
    }
}
