using UnityEngine;

public class MovimientoPaladin : MonoBehaviour
{
    public float velocidad = 3f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(x, 0, z) * velocidad * Time.deltaTime;
        transform.position += movimiento;
    }
}