using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SimpleLinkedList<T> : IEnumerable<T>
{
    private T _value;
    private SimpleLinkedList<T> _next;
    public SimpleLinkedList(T value)
    {
        Value = value;
    }

    public SimpleLinkedList(IEnumerable<T> values)
    {
        
        for;
    }

    public T Value 
    { 
        get
        {
            return _value;
        }
        set
        {
            _value = value;
        }
    }

    public SimpleLinkedList<T> Next
    { 
        get
        {
            return _next;
        } 
        set
        {
            _next = value;
        }
    }

    public SimpleLinkedList<T> Add(T value)
    {
        this.Next = new SimpleLinkedList<T>(value);
        return this;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        var list = new List<T>();

        list.Add(this.Value);
        list.Add(this.Next.Value);

        return list.GetEnumerator();
    }
}