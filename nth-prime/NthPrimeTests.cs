// This file was auto-generated based on version 2.1.0 of the canonical data.

//dotnet add package XunitLogger --version 2.4.0

using System.Collections.Generic;
using System;
using Xunit;
using Xunit.Abstractions;
public class NthPrimeTests :  IDisposable
{
    public NthPrimeTests(ITestOutputHelper testOutput)
    {
        XunitLogging.Register(testOutput);
    }
    public void Dispose()
    {
        XunitLogging.Flush();
    }
    [Fact]
    public void First_prime()
    {
        Assert.Equal(2, NthPrime.Prime(1));
    }

    [Fact]
    public void Second_prime()
    {
        Assert.Equal(3, NthPrime.Prime(2));
    }

    [Fact]
    public void Sixth_prime()
    {
        Assert.Equal(13, NthPrime.Prime(6));
    }

    [Fact]
    public void Big_prime()
    {
        Assert.Equal(104743, NthPrime.Prime(10001));
    }

    [Fact]
    public void There_is_no_zeroth_prime()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => NthPrime.Prime(0));
    }
}