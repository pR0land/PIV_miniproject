using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField]
    private float minRotSpeed = 3, maxRotSpeed = 5;
    private List<GameObject> rotationObstacles = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform child in transform){
            print(child.name); 
            switch (child.gameObject.name)
            {
                case "RotationObstacle":
                    rotationObstacles.Add(child.gameObject);
                    break;
            }
        }

        foreach(GameObject obj in rotationObstacles)
        {
            IEnumerator rotateChild = rotate(Random.Range(minRotSpeed, maxRotSpeed), obj);
            StartCoroutine(rotateChild);
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator rotate(float speed, GameObject obj)
    {
        print(speed);
        Vector3 rotationVector = new Vector3(0, Random.Range(0f, 1f), 0);
        while (true)
        {
            obj.transform.Rotate(rotationVector * speed * Time.deltaTime);
            yield return null;
        }
        
    }
}
