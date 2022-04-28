using UnityEngine;
using UnityEngine.UI;

public class PentaUIManager : MonoBehaviour
{
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

    public int piece = 12;

    private void OnEnable()
    {
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
    private void Awake()
    {
        piece = 12;
        ChangeImage(piece);
    }
    void ChangeImage(int aux)
    {
        switch (aux)
        {
            case 0:
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
            case 1:
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
            case 2:
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
            case 3:
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
            case 4:
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
            case 5:
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
            case 6:
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
            case 7:
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
            case 8:
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
            case 9:
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
            case 10:
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
            case 11:
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
            case 12:
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
    public void npf() 
    {
        piece = 0;
        ChangeImage(piece);
    }
    public void npi()
    {
        piece = 1;
        ChangeImage(piece);
    }
    public void npl()
    {
        piece = 2;
        ChangeImage(piece);
    }
    public void npn()
    {
        piece = 3;
        ChangeImage(piece);
    }
    public void npp()
    {
        piece = 4;
        ChangeImage(piece);
    }
    public void npt()
    {
        piece = 5;
        ChangeImage(piece);
    }
    public void npu()
    {
        piece = 6;
        ChangeImage(piece);
    }
    public void npv()
    {
        piece = 7;
        ChangeImage(piece);
    }
    public void npw()
    {
        piece = 8;
        ChangeImage(piece);
    }
    public void npx()
    {
        piece = 9;
        ChangeImage(piece);
    }
    public void npy()
    {
        piece = 10;
        ChangeImage(piece);
    }
    public void npz()
    {
        piece = 11;
        ChangeImage(piece);
    }
}