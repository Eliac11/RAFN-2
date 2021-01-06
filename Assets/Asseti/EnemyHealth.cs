using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
   public float HP = 10;

	public void AddDamage(float damage)
	{
		HP -= damage;
		if(HP <= 0)
		{
			Destroy(gameObject);
		}
	}
}
