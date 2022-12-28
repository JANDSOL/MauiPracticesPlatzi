namespace PagePlatziSample.Utils.Draws;

public class DrawVerticalLine : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.StrokeColor = Color.FromArgb("#e7e8e9");
        canvas.StrokeSize = 10;
        canvas.DrawLine(10, 10, 10, 10);
    }
}
