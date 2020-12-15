namespace Zadanie1
{
    public class Copier
    {
        private int _printCounter;
        private int _scanCounter;
        private int _counter;

        public int Counter
        {
            get => _counter;
            set => _counter = value;
        }

        public int PrintCounter
        {
            get => _printCounter;
            set => _printCounter = value;
        }

        public int ScanCounter
        {
            get => _scanCounter;
            set => _scanCounter = value;
        }
    }
}