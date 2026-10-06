using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.XR.Haptics;

public class semafor : MonoBehaviour
{


    public int currentState=1;
    public Light Light1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Light1 = GetComponent<Light>();

        if (currentState == 0)
        {
            Light1.color = Color.red;
        }

        else if(currentState == 1)
        {
            Light1.color = Color.yellow;
        }

        else if(currentState == 2)
        {
            Light1.color = Color.green;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
