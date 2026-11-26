public class NumMatrix {
    int[,] prefix;
    public NumMatrix(int[][] matrix)
    {
        if(matrix==null || matrix.Length==0)
        {
            return;
        }
        int rows= matrix.Length;
        int cols= matrix[0].Length;

        prefix = new int[rows,cols];

        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<cols;j++)
            {
                int up   = i > 0 ? prefix[i - 1, j] : 0;
                int left = j>0 ? prefix[i,j-1]:0;
                int diagonal = (i>0 && j>0) ? prefix[i-1,j-1] :0;
                prefix[i,j]= matrix[i][j]+up+left-diagonal;
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2)
    {
        int up = (row1>0)? prefix[row1-1,col2]:0;
        int left = (col1>0)?prefix[row2,col1-1]:0;
        int diagonal = (row1>0 && col1>0) ? prefix[row1-1,col1-1]:0;

        return prefix[row2,col2]-up-left+diagonal;
        
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */