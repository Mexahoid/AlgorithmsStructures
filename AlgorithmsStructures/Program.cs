using Structures.Interfaces;
using Structures.List;

IMyList<int> arrayList = new MyArrayList<int>(8);
IMyList<int> linkedList = new MyLinkedList<int>();

int count = 10;
for (int i = 0; i < count; i++)
{
    linkedList.Add(i);
    arrayList.Add(i);
}
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

for (int i = 0; i < count; i++)
{
    linkedList[i] = linkedList[i] * 10;
    arrayList[i] = arrayList[i] * 5;
}

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

for (int i = count - 1; i >= 0; i--)
{
    linkedList.RemoveAt(i);
    arrayList.RemoveAt(i);
}

Console.WriteLine($"Count: {linkedList.Count}, {arrayList.Count}");
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

for (int i = 0; i < count; i++)
{
    linkedList.Add(i);
    arrayList.Add(i);
}

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

for (int i = 0; i < count; i++)
{
    linkedList.Remove(i);
    arrayList.Remove(i);
}
Console.WriteLine($"Count: {linkedList.Count}, {arrayList.Count}");
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

Console.WriteLine($"Hello, World!");

