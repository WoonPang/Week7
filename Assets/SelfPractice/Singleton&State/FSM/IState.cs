public interface IState
{
    public void Enter()
    {
        // code that runs when we first enter the state
    }

    public void Update()
    {
        // per-frame logic, +condition to transtion to a new state
    }

    public void Exit()
    {
        // code that runs when we exit the state
    }
}