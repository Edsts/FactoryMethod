using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PlasticDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new PlasticDocument();
        }
    }
}
