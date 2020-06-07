using UnityEngine;

public class Script_Exp0110 : MonoBehaviour
{
	void OnDrawGizmosSelected() 
	{
		Gizmos.color = Color.red;
		//画线
		Gizmos.DrawLine(transform.position, Vector3.one);
		//立方体
		Gizmos.DrawCube (Vector3.one, Vector3.one);
	}

	void OnDrawGizmos() 
	{
		Gizmos.DrawSphere(transform.position, 1);
	}
}
