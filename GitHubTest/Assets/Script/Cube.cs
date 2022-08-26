using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    Vector3 pos = Vector3.zero;
    float num = 0;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        num += Time.deltaTime;
=======
        num += Time.deltaTime*25;
>>>>>>> Stashed changes
        transform.position = pos + new Vector3(0,Mathf.Sin(num),0);
    }
}
