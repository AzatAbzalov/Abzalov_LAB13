//Задание 1
//DoublyLinkedList list = new DoublyLinkedList();
//Console.WriteLine("Введите эл-ы: ");
//while (true)
//{
//    string str = Console.ReadLine();

//    if (str == "")
//        break;
//    int num = Convert.ToInt32(str);
//    if (list.Count < 2)
//        list.Add(num);
//    else if (Math.Abs(num - list.HeadData) < Math.Abs(num - list.TailData))
//        list.AddFirst(num);
//    else list.Add(num);
//}
//Console.WriteLine("Размер: " + list.Count);
//Console.WriteLine("Список: " + list.StrList());

//Задание 2
//string[] text = File.ReadAllLines(@"..\..\..\task2.txt");
//DoublyLinkedList pos = new DoublyLinkedList();
//DoublyLinkedList neg = new DoublyLinkedList();
//foreach(string line in text)
//{
//    int n = int.Parse(line);
//    if (n >= 0) pos.Add(n);
//    else neg.Add(n);
//}    

//Задание 2. А
//DoublyLinkedList n1= new DoublyLinkedList();
//Node current = pos.Head;
//int count = 0;
//while (current != null)
//{
//    if(count == pos.Count/2)
//    {
//        Node neg1 = neg.Head;
//        for (int i = 0; i < neg.Count; i++)
//        {
//            n1.Add(neg1.Data);
//            neg1 = neg1.Next;
//        }
//        count++;
//    }
//    else
//    {
//        n1.Add(current.Data);
//        current = current.Next;
//        count++;
//    }
//}
//Console.WriteLine("A: " + n1);

//Задание 2. Б
//DoublyLinkedList n2 = new DoublyLinkedList();
//Node pos1 = pos.Head;
//Node neg1 = neg.Head;
//int min;
//for (int i = 0; i < (min = Math.Min(pos.Count, neg.Count)); i++)
//{
//    n2.Add(pos1.Data);
//    pos1 = pos1.Next;
//    n2.Add(neg1.Data);
//    neg1 = neg1.Next;
//}
//if (pos.Count != neg.Count)
//{
//    if(pos.Count == min)
//    {
//        for (int i = 0; i < neg.Count - min; i++)
//        { n2.Add(neg1.Data); neg1 = neg1.Next; }    
//    }
//} 
//else
//{
//    for (int i = 0; i < pos.Count - min; i++)
//    {
//        n2.Add(pos1.Data);
//        pos1 = pos1.Next;
//    }    
//}
//Console.WriteLine("B: " + n2);

//Задание 3.
//LinkedList<int> linkedlist = new();
//Console.WriteLine("Вводите целые числа:");
//while (true)
//{
//    string str = Console.ReadLine();
//    if (str == "") 
//        break;
//    if (linkedlist.Count < 2)
//        linkedlist.AddLast(int.Parse(str));
//    else if (Math.Abs(int.Parse(str) - linkedlist.First.Value) < Math.Abs(int.Parse(str) - linkedlist.Last.Value))
//        linkedlist.AddFirst(int.Parse(str));
//    else linkedlist.AddLast(int.Parse(str));
//}
//Console.WriteLine("Размер: " + linkedlist.Count);
//Console.Write("Список: ");
//for (int i = 0; i < linkedlist.Count; i++)
//    Console.Write(linkedlist.ElementAt<int>(i) + " ");
//Console.WriteLine();

//Кольцевые списки
//Задание 1

Console.Write("Введите кол-во чисел в списке: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите список:");
int[] nums = new int[n];
for (int i = 0; i < n; i++)
    nums[i] = int.Parse(Console.ReadLine());
CircularList list = new(nums);
Node current = list.Head;

Console.Write("Введите кол-во команд: ");
int k = int.Parse(Console.ReadLine());

Console.WriteLine("Введите команды:");
for (int i = 0; i < k; i++)
{
    string[] command = Console.ReadLine().Split(' ');
    if (command[0] == "R")
    {
        int count = int.Parse(command[1]);
        for (int j = 0; j < count; j++)
            list.Remove(current.Next.Data);
    }
    else if (command[0] == "L")
    {
        int count = int.Parse(command[1]);
        for (int j = 0; j < list.Count - 1 - count; j++)
            current = current.Next;
        for (int j = 0; j < count; j++)
            list.Remove(current.Next.Data);
    }
    current = current.Next;
}

Console.Write("Найти число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Список:");
Console.WriteLine(list);
if (list.Contains(num))
    Console.WriteLine($"Число {num} есть в списке");
else Console.WriteLine($"Числа {num} нет в списке");