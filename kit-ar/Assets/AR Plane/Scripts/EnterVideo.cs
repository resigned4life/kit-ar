using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterVideo : MonoBehaviour
{
    //public GameObject GlobeVideo;
    public GameObject CanvasText;
    public GameObject Videos;


    // Start is called before the first frame update
    void Start()
    {
        CanvasText.SetActive(true);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CanvasText.SetActive(false);
            Videos.SetActive(true);
        }
    }
}
