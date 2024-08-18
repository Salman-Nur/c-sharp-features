// Open Closed Principle = Open for extension, closed for modification
//https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/

// Chat gpt  <-------------------------


using Solid_OCP_examples;

var shapes = new List<Shape>()
{
    new Circle() { Radius = 2},
    new Rectangle() { Width = 3 , Height = 4 }
};

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Area());
}
