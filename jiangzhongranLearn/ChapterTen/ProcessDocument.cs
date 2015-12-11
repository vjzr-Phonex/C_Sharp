using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ChapterTen
{
    class ProcessDocuments
    {
        private DocumentManager documentManager = null;

        public static void Start(DocumentManager dm)
        {
            new Thread(new ProcessDocuments(dm).Run).Start();
        }

        protected ProcessDocuments(DocumentManager dm)
        {
            documentManager = dm;
        }

        protected void Run()
        { 
            while(true)
            {
                if (documentManager.IsDocumentAvailable())
                {
                    Document doc = documentManager.getDocument();
                    Console.WriteLine("Processing document {0}",doc.Title);
                }
            }
            Thread.Sleep(new Random().Next(20));
        }
    }
}
