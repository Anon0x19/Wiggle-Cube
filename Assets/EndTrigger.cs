//Made by Marc Perales Salomó
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
	
	public GameManager gameManager;
	
	void OnTriggerEnter ()
	{
		gameManager.CompleteLevel();
	}
}
