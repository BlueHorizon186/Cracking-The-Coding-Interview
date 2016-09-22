using System;

public class NewStack<T>
{
    private Node<T> top;
    public int Size { get; set; }

    public NewStack()
    {
        top = null;
        Size = 0;
    }

    public void PushElement(T data)
    {
        if (top == null)
        {
            top = new Node<T>(data);
            Size++;
            return ;
        }

        var newElement = new Node<T>(data);
        newElement.Next = top;
        top = newElement;
    }

    public void PrintStack()
    {
        var runner = top;

        Console.Write("{ ");
        while (runner != null)
        {
            Console.Write("{0} ", runner.ToString());
            runner = runner.Next;
        }
        Console.Write("}\n");
    }
}

public class Tester
{
    static void Main(string[] args)
    {
        var stInt = new NewStack<int>();
        var stStr = new NewStack<string>();

        for (int i = 0; i < 5; i++) stInt.PushElement(i);

        stStr.PushElement("Hello!");
        stStr.PushElement("I'm a string!");
        stStr.PushElement("I'm using the same NewStack implementation!");
        stStr.PushElement("LolPol Test!");
        stStr.PushElement("I'm the fifth one!");

        Console.WriteLine("Integer Stack:");
        stInt.PrintStack();
        Console.WriteLine("\nString Stack:");
        stStr.PrintStack();
    }
}
