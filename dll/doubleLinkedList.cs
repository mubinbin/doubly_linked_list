using System;
namespace dll
{
    //And a DLL keeps track of both a head and a tail pointer
    public class DLL
    {
        public DNode head {get;set;}
        public DNode tail {get;set;}
        public DLL()
        {
            head = null;
            tail = null;
        }

        //Add a value to the back of a DLL
        public void AddNodeFromBack(DNode NewNode){
            
            if (tail == null && head == null){
                tail = NewNode;
                head = NewNode;
            }
            NewNode.prev = tail;
            tail.next = NewNode;
            tail = NewNode;
        }

        //Add a value to the front of a DLL
        public void AddNodeFromFront(DNode NewNode){

            if (tail == null && head == null){
                tail = NewNode;
                head = NewNode;
            }
            NewNode.next = head;
            head.prev = NewNode;
            head = NewNode;
            
        }

        public void showListFromFront(){
            DNode pointer = head;
            while (pointer !=null)
            {
                Console.Write(pointer.val+", ");
                pointer = pointer.next;
            }
            Console.WriteLine("");
        }

        //Remove a given value from the list, or return false if not found
        public bool Remove(int num)
        {
            if (head.val == num)
            {
                head.next.prev= null;
                head = head.next;
                Console.WriteLine($"{num} has been removed");
                return true;
            }else if (tail.val == num){
                tail.prev.next = null;
                tail = tail.prev;
                Console.WriteLine($"{num} has been removed");
                return true;
            }else{
                DNode pointer = head;
                while(pointer.next != null)
                {
                    if(pointer.next.val !=num){
                        pointer = pointer.next;
                    }else{
                        pointer.next.next.prev = pointer;
                        pointer.next = pointer.next.next;
                        Console.WriteLine($"{num} has been removed");
                        return true;
                    }
                }
                Console.WriteLine("No such a node in the list");
                return false;    
            }
            
            
        }

        //Insert a new node after a given value, or return false if the value was not found
        public bool Insert(int num, DNode node)
        {
            if(head.val == num){
                node.next = head.next;
                node.prev = head;
                head.next = node;
                return true;
            }else if(tail.val == num){
                node.prev = tail;
                tail.next = node;
                tail = node;
                return true;
            }else{
                DNode pointer = head;
                while (pointer.next != null){
                    if (pointer.val == num){
                        node.next = pointer.next;
                        node.prev = pointer;
                        pointer.next = node;
                        return true;
                    }else{
                        pointer = pointer.next;
                    }
                }
                Console.WriteLine("No such a node in the list");
                return false;
            }
        }
    }
}