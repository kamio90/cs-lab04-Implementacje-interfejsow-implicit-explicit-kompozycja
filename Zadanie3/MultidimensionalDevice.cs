using System;
using Zadanie1;
using Zadanie2;

namespace Zadanie3
{
    public class MultidimensionalDevice : BaseDevice
    {
        private int _sendCounter;
        private int _reciveCounter;
        private int _counter;
        private int _number;

        public IFax Fax { get; set; }
        public IPrinter Printer { get; set;}
        public IScanner Scanner { get;set; }

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

       public void PrinterOn()
        {
            switch (state)
            {
                case IDevice.State.@on:
                    Printer.PowerOn();
                    break;
                case IDevice.State.off:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        } 
        public void PrinterOff() => Printer.PowerOff();

        public void ScannerOn()
        {
            switch (state)
            {
                case IDevice.State.@on:
                    Scanner.PowerOn();
                    break;
                case IDevice.State.off:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void ScannerOff() => Scanner.PowerOff();
        
        public void FaxOn()
        {
            switch (state)
            {
                case IDevice.State.@on:
                    Fax.PowerOn();
                    break;
                case IDevice.State.off:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void FaxOff() => Fax.PowerOff();
        public void Scan(out IDocument document, IDocument.FormatType formatType = IDocument.FormatType.JPG) => Scanner.Scan(out document, formatType);
        public void Print(in IDocument document) => Printer.Print(in document);

        public void Send(out IDocument doc, int number)
        {
            Scan(out doc);
            
            switch (state)
            {
                case IDevice.State.@on:
                    Fax.Send(out doc, number);
                    break;
                case IDevice.State.off:
                    Console.WriteLine("Can't send a document when Scanner is turned off!");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Receive(in IDocument doc, int number)
        {
            switch (state)
            {
                case IDevice.State.@on:
                    Fax.Receive(doc, number);
                    Print(doc);
                    break;
                case IDevice.State.off:
                    Console.WriteLine("Can't receive a document when Printer is turned off!");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}