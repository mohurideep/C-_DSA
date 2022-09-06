using System;
namespace C__CODE
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList dll = new DoublyLinkedList();

            dll.CreateDll(10);

            Console.WriteLine(dll.head.value);
        }
    }
}
    