using UnityEngine;

public class PieceGenerator : MonoBehaviour
{
    public GameObject[] pieces;

    public int nextPiece;
    public int selectedPiece;

    public GameEvents ge;

    void OnEnable()
    {
        GameEvents.NP += NewPiece;
    }
    void OnDisable()
    {
        GameEvents.NP -= NewPiece;
    }
    protected virtual void Start()
    {
        nextPiece = Random.Range(0, 7);
        NextPiece();
    }
    protected virtual void NewPiece()
    {
        selectedPiece = nextPiece;
        Instantiate(pieces[selectedPiece], transform.position, Quaternion.identity);
        nextPiece = Random.Range(0, 7);
        NextPiece();
    }
    protected virtual void NextPiece()
    {
        ge.NextPiece(nextPiece);
    }
}