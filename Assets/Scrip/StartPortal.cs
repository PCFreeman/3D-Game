using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartPortal : MonoBehaviour
{




    void OnTriggerEnter(Collider colider)
    {
        if (colider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }

    }

}

