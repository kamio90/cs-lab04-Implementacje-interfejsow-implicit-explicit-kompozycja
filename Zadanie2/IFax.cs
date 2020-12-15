using Zadanie1;

namespace Zadanie2
{
   public interface IFax : IDevice
   {
      void Send(out IDocument document, int number);
      void Recive(in IDocument document, int number);
   }
}