enum Colors { UnKnown, Red, Green, Blue, White, Black, Pink };

class Shape
{
	public Colors Color { get; set; }

	public string? Name { get; init; } = nameof(Shape);
	public double Area { get; set; }


	public Shape(Colors color, string name)
	{
		Color = color;
		Name = name;
	}

	public override string ToString() => @$"
Color : {Color}
Name : {Name}
Area : {Area}";
}

class Rectangle : Shape
{
	public double Width { get; set; }
	public double Length { get; set; }

	public Rectangle(double width, double length, Colors color = Colors.UnKnown)
		: base(color, nameof(Rectangle))
	{
		Area = width * length;

		Width = width;
		Length = length;
	}

	public double Perimeter() => 2 * (Width + Length);

	public override string ToString() => @$"
{base.ToString()}
Width : {Width}
Length : {Length}
Perimeter : {Perimeter()}";
}

class Square : Rectangle
{
	public Square(double side, Colors color = Colors.UnKnown)
		: base(side, side, color)
	{
		Name = nameof(Square);
	}
}

class Circle : Shape
{
	public double Radius { get; set; }

	public Circle(double radius, Colors color = Colors.UnKnown)
		: base(color, nameof(Circle))
	{
		Radius = radius;
		Area = Math.Pow(Radius, 2) * Math.PI;
	}

	public double Length() => 2 * Math.PI * Radius;


	public override string ToString() => @$"
{base.ToString()}
Radius : {Radius}
Length : {Length()}";
}

class Program
{
	static void Main()
	{
		Console.ForegroundColor = ConsoleColor.DarkGreen;

		Shape[] shapes =
		{
			new Rectangle(2, 3),
			new Circle(10),
			new Square(5)
		};

		foreach (var shape in shapes)
			Console.WriteLine(shape);
	}
}