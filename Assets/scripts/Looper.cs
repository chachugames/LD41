using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Looper : MonoBehaviour {
    public GameObject player, mainCamera;
    private Vector3 playerInitialPos, cameraInitialPos;
    public GameObject black, text, win;
    CanvasGroup cg;
    // Use this for initialization
    void Start () {
        playerInitialPos = player.transform.position;
        cameraInitialPos = mainCamera.transform.position;
        cg = black.GetComponent<CanvasGroup>();
    }

    IEnumerator FadeInRoutine()
    {
        player.GetComponent<PlayerController>().canMove = false;
        mainCamera.GetComponent<CameraTracker>().autoMove = false;
        cg.alpha = 0;
        while (cg.alpha < 1)
        {
            cg.alpha += Time.deltaTime;
            yield return null;
        }
        
        cg.interactable = true;
        yield return null;
    }

    IEnumerator FadeOutRoutine()
    {
        player.transform.position = playerInitialPos;
        mainCamera.transform.position = cameraInitialPos;
        cg.interactable = false;
        while (cg.alpha > 0)
        {
            cg.alpha -= Time.deltaTime;
            yield return null;
        }
        black.SetActive(false);
        player.GetComponent<PlayerController>().canMove = true;
        mainCamera.GetComponent<CameraTracker>().autoMove = true;
        yield return null;
    }
    public void loop()
    {
        StartCoroutine(FadeOutRoutine());
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(player.GetComponent<PickupTracker>().collected == player.GetComponent<PickupTracker>().total)
            { 
                win.SetActive(true);
                player.SetActive(false);
                mainCamera.GetComponent<CameraTracker>().autoMove = false;
                return;
            }
            black.SetActive(true);
            StartCoroutine(FadeInRoutine());
        }
    }
}
