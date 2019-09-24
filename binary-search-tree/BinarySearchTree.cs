using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class BinarySearchTree : IEnumerable<int>
{
    public BinarySearchTree(int value)
    {
        Value = value;
    }

    public BinarySearchTree(IEnumerable<int> values)
    {
        var listOfValues = new List<int>(values);
        this.Value = listOfValues[0];
        for (int i = 1; i < listOfValues.Count; i++)
        {
            this.Add(listOfValues[i]);
        }            
    }

    public int Value
    {
        get;
        set;
    }

    public BinarySearchTree Left
    {
        get;
        set;
    }

    public BinarySearchTree Right
    {
        get;
        set;
    }

    public BinarySearchTree Add(int value)
    {
        if (value <= Value)
        {
           if (Left == null)
               return (Left = new BinarySearchTree(value));
           else
            return (Left.Add(value));
        }
        else
        {
           if (Right == null)
               return (Right = new BinarySearchTree(value));
           else // must be > right
            return (Right.Add(value));
        }
    }

    public IEnumerator<int> GetEnumerator()
    {
        if (Left != null)
            foreach (var l in Left)
                yield return l;
        yield return Value;
        if (Right != null)
            foreach (var r in Right)
                yield return r;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}