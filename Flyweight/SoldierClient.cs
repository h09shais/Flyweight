namespace Flyweight
{
    public class SoldierClient
    {
        private readonly ISoldier _soldier = SoldierFactory.GetSoldier();
        private int _currentX;
        private int _currentY;
        public void MoveSoldier(int newX, int newY)
        {

            // here the actual rendering is handled by the flyweight object 
            this._soldier.MoveSoldier(this._currentX, this._currentY, newX, newY);

            // this object is responsible for maintaining the state
            // that is extrinsic to the flyweight
            this._currentX = newX;
            this._currentY = newY;
        }
    }
}
