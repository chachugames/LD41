using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlane : MonoBehaviour {
    public GameObject gameOver, counterText;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject.tag == "Player")
        {
            counterText.SetActive(false);
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
