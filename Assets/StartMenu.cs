using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

    [SerializeField]
   private GameObject Newcam;

    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private GameObject Menu;

    [SerializeField]
    private GameObject Ingame;


    public void Play()
    {
        Newcam.SetActive(false);
        Player.SetActive(true);
        Ingame.SetActive(true);
        Menu.SetActive(false);

    }
    public void Exit()
    {
        Application.Quit();
    }
}
