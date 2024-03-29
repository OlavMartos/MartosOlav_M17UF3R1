using UnityEngine;

public class Brain : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.AddBrain();
        Destroy(gameObject);
    }
}
