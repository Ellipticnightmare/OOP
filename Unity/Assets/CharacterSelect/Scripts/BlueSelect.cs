using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueSelect : MonoBehaviour
{
    public GameObject blueShip;
    public GameObject redShip;
    public GameObject greenShip;

    public void ClickUp()
    {
        if (blueShip.activeSelf)
        {
            blueShip.SetActive(false);
            redShip.SetActive(true);
            Debug.Log("RED");
        }
        else if (redShip.activeSelf)
        {
            redShip.SetActive(false);
            greenShip.SetActive(true);
            Debug.Log("GREEN");
        }
        else if (greenShip.activeSelf)
        {
            greenShip.SetActive(false);
            blueShip.SetActive(true);
            Debug.Log("BLUE");
        }
    }

    public void ClickDown()
    {
        if (redShip.activeSelf)
        {
            blueShip.SetActive(true);
            redShip.SetActive(false);
            greenShip.SetActive(false);
            Debug.Log("RED");
        }
        else if (greenShip.activeSelf)
        {
            redShip.SetActive(true);
            greenShip.SetActive(false);
            blueShip.SetActive(false);
            Debug.Log("GREEN");
        }
        else if (blueShip.activeSelf)
        {
            greenShip.SetActive(true);
            blueShip.SetActive(false);
            redShip.SetActive(false);
            Debug.Log("BLUE");
        }
    }
}