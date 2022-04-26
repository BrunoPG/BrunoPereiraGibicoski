using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tooltip : MonoBehaviour
{

    public static tooltip instance;
    private Text tooltipText;

    private RectTransform bgRectTrans;

    private void Awake()
    {
        //Rotina que inicializa o componente de hint.
        instance = this;
        bgRectTrans = transform.Find("/Canvas/Tooltip/bgTooltip").GetComponent<RectTransform>();
        tooltipText = transform.Find("/Canvas/Tooltip/textTooltip").GetComponent<Text>();
        pHideTooltip();
    }
    private void Update()
    {
        //Rotina altera a posição do hint.
        Vector2 localpoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent.GetComponent<RectTransform>(), Input.mousePosition, null, out localpoint);
        transform.localPosition = localpoint;
    }
    private void pShowTooltip(string tooltipString)
    {
        //Rotina que mostra o hint.
        gameObject.SetActive(true);
        tooltipText.text = tooltipString;
        float textPaddingSize = 4f;
        Vector2 bgSize = new Vector2(tooltipText.preferredWidth + textPaddingSize * 2f, tooltipText.preferredHeight + textPaddingSize * 2f);
        bgRectTrans.sizeDelta = bgSize;
    }
    private void pHideTooltip()
    {
        //Rotina que esconde hint.
        gameObject.SetActive(false);
    }
    public static void pShowTooltip_Static(string tooltipString)
    {
        //Rotina estática que mostra o hint.
        instance.pShowTooltip(tooltipString);
    }
    public static void pHideTooltip_Static()
    {
        //Rotina estática que esconde o hint.
        instance.pHideTooltip();
    }
}
