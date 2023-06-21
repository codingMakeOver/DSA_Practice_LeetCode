namespace ArrayProblem;
// [1,1,0,1,0,1,1,0,1,0,0,0,1] => [0,0,0,0,0,0,1,1,1,1,1,1,1] =https://www.youtube.com/watch?v=jFrUwjx4eoA
public static class Sort0And1
{
    public static void Sort01(int[] arr)
    {
        // here we need to find two region where in one part we will be adding 0 and another we will be adding 1 
        // j to i-1 will have 1
        // 0 to j-1 will have 0
        // trick is what needs to be added first that will be the swapping element 
        // i is the pointer which will be used to traverse all the element
        int i = 0, j = 0;

        // will be traversed until we did not reached to the end
        while(i < arr.Length)
        {
            if (arr[i] == 1) {  i ++; }
            else
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++; j++;
            }
        }

        // Print the elements
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
    

}
