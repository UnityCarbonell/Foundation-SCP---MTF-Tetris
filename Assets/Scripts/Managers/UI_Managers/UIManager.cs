using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //Images for the next pieces 
    public Image NextI;
    public Image NextJ;
    public Image NextL;
    public Image NextO;
    public Image NextS;
    public Image NextT;
    public Image NextZ;

    public int piece = 7;

    private void OnEnable()
    {
        GameEvents.i += ni;
        GameEvents.j += nj;
        GameEvents.l += nl;
        GameEvents.o += no;
        GameEvents.s += ns;
        GameEvents.t += nt;
        GameEvents.z += nz;
    }
    private void OnDisable()
    {
        GameEvents.i -= ni;
        GameEvents.j -= nj;
        GameEvents.l -= nl;
        GameEvents.o -= no;
        GameEvents.s -= ns;
        GameEvents.t -= nt;
        GameEvents.z -= nz;
    }

    private void Awake()
    {
        piece = 7;
        ChangeImage(piece);
    }
    void ChangeImage(int aux)
    {
        switch (aux)
        {
            case 0:
                NextI.enabled = true;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                break;
            case 1:
                NextI.enabled = false;
                NextJ.enabled = true;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                break;
            case 2:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = true;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                break;
            case 3:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = true;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                break;
            case 4:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = true;
                NextT.enabled = false;
                NextZ.enabled = false;
                break;
            case 5:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = true;
                NextZ.enabled = false;
                break;
            case 6:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = true;
                break;
            case 7:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                break;
        }
    }


    //piece settings
    public void ni()
    {
        piece = 0;
        ChangeImage(piece);
    }
    public void nj()
    {
        piece = 1;
        ChangeImage(piece);
    }
    public void nl()
    {
        piece = 2;
        ChangeImage(piece);
    }
    public void no()
    {
        piece = 3;
        ChangeImage(piece);
    }
    public void ns()
    {
        piece = 4;
        ChangeImage(piece);
    }
    public void nt()
    {
        piece = 5;
        ChangeImage(piece);
    }
    public void nz()
    {
        piece = 6;
        ChangeImage(piece);
    }
}