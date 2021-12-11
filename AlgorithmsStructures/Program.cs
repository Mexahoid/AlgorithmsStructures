using Structures.Interfaces;
using Structures.List;
using Structures.Stack;
using Structures.Queue;

Console.WriteLine($"Hello, World!");


TestQueues();
TestLists();
TestStacks();



static void TestQueues()
{
    Console.WriteLine("=== Queue tests.");

    Console.WriteLine("== Making queues..");
    IMyQueue<int> linkedQueue = new MyLinkedQueue<int>();

    int count = 10;
    Console.WriteLine("== Filling queues..");
    Console.WriteLine("Linked");
    for (int i = 0; i < count; i++)
    {
        linkedQueue.Enqueue(i);
    }

    Console.WriteLine("== Clearing queues..");
    Console.WriteLine("Linked");
    while (!linkedQueue.IsEmpty)
    {
        Console.WriteLine($">> {linkedQueue.Dequeue()}");
    }

    Console.WriteLine("== Filling queues..");
    Console.WriteLine("Linked");
    for (int i = 0; i < count; i++)
    {
        linkedQueue.Enqueue(i);
    }
    Console.WriteLine("== Circulating queues..");
    Console.WriteLine("Linked");
    for (int i = 0; i < count; i++)
    {
        var val = linkedQueue.Dequeue();
        Console.WriteLine($">> {val}");
        linkedQueue.Enqueue(i);
    }

    Console.WriteLine("== Clearing queues..");
    Console.WriteLine("Linked");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($">> {linkedQueue.Dequeue()}");
    }

    Console.WriteLine("=== End.");
}



static void TestStacks()
{
    Console.WriteLine("=== Stack tests.");

    Console.WriteLine("== Making stacks..");
    IMyStack<int> linkedStack = new MyLinkedStack<int>();
    IMyStack<int> linkedStack2 = new MyLinkedStack<int>();

    IMyStack<int> arrayStack = new MyArrayStack<int>(8);
    IMyStack<int> arrayStack2 = new MyArrayStack<int>(8);


    int count = 10;
    Console.WriteLine("== Filling stacks..");
    for (int i = 0; i < count; i++)
    {
        linkedStack.Push(i);
        arrayStack.Push(i);
    }

    Console.WriteLine("== Moving stacks..");

    Console.WriteLine("Linked");
    while (!linkedStack.IsEmpty)
    {
        int val = linkedStack.Pop();
        Console.WriteLine($">> {val}");
        linkedStack2.Push(val);
    }

    Console.WriteLine("Array");
    while (!arrayStack.IsEmpty)
    {
        int val = arrayStack.Pop();
        Console.WriteLine($">> {val}");
        arrayStack2.Push(val);
    }


    Console.WriteLine("== Moving stacks..");
    Console.WriteLine("Linked");
    while (!linkedStack2.IsEmpty)
    {
        int val = linkedStack2.Pop();
        Console.WriteLine($">> {val}");
        linkedStack.Push(val);
    }

    Console.WriteLine("Array");
    while (!arrayStack2.IsEmpty)
    {
        int val = arrayStack2.Pop();
        Console.WriteLine($">> {val}");
        arrayStack.Push(val);
    }

    Console.WriteLine("=== End.");
}



static void TestLists()
{
    Console.WriteLine("=== List tests.");
    Console.WriteLine("== Making lists..");

    IMyList<int> arrayList = new MyArrayList<int>(8);
    IMyList<int> linkedList = new MyLinkedList<int>();
    IMyList<int> unrolledList = new MyUnrolledList<int>(4);

    int count = 10;
    Console.WriteLine("== Filling lists..");
    for (int i = 0; i < count; i++)
    {
        linkedList.Add(i);
        arrayList.Add(i);
        unrolledList.Add(i);
    }

    Console.WriteLine("== Printing..");
    Console.WriteLine("Linked");
    for (int i = 0; i < linkedList.Count; i++)
    {
        Console.WriteLine($">> {linkedList[i]}");
    }
    Console.WriteLine("Array");
    for (int i = 0; i < arrayList.Count; i++)
    {
        Console.WriteLine($">> {arrayList[i]}");
    }
    Console.WriteLine("Unrolled");
    for (int i = 0; i < unrolledList.Count; i++)
    {
        Console.WriteLine($">> {unrolledList[i]}");
    }

    Console.WriteLine("== Increasing..");
    for (int i = 0; i < count; i++)
    {
        linkedList[i] = linkedList[i] * 10;
        arrayList[i] = arrayList[i] * 5;
        unrolledList[i] = unrolledList[i] * 20;
    }

    Console.WriteLine("== Printing..");
    Console.WriteLine("Linked");
    for (int i = 0; i < linkedList.Count; i++)
    {
        Console.WriteLine($">> {linkedList[i]}");
    }
    Console.WriteLine("Array");
    for (int i = 0; i < arrayList.Count; i++)
    {
        Console.WriteLine($">> {arrayList[i]}");
    }
    Console.WriteLine("Unrolled");
    for (int i = 0; i < unrolledList.Count; i++)
    {
        Console.WriteLine($">> {unrolledList[i]}");
    }

    Console.WriteLine("== Removing at..");
    for (int i = count - 1; i >= 0; i--)
    {
        linkedList.RemoveAt(i);
        arrayList.RemoveAt(i);
        unrolledList.RemoveAt(i);
    }

    Console.WriteLine("== Printing..");
    Console.WriteLine($"Count: {linkedList.Count}, {arrayList.Count}, {unrolledList.Count}");
    Console.WriteLine("Linked");
    for (int i = 0; i < linkedList.Count; i++)
    {
        Console.WriteLine($">> {linkedList[i]}");
    }
    Console.WriteLine("Array");
    for (int i = 0; i < arrayList.Count; i++)
    {
        Console.WriteLine($">> {arrayList[i]}");
    }
    Console.WriteLine("Unrolled");
    for (int i = 0; i < unrolledList.Count; i++)
    {
        Console.WriteLine($">> {unrolledList[i]}");
    }

    Console.WriteLine("== Adding data..");
    for (int i = 0; i < count; i++)
    {
        linkedList.Add(i);
        arrayList.Add(i);
        unrolledList.Add(i);
    }

    Console.WriteLine("== Printing..");
    Console.WriteLine("Linked");
    for (int i = 0; i < linkedList.Count; i++)
    {
        Console.WriteLine($">> {linkedList[i]}");
    }
    Console.WriteLine("Array");
    for (int i = 0; i < arrayList.Count; i++)
    {
        Console.WriteLine($">> {arrayList[i]}");
    }
    Console.WriteLine("Unrolled");
    for (int i = 0; i < unrolledList.Count; i++)
    {
        Console.WriteLine($">> {unrolledList[i]}");
    }

    Console.WriteLine("== Removing..");
    for (int i = 0; i < count; i++)
    {
        linkedList.Remove(i);
        arrayList.Remove(i);
        unrolledList.Remove(i);
    }
    Console.WriteLine("== Printing..");
    Console.WriteLine($"Count: {linkedList.Count}, {arrayList.Count}, {unrolledList.Count}");
    Console.WriteLine("Linked");
    for (int i = 0; i < linkedList.Count; i++)
    {
        Console.WriteLine($">> {linkedList[i]}");
    }
    Console.WriteLine("Array");
    for (int i = 0; i < arrayList.Count; i++)
    {
        Console.WriteLine($">> {arrayList[i]}");
    }
    Console.WriteLine("Unrolled");
    for (int i = 0; i < unrolledList.Count; i++)
    {
        Console.WriteLine($">> {unrolledList[i]}");
    }
    Console.WriteLine("=== End.");

}