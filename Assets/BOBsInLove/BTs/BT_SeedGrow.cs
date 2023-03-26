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
        /* Write here (method OnConstruction) the code that constructs the Behaviour Tree 
           Remember to set the root attribute to a proper node
           e.g.
            ...
            root = new Sequence();
            ...

          A behaviour tree can use other behaviour trees.  
      */
        FLOWER_Blackboard bl = (FLOWER_Blackboard)blackboard;

        m_TimeToGrow = Random.Range(6.0f, 14.0f);

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
