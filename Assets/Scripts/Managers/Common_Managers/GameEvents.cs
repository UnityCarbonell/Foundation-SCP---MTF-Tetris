using UnityEngine;

public class GameEvents : MonoBehaviour
{
    //General events
    public delegate void GeneratePiece();
    public static event GeneratePiece NP;

    public delegate void AddToScore();
    public static event AddToScore ats;

    public delegate void LimitReached();
    public static event LimitReached lr;

    public delegate void PauseOff();
    public static event PauseOff poff;
    
    //Audio
    public delegate void Landed();
    public static event Landed pieceLanded;

    //Difficulty level
    public delegate void DifZero();
    public static event DifZero dz;

    public delegate void DifOne();
    public static event DifOne difo;

    public delegate void DifTwo();
    public static event DifTwo dt;

    public delegate void DifThree();
    public static event DifThree dth;

    public delegate void DifFour();
    public static event DifFour df;

    //Next Piece
    public delegate void NiNI();
    public static event NiNI i;

    public delegate void NiNJ();
    public static event NiNJ j;

    public delegate void NiNL();
    public static event NiNL l;

    public delegate void NiNO();
    public static event NiNO o;

    public delegate void NiNS();
    public static event NiNS s;

    public delegate void NiNT();
    public static event NiNT t;

    public delegate void NiNZ();
    public static event NiNZ z;

    //Next Penta Piece
    public delegate void NiPF();
    public static event NiPF pf;

    public delegate void NiPI();
    public static event NiPI pi;

    public delegate void NiPL();
    public static event NiPL pl;

    public delegate void NiPN();
    public static event NiPN pn;

    public delegate void NiPP();
    public static event NiPP pp;

    public delegate void NiPT();
    public static event NiPT pt;

    public delegate void NiPU();
    public static event NiPU pu;

    public delegate void NiPV();
    public static event NiPV pv;

    public delegate void NiPW();
    public static event NiPW pw;

    public delegate void NiPX();
    public static event NiPX px;

    public delegate void NiPY();
    public static event NiPY py;

    public delegate void NiPZ();
    public static event NiPZ pz;

    public void Awake()
    {
        NewPiece();
        DZ();
    }
    public void NewPiece()
    {
        NP();
    }
    public void ATS()
    {
        ats();
    }
    public void LR()
    {
        lr();
    }
    public void POff()
    {
        poff();
    }
    //Audio events
    public void PieceLanded()
    {
        pieceLanded();
    }
    //Difficulty level
    public void DZ()
    {
        dz();
    }
    public void DO()
    {
        difo();
    }
    public void DT()
    {
        dt();
    }
    public void DTH()
    {
        dth();
    }
    public void DF()
    {
        df();
    }
    //Next Piece
    public void NextPiece(int a)
    {
        switch (a)
        {
            case 0:
                i();
                break;
            case 1:
                j();
                break;
            case 2:
                l();
                break;
            case 3:
                o();
                break;
            case 4:
                s();
                break;
            case 5:
                t();
                break;
            case 6:
                z();
                break;
        }
    }
    //Next Penta Piece
    public void NextPentaPiece(int b)
    {
        switch (b)
        {
            case 0:
                pf();
                break;
            case 1:
                pi();
                break;
            case 2:
                pl();
                break;
            case 3:
                pn();
                break;
            case 4:
                pp();
                break;
            case 5:
                pt();
                break;
            case 6:
                pu();
                break;
            case 7:
                pv();
                break;
            case 8:
                pw();
                break;
            case 9:
                px();
                break;
            case 10:
                py();
                break;
            case 11:
                pz();
                break;
        }
    }
    //Next Caos Piece
    public void NextCaosPiece(int c)
    {
        switch (c)
        {
            case 0:
                i();
                break;
            case 1:
                j();
                break;
            case 2:
                l();
                break;
            case 3:
                o();
                break;
            case 4:
                s();
                break;
            case 5:
                t();
                break;
            case 6:
                z();
                break;
            case 7:
                pf();
                break;
            case 8:
                pi();
                break;
            case 9:
                pl();
                break;
            case 10:
                pn();
                break;
            case 11:
                pp();
                break;
            case 12:
                pt();
                break;
            case 13:
                pu();
                break;
            case 14:
                pv();
                break;
            case 15:
                pw();
                break;
            case 16:
                px();
                break;
            case 17:
                py();
                break;
            case 18:
                pz();
                break;
        }
    }
}