/*
[
  [a, b, c],
  [d, e, f],    =  List<List<int>> arr
  [g, h, i]

  [0][0]  [0][1]  [0][2]    left diagonal:  [0][0] + [1][1] + [2][2] -> i == j
  [1][0]  [1][1]  [1][2]    right diagonal: [0][2] + [1][1] + [2][0] -> i+j == n-1 
  [2][0]  [2][1]  [2][2]    result = |left diagonal - right diagonal|
]
*/

using System;
using System.Collections.Generic;
class Solution {
    static int diagonalDifference(List<List<int>> arr) {
      
        int n = arr.Count;
        int leftDiagonalSum = 0;
        int rightDiagonalSum = 0;

        for (int i = 0; i < n; i++) {
            leftDiagonalSum += arr[i][i];
            rightDiagonalSum += arr[i][n - 1 - i];
        }

        return Math.Abs(leftDiagonalSum - rightDiagonalSum);
    }
}