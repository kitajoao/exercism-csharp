using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        if(shiftKey >= 26)
        {
            shiftKey = shiftKey - 26;
        }

        var ori = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        var shifted = string.Empty; 
        
        shifted = ori.Substring(shiftKey) + ori.Substring(0, shiftKey);

        shifted = $"{shifted}{shifted.ToLowerInvariant()}";
        
        ori = $"{ori}{ori.ToLowerInvariant()}";

        char[] buffer = text.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            var oriposition = ori.IndexOf(letter);

            if (oriposition >= 0)
                buffer[i] = shifted[oriposition];

         }
       return new string(buffer);

    }
}