using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PlasticDocument : IDocument
    {
        public void CloseDocument()
        {
            Console.WriteLine("Fechando documento de plástico");
        }

        public void OpenDocument()
        {
            Console.WriteLine("Abrindo documento de plástico");
        }
    }
}
