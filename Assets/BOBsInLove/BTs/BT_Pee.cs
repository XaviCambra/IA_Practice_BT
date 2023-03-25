using BTs;
using UnityEngine;

[CreateAssetMenu(fileName = "BT_Pee", menuName = "Behaviour Trees/BT_Pee", order = 1)]
public class BT_Pee : BehaviourTree
{
    /* If necessary declare BT parameters here. 
       All public parameters must be of type string. All public parameters must be
       regarded as keys in/for the blackboard context.
       Use prefix "key" for input parameters (information stored in the blackboard that must be retrieved)
       use prefix "keyout" for output parameters (information that must be stored in the blackboard)

       e.g.
       public string keyDistance;
       public string keyoutObject 

       NOTICE: BT's with parameters cannot be constructed using ScriptableObject.CreateInstance<>
       An explicit constructor with new must be used. Unity will complain...
       Whenever possible, use parameter-less BT's. Use blackboard to pass information.
       TOP-level BTs (those attached to the executor) cannot have parameters
       
       In future versions, BT parameters may cease to exit

     */

    // construtor
    public BT_Pee()
    {
        /* Receive BT parameters and set them. Remember all are of type string */
    }

    public override void OnConstruction()
    {
        BOB_Blackboard bl = (BOB_Blackboard)blackboard;

        Sequence dyn = new Sequence(
            new ACTION_Speak("Gotta take a leak..."),
            new ACTION_Arrive("wc"),
            new ACTION_Quiet(),
            new LambdaAction(() =>
            {
                bl.CloseDoor();
                return Status.SUCCEEDED;
            }),
            new ACTION_WaitForSeconds("4"),
            new LambdaAction(() =>
            {
                bl.OpenDoor();
                return Status.SUCCEEDED;
            }),
            new ACTION_Speak("OH!!! I needed this"),
            new ACTION_WaitForSeconds("2"),
            new ACTION_Quiet(),
            new LambdaAction(() =>
            {
                bl.PeeAlarmOff();
                return Status.SUCCEEDED;
            })
        );
        
        root = dyn;


    }
}
