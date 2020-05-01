using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Flyweight
{
    /// <summary>
    /// Singleton responsible with creating Flyweight objects
    /// Mantains a pool of flyweight objects (creates one if key doesn't exist, returns existing one otherwise)
    /// </summary>
    public class FlyweightFactory
    {
        private readonly IDictionary<string, IFlyweight> _flyweightPool = new Dictionary<string, IFlyweight>();

        private readonly object _lockObject = new object();

        private static readonly Lazy<FlyweightFactory> _instance = new Lazy<FlyweightFactory>(() => new FlyweightFactory());

        private FlyweightFactory()
        {
        }

        public static FlyweightFactory Instance => _instance.Value;

        public IFlyweight GetFlyweight(string key)
        {
            lock (_lockObject)
            {
                if (_flyweightPool.TryGetValue(key, out var value))
                {
                    return value;
                }

                var flyweight = new SharedFlyweight(key);
                _flyweightPool.Add(key, flyweight);
                return flyweight;
            }
        }

        public int GetSize()
        {
            return _flyweightPool.Count;
        }
    }
}
