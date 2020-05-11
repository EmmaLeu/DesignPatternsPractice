namespace DesignPatterns.Behavioral.Mediator
{
    /// <summary>
    /// We want these types of objects to be reusable, not the <see cref="IMediator"/>
    /// </summary>
    public abstract class Colleague
    {
        protected readonly IMediator _mediator;

        public Colleague (IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
