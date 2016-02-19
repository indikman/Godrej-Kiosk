using UnityEngine;
using System.Collections;
using DG.Tweening;

public class SwitchPanel : MonoBehaviour {

    public GameObject PanelThatShouldClose;
    public GameObject PanelThatShouldOpen;

   // public MovieTexture


    public void Switch()
    {
        PanelThatShouldClose.SetActive(false);
        PanelThatShouldOpen.SetActive(true);
        PanelThatShouldOpen.transform.DOMoveY(PanelThatShouldOpen.transform.position.y + 10.0f, 0.4f).From().SetEase(Ease.OutCubic);
    }
}
