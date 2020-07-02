using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{

    [SerializeField] float BulletLoadingTime = 0.7f;
    [SerializeField] GameObject Bullet;
    private bool shootable = true;
    private Transform BarrelTrans;
    // Start is called before the first frame update
    void Start()
    {
        BarrelTrans = gameObject.transform.GetChild(0).transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B) && shootable)
        {
            Fire();
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
        GameObject Bullet_clone = Instantiate(Bullet, BarrelTrans.position, transform.rotation);
        Bullet_clone.transform.localScale = BarrelTrans.lossyScale;
        StartCoroutine(LoadingBullet());

    }
}
