using System;
using Zadanie1;

namespace Zadanie2
{
    public class MultifunctionalDevice: Copier, IFax
    {
        private int _sendCounter;
        private int _reciveCounter;
        private int _counter;
        private int _number;

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

        public void Send(out IDocument document, int number)
        {
            switch (state)
            {
                case IDevice.State.@on:
                    _sendCounter++;
                    break;
                case IDevice.State.off:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
           Scan(out document);
        }

        public void Recive(in IDocument document, int number)
        {
            switch (state)
            {
                case IDevice.State.@on:
                    _reciveCounter++;
                    break;
                case IDevice.State.off:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            Print(in document);
        }
    }
}