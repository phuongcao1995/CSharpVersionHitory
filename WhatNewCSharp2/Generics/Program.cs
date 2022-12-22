using System;

namespace Generics
{

    public class Node<T>
    {
        public T GenericObject { get; set; }
        public Node<T> ObjectNext { get; set; }

        public Node(T GenericObject)
        {
            this.GenericObject = GenericObject;
        }

        public T Data { get { return this.GenericObject; } }

        public Node<T> Next { get { return this.ObjectNext; } }

        public void Append (Node <T> newNode)
        {
            if(this.ObjectNext == null)
            {
                this.ObjectNext = newNode;
            }
            else
            {
                this.ObjectNext.Append (newNode);
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<String> objNode = new Node<string>("John Charles");
            Node<String> objNext = new Node<string>("olamendy");
            Node<String> objNext2 = new Node<string>("Drake");

            objNode.Append(objNext);
            objNode.Append(objNext2);
            //objNext.Append(objNext2);

            Node<int> nodeInt = new Node<int>(3);

            Node<int> nodeIntNext = new Node<int>(4);

            nodeInt.Append(nodeIntNext);

        }
    }
}
