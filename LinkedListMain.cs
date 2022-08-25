﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListMain
    {
        Node head;
        public void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(" {0} imserted into Linked List ", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }

             Node RemovalFirstNode()            //Removal FirstNode
            {
                if (this.head == null)
                {
                    return null;
                }
                this.head = this.head.next;
                return this.head;
            }
            Node RemovalLastNode()              //Removal LastNode
            {
                if (head == null)
                {
                    return null;
                }
                if (head.next == null)
                {
                    return null;
                }
                Node newNode = head;
                while (newNode.next.next != null)
                {
                    newNode = newNode.next;
                }
                newNode.next = null;
                return head;
            }
        }
    }
}