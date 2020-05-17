namespace DesignPatterns.Behavioral.State
{
    /// <summary>
    /// Common interface for defining state specific behavior.
    /// State objects are responsible to change Context's current state dynamically when a state transition occurs
    /// </summary>
    public interface IState
    {
        string Operation(Context context);
    }
}
