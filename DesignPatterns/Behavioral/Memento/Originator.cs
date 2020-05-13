namespace DesignPatterns.Behavioral.Memento
{
    /// <summary>
    /// Saves it's current state to a memento. Clients are responsible to restore it's state
    /// </summary>
    public class Originator
    {
        private string _state;

        /// <summary>
        /// Saves state to a memento
        /// </summary>
        /// <remarks>Careful with immutable reference types</remarks>
        public Memento CreateMememto()
        {
            var memento = new MementoPrivate();
            memento.SetState(_state);
            return memento;
        }

        public void Restore(Memento memento)
        {
            _state = (memento as MementoPrivate).GetState();
        }

        public string State 
        {
            get
            {
                return _state;
            }
            set
            {
                if(value != _state)
                {
                    _state = value;
                }
            }
        }

        public abstract class Memento
        {
            protected Memento() { }
        }

        /// <summary>
        /// Stores Originators' internal state
        /// All members accessible to Originator only. 
        /// </summary>
        private class MementoPrivate : Memento
        {
            private string _state;

            internal string GetState()
            {
                return _state;
            }

            internal void SetState(string state)
            {
                _state = state;
            }
        }
    }
}
