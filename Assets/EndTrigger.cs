//Made by Anon0x19
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
	
	public GameManager gameManager;
	
	void OnTriggerEnter ()
	{
		gameManager.CompleteLevel();
	}
}
