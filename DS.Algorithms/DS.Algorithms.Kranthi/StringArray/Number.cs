namespace DS.Algorithms.Kranthi.StringArray
{
    class Number
    {
        /// <summary>
        /// This method reverses the given number.
        /// It can be a positive or negative number.
        /// </summary>
        /// <param name="inputNumber">Input Number</param>
        /// <returns>Reverse of a given number</returns>
        internal static long Reverse(long inputNumber)
        {
            long reverseNumber = 0;
            sbyte signConverter = 1;

            if (inputNumber < 0)
            {
                signConverter = -1;
                inputNumber *= signConverter;
            }

            while (inputNumber > 0)
            {
                reverseNumber = (reverseNumber * 10) + (inputNumber % 10);
                inputNumber /= 10;
            }
            return reverseNumber * signConverter;
        }
    }
}
