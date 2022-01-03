using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExcercise
{
    public class LinkedList
    {
        private Node FirstNode;
        private Node LastNode;

        private class Node
        {
            protected internal int value;
            protected internal Node next;

            public Node(int _value)
            {
                this.value = _value;
            }
        }

        public void addLast(int item)
        {
            var node = new Node(item);

            if (FirstNode == null)
            {
                FirstNode = node;
                LastNode = node;
            }
            else
            {
                LastNode.next = node;
                LastNode = node;
            }
        }

        public void addFirst(int item)
        {
            var node = new Node(item);
            if(FirstNode == null)
            {
                FirstNode = node;
                LastNode = node;
            }
            else
            {
                node.next = FirstNode;
                FirstNode = node;
            }
        }

        public int IndexOf(int item)
        {
            int index = 0; //O(1)
            var currentNodeToLoop = FirstNode; //O(1)

            while(currentNodeToLoop != null) // O(n)
            {
                //index++;
                if (currentNodeToLoop.value == item)
                    return index;

                currentNodeToLoop = currentNodeToLoop.next;
                index++;
            }
            return -1;
        } //O(2 + n) ==> O(n)


        public bool contains(int item)
        {
            return (IndexOf(item) != -1);

            // OR


            //var currentNodeToLoop = FirstNode;

            //while(currentNodeToLoop != null)
            //{
            //    if (currentNodeToLoop.value == item)
            //        return true;

            //    currentNodeToLoop = currentNodeToLoop.next;
            //}
            //return false;
        }

        public void removeFirst(int item)
        {
            if (FirstNode == null)
                throw new Exception();

            if (FirstNode == LastNode)
            {
                FirstNode = LastNode = null;
                return;
            }

            var nextValueReferencingTheSecondNode = FirstNode.next;
            FirstNode.next = null;
            FirstNode = nextValueReferencingTheSecondNode;
        }

        public void removeLast()
        {
            if (FirstNode == null)
                throw new Exception();

            if (FirstNode == LastNode)
            {
                FirstNode = LastNode = null;
                return;
            }

            var currentNodeToLoop = FirstNode;
            while(currentNodeToLoop != null)
            {
                if (currentNodeToLoop.next == LastNode)
                {
                    LastNode = currentNodeToLoop;
                    LastNode.next = null;
                    //return currentNodeToLoop;

                    // break;
                }
                currentNodeToLoop = currentNodeToLoop.next;
            }
        }
    }
}
