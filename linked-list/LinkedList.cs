using System;
using System.Collections.Generic;
using System.Linq;

public class Deque<T>
{
    private class Linked<T>
    {
        internal T Value;
        internal Linked<T> Child;
    }

    private Linked<T> First = null;
    
    private static Linked<T> GetPenultimate(Linked<T> v, Linked<T> p) =>
        (v.Child != null)
           ? GetPenultimate(v.Child, v)
           : p;

    private static Linked<T> GetLast(Linked<T> v) =>
        (v != null && v.Child != null)
            ? GetLast(v.Child)
            : v;

    // `push` (*insert value at back*);
    public void Push(T value)
    {
        var set = new Linked<T>();
        set.Value = value;

        if (First == null)
        {
            First = set;
        }
        else
        {
            var last = GetLast(First);
            last.Child = set;
        }
    }

    // `pop` (*remove value at back*);
    public T Pop()
    {
        if (First == null)
        {
            return default(T);
        }

        var penultimate = GetPenultimate(First, First);

        var ret = default(T);
        
        if (penultimate.Child != null)
        {
            ret = penultimate.Child.Value;
            penultimate.Child = null;
        }
        else
        {
            ret = First.Value;
            First = null;
        }

        return ret;
    }

    // `unshift` (*insert value at front*);
    public void Unshift(T value)
    {
        var add = new Linked<T>();
        add.Value = value;

        if (First != null)
        {
            add.Child = First;
        }
        
        First = add;
    }

    // `shift` (*remove value at front*).
    public T Shift()
    {
        if (First == null)
        {
            return default(T);
        }

        var ret = First.Value;
        First = First.Child;
        return ret;
    }

}