using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    private Puppet puppet;

    public ShotData thrust;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.collider.gameObject.tag == "Puppet")
        {
            puppet.Drop();
        }
        Destroy(this.gameObject);
    }

    public void StartShot(Vector3 target, Puppet puppet)
    {
        rb = GetComponent<Rigidbody>();
        this.puppet = puppet;
        var t = target - transform.position;
        var n = t.normalized * thrust.Forse;
        rb.AddForce(n.x, n.y, n.z, ForceMode.Impulse);
    }
}
