using UnityEngine;
using BTs;

[CreateAssetMenu(fileName = "BT_BigBob", menuName = "Behaviour Trees/BT_BigBob", order = 1)]
public class BT_BigBob : BehaviourTree
{
    public BT_BigBob()  { 
        
    }
    
    public override void OnConstruction()
    {
        BT_WorkForMoney work = ScriptableObject.CreateInstance<BT_WorkForMoney>();
        BT_MakeBouquet makeBouquet = ScriptableObject.CreateInstance<BT_MakeBouquet>();
        BT_BuyPresent jewel = ScriptableObject.CreateInstance<BT_BuyPresent>();

        Sequence sq = new Sequence(
            work,
            makeBouquet,
            jewel,
            new ACTION_Arrive("daisys","1.0"),
            new ACTION_Speak("Would you marry me?")
        );
        root = sq;
    }
}
