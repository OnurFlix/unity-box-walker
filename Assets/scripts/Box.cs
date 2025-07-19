using UnityEngine;
 
public class Box : MonoBehaviour
{   
    public bool HareketEtmek; 
    public float speed = 5f;
    // Start is called once before the first frame update
    void Start()
    {
        print("hello world");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
      
      
        if (Input.GetMouseButton(0)) 
        {  
            transform.position += Vector3.up * speed * Time.deltaTime; 
        } 
        else 
        {  
            transform.position += Vector3.down * speed * Time.deltaTime; 
        } 
} 

}