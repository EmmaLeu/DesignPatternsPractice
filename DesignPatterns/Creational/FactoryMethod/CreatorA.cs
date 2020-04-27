﻿namespace DesignPatterns.Creational.FactoryMethod
{
    public class CreatorA : Creator
    {
        public override IProduct ProductFactory()
        {
            return new ProductA();
        }
    }
}
