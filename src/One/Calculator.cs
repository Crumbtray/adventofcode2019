namespace One
{
    public static class Calculator
    {
        public static int GetFuel(int mass)
        {
            return (mass / 3) - 2;
        }

        public static int GetFinalFuelForFuel(int fuel)
        {
            int subFuel = GetFuel(fuel);

            if (subFuel <= 0)
            {
                return fuel + 0;
            }
            else
            {
                return fuel + GetFinalFuelForFuel(subFuel);
            }
        }
    }
}