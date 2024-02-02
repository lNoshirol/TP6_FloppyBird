using System.Collections.Generic;
using UnityEngine;
public class pipeMove : MonoBehaviour
{
    public Vector2 _vectorDestroy;
    public float speed;
    void Update()
    {
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        if (transform.position.x <= -13)
        {
            KillThisPipe();
        }
    }
    public void KillThisPipe()
    {
        Destroy(gameObject);
    }
}