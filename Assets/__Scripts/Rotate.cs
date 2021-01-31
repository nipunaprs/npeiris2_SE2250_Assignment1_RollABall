using UnityEngine;

public class Rotate : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        //Object rotation script -- multiplied by Time.deltaTime to smooth out the rotation 
        transform.Rotate(new Vector3 (15, 38, 45) * Time.deltaTime);
    }
}
