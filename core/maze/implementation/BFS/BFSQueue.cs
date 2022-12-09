using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.core.maze.implementation.BFS
{
    class BFSQueue
    {
        private Queue<Cell> mainQueue;
        private Queue<Cell> dropedQueue;

        public BFSQueue(Queue<Cell> cells)
        {
            mainQueue = cells;
            dropedQueue = new Queue<Cell>();
        }

        public Cell Dequeue()
        {
            if(mainQueue.Count > 0)
            {
                return mainQueue.Dequeue();
            }
            else
            {
                return dropedQueue.Dequeue();
            }
        }

        public void Enqueue(Cell cell)
        {
            mainQueue.Enqueue(cell);
        }

        public void DropMainQueue()
        {
            foreach(Cell cell in mainQueue)
            {
                dropedQueue.Enqueue(cell);
            }

            mainQueue.Clear();
        } 
        public void SetMainQueue(Queue<Cell> mainQueue)
        {
            this.mainQueue = mainQueue;
        }

        public void DropAndSetMainQueue(Queue<Cell> mainQueue)
        {
            DropMainQueue();

            SetMainQueue(mainQueue);
        }

        public long Count()
        {
            return mainQueue.Count + dropedQueue.Count;
        }
    }
}
