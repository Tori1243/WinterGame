using UnityEngine;

public class Destroy : MonoBehaviour
{

    void OnCollisionEnter(Collision collision){
        
        Destroy(collision.collider.gameObject);
        
        Destroy(gameObject);
    }
}
    