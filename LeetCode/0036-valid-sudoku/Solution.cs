public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        var uniqueness = new HashSet<char>();

        //Check over all rows 
        for(int i=0;i<9;i++)
        {
            for(int j=0;j<9;j++)
            {
                if(board[i][j]=='.')
                {
                    continue;
                }
                else if(uniqueness.Contains(board[i][j]))
                {
                    return false;
                }
                else
                {
                    uniqueness.Add(board[i][j]);
                }
            }

            uniqueness.Clear();
        }

        //check over all columns 

         //Check over all rows 
        for(int i=0;i<9;i++)
        {
            for(int j=0;j<9;j++)
            {
                if(board[j][i]=='.')
                {
                    continue;
                }
                else if(uniqueness.Contains(board[j][i]))
                {
                    return false;
                }
                else
                {
                    uniqueness.Add(board[j][i]);
                }
            }

            uniqueness.Clear();
        }

        //check over all boxes 
        
        for(int startrow=0;startrow<9;startrow+=3)
        {
            for(int startcol=0;startcol<9;startcol+=3)
            {
                for(int i=0;i<3;i++)
                {
                    for(int j=0;j<3;j++)
                    {
                        char c = board[startrow+i][startcol+j];
                        if(c=='.')
                        {
                            continue;
                        }

                        if (!uniqueness.Add(c))
                        {
                            return false;
                        }
                    }
                }
                
                uniqueness.Clear();

            }
        }


        return true;
        
    }
}