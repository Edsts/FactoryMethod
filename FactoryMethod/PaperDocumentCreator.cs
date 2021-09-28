using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class PaperDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new PaperDocument();
        }
    }
}
