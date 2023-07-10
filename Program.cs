var llist = new ReversedLinkedList.LinkedList();

llist.Root = llist.Insert(1, llist.Root);
llist.Root = llist.Insert(2, llist.Root);
llist.Root = llist.Insert(3, llist.Root);
//llist.Root = llist.Insert(4, llist.Root);
//llist.Root = llist.Insert(5, llist.Root);

llist.Print(llist.Root);
Console.WriteLine();
llist.ReversedList(llist.Root);
Console.WriteLine();
llist.Print(llist.Root);