using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Bullet bullet;
    public Puppet puppet;

    public void Shot(Vector3 target)
    {
         var gm  =Instantiate(bullet.gameObject, new Vector3(1.243f, 1.402f, -7.444f),Quaternion.identity);
         gm.GetComponent<Bullet>().StartShot(target, puppet);
    }
}
