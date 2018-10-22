namespace Flyweight
{
    public interface ISoldier
    {
        /// <summary>
        /// Move Soldier From Old Location to New Location. Note that soldier location is extrinsic to the Flyweight Implementation
        /// </summary>
        /// <param name="previousX">The previous location X</param>
        /// <param name="previousY">The previous location Y</param>
        /// <param name="newX">The new location X</param>
        /// <param name="newY">The new location Y</param>
        void MoveSoldier(int previousX, int previousY, int newX, int newY);
    }
}
