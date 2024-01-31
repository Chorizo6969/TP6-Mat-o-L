using UnityEngine;

public class Tuyau : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.left * 5 * Time.deltaTime );
        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}
