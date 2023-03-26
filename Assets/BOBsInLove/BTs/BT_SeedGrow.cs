using UnityEngine;
using BTs;

[CreateAssetMenu(fileName = "BT_SeedGrow", menuName = "Behaviour Trees/BT_SeedGrow", order = 1)]
public class BT_SeedGrow : BehaviourTree
{
    private float m_TimeToGrow;

     // construtor
    public BT_SeedGrow()  { 
        /* Receive BT parameters and set them. Remember all are of type string */
    }
    
    public override void OnConstruction()
    {
        FLOWER_Blackboard bl = (FLOWER_Blackboard)blackboard;

        m_TimeToGrow = Random.Range(15.0f, 30.0f);

        root = new Sequence(
            new ACTION_WaitForSeconds(((int)m_TimeToGrow).ToString()),
            new LambdaAction(() =>
            {
                bl.FromSeedToFlower();
                return Status.SUCCEEDED;
            }
            )
        );

        
    }
}
