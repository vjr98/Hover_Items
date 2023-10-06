using UnityEngine;
using System.Collections;
public class CubeScript : SphereScript
{
    public override void DoMagic(float power)
    {
        this.GetComponent<Rigidbody>().AddForce(0, 30.0f / power, 0);
        this.GetComponent<Rigidbody>().AddRelativeTorque(0.1f, 0.0f, 0.1f);
    }

}
