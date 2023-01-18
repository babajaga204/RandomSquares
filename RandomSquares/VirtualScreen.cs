namespace RandomSquares;

public class VirtualScreen
{
    private VirtualScreenRow[] _rows;

    public VirtualScreen(int width, int height)
    {
        _rows = new VirtualScreenRow[height];
        for (var i = 0; i < height; i++)
        {
            _rows[i] = new VirtualScreenRow(width);
        }
    }

    public void Add(Box box)
    {
        _rows[box.StartY].AddBoxTopRow(box.X, box.Width);
        for (var i = box.StartY + 1; i < box.EndY - 1; i++)
        {
            _rows[i].AddBoxMiddleRow(box.X, box.Width);
        }
        _rows[box.EndY -1 ].AddBoxBottomRow(box.X, box.Width);
    }

    public void Show()
    {
        Console.Clear();
        foreach (var screenRow in _rows)
        {
            screenRow.Show();
        }
    }
}