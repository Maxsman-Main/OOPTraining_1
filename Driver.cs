namespace InteractrionOfClasses
{
    class Driver
    {
        private string name;
        private int cash;
        private static Chief chief;
        
        public Driver()
        {
            name = null;
            chief = null;
        }
        public Driver(string name, Chief mainChief)
        {
            this.name = name;
            chief = mainChief;
        }
        
        public string getName()
        {
            return name;
        }
        
        public int getCash()
        {
            return cash;
        }

        private void doWork()
        {
            //do some work
        }

        public void startWork()
        {
            doWork();
            cash += chief.giveMoney(name);
        }
    }
}