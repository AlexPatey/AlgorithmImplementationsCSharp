public static class AddBinary_67
{
    public static string AddBinary(string a, string b)
    {
        var i = a.Length - 1;
        var j = b.Length - 1;
        var result = string.Empty;
        var carry = false;
        
        while (i >= 0 && j >= 0)
        {
            if (a[i] == '1' ^ b[j] == '1')
            {
                result = carry ? $"0{result}" : $"1{result}";
            }
            else if (a[i] == '1' && b[j] == '1')
            {
                if (carry)
                {
                    result = $"1{result}";
                }
                else
                {
                    result = $"0{result}";
                    carry = true;
                }
            }
            else
            {
                if (carry)
                {
                    result = $"1{result}";
                    carry = false;
                }
                else
                {
                    result = $"0{result}";
                }
            }
            
            i--;
            j--;
        }

        while (i >= 0)
        {
            if (a[i] == '1')
            {
                result = carry ? $"0{result}" : $"1{result}";
            }
            else
            {
                if (carry)
                {
                    result = $"1{result}";
                    carry = false;
                }
                else
                {
                    result = $"0{result}";
                }
            }
            
            i--;
        }
        
        while (j >= 0)
        {
            if (b[j] == '1')
            {
                result = carry ? $"0{result}" : $"1{result}";
            }
            else
            {
                if (carry)
                {
                    result = $"1{result}";
                    carry = false;
                }
                else
                {
                    result = $"0{result}";
                }
            }
            j--;
        }

        if (carry)
        {
            result = $"1{result}";
        }
        
        return result;
    }
}