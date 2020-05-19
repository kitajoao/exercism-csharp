using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Collections;

public static class DiffieHellman
{
    public static BigInteger PrivateKey(BigInteger primeP) 
    {
        Random randNumb = new Random();
        return (BigInteger) randNumb.Next(1, (int)primeP);
    }

    public static BigInteger PublicKey(BigInteger primeP, BigInteger primeG, BigInteger privateKey) 
    {
        var privateKeyP = PrivateKey(primeP);
        var privateKeyG = PrivateKey(primeG);
        var pubKey = Math.Pow((int)primeG,(int)privateKey) % (int)primeP;

        return (BigInteger) pubKey; 
    }

    public static BigInteger Secret(BigInteger primeP, BigInteger publicKey, BigInteger privateKey) 
    {
        var step1 = Math.Pow((int)publicKey, (int)privateKey);
        var result = step1 % (int)primeP; 

        return (BigInteger) result;
    }
}



