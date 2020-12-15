using System;

namespace Zadanie1
{
    public class Copier : BaseDevice, IScanner, IPrinter
    {
        private int _printCounter;
        private int _scanCounter;
        private int _counter;

        public int Counter
        {
            get => _counter;
            set => _counter = value;
        }

        public void Print(in IDocument document)
        {
            switch (state)
            {
                case IDevice.State.@on:
                    _printCounter++;
                    Console.Write($" { DateTime.Now } Scan: { document.GetFileName() } ");
                    break;
                case IDevice.State.off:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Scan(out IDocument document, IDocument.FormatType formatType)
        {
            throw new System.NotImplementedException();
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