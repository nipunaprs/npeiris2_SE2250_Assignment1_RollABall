using UnityEngine;

public class Create : MonoBehaviour
{
    //Getting the prefabs
    public GameObject one;
    public GameObject two;
    public GameObject three;

    //Arrays with location data for object points
    float[] location = {1.5f, 1, 5, -1.28f, 1, 5, -5, 1, 1.5f, -5.3f, 1, -1.05f, 5.3f, 1, 1.05f, 5.3f, 1, -1.05f, 1.5f, 1, -5, -1.5f, 1, -5 };
    float[] location2 = { -3.41f, 1, 3.79f, -3.41f, 1, -3.68f, 3.71f, 1, 3.79f, 3.71f, 1, -3.63f, };
    float[] location3 = { 7.7f, 1, 0.16f, -7.7f, 1, 0.16f, 0.08f, 1, -7.65f, 0.08f, 1, 7.65f, };

    // Start is called before the first frame update
    void Start()
    {
        //Object instiation for loops for creating the different types of pickups. Uses location data stored in arrays.
        for(int i = 0; i < location.Length; i+=3)
        {
            GameObject.Instantiate(one, new Vector3(location[i], location[i+1], location[i+2]), Quaternion.identity);
        }

        for (int i = 0; i < location2.Length; i += 3)
        {
            GameObject.Instantiate(two, new Vector3(location2[i], location2[i + 1], location2[i + 2]), Quaternion.identity);
        }

        for (int i = 0; i < location3.Length; i += 3)
        {
            GameObject.Instantiate(three, new Vector3(location3[i], location3[i + 1], location3[i + 2]), Quaternion.identity);
        }


    }

}
