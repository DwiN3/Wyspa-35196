using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BiteByWolf : MonoBehaviour
{
    GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
            // Znajd� obiekt ze skryptem showDieInfo w scenie
            showDieInfo showInfoScript = FindObjectOfType<showDieInfo>();

            // Je�li znaleziono skrypt, zmie� warto�� showInfo na true
            if (showInfoScript != null)
            {
                showInfoScript.SetShowInfo(true);
            }

            // Prze��cz scen� po 0.1 sekundy
            Invoke("SwitchScene", 0.1f);
        }
    }

    void SwitchScene()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("Menu");
    }
}
