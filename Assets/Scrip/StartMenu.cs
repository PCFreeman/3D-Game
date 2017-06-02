using UnityEngine;
using UnityEngine.SceneManagement;
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

    public GameObject portal;

    public void Play()
    {
        Newcam.SetActive(false);
        Player.SetActive(true);
        Ingame.SetActive(true);
        Menu.SetActive(false);
        Vector3 position = new Vector3(Random.Range(459f, 225f),50, Random.Range(208f, 440f));
        portal.transform.position = position;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
