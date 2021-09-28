using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Criando documento de papel ----------");
            PaperDocumentCreator paperDocumentCreator = new PaperDocumentCreator();
            IDocument paperDocument = paperDocumentCreator.CreateDocument();
            paperDocument.OpenDocument();
            paperDocument.CloseDocument();

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("--------- Criando documento de plástico ----------");
            PlasticDocumentCreator plasticDocumentCreator = new PlasticDocumentCreator();
            IDocument plasticDocument = plasticDocumentCreator.CreateDocument();
            plasticDocument.OpenDocument();
            plasticDocument.CloseDocument();

            Console.ReadKey();

        }
    }
}
