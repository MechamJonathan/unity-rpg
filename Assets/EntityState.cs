using UnityEngine;

public class EntityState
{
    protected StateMachine stateMachine;
    protected string stateName;

    public EntityState(StateMachine stateMachine, string stateName)
    {
        this.stateMachine = stateMachine;
        this.stateName = stateName;
    }

    public virtual void Enter()
    {
        Debug.Log("Entering " + stateName);
    }

    public virtual void Update()
    {
        Debug.Log("Running update of " + stateName);
    }

    public virtual void Exit()
    {
        Debug.Log("Exiting " + stateName);

    }
}
