using UnityEngine;
using UnityEngine.UI;

public class CaosUIManager : MonoBehaviour
{
    //Images for the next normal pieces 
    public Image NextI;
    public Image NextJ;
    public Image NextL;
    public Image NextO;
    public Image NextS;
    public Image NextT;
    public Image NextZ;

    //Images for the next penta pieces
    public Image NextPF;
    public Image NextPI;
    public Image NextPL;
    public Image NextPN;
    public Image NextPP;
    public Image NextPT;
    public Image NextPU;
    public Image NextPV;
    public Image NextPW;
    public Image NextPX;
    public Image NextPY;
    public Image NextPZ;

    public int piece = 19;

    private void OnEnable()
    {
        GameEvents.i += ni;
        GameEvents.j += nj;
        GameEvents.l += nl;
        GameEvents.o += no;
        GameEvents.s += ns;
        GameEvents.t += nt;
        GameEvents.z += nz;
        GameEvents.pf += npf;
        GameEvents.pi += npi;
        GameEvents.pl += npl;
        GameEvents.pn += npn;
        GameEvents.pp += npp;
        GameEvents.pt += npt;
        GameEvents.pu += npu;
        GameEvents.pv += npv;
        GameEvents.pw += npw;
        GameEvents.px += npx;
        GameEvents.py += npy;
        GameEvents.pz += npz;
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
        GameEvents.pf -= npf;
        GameEvents.pi -= npi;
        GameEvents.pl -= npl;
        GameEvents.pn -= npn;
        GameEvents.pp -= npp;
        GameEvents.pt -= npt;
        GameEvents.pu -= npu;
        GameEvents.pv -= npv;
        GameEvents.pw -= npw;
        GameEvents.px -= npx;
        GameEvents.py -= npy;
        GameEvents.pz -= npz;
    }
    public void Awake()
    {
        piece = 19;
        ChangeImage(piece);
    }
    public void ChangeImage(int aux)
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
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 1:
                NextI.enabled = false;
                NextJ.enabled = true;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 2:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = true;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 3:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = true;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 4:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = true;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 5:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = true;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 6:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = true;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 7:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = true;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 8:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = true;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 9:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = true;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 10:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = true;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 11:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = true;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 12:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = true;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 13:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = true;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 14:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = true;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 15:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = true;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 16:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = true;
                NextPY.enabled = false;
                NextPZ.enabled = false;
                break;
            case 17:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = true;
                NextPZ.enabled = false;
                break;
            case 18:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = true;
                break;
            case 19:
                NextI.enabled = false;
                NextJ.enabled = false;
                NextL.enabled = false;
                NextO.enabled = false;
                NextS.enabled = false;
                NextT.enabled = false;
                NextZ.enabled = false;
                NextPF.enabled = false;
                NextPI.enabled = false;
                NextPL.enabled = false;
                NextPN.enabled = false;
                NextPP.enabled = false;
                NextPT.enabled = false;
                NextPU.enabled = false;
                NextPV.enabled = false;
                NextPW.enabled = false;
                NextPX.enabled = false;
                NextPY.enabled = false;
                NextPZ.enabled = false;
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
    public void npf()
    {
        piece = 7;
        ChangeImage(piece);
    }
    public void npi()
    {
        piece = 8;
        ChangeImage(piece);
    }
    public void npl()
    {
        piece = 9;
        ChangeImage(piece);
    }
    public void npn()
    {
        piece = 10;
        ChangeImage(piece);
    }
    public void npp()
    {
        piece = 11;
        ChangeImage(piece);
    }
    public void npt()
    {
        piece = 12;
        ChangeImage(piece);
    }
    public void npu()
    {
        piece = 13;
        ChangeImage(piece);
    }
    public void npv()
    {
        piece = 14;
        ChangeImage(piece);
    }
    public void npw()
    {
        piece = 15;
        ChangeImage(piece);
    }
    public void npx()
    {
        piece = 16;
        ChangeImage(piece);
    }
    public void npy()
    {
        piece = 17;
        ChangeImage(piece);
    }
    public void npz()
    {
        piece = 18;
        ChangeImage(piece);
    }
}