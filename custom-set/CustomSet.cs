using System;
using System.Collections.Generic;
using System.Linq;
public class CustomSet : IEquatable<CustomSet>
{
    private int[] _values = null;

    public CustomSet(params int[] values)
    {
        _values = values;
    }


    public bool Empty()
    {
        if (_values.Length != 0)
        {
            return false;
        }
        return true;
    }

    public bool Contains(int value)
    {
        for (int i = 0; i < _values.Length; i++)
        {
            if (_values[i] == value)
            {
                return true;
            }
        }
        return false;
    }

    public bool Subset(CustomSet right)
    {
        bool validation = true;
        for (int i = 0; i < _values.Length; i++)
        {
            if (!right._values.Contains(_values[i]))
            {
                validation = false;
            }
        }
        return validation;
    }

    public bool Disjoint(CustomSet right)
    {
        bool validation = true;
        for (int i = 0; i < right._values.Length; i++)
        {
            Console.WriteLine("aaaa");
            if (!_values.Contains(right._values[i]))
            {
                validation = true;
            }
            else
            {
                validation = false;
                break;
            }
        }

        return validation;
    }
    public bool Equals(CustomSet right)
    {
        bool validation = false;
        Console.WriteLine(validation);
        if (_values.Length == right._values.Length)
        {
            if (_values.Length > 0)
            {
                for (int i = 0; i < _values.Length; i++)
                {
                    if (!right._values.Contains(_values[i]))
                    {
                        validation = false;
                        break;
                    }
                    else
                    {
                        validation = true;
                    }
                }
            }
            else
            {
                validation = true;
            }
        }

        return validation;
    }
    public CustomSet Add(int value)
    {
        if(!_values.Contains(value))
            _values = _values.Concat(new int[] { value }).ToArray();
        
        return this;
    }
    public CustomSet Intersection(CustomSet right)
    {
        _values = _values.Intersect(right._values).ToArray();
        
        return this;
    }

    public CustomSet Difference(CustomSet right)
    {
        _values = _values.Except(right._values).ToArray();

        return this;
    }

    public CustomSet Union(CustomSet right)
    {
        _values = _values.Union(right._values).ToArray();

        return this;
    }
}