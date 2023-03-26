using UnityEngine;
using BTs;

public class ACTION_Work : Action
{
    
    /* Declare action parameters here. 
       All public parameters must be of type string. All public parameters must be
       regarded as keys in/for the blackboard context.
       Use prefix "key" for input parameters (information stored in the blackboard that must be retrieved)
       use prefix "keyout" for output parameters (information that must be stored in the blackboard)

       e.g.
       public string keyDistance;
       public string keyoutObject 
     */
    
    // construtor
    public ACTION_Work()  { 
        /* Receive action parameters and set them */
    }

    private FSM_Work fsm;

    public override void OnInitialize()
    {
        fsm = ScriptableObject.CreateInstance<FSM_Work>();
        fsm.Construct(gameObject);
        //aqui faltan los parametros creo. REVISITAR
        fsm.OnEnter();
    }

    public override Status OnTick ()
    {
        fsm.Update();
        if (fsm.InSuccess()) return Status.SUCCEEDED;
        else if (fsm.InFailure()) return Status.FAILED;
        return Status.RUNNING;
        
    }

    public override void OnAbort()
    {
        fsm.OnExit();
    }

}
