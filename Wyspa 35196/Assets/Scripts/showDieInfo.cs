using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showDieInfo : MonoBehaviour
{
    bool showInfo = false;

    void Start()
    {
        SetObjectVisibility();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            showInfo = !showInfo;
            SetObjectVisibility();
        }
    }

    void SetObjectVisibility()
    {
        Collider collider = GetComponent<Collider>();

        if (collider != null)
        {
            collider.enabled = showInfo;
        }
        else
        {
            gameObject.SetActive(showInfo);
        }
    }

    // Dodaj now� metod�, kt�ra b�dzie wywo�ywana po ugryzieniu wilka
    public void OnWolfBite()
    {
        // Zmiana warto�ci showInfo po ugryzieniu
        showInfo = true;
        SetObjectVisibility();
    }
}
