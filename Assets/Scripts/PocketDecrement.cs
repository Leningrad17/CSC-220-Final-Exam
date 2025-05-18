using UnityEngine;

public class PocketDecrement : MonoBehaviour
{
    public PocketHandler pocketHandler;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Balls"))
        {
            other.gameObject.SetActive(false);
            pocketHandler.Decrement();
            pocketHandler.SetCountText();
        }
    }
}
