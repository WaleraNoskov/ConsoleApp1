namespace ConsoleApp1;

/* Coordinates must be in 'y,x' format for arrays!!
 * 
 */

public class Cartographer
{
    private int[,] map;
    private int[,] mapChecked;
    private int mapSizeX;
    private int mapSizeY;
    private int IslandCount = 0;
    
    public Cartographer(int[,] map)
    {
        this.map = map;
        mapSizeX = map.GetLength(1);
        mapSizeY = map.Length / mapSizeX;
        mapChecked = new int[mapSizeX, mapSizeY];
    }

    public int MakeMap()
    {
        for (int y = 0; y < mapSizeY; y++)
        {
            for (int x = 0; x < mapSizeX; x++)
            {
                if (!IsSectorChecked(x, y))
                {
                    if (map[y, x] == 1)
                    {
                        IslandCount++;
                        ResearchArea(x,y);
                    }
                    CheckSector(x,y);
                }
                
            }
        }
        return this.IslandCount;
    }

    private void ResearchArea(int x, int y)
    {
        CheckSector(x, y);
        
        //up
        if (y > 0 && !IsSectorChecked(x,y-1) && map[y-1,x]==1 )
            ResearchArea(x,y-1);
        //left
        if (x > 0 && !IsSectorChecked(x-1,y) && map[y,x-1]==1 )
            ResearchArea(x-1,y);
        //down
        if (y < mapSizeY-1 && !IsSectorChecked(x,y+1) && map[y+1,x]==1 )
            ResearchArea(x,y+1);
        //right
        if (x < mapSizeX-1 && !IsSectorChecked(x+1,y) && map[y,x+1]==1 )
            ResearchArea(x+1,y);
    }
    
    private bool IsSectorChecked(int x, int y)
    {
        return mapChecked[y, x] == 1;
    }

    private void CheckSector(int x, int y)
    {
        mapChecked[y, x] = 1;
    }
}