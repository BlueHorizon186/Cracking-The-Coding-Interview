using System;

namespace CrackingTheCodingInterview
{
    class NewStackNode<T>
    {
        public T Data { get; set; }
        public NewStackNode<T> Above { get; set; }
        public NewStackNode<T> Below { get; set; }

        public NewStackNode(T data)
        {
            Data = data;
            Above = null;
            Below = null;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
