using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * _speed;
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * _speed;
        transform.Translate(xValue, yValue, zValue);
    }
}
