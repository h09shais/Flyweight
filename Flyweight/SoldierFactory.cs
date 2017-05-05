namespace Flyweight
{
    public class SoldierFactory
    {
        /// <summary>
        /// Pool for one soldier only if there are more soldier types this can be an array or list or better a HashMap
        /// </summary>
        private static ISoldier soldier;

        /// <summary>
        /// getFlyweight
        /// </summary>
        /// <returns></returns>
        public static ISoldier GetSoldier()
        {
            // this is a singleton 
            // if there is no soldier create the soldier 
            // return the only soldier reference
            return soldier ?? (soldier = new Robocop());
        }
    }
}
