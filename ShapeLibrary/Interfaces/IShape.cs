namespace ShapeLibrary.Interfaces
{
    /// <summary>
    /// Для легкости добавления других фигур создаем новый класс, реализующий интерфейс IShape
    /// </summary>
    public interface IShape
    {
        double CalculateArea();
    }
}
