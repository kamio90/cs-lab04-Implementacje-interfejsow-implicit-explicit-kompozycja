using System;
using Zadanie1;
using Zadanie2;

namespace Zadanie3
{
    public class MultidimensionalDevice
    {
        private int _sendCounter;
        private int _reciveCounter;
        private int _counter;
        private int _number;

        private IFax _fax;
        private IPrinter _printer;
        private IScanner _scanner;

        public int SendCounter
        {
            get => _sendCounter;
            set => _sendCounter = value;
        }

        public int ReciveCounter
        {
            get => _reciveCounter;
            set => _reciveCounter = value;
        }

        public int Counter
        {
            get => _counter;
            set => _counter = value;
        }

        public int Number
        {
            get => _number;
            set => _number = value;
        }
    }
}