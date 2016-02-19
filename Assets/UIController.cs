using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class UIController : MonoBehaviour {

    public GameObject StartPanel;

    public GameObject goodKnight;
    public GameObject cinthol;
    public GameObject stellaBall;
    public GameObject softnGentle;

    public GameObject hand;
    public GameObject handText;

    public GameObject godrej;

	// Use this for initialization
	void Start () {
        DOTween.Init();


        //Initially main 4 buttons are hidden
        goodKnight.SetActive(false);
        cinthol.SetActive(false);
        stellaBall.SetActive(false);
        softnGentle.SetActive(false);
	}

    public void MainButtonAnimation() {
        goodKnight.SetActive(true);
        cinthol.SetActive(true);
        stellaBall.SetActive(true);
        softnGentle.SetActive(true);

        Destroy(hand);
        Destroy(handText);

        goodKnight.transform.DOMove(godrej.transform.position, 0.5f).SetEase(Ease.OutBack).SetDelay(0.0f).From();
        cinthol.transform.DOMove(godrej.transform.position, 0.5f).SetEase(Ease.OutBack).SetDelay(0.1f).From();
        stellaBall.transform.DOMove(godrej.transform.position, 0.5f).SetEase(Ease.OutBack).SetDelay(0.2f).From();
        softnGentle.transform.DOMove(godrej.transform.position, 0.5f).SetEase(Ease.OutBack).SetDelay(0.3f).From();

        goodKnight.transform.DOScale(0, 0.5f).SetDelay(0.0f).From();
        cinthol.transform.DOScale(0, 0.5f).SetDelay(0.1f).From();
        stellaBall.transform.DOScale(0, 0.5f).SetDelay(0.2f).From();
        softnGentle.transform.DOScale(0, 0.5f).SetDelay(0.3f).From();

        godrej.GetComponent<Button>().enabled = false; // disable after first touch
    }

    public void resetScreen() {
        Application.LoadLevel(0);
    }
}
