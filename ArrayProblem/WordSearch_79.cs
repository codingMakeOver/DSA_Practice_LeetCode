namespace ArrayProblem;

public class WordSearch_79
{
    // in this problem we will be using recursion 
    // we will get one character from the word then search the word in horizontal and vertical way
    // if we found the word then we will mark that with * and once all search will be done will reset to original value
    public static bool Exist(char[][] board, string word)
    {
        int column = board.Length;
        int row = board[0].Length;
        // tracking the word index 
        int index = 0;
        bool ans = false;

        for (int i = 0; i < column; i++)
        {
            for (int j = 0; j < row; j++)
            {
                if (word[index] == board[i][j])
                {
                    if(SearchWord(index, i, j, board, word))
                    {
                        return true;
                    }
                }
            }
        }
        return ans;
    }

    private static bool SearchWord(int index, int i, int j, char[][] board, string word)
    {
        if (index == word.Length) return true;

        if(i<0 || j<0 || i>= board.Length || j>= board[0].Length) return false;

        bool ans = false;

        // check if the searched character is found then make that with * in the board
        if (word[index] == board[i][j])
        {
            board[i][j] = '*';

            // now we will be checking the next character in horizontal and vertical way
            ans = SearchWord(index + 1, i + 1, j, board, word) ||
                SearchWord(index + 1, i - 1, j, board, word) ||
                SearchWord(index + 1, i , j+1, board, word) ||
                SearchWord(index + 1, i , j-1, board, word);

            // after checking the next character in all the horizontal and vertical way we will reset the value from * to the original value
            board[i][j] = word[index];
        }

        return ans;
    }
}
