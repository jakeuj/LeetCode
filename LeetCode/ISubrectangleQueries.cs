namespace LeetCode
{
    public interface ISubrectangleQueries
    {
        int GetValue(int row, int col);
        void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue);
    }
}