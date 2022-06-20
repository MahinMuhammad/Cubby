using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public Transform player;
    public Text score;
    //public float startPos = player.position.z;

    // Update is called once per frame
    void Update()
    {
        score.text = (player.position.z + 43).ToString("0");
    }
}
