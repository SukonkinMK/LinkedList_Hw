// See https://aka.ms/new-console-template for more information
using LinkedList_Hw;

MyLinkedList<int> list = new MyLinkedList<int>();
for (int i = 0; i < 10; i++)
{
    list.addLast(i);
}
list.printList();
list.reverseList();
list.printList();
