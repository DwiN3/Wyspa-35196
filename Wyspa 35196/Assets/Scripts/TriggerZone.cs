using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerZone : MonoBehaviour
{
    public AudioClip lockedSound;
    public Light doorLight;
    public Text textHints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PowerGUI") && Inventory.charge == 4)
        {
            doorLight.color = Color.green;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Inventory.charge == 4)
            {
                Destroy(GameObject.Find("PowerGUI"));
                transform.Find("door").SendMessage("DoorCheck");
            }
            else
            {
                transform.Find("door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
                col.gameObject.SendMessage("HUDon");
                textHints.SendMessage("ShowHint", "Te drzwi wygl¹daj¹ na zamkniête, \n byæ mo¿e generatorwymaga \n odpowiedniego zasilania...");
            }
        }
    }
}
