using System;

namespace DesignPatterns.Creational.Singleton
{
    /// <summary>
    /// Thread safe class that returns the same instance of an object
    /// </summary>
    public class Singleton
    {
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
        
        private Singleton() 
        { 
        }

        public static Singleton Instance => _instance.Value;
    }
}
