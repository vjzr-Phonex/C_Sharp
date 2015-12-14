using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterTen
{
    class PriorityDocumentManagement
    {
        private readonly LinkedList<Document> documentList;
        private readonly List<LinkedListNode<Document>> priorityNodes;

        public PriorityDocumentManagement()
        {
            documentList = new LinkedList<Document>();

            priorityNodes = new List<LinkedListNode<Document>>(10);
            for (int i = 0; i < 10; i++)
            {
                priorityNodes.Add(new LinkedListNode<Document>(null));
            }
        }
    }
}
