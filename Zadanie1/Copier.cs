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

        private bool CanOperate(in IDocument document, int value, string stringValue)
        {
            switch (state)
            {
                case IDevice.State.@on:
                    ++value;
                    Console.Write(stringValue);            
                    return true;
                case IDevice.State.off:
                    return false;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Print(in IDocument document) =>
            CanOperate(document, _printCounter, $" {DateTime.Now} Scan: {document.GetFileName()}");

        public void Scan(out IDocument document, IDocument.FormatType formatType) => document != null &&
            CanOperate(document, _scanCounter, $"{DateTime.Now} Scan: ${document.GetFileName()}")
            ? document = formatType switch
            {
                IDocument.FormatType.TXT => new TextDocument($"TextScan{_scanCounter}.txt"),
                IDocument.FormatType.PDF => new PDFDocument($"PDFScan{_scanCounter}.pdf"),
                IDocument.FormatType.JPG => new ImageDocument($"ImageScan{_scanCounter}.pdf"),
                _ => throw new FormatException()
            }
            : throw new ApplicationException();
        
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