using System.Xml.Linq;

namespace ArrayProblem;

// the problem staement is we need to rotate a matrix in 90 degree

public class RotateImage_48
{
    public static void Rotate(int[][] matrix)
    {
        // for this problem we need to first transpose the matrix means rows will go the column
        // then reverse the column which will give you the answer

        // transpose the matrix
        // transpose matrix diagonal element did not changed 
        //[1,2,3]
        //[4,5,6]
        //[7,8,9]
        // now if you transpose the matrix then row will go to the column
        //[1,4,7]
        //[2,5,8]
        //[3,6,9]
        // here you can see the position of 1,5,9 remain unchanged 
        // and position of the other diagonal element is swaped
        // like 2 and 4 , 7 and 3 , 6 and 8
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                // we need to swap between matrix[i][j] and matrix[j][i]
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp; 
            }

            
        }
        // now reverse all the column
        for (int i = 0; i < matrix.Length; i++)
        {
            Array.Reverse(matrix[i]);  
        }


        // Solution 2
        // in this solution we will not solve using o(n2) + o(n2) [one for transpose and another for reverse]
        // We will start rotating (shifting) the matrix element in the clock wise manner
        // image a 4X4 matrix , now if you rotate the first layer , then there will only one layer remain
        // so we will terminate the loop if i cross n/2 value [outer layer]
        // now we will run the inner layer from i as will refer the current layer and will loop through until n -i-1
        // for checking all the element in the layer we will be increasing the j based on i , 
        // so that the inner loop terminating state is based on i
        // now will assign for element
        //he variable a stores the value of the top-left element of the current square (m[i][j]).
        //The variable b stores the value of the top - right element of the current square(m[j][n - 1 - i]).
        //The variable c stores the value of the bottom - right element of the current square(m[n - 1 - i][n - 1 - j]).
        //The variable d stores the value of the bottom - left element of the current square(m[n - 1 - j][i]).
        //The values of the elements are swapped in a clockwise manner:

        //The value of d is assigned to the top-left element(m[i][j]).
        //The value of a is assigned to the top-right element(m[j][n - 1 - i]).
        //The value of b is assigned to the bottom-right element(m[n - 1 - i][n - 1 - j]).
        //The value of c is assigned to the bottom-left element(m[n - 1 - j][i]).
        int n = matrix.Length;

        for (int i = 0; i < n / 2; i++)
        {
            for (int j = i; j < n - i - 1; j++)
            {
                var a = matrix[i][j];
                var b = matrix[j][n - 1 - i];
                var c = matrix[n - 1 - i][n - 1 - j];
                var d = matrix[n - 1 - j][i];

                matrix[i][j] = d;
                matrix[j][n - 1 - i] = a;
                matrix[n - 1 - i][n - 1 - j] = b;
                matrix[n - 1 - j][i] = c;
            }
        }
    }
}
