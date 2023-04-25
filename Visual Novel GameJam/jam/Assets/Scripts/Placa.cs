using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Placa : MonoBehaviour
{
   
    public GameObject caixaDialogo;
    public Text textoDialogo;
    public string dialogo;
    public bool isActive;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isActive)
        {
            if (caixaDialogo.activeInHierarchy)
            {
                caixaDialogo.SetActive(false);
            }
            else
            {
                caixaDialogo.SetActive(true);
                textoDialogo.text = dialogo;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isActive = false;
            caixaDialogo.SetActive(false);
        }
    }
}
