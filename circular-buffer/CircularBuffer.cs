using System;

public class CircularBuffer<T>
{

    private int capacity; // capacity of the queue(how many numbers it can recieve)

    private int numbersAdded;//how many numbers are added into the circular buffer;
    private T[] data; // array that will recieve the numbers of the buffer;

    private int addedQue; //first element added into the queue;

    private int addWillReque; // last element added into the queue

    private int posQue; // actual position of the queue;

    public CircularBuffer(int capacity)
    {
        this.capacity = capacity;

        data = new T[capacity];

    }

    public T Read()
    {
        if (numbersAdded == 0)
        {
            throw new InvalidOperationException();
        }
        T result = data[addedQue];

        return result;
    }

    public void Write(T value)
    {
        if (numbersAdded < capacity)
        {
            data[posQue] = value;

            if (posQue + 1 == capacity)
            {
                posQue = 0;
            }
            else
            {
                posQue++;
            }
            
            numbersAdded ++;
        }
        else
        {
            throw new InvalidOperationException();
        }
    }

    public void Overwrite(T value)
    {
        if(numbersAdded != capacity)
        {
            this.Write(value);
        }
        else
        {
            this.Clear();
            this.Write(value);
        }
    }

    public void Clear()
    {
        if(numbersAdded != 0)
        {
            T toRemove = data[addedQue];
            
            T[] auxData = new T[capacity];

            int count = 0;

            foreach(T var in data)
            {
                if(var.Equals(toRemove))
                {
                    count ++;
                }
                else
                {
                    auxData[count] = var;
                    count ++;
                }
            }
            data = auxData;
            if(addedQue + 1 == capacity)
            {
                addedQue = 0;
            }
            else
            {
                addedQue ++;
            }
            numbersAdded --;
        }
    }
}


