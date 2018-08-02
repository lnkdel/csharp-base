using System.Collections;

namespace DataStructure
{
    public class CQueue
    {
        private ArrayList pqueue;
        public CQueue()
        {
            pqueue = new ArrayList();
        }

        public void EnQueue(object item)
        {
            pqueue.Add(item);
        }
        public void DeQueue()
        {
            pqueue.RemoveAt(0);
        }
        public object Peek()
        {
            return pqueue[0];
        }
        public void Clear()
        {
            pqueue.Clear();
        }
        public int Count()
        {
            return pqueue.Count;
        }
    }
}
