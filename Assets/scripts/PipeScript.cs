using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float movementSpeed = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        if (gameObject.transform.position.x < -30)
        {
            Destroy(gameObject);
        }
    }
}