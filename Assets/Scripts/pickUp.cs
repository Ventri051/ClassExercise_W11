using Unity.VisualScripting;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    [SerializeField] ParticleSystem Pickup;
    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collected item!");
        GetComponent<ParticleSystem>().Play();
        Destroy(collision.gameObject);
       

    }
    void OnDestroy()
    {
        Pickup.Play();
    }
   // if (collision.CompareTag("Package") && !hasPackage)
       // {
          //  Debug.Log("picked up package");
         //   hasPackage = true;
            
       // }
}
