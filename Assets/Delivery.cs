using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 packageColor = new Color32(17, 175, 17, 255);
    [SerializeField] Color32 defaultColor = new Color32(255, 255, 255, 255);
    [SerializeField] float destroyDelay = 0.5f;

    SpriteRenderer spriteRenderer;
    bool hasPackage;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Boom!!!!!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("You picked up a package.");
            hasPackage = true;
            spriteRenderer.color = packageColor;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("You delivered a package.");
            spriteRenderer.color = defaultColor;
        }
    }

}
