using UnityEngine;

public class bulletManager : MonoBehaviour
{
    public GameController gameController;

    void OnCollisionEnter(Collision obj)
    {
        Debug.Log("Derribado");

        gameController.TargetHit(obj.gameObject);

        //if (GameController.Instance != null)
        //    GameController.Instance.TargetHit(obj.gameObject);
    }


}
