using System;

public class CircularBuffer<T>
{

    private T[] buffer;
    private int fillNumber, oldestWritePosition, capacity, currentWritingPosition;

    public CircularBuffer(int capacity)
    {
        buffer = new T[capacity];
        this.capacity = capacity;
    }

    public T Read()
    {
        if(fillNumber == 0)
            throw new InvalidOperationException();
        T result = buffer[oldestWritePosition];
        this.Clear();
        return result;
    }

    public void Write(T value)
    {
        if(fillNumber < capacity)
        {
            buffer[currentWritingPosition] = value;
            if(currentWritingPosition + 1 == capacity)
                currentWritingPosition = 0;
            else
                currentWritingPosition++;
            fillNumber++;
        }
        else
        {
            throw new InvalidOperationException();
        }
    }

    public void Overwrite(T value)
    {
        if(fillNumber != capacity)
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
        if(fillNumber != 0)
        {
            T toRemove = buffer[oldestWritePosition];
            T[] auxiliaryBuffer = new T[capacity];
            int counter = 0;
            foreach(T var in buffer)
            {
                if(var.Equals(toRemove))
                {
                    counter++;
                }
                else
                {
                    auxiliaryBuffer[counter] = var;
                    counter++;
                }
            }
            buffer = auxiliaryBuffer;
            if(oldestWritePosition + 1 == capacity)
                oldestWritePosition = 0;
            else
                oldestWritePosition++;
            fillNumber--;
        }
    }



























}

//     private int capacity; // capacity of the queue(how many numbers it can recieve)

//     private int numbersAdded;//how many numbers are added into the circular buffer;
//     private T[] data; // array that will recieve the numbers of the buffer;

//     private int addedQue; //first element added into the queue;

//     private int addWillReque; // last element added into the queue

//     private int posQue; // actual position of the queue;

//     public CircularBuffer(int capacity)
//     {
//         this.capacity = capacity;

//         data = new T[capacity];

//     }

//     public T Read()
//     {
//         if (numbersAdded == 0)
//         {
//             throw new InvalidOperationException();
//         }
//         T result = data[addedQue];

//         return result;
//     }

//     public void Write(T value)
//     {
//         if (numbersAdded < capacity)
//         {
//             data[posQue] = value;

//             if (posQue + 1 == capacity)
//             {
//                 posQue = 0;
//             }
//             else
//             {
//                 posQue++;
//             }
            
//             numbersAdded ++;
//         }
//         else
//         {
//             throw new InvalidOperationException();
//         }
//     }

//     public void Overwrite(T value)
//     {
//         if(numbersAdded != capacity)
//         {
//             this.Write(value);
//         }
//         else
//         {
//             this.Clear();
//             this.Write(value);
//         }
//     }

//     public void Clear()
//     {
//         if(numbersAdded != 0)
//         {
//             T toRemove = data[addedQue];
            
//             T[] auxData = new T[capacity];

//             int count = 0;

//             foreach(T var in data)
//             {
//                 if(var.Equals(toRemove))
//                 {
//                     count ++;
//                 }
//                 else
//                 {
//                     auxData[count] = var;
//                     count ++;
//                 }
//             }
//             data = auxData;
//             if(addedQue + 1 == capacity)
//             {
//                 addedQue = 0;
//             }
//             else
//             {
//                 addedQue ++;
//             }
//             numbersAdded --;
//         }
//     }
// }


