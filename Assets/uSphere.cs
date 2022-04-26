using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class uSphere : MonoBehaviour
{
    private bool wMouseOver = false;
    private float wT;

    void Update()
    {
        //Rotina que mostra o hint dos pontos.
        if ((wMouseOver))
        {
            tooltip.pShowTooltip_Static("T = " + wT);
        }
    }
    public void setT(float prfloat)
    {
        //Rotina que atribui o valor ao hint.
        wT = prfloat;
    }
    public void OnMouseExit()
    {
        //Rotina que esconde o hint.
        wMouseOver = false;
        tooltip.pHideTooltip_Static();
    }
    public void OnMouseOver()
    {
        //Rotina que ativa a variável que sinaliza que o ponto está sendo focado.
        wMouseOver = true;
    }
}
