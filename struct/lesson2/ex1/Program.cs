using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(24);
            linkedList.AddNode(37);
            linkedList.AddNode(8);

            Node nd = linkedList.FindNode(24);

            linkedList.AddNodeAfter(nd, 15);
            linkedList.GetCount();

            linkedList.RemoveNode(2);
            linkedList.RemoveNode(nd);
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }

    //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
    public interface ILinkedList
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value);  // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению
    }

    public class LinkedList : ILinkedList
    {
        private Node _startNode;
        private Node _endNode;
        private int _count; 

        public void AddNode(int value)
        {
            if (_startNode == null)
            {
                _startNode = new Node { Value = value };
                _endNode = _startNode;
            } 
            else
            {
                Node newNode = new Node { Value = value };
                _endNode.NextNode = newNode;
                newNode.PrevNode = _endNode;
                _endNode = newNode;
            }
            _count++;
        }

        public void AddNodeAfter(Node node, int value)
        {   
            if (node != _endNode)
            {
                Node newNode = new Node { Value = value };

                newNode.NextNode = node.NextNode;
                newNode.PrevNode = node;

                node.NextNode.PrevNode = newNode;
                node.NextNode = newNode;

                _count++;
            }
            else
            {
                this.AddNode(value);
            }
           
        }

        public Node FindNode(int searchValue)
        {
            Node curNode = _startNode;

            while (curNode.NextNode != null)
            {
                if (curNode.Value == searchValue)
                {
                    return curNode;
                }

                curNode = curNode.NextNode;
            }
            return null;
        }

        public int GetCount()
        {
            return _count;
        }

        public void RemoveNode(int index)
        {
            if (index <= _count)
            {
                if (index == 0)
                {
                    this.RemoveNode(_startNode);
                }
                else if (index == _count)
                {
                    this.RemoveNode(_endNode);
                }
                else
                {
                    Node targetNode = _startNode;
                    for (int i = 1; i <= index; i++)
                    {
                        targetNode = targetNode.NextNode;
                    }

                    this.RemoveNode(targetNode);
                }
            }
        }

        public void RemoveNode(Node node)
        {
            if (node.Equals(_startNode))
            {
                node.NextNode.PrevNode = null;
                node.NextNode = null;
                _startNode = node;
            } 
            else if (node.Equals(_endNode))
            {
                node.PrevNode.NextNode = null;
                node.PrevNode = null;
                _endNode = node;
            }
            else
            {
                node.PrevNode.NextNode = node.NextNode;
                node.NextNode.PrevNode = node.PrevNode;
                node.PrevNode = null;
                node.NextNode = null;
            }
            _count--;
        }
    }
}
