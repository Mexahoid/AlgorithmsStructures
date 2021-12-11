using Structures.Interfaces;
using Structures.List;

IMyList<int> linkedList = new MyLinkedList<int>();


for (int i = 0; i < 10; i++)
{
    linkedList.Add(i);  
}

for (int i = 0; i < linkedList.Count; i++)
{
    Console.WriteLine($">> {linkedList[i]}");
}

for (int i = 0; i < linkedList.Count; i++)
{
    linkedList[i] = linkedList[i] * 10;
}

for (int i = 0; i < linkedList.Count; i++)
{
    Console.WriteLine($">> {linkedList[i]}");
}

for (int i = linkedList.Count - 1; i >= 0; i--)
{
    linkedList.RemoveAt(i);
}

for (int i = 0; i < 10; i++)
{
    linkedList.Add(i);
}

for (int i = 0; i < 10; i++)
{
    linkedList.Remove(i);
}
Console.WriteLine($"Count: {linkedList.Count}");

Console.WriteLine($"Hello, World!");

