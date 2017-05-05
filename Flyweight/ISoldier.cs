namespace Flyweight
{
    public interface ISoldier
    {
        /// <summary>
        /// Move Soldier From Old Location to New Location. Note that soldier location is extrinsic to the Flyweight Implementation
        /// </summary>
        /// <param name="previousLocationX">The previous location X</param>
        /// <param name="previousLocationY">The previous location Y</param>
        /// <param name="newLocationX">The new location X</param>
        /// <param name="newLocationY">The new location Y</param>
        void moveSoldier(int previousLocationX, int previousLocationY, int newLocationX, int newLocationY);
    }
}
