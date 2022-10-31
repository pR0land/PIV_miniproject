using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField]
    private float minRotSpeed = 3, maxRotSpeed = 5;

    [SerializeField]
    private float minSwipeSpeed = 3, maxSwipeSpeed = 5;

    private List<GameObject> rotationObstacles = new List<GameObject>();
    private List<GameObject> sideSwipingObstacles = new List<GameObject>();
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
                case "SideSwipingObstacle":
                    sideSwipingObstacles.Add(child.gameObject);
                    break;
            }
        }

        foreach(GameObject obj in rotationObstacles)
        {
            IEnumerator rotateChild = rotate(Random.Range(minRotSpeed, maxRotSpeed), obj);
            StartCoroutine(rotateChild);
        }
        foreach(GameObject obj in sideSwipingObstacles)
        {
            IEnumerator sideSwipeChild = sideSwipe(Random.Range(minSwipeSpeed, maxSwipeSpeed), obj);
            StartCoroutine(sideSwipeChild);
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator rotate(float speed, GameObject obj)
    {
        int rotationDirect = Random.Range(0, 1f) > 0.5f ? 1 : -1;  
        Vector3 rotationVector = new Vector3(0, rotationDirect, 0);
        while (true)
        {
            obj.transform.Rotate(rotationVector * speed * Time.deltaTime);
            yield return null;
        }
        
    }
    IEnumerator sideSwipe(float speed, GameObject obj)
    {

        while (true)
        {
            if(obj.tag == "Left")
            {
                obj.transform.Translate(new Vector3(0, 0, Mathf.Sin(Time.timeSinceLevelLoad)) * speed * Time.deltaTime);
            }
            else
            {
                obj.transform.Translate(new Vector3(0,0,Mathf.Sin(Time.timeSinceLevelLoad+Mathf.PI))*speed * Time.deltaTime);
            }
            yield return null;
        }
    }
}
