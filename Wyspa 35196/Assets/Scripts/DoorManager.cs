using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    bool doorIsOpen = false;
    float doorTimer = 0.0f;
    public float doorOpenTime = 3.0f;
    public AudioClip doorOpenSound;
    public AudioClip doorShutSound;
    GameObject currentDoor;

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream

=======
        
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        if (doorIsOpen)
        {
            doorTimer += Time.deltaTime;
        }
        if (doorTimer > doorOpenTime)
        {
            Door(doorShutSound, false, "doorshut");
            doorTimer = 0.0f;
        }
<<<<<<< Updated upstream
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 3))
        {
            if (hit.collider.gameObject.tag == "playerDoor")
            {
                currentDoor = hit.collider.gameObject;
                currentDoor.SendMessage("DoorCheck");
            }
        }
    }

    void DoorCheck()
    {
        if (!doorIsOpen)
        {
=======
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "playerDoor" && doorIsOpen == false)
        {
            currentDoor = hit.gameObject;
>>>>>>> Stashed changes
            Door(doorOpenSound, true, "dooropen");
        }
    }

    void Door(AudioClip aClip, bool openCheck, string animName)
    {
        doorIsOpen = openCheck;
        currentDoor.GetComponent<AudioSource>().PlayOneShot(aClip);
        currentDoor.transform.parent.GetComponent<Animation>().Play(animName);
    }
}
