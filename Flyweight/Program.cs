namespace Flyweight
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // start war 

            // draw war terrain 

            // create 5 soldiers:
            var warSoldiers = new[] {
                new SoldierClient(),
                new SoldierClient(),
                new SoldierClient(),
                new SoldierClient(),
                new SoldierClient()
            };

            // move each soldier to his location 
            // take user input to move each soldier 
            warSoldiers[0].MoveSoldier(17, 2112);

            // 	take user input to move each soldier 
            warSoldiers[1].MoveSoldier(137, 112);

            // note that there is only one SoldierImp ( flyweight Imp)
            // for all the 5 soldiers 
            // Soldier Client size is small due to the small state it maintains
            // SoliderImp size might be large or might be small 
            // however we saved memory costs of creating 5 Soldier representations

            Console.ReadLine();
        }
    }
}
