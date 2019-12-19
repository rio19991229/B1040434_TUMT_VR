using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    [Header("動畫控制器")]
    public Animator aniContorl;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "HeadCollider"&&GameManager.havekey)
        {
            aniContorl.SetBool("character_nearby", true);
        }
    }

}
