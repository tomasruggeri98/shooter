using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PuntajeText : MonoBehaviour
{

    private TextMeshProUGUI textMeshProUGUI;
    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        ControladorPuntos.instance.sumarPuntosEvent += CambiarTexto;
        
    }

    public void CambiarTexto(object sender, ControladorPuntos.SumarPuntosEventArgs e)
    {
        textMeshProUGUI.text = e.puntajeActualEvent.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
