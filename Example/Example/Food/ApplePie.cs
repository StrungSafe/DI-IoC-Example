namespace Example.Food
{
    public class ApplePie
    {
        private bool isWarmed;

        private int percentOfPieLeft;

        public ApplePie()
        {
            isWarmed = false;
            percentOfPieLeft = 100;
        }

        public void Eat()
        {
            if (percentOfPieLeft == 0)
            {
                throw new NoOrangeLeftException();
            }

            percentOfPieLeft = 0;
        }

        public void Warm()
        {
            if (!isWarmed)
            {
                isWarmed = true;
            }
        }
    }
}