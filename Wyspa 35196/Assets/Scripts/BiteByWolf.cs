using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BiteByWolf : MonoBehaviour
{
    GameObject _player;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
<<<<<<< Updated upstream
            SceneManager.LoadScene("Menu");
=======
            // SprawdŸ, czy obiekt posiada skrypt showDieInfo
            showDieInfo dieInfoScript = other.GetComponent<showDieInfo>();
            if (dieInfoScript != null)
            {
                dieInfoScript.OnWolfBite();
            }

            Invoke("SwitchScene", 0.1f);
>>>>>>> Stashed changes
        }
    }
}
