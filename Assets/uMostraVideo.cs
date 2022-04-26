using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.EventSystems;
using System.Windows;
using UnityEngine.UI;


public class uMostraVideo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public VideoPlayer wVid;
    public GameObject wRaw;
    public VideoClip wVideo;
    void Start()
    {
        //Esconde o componente de exibição do video.
        wRaw.SetActive(false);
    }
    private void pSetVideo()
    {
        //Atribui o video desejado ao componente de exibição do video.
        wVid.Prepare();
        wVid.clip = wVideo;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        //Torna o componente de video visível e inicializa o video.
        if (Input.GetKey(KeyCode.LeftControl))
        {
            pSetVideo();
            wRaw.SetActive(true);
            wVid.Play();
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        //Finaliza a execução do video e esconde o componente de exibição do video.
        wVid.Stop();
        wRaw.SetActive(false);
    }
}
