using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static long aVeryBigSum(List<long> ar)
    {
        long sum = 0;
        
        foreach(var number in ar){
            sum += number;
        }
        return sum;

    }

}

