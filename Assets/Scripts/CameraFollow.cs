using UnityEngine;

public class CameraFollow : MonoBehaviour {
    
    public Transform target;
    public Vector3 offset;
    public float smoothTime = 0.3f;
    
    private Vector3 velocity;

    public static bool deattachcamera;

    private Vector3 initial;

    void Start()
    {
        deattachcamera = true;
        initial = transform.position;
    }
    
    private void LateUpdate()
    {
        if ((deattachcamera) && (target.position.y > 2.88 ) && (target.position.y < 111.39))
        {
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3 (transform.position.x, target.position.y, transform.position.z) + offset, ref velocity, smoothTime);
        }
        
        else if ((deattachcamera) && (target.position.y < 2.88))
        {
            transform.position = initial;
        }

        else if ((deattachcamera) && (target.position.y > 11.39))
        {
            transform.position = new Vector3 (initial.x, 111.36f, initial.z);
        }
        
    }   
}