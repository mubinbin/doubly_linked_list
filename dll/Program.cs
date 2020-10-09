using System;

namespace dll
{
    class Program
    {
        static void Main(string[] args)
        {
            DNode node1 = new DNode(3);
            DNode node2 = new DNode(36);
            DNode node3 = new DNode(83);
            DNode node4 = new DNode(993);
            DNode node5 = new DNode(-303);
            DNode node6 = new DNode(3);

            DLL dll = new DLL();
            dll.AddNodeFromBack(node1); // dll: 3
            dll.AddNodeFromBack(node2); // dll: 3, 36
            dll.AddNodeFromFront(node3);// dll: 83, 3, 36
            dll.AddNodeFromBack(node4); // dll: 83, 3, 36, 993
            dll.AddNodeFromBack(node5); // dll: 83, 3, 36, 993, -303
            dll.AddNodeFromFront(node6);// dll: 3, 83, 3, 36, 993, -303

            dll.showListFromFront();
            dll.Remove(3);
            dll.Remove(3);
            dll.showListFromFront();
            dll.Remove(-303);
            dll.showListFromFront();
            dll.Insert(2, new DNode(1));
            dll.showListFromFront();
        }
    }
}
