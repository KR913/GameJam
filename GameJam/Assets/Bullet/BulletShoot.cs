using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{

    [SerializeField] float BulletLoadingTime = 0.7f;
    [SerializeField] GameObject Bullet;
    ObjectMovement om;
    private bool shootable = true;
    private Transform BarrelTrans;
    // Start is called before the first frame update
    void Start()
    {
        BarrelTrans = gameObject.transform.GetChild(0).transform;
        om = gameObject.GetComponent<ObjectMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (om.pause)
        {
            gameObject.transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color;
        }
            
    }
    IEnumerator LoadingBullet()
    {
        shootable = false;
        yield return new WaitForSeconds(BulletLoadingTime);
        shootable = true;
    }
    public void Fire()
    {
        if (!om.pause)
        {
            if (shootable)
            {
                GameObject Bullet_clone = Instantiate(Bullet, BarrelTrans.position, transform.rotation);
                Bullet_clone.transform.localScale = BarrelTrans.lossyScale;
                StartCoroutine(LoadingBullet());
            }
        }
    }
}
