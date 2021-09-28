using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PaperDocument : IDocument
    {
        public void CloseDocument()
        {
            Console.WriteLine("Fechando documento de papel");
        }

        public void OpenDocument()
        {
            Console.WriteLine("Abrindo documento de papel");
        }
    }
}
