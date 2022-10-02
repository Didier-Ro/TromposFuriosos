using UnityEngine;

public class Interactions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Damage"))
        {
            gameObject.tag = "MakeDamage";
        }
    }
}
