using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Materia : MonoBehaviour
{
    public string Nombre;
    public int Creditos;
    public bool Matriculado = false;
    public TMP_Text NombreText;
    public TMP_Text CreditosText;

    void Awake()
    {
        NombreText.text = Nombre;
        CreditosText.text = $"Costo Creditos: {Creditos}";
    }
}
