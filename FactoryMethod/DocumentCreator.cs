using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class DocumentCreator
    {
        public abstract IDocument CreateDocument();
    }
}
