using UnityEngine;
 
public class Box : MonoBehaviour
{   
    public float speed = 5f;
    
    void Start()
    {
        print("hello world");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W)) // W tuşu basılıysa ileri (yürüme)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) // S tuşu basılıysa geri
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) // A tuşu basılıysa sola
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) // D tuşu basılıysa sağa
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        } 
        if (Input.GetKey(KeyCode.LeftShift)) // Shift tuşu basılıysa aşağı 
        {
           transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space)) // Space tuşu basılıysa yukarı 
        {  
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
    } 
}