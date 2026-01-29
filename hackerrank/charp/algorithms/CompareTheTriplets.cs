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

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int aliceScore = 0;
        int bobScore = 0;
        
        for(int i=0; i< a.Count; i++)
        {
            if(a[i] >b[i]){
                aliceScore++;
            }
            else if(b[i] > a[i]){
                bobScore++;
            }

        }
        return new List<int> {aliceScore,bobScore};
    }
}
