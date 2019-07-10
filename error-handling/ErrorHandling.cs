using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception();
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        if( input =="1")
        {
            return 1;
        }
        if(input == "a")
        {
            return null;
        }    

        throw new Exception();
    }
    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        if( input =="1")
        {
            result = 1;

            return true;
        }
        if(input == "a")
        {
            result = 0;

            return false;
        }
        
        throw new Exception();
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        using(disposableObject)
        {
            throw new Exception();
        }
    }   
}
