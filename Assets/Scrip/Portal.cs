using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Portal : MonoBehaviour
{



    void OnTriggerEnter(Collider colider)
    {
        if (colider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
        
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
