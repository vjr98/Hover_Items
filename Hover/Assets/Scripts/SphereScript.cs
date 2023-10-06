using UnityEngine;
using System.Collections;

public class SphereScript : MonoBehaviour
{
    public Transform player;
    public float distance = 5;
    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(this.transform.position, player.transform.position);
        if (dist < distance)
        {
            DoMagic(dist);
        }
    }
    public virtual void DoMagic(float power)
    {
        this.GetComponent<Rigidbody>().AddForce(0, 20.0f / power, 0);
    }
}
