using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
<<<<<<< Updated upstream
=======
using UnityEngine.UI;
>>>>>>> Stashed changes

public class BiteByWolf : MonoBehaviour
{
    GameObject _player;
<<<<<<< Updated upstream
=======
    public Text textHints;
>>>>>>> Stashed changes

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
<<<<<<< Updated upstream
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
=======
            textHints.SendMessage("Wilk ciê ugryz³");
            Invoke("SwitchScene", 4.0f);
>>>>>>> Stashed changes
        }
    }
}
