using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

    public GameObject enemy;
    void OnTriggerEnter(Collider colider)
    {
       if(colider.gameObject.tag == "Player")
        {
            enemy.gameObject.SetActive(true);
        }
    }
}
