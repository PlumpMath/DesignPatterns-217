using System;

namespace DesignPatterns.Adapter
{
    public class FightingFarmerAdapter : IFighter
    {
        private readonly Farmer _farmer;

        public FightingFarmerAdapter(Farmer farmer)
        {
            _farmer = farmer;
        }

        public void Move()
        {
            _farmer.Move();
        }

        public void Attack()
        {
            Console.WriteLine("Farmer attacked with pitch fork");
        }
    }
}