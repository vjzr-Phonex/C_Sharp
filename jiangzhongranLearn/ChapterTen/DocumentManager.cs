using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterTen
{
    class DocumentManager
    {
        private readonly Queue<Document> documentQueue = new Queue<Document>();

        public void AddDocument(Document doc) 
        {
            lock (this)
            {
                documentQueue.Enqueue(doc);
            }
        }

        public Document getDocument()
        {
            Document doc = null;
            lock (this)
            {
                doc = this.documentQueue.Dequeue();
            }
            return doc;
        }

        public bool IsDocumentAvailable()
        { 
            return documentQueue.Count > 0;
        }
    }
}
