using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{

    public Button btMatrixScene;
    public Button btSplineScene;
    public Button btClose;

    void Start()
    {
        //Atribui as rotinas ao evento de clique dos botões.
        btMatrixScene.onClick.AddListener(matrixSceneOpener);
        btSplineScene.onClick.AddListener(splineSceneOpener);
        btClose.onClick.AddListener(appCloser);
    }
    void matrixSceneOpener()
    {
        //Abre a cena de matrizes.
        SceneManager.LoadScene("MatrixScene", LoadSceneMode.Single);
    }
    void splineSceneOpener()
    {
        //Abre a cena de splines. 
        SceneManager.LoadScene("SplineScene", LoadSceneMode.Single);
    }
    void appCloser()
    {
        //Fecha a aplicação.
        Application.Quit();
    }


}
