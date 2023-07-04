namespace ArrayProblem;

/*
 * In this question we have given an array and we need to find the h index 
 * means in the array, based on the value of the particular index we need to check that many element is present in the array or not
 * For which array element the value will be highest that will be the answer
 * [1,1,2,2,2,2,20]
 * so in 0th index we have 1 that mean in the array we need atleast one 1 or more then 1(value) element => so h index may be 1
 * for 1th index same like 0th as the value is also 1 so there should be alteast one 1 
 * for 2 index , value is 2 means there should be minimum two 2 value or have minimum 2 value which is grater than 2. in our case we have 4 element => h= 20
 * for last index we have 20 so in the enture array there have no twenty elements who are equal to 20 or grater then 20  
 * 
 * this is a bucket sort problem
 * */
public class HIndex_274
{
    public static int HIndex(int[] citations)
    {
        // this problem can be solved by first short the array then search the frequency. which element frequency is highest that will be the answer
        // But here we will do more optimize way by adding a new array which length will be citations.Length + 1
        // because the h must be less then the length of citations.
        // means if you have a array of length 5 so your h can be max 4,
        // so in array if you have [1,2,2,2,700] your h will be 2.
        // new array lenght is citations.Length + 1 so that we can store the frequency of all the array element which length is grater then the citations.Length.


        // in the new array we will be adding frequency of the element
        // like if you have a array => [3,1,2,3,2,700] , new array = [0,0,0,0,0,0,0]
        // when i = 0, citations[i] = 3 , so in the new array we will update the frequency of the 3rd index => [0,0,0,1,0,0,0]
        // i = 1, citations[i] = 1 , so in the new array we will update the frequency of the 1st index => [1,0,0,1,0,0,0]
        // i = 2, citations[i] = 2 , so in the new array we will update the frequency of the 1st index => [1,0,1,1,0,0,0]
        // i = 3, citations[i] = 3 , so in the new array we will update the frequency of the 1st index => [1,0,1,2,0,0,0]
        // i = 4, citations[i] = 2 , so in the new array we will update the frequency of the 1st index => [1,0,2,2,0,0,0]
        // i = 5, citations[i] = 700 , so in the new array we will update the frequency of the 1st index => [1,0,2,2,0,0,1]
        // as per our condition , for 3 the frequency should be atleast 3 but in our case that is 2 (new array[3])
        // but for 2 , the frequency is 2 (new array[3]) so h = 2

        int[] frequencyMap = new int[citations.Length + 1];

        // storing the frequency in the array
        for (int i = 0; i < citations.Length; i++)
        {
            if (citations[i] > citations.Length)
            {
                //frequencyMap[citations.Length] = frequencyMap[citations.Length] + 1;
                frequencyMap[citations.Length]++;
            }
            else
            {
                frequencyMap[citations[i]]++;
            }
        }

        // now check the frequency 
        int count = 0;
        // will start the loop from end as we are looking for the max frequency , so if very much possible that the highest should be at the right
        // and second reason is we need to keep adding the frequency, because if for 4 index frequency is 2 then we can not consider this
        // now for index 3 , if the frequency is 2 , that means in the array we have two 3 and have two element i.e 4 which are more than 3 so => count + frequencyMap[i];
        for (int i = frequencyMap.Length - 1; i >= 0; i--)
        {
            count = count + frequencyMap[i];
            if (count >= i)
                return i;
        }

        return 0;
    }
}
