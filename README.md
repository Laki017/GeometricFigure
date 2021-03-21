# GeometricFigure
В библиотеке реализованы фигуры круг и треугольник с возможностью проверки является ли треугольник прямоугольным.
#### Пример использования:
>IFigure circle = new Circle(10);
> double area = circle.GetArea();

#### Для добавления нового типа фигур нужно реализовать интерфейс IFigure: 
> public class Square : IFigure {}