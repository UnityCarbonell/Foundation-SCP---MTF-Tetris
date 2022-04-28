using UnityEngine;
public class PiecesScript : MonoBehaviour
{
    private float previousTime;
    public float fallingTime = 1;

    public static int height = 20;
    public static int widht = 20;

    public bool limit = false;

    public Vector3 rotationPoint;

    private static Transform[,] grid = new Transform[widht, height];

    public GameEvents ge;

    public void OnEnable()
    {
        GameEvents.dz += FirstLevel;
        GameEvents.difo += SecondLevel;
        GameEvents.dt += ThirdLevel;
        GameEvents.dth += FourthLevel;
        GameEvents.df += FifthLevel;
    }
    public void OnDisable()
    {
        GameEvents.dz -= FirstLevel;
        GameEvents.difo -= SecondLevel;
        GameEvents.dt -= ThirdLevel;
        GameEvents.dth -= FourthLevel;
        GameEvents.df -= FifthLevel;
    }
    
    public void Update()
    {
        //Movement Controls
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
            if (!borders())
            {
                transform.position -= new Vector3(-1, 0, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
            if (!borders())
            {
                transform.position -= new Vector3(1, 0, 0);
            }
        }
        if (Time.time - previousTime > (Input.GetKey(KeyCode.DownArrow) ? fallingTime / 20 : fallingTime) 
            || Time.time - previousTime > (Input.GetKey(KeyCode.Space) ? fallingTime / 20 : fallingTime))
        {
            transform.position += new Vector3(0, -1, 0);
            if (!borders())
            {
                transform.position -= new Vector3(0, -1, 0);
                AddToGrid();
                ge.PieceLanded();
                CheckForLines();
                this.enabled = false;
                NewPiece();
            }

            previousTime = Time.time;
        }
        
        //Rotation Controls
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.RotateAround(transform.TransformPoint(rotationPoint),
                new Vector3(0, 0, 1), -90);
            if (!borders())
            {
                transform.RotateAround(transform.TransformPoint(rotationPoint),
                    new Vector3(0, 0, 1), 90);
            }
        }
    }
    
    //Grid Settings
    bool borders()
    {
        foreach (Transform child in transform)
        {
            int xNumber = Mathf.RoundToInt(child.transform.position.x);
            int yNumber = Mathf.RoundToInt(child.transform.position.y);

            if (xNumber < 0f || xNumber >= widht 
                || yNumber < 0f || yNumber >= height)
            {
                return false;
            }

            if(grid[xNumber, yNumber] != null)
            {
                return false;
            }
        }

        return true;
    }
    void AddToGrid()
    {
        foreach (Transform child in transform)
        {
            int xNumber = Mathf.RoundToInt(child.transform.position.x);
            int yNumber = Mathf.RoundToInt(child.transform.position.y);
            grid[xNumber, yNumber] = child;

            if (yNumber >= 19)
            {
                Debug.Log("Limit reached");
                limit = true;
                ge.LR();
            }
        }
    }

    //Lines
    void CheckForLines()
    {
        for (int i = height -1; i >=0; i--)
        {
            if (HasLine(i))
            {
                EraseLine(i);
                PushLineDown(i);
            }
        }
    }
    bool HasLine(int i)
    {
        for (int j = 0; j < widht; j++)
        {
            if (grid[j, i]==null)
            {
                return false;
            }
        }
        ge.ATS();
        return true;
    }
    void EraseLine(int i)
    {
        for (int j = 0; j < widht; j++)
        {
            Destroy(grid[j, i].gameObject);
            grid[j, i] = null;
        }
    }
    void PushLineDown(int i)
    {
        for (int y = i; y < height; y++)
        {
            for (int j = 0; j < widht; j++)
            {
                if (grid[j, y] != null)
                {
                    grid[j, y - 1] = grid[j, y];
                    grid[j, y] = null;
                    grid[j, y - 1].transform.position -= new Vector3(0, 1, 0);
                }
            }
        }
    }

    public void NewPiece()
    {
        if (!limit)
        {
            ge.NewPiece();
        }
    }

    //Levels
    public void FirstLevel()
    {
        fallingTime = 1.5f;
    }
    public void SecondLevel()
    {
        fallingTime = 1f;
    }
    public void ThirdLevel()
    {
        fallingTime = 0.75f;
    }
    public void FourthLevel()
    {
        fallingTime = 0.5f;
    }
    public void FifthLevel()
    {
        fallingTime = 0.25f;
    }
}