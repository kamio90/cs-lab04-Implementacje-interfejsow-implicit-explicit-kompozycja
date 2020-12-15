namespace Zadanie1
{
    public class Copier
    {
        private int _printCounter;
        private int _scanCounter;

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