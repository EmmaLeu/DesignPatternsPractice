namespace DesignPatterns.Behavioral.Mediator
{
    /// <summary>
    /// Interface for controlling and coordinating the interaction (updates) among <see cref="Colleague"/>s
    /// </summary>
    /// <remarks>Its complexity grows as the number of <see cref="Colleague"/>s grow!!!</remarks>
    public interface IMediator
    {
        void Mediate(Colleague colleague);
    }
}
