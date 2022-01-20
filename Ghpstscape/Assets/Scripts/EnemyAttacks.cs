using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacks : GameData
{ 
    private GameObject weaponPrefab;

    private Transform ghostShoot;

    Coroutine fireCoroutine;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        weaponPrefab = Resources.Load("weapon") as GameObject;
        ghostShoot = this.gameObject.transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookAtThis = this.transform.position - GameData.MousePos;
        

        if (Input.GetButtonDown("Fire1"))
        {
            fireCoroutine = StartCoroutine(OrbFiredAtEnemies());
        }
        else if (Input.GetButtonUp("Fire1")) StopCoroutine(fireCoroutine);
    }

    IEnumerator OrbFiredAtEnemies()
    {
        while (true)
        {
            GameObject ghostOrb = Instantiate(weaponPrefab, ghostShoot.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
