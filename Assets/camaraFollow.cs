using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public Transform objetivo;
    public Vector3 offset = new Vector3(0, 3, -5);

    void LateUpdate()
    {
        if (objetivo != null)
        {
            transform.position = Vector3.Lerp(transform.position, objetivo.position + offset, Time.deltaTime * 5f);
            transform.LookAt(objetivo);
        }
    }
}