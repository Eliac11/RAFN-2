using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRegdolloverplayer : MonoBehaviour
{
    public float mintimespawn;
    public float maxtimespawn;

    public GameObject[] regdolls;

    public float spawnheight;
    public float spawnrect;
    public GameObject player;

    public GameObject randEnemy;
	public GameObject targrandEnemy;
    private float curenttime;
    private int curinndex;
    private GameObject curregdoll;


    public GameObject groza;
    void Start()
    {
        curenttime = maxtimespawn;
    }
    void Update()
    {
        gameObject.transform.position = player.transform.position;

        if (curenttime <= 0)
        {
            curenttime = Random.Range(mintimespawn, maxtimespawn);
            if (player.activeSelf)
            {
                SpawnRogdoll();
            }
            
        }
        else
        {
            curenttime -= Time.deltaTime;
        }
    }

    void SpawnRogdoll()
    {
        curinndex = Random.Range(0, regdolls.Length);
        curregdoll = Instantiate(regdolls[curinndex]);
	Vector3 n = new Vector3(gameObject.transform.position.x  - Random.Range(-spawnrect, spawnrect), gameObject.transform.position.y + spawnheight, gameObject.transform.position.z - Random.Range(-spawnrect, spawnrect));
        curregdoll.transform.position = n;

	targrandEnemy.transform.position = n;
        groza.transform.position = n;
        groza.GetComponent<SongsGroza>().PlayGroza();
    }
}
