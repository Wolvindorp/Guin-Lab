using UnityEngine;

public class Siegtrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        string tag = other.gameObject.tag;
        if (name == "Spielfigur") {
            FindObjectOfType<GameEngineService>().wonGame();
        }
    }

    private void OnCollisionExit(Collision collisionInfo)
    {

    }
}