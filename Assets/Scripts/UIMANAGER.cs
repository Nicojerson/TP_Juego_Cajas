using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIMANAGER : MonoBehaviour
{
    public TextMeshProUGUI textoPerdiste;
    public TextMeshProUGUI textoTiempo;


    // Start is called before the first frame update
    void Start()
    {
        textoPerdiste.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float tiempo = Time.time;
        textoTiempo.text = "Tiempo: " + tiempo.ToString("F2");
    }
}
