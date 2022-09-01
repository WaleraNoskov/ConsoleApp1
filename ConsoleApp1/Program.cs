using ConsoleApp1;

int[,] map =
{
    {0,0,0,1,1,0,0},
    {0,0,0,1,0,0,0},
    {1,1,0,0,0,0,0},
    {0,1,0,0,1,0,1},
    {0,0,0,1,1,1,1},
    {1,0,0,0,1,0,1},
    {1,1,0,0,1,0,1},
};

var mapSizeX = map.GetLength(1);
var mapSizeY = map.Length / mapSizeX;
var mapChecked = new int[mapSizeX, mapSizeY];

var cartographer = new Cartographer(map);

Console.WriteLine(cartographer.MakeMap());
