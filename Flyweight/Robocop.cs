﻿namespace Flyweight
{
    using System;

    public class Robocop : ISoldier
    {
        /// <summary>
        /// This method accepts soldier location Soldier Location is Extrinsic and no reference to previous location or new location is maintained inside the flyweight implementation
        /// </summary>
        /// <param name="previousLocationX"></param>
        /// <param name="previousLocationY"></param>
        /// <param name="newLocationX"></param>
        /// <param name="newLocationY"></param>
        public void MoveSoldier(int previousLocationX, int previousLocationY, int newLocationX, int newLocationY)
        {
            // delete soldier representation from previous location 
            // then render soldier representation in new location 	
            Console.WriteLine("Previous location X: {0}, Previous location Y: {1}, New location X: {2}, New location Y: {3}", previousLocationX, previousLocationY, newLocationX, newLocationY);
        }
    }
}
