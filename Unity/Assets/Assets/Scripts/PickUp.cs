using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;
//this script can be found in the Component section under the option Character Set Up 
//Interact

[AddComponentMenu("Character Set Up/Interact")]
public class PickUp : MonoBehaviour
{
    #region Variables
    //We are setting up these variable and the tags in update for week 3,4 and 5
    [Header("Player and Camera connection")]
    //create two gameobject variables one called player and the other mainCam
    public GameObject player;
    public GameObject mainCam;
    #endregion

    #region Start
    void Start()
    {
        //connect our player to the player variable via tag
        player = GameObject.FindGameObjectWithTag("Player");
        //connect our Camera to the mainCam variable via tag
        player = GameObject.FindGameObjectWithTag("MainCamera");
    }
    #endregion

    #region Update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray interact;

            interact = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));

            RaycastHit hitinfo;

            if (Physics.Raycast(interact,out hitinfo, 10))
            {
                if (hitinfo.collider.CompareTag("Titan_Trigger_Kyn"))
                {
                    SceneManager.LoadScene("Kyn_Load");
                }

                if (hitinfo.collider.CompareTag("Titan_Trigger_Tiot"))
                {
                    SceneManager.LoadScene("Tiot_Load");
                }
            }
        }
    }
    //if our interact key is pressed
    //create a ray
    //this ray is shooting out from the main cameras screen point center of screen
    //create hit info
    //if this physics raycast hits something within 10 units
    #region NPC tag
    //and that hits info is tagged NPC
    //Debug that we hit a NPC
    #endregion
    #region Item
    //and that hits info is tagged Item
    //Debug that we hit an Item
    #endregion
    #endregion
}






