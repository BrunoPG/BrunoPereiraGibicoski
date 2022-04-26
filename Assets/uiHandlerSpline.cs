using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiHandlerSpline : MonoBehaviour
{
    public Button btVoltar;
    public Button btInstructions;
    public Button btInstructionsClose;
    public GameObject HelpPanel;

    void Start()
    {
        //Rotina que fecha a tela de tutorial.Rotina que aplica os eventos aos botões da tela de splines.
        btInstructionsCloseClick();
        btVoltar.onClick.AddListener(btVoltarClick);
        btInstructions.onClick.AddListener(btInstructionsClick);
        btInstructionsClose.onClick.AddListener(btInstructionsCloseClick);
        GameObject.Find("/Canvas/uQtdPoints").GetComponent<InputField>().text = "10";
    }

    void btVoltarClick()
    {
        //Rotina que volta para o menu principal.
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
    void btInstructionsClick()
    {
        //Rotina que abre a tela de tutorial.
        if (HelpPanel != null)
        {
            HelpPanel.SetActive(true);
            HelpPanel.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
        }
    }
    void btInstructionsCloseClick()
    {
        //Rotina que fecha a tela de tutorial.
        HelpPanel.SetActive(false);
    }
}
