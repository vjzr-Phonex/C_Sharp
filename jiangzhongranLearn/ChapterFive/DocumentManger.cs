using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFive
{
    class DocumentManger<T>
    {
        private readonly Queue<T> documentQueue = new Queue<T>();

        public void AddDocument(T doc)
        {
            lock (this)
            {
                documentQueue.Enqueue(doc);
            }
        }

        public bool IsDocumentAviable
        { 
            get { return documentQueue.Count > 0;}
        }

        public T GetDocument()
        {
            T doc = default(T);
            lock (this)
            {
                doc = documentQueue.Dequeue();
            }
            return doc;
        }
    }
}
