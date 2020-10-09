//Doubly Linked Lists
//DLL's have nodes with a next and previous pointer
using System;


namespace dll
{
    public class DNode
    {
        public int val {get;set;}
        public DNode next {get;set;}
        public DNode prev {get;set;}
        public DNode(int value)
        {
            val = value;
            next = null;
            prev = null;
        }
    }

    
}