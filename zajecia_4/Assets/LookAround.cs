using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    // ruch wokół osi Y będzie wykonywany na obiekcie gracza, więc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;

    public float sensitivity = 2f;
    private float XRotation = 0f;
    private float YRotation = 0f;
    void Start()
    {
        // zablokowanie kursora na środku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy wartości dla obu osi ruchu myszy
        float XaxisRotation = Input.GetAxis("Mouse X") * sensitivity;
        float YaxisRotation = Input.GetAxis("Mouse Y") * sensitivity;
        XRotation -= YaxisRotation;
        YRotation -= XaxisRotation;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);
        transform.parent.localRotation = Quaternion.Euler(XRotation, -YRotation, 0f);
    }
}