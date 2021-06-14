using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("SampleScene");
        }  
    }

    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if(collision.gameObject.tag == "Player" && this.gameObject.tag == "FallForest")
    //     {
    //         collision.gameObject.transform.position = new Vector3(-11, -2, 0);
    //         SceneManager.LoadScene("SampleScene");
    //     }

    //     if(collision.gameObject.tag == "Player" && this.gameObject.tag == "FallDesert")
    //     {
    //         collision.gameObject.transform.position = new Vector3(45, 1, 0);
    //         SceneManager.LoadScene("SampleScene");
    //     }
    //     }
}
