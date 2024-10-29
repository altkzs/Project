using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
	public UICondition uiCondition;
	Condition health { get { return uiCondition.health; } }


	void Update()
	{
		health.Subtract(health.passiveValue * Time.deltaTime);
		if (health.curValue == 0f)
		{
			Die();
		}
	}
	public void Heal(float amout)
	{
		health.Add(amout);
	}
	public void Die()
	{
		Debug.Log("죽었다");
	}
}
