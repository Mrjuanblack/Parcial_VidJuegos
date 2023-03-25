using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float VelocidadMax;
    private float velH;
    private float velV;
    Transform thisTransform;

    public TMP_Text textoCreditosRef;
    public int creditos = 50;

	private void Awake()
	{
        velH = 0.0f;
        velV = 0.0f;
        thisTransform = GetComponent<Transform>();
        textoCreditosRef.text = $"Creditos: {creditos}";

    }

	// Update is called once per frame
	void Update()
    {
        velH = Input.GetAxis("Horizontal");
        velV = Input.GetAxis("Vertical");

        thisTransform.position = new Vector3(transform.position.x + (velH * VelocidadMax) * Time.deltaTime, transform.position.y, transform.position.z + (velV * VelocidadMax) * Time.deltaTime);
    }

	private void OnTriggerEnter(Collider other)
	{
        
	}

	private void OnTriggerStay(Collider other)
	{
        if (other.gameObject.CompareTag("Materia"))
        {
            Materia materiaRef = other.gameObject.GetComponent<Materia>();
            if (!materiaRef.Matriculado)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    Debug.Log("aaa");
                    materiaRef.Matriculado = false;
                    UpdateCreditos(materiaRef.Creditos);
                }
            }
            
        }
    }

    private void UpdateCreditos(int creditosRestar)
    {
        creditos -= creditosRestar;
        textoCreditosRef.text = $"Creditos: {creditos}";
    }
}
