namespace Flyweight
{
    public class SoldierClient
    {
        private ISoldier soldier = SoldierFactory.GetSoldier();
        private int currentLocationX;
        private int currentLocationY;
        public void MoveSoldier(int newLocationX, int newLocationY)
        {

            // here the actual rendering is handled by the flyweight object 
            this.soldier.moveSoldier(this.currentLocationX, this.currentLocationY, newLocationX, newLocationY);

            // this object is responsible for maintaining the state
            // that is extrinsic to the flyweight
            this.currentLocationX = newLocationX;

            this.currentLocationY = newLocationY;
        }
    }
}
