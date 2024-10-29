using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praca_domowa_02
{
    internal class List
    {
        private Node head;
        private Node tail;
        private int count;

        public List()
        {
            //head = null;
            //tail = null;
            count = 0;
        }

        public void AddFirst(int liczba)
        {
            Node newNode = new Node(liczba);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }

            count++;
        }


        public override string ToString()
        {
            Node current = head;
            string result = "";

            while (current != null)
            {
                result += current.data.ToString();
                if (current.next != null)
                {
                    result += ", ";
                }
                current = current.next;
            }

            return result;
        }

        public void AddLast(int liczba)
        {
            Node newNode = new Node(liczba);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }

            count++;
        }

        public void RemoveFirst()
        {
            if (head != null)
            {
                if (head == tail) 
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.next;
                    head.prev = null;
                }

                count--;
            }
        }

        public void RemoveLast()
        {
            if (tail != null)
            {
                if (head == tail)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    tail = tail.prev;
                    tail.next = null;
                }

                count--;
            }
        }

        public int Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("Index out of bounds.");
            }

            Node current = head;
            int currentIndex = 0;

            while (current != null)
            {
                if (currentIndex == index)
                {
                    return current.data;
                }

                current = current.next;
                currentIndex++;
            }

            throw new Exception("Index not found.");
        }

    }
}
