using UnityEngine;

public class CaosPieceGeneratorScript : PieceGenerator
{
    protected override void Start()
    {
        nextPiece = Random.Range(0, 19);
        NextPiece();
    }
    protected override void NewPiece()
    {
        selectedPiece = nextPiece;
        Instantiate(pieces[selectedPiece], transform.position, Quaternion.identity);
        nextPiece = Random.Range(0, 19);
        NextPiece();
    }
    protected override void NextPiece()
    {
        ge.NextCaosPiece(nextPiece);
    }
}
