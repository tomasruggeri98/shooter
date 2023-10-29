using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ControladorPuntos : MonoBehaviour
{
    public static ControladorPuntos instance;

    [SerializeField] private int puntajeActual;
    [SerializeField] private int puntajeMaximo;
    public event EventHandler<SumarPuntosEventArgs> sumarPuntosEvent;
    public class SumarPuntosEventArgs : EventArgs
    {
        public int puntajeActualEvent;
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else { 
            instance = this;
        }
    }

    private void Start()
    {
       puntajeMaximo = PlayerPrefs.GetInt("PuntajeMaximo");
    }

    public void SumarPuntos(int puntos)
    {
        puntajeActual += puntos;
        if (puntajeActual > puntajeMaximo)
        {
            puntajeMaximo = puntajeActual;
            PlayerPrefs.SetInt("PuntajeMaximo", puntajeMaximo);
        }

        sumarPuntosEvent?.Invoke(this, new SumarPuntosEventArgs { puntajeActualEvent = puntajeActual });
    }


}
