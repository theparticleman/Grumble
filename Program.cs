using Spectre.Console;

const int imageWidth = 13;
const int imageHeight = 16;

AnsiConsole.Write(new FigletText("Grumble, Grumble...").Centered());
AnsiConsole.WriteLine();

var xOffset = (Console.WindowWidth / 2) - (imageWidth / 2) - 1;
AnsiConsole.Write(BuildImage(xOffset, 0));

Canvas BuildImage(int xOffset, int yOffset)
{
    var canvas = new Canvas(Console.WindowWidth, imageHeight * 2);
    canvas.Scale = false;
    xOffset /= canvas.PixelWidth;
    yOffset /= canvas.PixelWidth;

    var primary = Color.Red1;
    var secondary = Color.Orange1;
    var white = Color.White;

    canvas.SetPixel(0 + xOffset, 0 + yOffset, secondary);
    canvas.SetPixel(1 + xOffset, 0 + yOffset, secondary);
    canvas.SetPixel(2 + xOffset, 0 + yOffset, secondary);
    canvas.SetPixel(3 + xOffset, 0 + yOffset, secondary);
    canvas.SetPixel(9 + xOffset, 0 + yOffset, secondary);
    canvas.SetPixel(10 + xOffset, 0 + yOffset, secondary);
    canvas.SetPixel(11 + xOffset, 0 + yOffset, secondary);
    canvas.SetPixel(12 + xOffset, 0 + yOffset, secondary);

    canvas.SetPixel(2 + xOffset, 1 + yOffset, secondary);
    canvas.SetPixel(3 + xOffset, 1 + yOffset, secondary);
    canvas.SetPixel(4 + xOffset, 1 + yOffset, primary);
    canvas.SetPixel(5 + xOffset, 1 + yOffset, primary);
    canvas.SetPixel(6 + xOffset, 1 + yOffset, primary);
    canvas.SetPixel(7 + xOffset, 1 + yOffset, primary);
    canvas.SetPixel(8 + xOffset, 1 + yOffset, primary);
    canvas.SetPixel(9 + xOffset, 1 + yOffset, secondary);
    canvas.SetPixel(10 + xOffset, 1 + yOffset, secondary);

    canvas.SetPixel(4 + xOffset, 2 + yOffset, primary);
    canvas.SetPixel(5 + xOffset, 2 + yOffset, primary);
    canvas.SetPixel(6 + xOffset, 2 + yOffset, primary);
    canvas.SetPixel(7 + xOffset, 2 + yOffset, primary);
    canvas.SetPixel(8 + xOffset, 2 + yOffset, primary);

    canvas.SetPixel(3 + xOffset, 3 + yOffset, primary);
    canvas.SetPixel(4 + xOffset, 3 + yOffset, white);
    canvas.SetPixel(5 + xOffset, 3 + yOffset, white);
    canvas.SetPixel(6 + xOffset, 3 + yOffset, primary);
    canvas.SetPixel(7 + xOffset, 3 + yOffset, white);
    canvas.SetPixel(8 + xOffset, 3 + yOffset, white);
    canvas.SetPixel(9 + xOffset, 3 + yOffset, primary);

    canvas.SetPixel(2 + xOffset, 4 + yOffset, primary);
    canvas.SetPixel(3 + xOffset, 4 + yOffset, primary);
    canvas.SetPixel(4 + xOffset, 4 + yOffset, primary);
    canvas.SetPixel(5 + xOffset, 4 + yOffset, secondary);
    canvas.SetPixel(6 + xOffset, 4 + yOffset, secondary);
    canvas.SetPixel(7 + xOffset, 4 + yOffset, secondary);
    canvas.SetPixel(8 + xOffset, 4 + yOffset, primary);
    canvas.SetPixel(9 + xOffset, 4 + yOffset, primary);
    canvas.SetPixel(10 + xOffset, 4 + yOffset, primary);

    canvas.SetPixel(2 + xOffset, 5 + yOffset, primary);
    canvas.SetPixel(3 + xOffset, 5 + yOffset, white);
    canvas.SetPixel(4 + xOffset, 5 + yOffset, white);
    canvas.SetPixel(5 + xOffset, 5 + yOffset, white);
    canvas.SetPixel(6 + xOffset, 5 + yOffset, white);
    canvas.SetPixel(7 + xOffset, 5 + yOffset, white);
    canvas.SetPixel(8 + xOffset, 5 + yOffset, white);
    canvas.SetPixel(9 + xOffset, 5 + yOffset, white);
    canvas.SetPixel(10 + xOffset, 5 + yOffset, primary);
    canvas.SetPixel(11 + xOffset, 5 + yOffset, primary);

    canvas.SetPixel(1 + xOffset, 6 + yOffset, primary);
    canvas.SetPixel(2 + xOffset, 6 + yOffset, white);
    canvas.SetPixel(3 + xOffset, 6 + yOffset, white);
    canvas.SetPixel(4 + xOffset, 6 + yOffset, white);
    canvas.SetPixel(5 + xOffset, 6 + yOffset, white);
    canvas.SetPixel(6 + xOffset, 6 + yOffset, white);
    canvas.SetPixel(7 + xOffset, 6 + yOffset, white);
    canvas.SetPixel(8 + xOffset, 6 + yOffset, white);
    canvas.SetPixel(9 + xOffset, 6 + yOffset, white);
    canvas.SetPixel(10 + xOffset, 6 + yOffset, white);
    canvas.SetPixel(11 + xOffset, 6 + yOffset, primary);
    canvas.SetPixel(12 + xOffset, 6 + yOffset, primary);

    canvas.SetPixel(1 + xOffset, 7 + yOffset, primary);
    canvas.SetPixel(2 + xOffset, 7 + yOffset, white);
    canvas.SetPixel(3 + xOffset, 7 + yOffset, secondary);
    canvas.SetPixel(4 + xOffset, 7 + yOffset, primary);
    canvas.SetPixel(5 + xOffset, 7 + yOffset, primary);
    canvas.SetPixel(6 + xOffset, 7 + yOffset, primary);
    canvas.SetPixel(7 + xOffset, 7 + yOffset, primary);
    canvas.SetPixel(8 + xOffset, 7 + yOffset, primary);
    canvas.SetPixel(9 + xOffset, 7 + yOffset, secondary);
    canvas.SetPixel(10 + xOffset, 7 + yOffset, white);
    canvas.SetPixel(11 + xOffset, 7 + yOffset, primary);
    canvas.SetPixel(12 + xOffset, 7 + yOffset, primary);

    canvas.SetPixel(0 + xOffset, 8 + yOffset, primary);
    canvas.SetPixel(1 + xOffset, 8 + yOffset, primary);
    canvas.SetPixel(2 + xOffset, 8 + yOffset, primary);
    canvas.SetPixel(3 + xOffset, 8 + yOffset, secondary);
    canvas.SetPixel(4 + xOffset, 8 + yOffset, secondary);
    canvas.SetPixel(5 + xOffset, 8 + yOffset, secondary);
    canvas.SetPixel(6 + xOffset, 8 + yOffset, secondary);
    canvas.SetPixel(7 + xOffset, 8 + yOffset, secondary);
    canvas.SetPixel(8 + xOffset, 8 + yOffset, secondary);
    canvas.SetPixel(9 + xOffset, 8 + yOffset, secondary);
    canvas.SetPixel(10 + xOffset, 8 + yOffset, secondary);
    canvas.SetPixel(11 + xOffset, 8 + yOffset, secondary);
    canvas.SetPixel(12 + xOffset, 8 + yOffset, primary);

    canvas.SetPixel(0 + xOffset, 9 + yOffset, primary);
    canvas.SetPixel(1 + xOffset, 9 + yOffset, primary);
    canvas.SetPixel(2 + xOffset, 9 + yOffset, white);
    canvas.SetPixel(3 + xOffset, 9 + yOffset, white);
    canvas.SetPixel(4 + xOffset, 9 + yOffset, secondary);
    canvas.SetPixel(5 + xOffset, 9 + yOffset, secondary);
    canvas.SetPixel(6 + xOffset, 9 + yOffset, secondary);
    canvas.SetPixel(7 + xOffset, 9 + yOffset, secondary);
    canvas.SetPixel(8 + xOffset, 9 + yOffset, secondary);
    canvas.SetPixel(9 + xOffset, 9 + yOffset, secondary);
    canvas.SetPixel(10 + xOffset, 9 + yOffset, secondary);
    canvas.SetPixel(11 + xOffset, 9 + yOffset, secondary);
    canvas.SetPixel(12 + xOffset, 9 + yOffset, primary);

    canvas.SetPixel(0 + xOffset, 10 + yOffset, primary);
    canvas.SetPixel(1 + xOffset, 10 + yOffset, white);
    canvas.SetPixel(2 + xOffset, 10 + yOffset, white);
    canvas.SetPixel(3 + xOffset, 10 + yOffset, white);
    canvas.SetPixel(4 + xOffset, 10 + yOffset, secondary);
    canvas.SetPixel(5 + xOffset, 10 + yOffset, primary);
    canvas.SetPixel(6 + xOffset, 10 + yOffset, primary);
    canvas.SetPixel(7 + xOffset, 10 + yOffset, primary);
    canvas.SetPixel(8 + xOffset, 10 + yOffset, secondary);
    canvas.SetPixel(9 + xOffset, 10 + yOffset, secondary);
    canvas.SetPixel(10 + xOffset, 10 + yOffset, secondary);
    canvas.SetPixel(11 + xOffset, 10 + yOffset, primary);

    canvas.SetPixel(0 + xOffset, 11 + yOffset, primary);
    canvas.SetPixel(1 + xOffset, 11 + yOffset, white);
    canvas.SetPixel(2 + xOffset, 11 + yOffset, white);
    canvas.SetPixel(3 + xOffset, 11 + yOffset, white);
    canvas.SetPixel(4 + xOffset, 11 + yOffset, primary);
    canvas.SetPixel(5 + xOffset, 11 + yOffset, primary);
    canvas.SetPixel(6 + xOffset, 11 + yOffset, white);
    canvas.SetPixel(7 + xOffset, 11 + yOffset, primary);
    canvas.SetPixel(8 + xOffset, 11 + yOffset, primary);
    canvas.SetPixel(9 + xOffset, 11 + yOffset, primary);
    canvas.SetPixel(10 + xOffset, 11 + yOffset, primary);
    canvas.SetPixel(11 + xOffset, 11 + yOffset, secondary);

    canvas.SetPixel(1 + xOffset, 12 + yOffset, white);
    canvas.SetPixel(2 + xOffset, 12 + yOffset, white);
    canvas.SetPixel(3 + xOffset, 12 + yOffset, secondary);
    canvas.SetPixel(4 + xOffset, 12 + yOffset, secondary);
    canvas.SetPixel(5 + xOffset, 12 + yOffset, primary);
    canvas.SetPixel(6 + xOffset, 12 + yOffset, primary);
    canvas.SetPixel(7 + xOffset, 12 + yOffset, primary);
    canvas.SetPixel(8 + xOffset, 12 + yOffset, secondary);
    canvas.SetPixel(9 + xOffset, 12 + yOffset, secondary);
    canvas.SetPixel(10 + xOffset, 12 + yOffset, secondary);
    canvas.SetPixel(11 + xOffset, 12 + yOffset, secondary);

    canvas.SetPixel(1 + xOffset, 13 + yOffset, secondary);
    canvas.SetPixel(2 + xOffset, 13 + yOffset, secondary);
    canvas.SetPixel(3 + xOffset, 13 + yOffset, secondary);
    canvas.SetPixel(4 + xOffset, 13 + yOffset, secondary);
    canvas.SetPixel(5 + xOffset, 13 + yOffset, secondary);
    canvas.SetPixel(6 + xOffset, 13 + yOffset, secondary);
    canvas.SetPixel(7 + xOffset, 13 + yOffset, secondary);
    canvas.SetPixel(8 + xOffset, 13 + yOffset, secondary);
    canvas.SetPixel(9 + xOffset, 13 + yOffset, secondary);
    canvas.SetPixel(10 + xOffset, 13 + yOffset, secondary);

    canvas.SetPixel(2 + xOffset, 14 + yOffset, primary);
    canvas.SetPixel(3 + xOffset, 14 + yOffset, primary);
    canvas.SetPixel(4 + xOffset, 14 + yOffset, primary);
    canvas.SetPixel(8 + xOffset, 14 + yOffset, primary);
    canvas.SetPixel(9 + xOffset, 14 + yOffset, primary);
    canvas.SetPixel(10 + xOffset, 14 + yOffset, primary);

    canvas.SetPixel(8 + xOffset, 15 + yOffset, primary);
    canvas.SetPixel(9 + xOffset, 15 + yOffset, primary);
    canvas.SetPixel(10 + xOffset, 15 + yOffset, primary);

    return canvas;
}