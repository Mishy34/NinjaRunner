using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dog : MonoBehaviour
{
    public GameObject winScrn ;
    private void OnCollisionEnter2D(Collision2D other){

        if(other.gameObject.tag == "Player"){

            winScrn.gameObject.SetActive(true);
        }
    }
}
