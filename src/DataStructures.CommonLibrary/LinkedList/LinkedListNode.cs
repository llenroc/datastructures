﻿namespace DataStructures.CommonLibrary.LinkedList
{
    /// <summary>
    /// This is linked list node
    /// LinkedList node contains a data property and link to the next node
    /// </summary>
    public class SinglyLinkedListNode<T>
    {
        /// <summary>
        /// Data property
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Next node 
        /// </summary>
        public SinglyLinkedListNode<T> Next { get; set; }

        public SinglyLinkedListNode(T data)
        {
            this.Data = data;
        }
    }
}
