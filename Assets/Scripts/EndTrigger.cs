using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider colliderInfo)
    {
        if(colliderInfo.name.Equals("Player"))
        {
            gameManager.LevelCompleted();
        }
    }

}
