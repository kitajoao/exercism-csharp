
//dotnet add package XunitLogger --version 2.4.0

using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;
using System;
public class DequeTest : IDisposable
{
    public DequeTest(ITestOutputHelper testOutput)
    {
        XunitLogging.Register(testOutput);
    }

    public void Dispose()
    {
        XunitLogging.Flush();
    }

    [Fact]
    public void Push_and_pop_are_first_in_last_out_order()
    {
        var deque = new Deque<int>();
        deque.Push(10);
        deque.Push(20);
        Assert.Equal(20, deque.Pop());
        Assert.Equal(10, deque.Pop());
        Assert.Equal(0, deque.Pop());
    }

    [Fact]
    public void Push_and_shift_are_first_in_first_out_order()
    {
        var deque = new Deque<int>();
        deque.Push(10);
        deque.Push(20);
        Assert.Equal(10, deque.Shift());
        Assert.Equal(20, deque.Shift());
    }

    [Fact]
    public void Unshift_and_shift_are_last_in_first_out_order()
    {
        var deque = new Deque<int>();
        deque.Unshift(10);
        deque.Unshift(20);
        Assert.Equal(20, deque.Shift());
        Assert.Equal(10, deque.Shift());
    }

    [Fact]
    public void Unshift_and_pop_are_last_in_last_out_order()
    {
        var deque = new Deque<int>();
        deque.Unshift(10);
        deque.Unshift(20);
        Assert.Equal(10, deque.Pop());
        Assert.Equal(20, deque.Pop());
    }

    [Fact]
    public void Push_and_pop_can_handle_multiple_values()
    {
        var deque = new Deque<int>();
        deque.Push(10);
        deque.Push(20);
        deque.Push(30);
        Assert.Equal(30, deque.Pop());
        Assert.Equal(20, deque.Pop());
        Assert.Equal(10, deque.Pop());
    }

    [Fact]
    public void Unshift_and_shift_can_handle_multiple_values()
    {
        var deque = new Deque<int>();
        deque.Unshift(10);
        deque.Unshift(20);
        deque.Unshift(30);
        Assert.Equal(30, deque.Shift());
        Assert.Equal(20, deque.Shift());
        Assert.Equal(10, deque.Shift());
    }

    [Fact]
    public void All_methods_of_manipulating_the_deque_can_be_used_together()
    {
        var deque = new Deque<int>();
        deque.Push(10);
        deque.Push(20);
        Assert.Equal(20, deque.Pop());

        deque.Push(30);
        Assert.Equal(10, deque.Shift());

        deque.Unshift(40);
        deque.Push(50);
        Assert.Equal(40, deque.Shift());
        Assert.Equal(50, deque.Pop());
        Assert.Equal(30, deque.Pop());
        Assert.Equal(0, deque.Shift());
    }
    
    [Fact]
    public void All_methods_of_manipulating_the_deque_can_be_used_together_2()
    {
        var deque = new Deque<int>();
        deque.Push(10);
        deque.Push(20);
        Assert.Equal(20, deque.Pop());

        deque.Push(30);
        Assert.Equal(10, deque.Shift());

        deque.Unshift(40);
        deque.Push(50);
        Assert.Equal(40, deque.Shift());
        Assert.Equal(30, deque.Shift());
        Assert.Equal(50, deque.Shift());
        Assert.Equal(0, deque.Shift());
    }
}