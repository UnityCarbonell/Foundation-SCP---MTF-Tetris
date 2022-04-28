using UnityEngine;

public class PentaPieceGenerator : PieceGenerator
{
    protected override void Start()
    {
        nextPiece = Random.Range(0, 12);
        NextPiece();
    }
    protected override void NewPiece()
    {
        selectedPiece = nextPiece;
        Instantiate(pieces[selectedPiece], transform.position, Quaternion.identity);
        nextPiece = Random.Range(0, 12);
        NextPiece();
    }
    protected override void NextPiece()
    {
        ge.NextPentaPiece(nextPiece);
    }
}