using System;
using System.Collections.Generic;

public class LinkedList<T>
{
    Node<T>? head;
    Node<T>? tail;
    int count;


    public void Add(T data)
    {
        Node<T> node = new Node<T>(data);
        if (head == null)
            head = node;    // Список пуст, а значит head и tail указывают на
                            // одного и того же Node
        else
            tail!.Next = node; // ! = tail НЕ может быть null, потому что if
        tail = node;
        count++;
    }
}