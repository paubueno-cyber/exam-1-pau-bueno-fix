using UnityEngine;

public class molino : MonoBehaviour
{
    
    public float turnSpeed = 1f;
    public Vector3 initialScale;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialScale=transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        rotate();
        size();
    }

    private void rotate()
    {
        transform.Rotate(0, 1, 0);
        transform.localScale = Vector3.MoveTowards(transform.localScale, initialScale*0.5f, Time.deltaTime*0.1f);
    }

    
    private void size()
    {
        
        transform.localScale.Set(1, 1, 1);
        
    }
}
