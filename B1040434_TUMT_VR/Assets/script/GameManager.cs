using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool havekey;


    //公開並且參數零或一個

    public void ThrowPickup()
    {
        print("撿起物件");
    }
    public void ThrowDetech(GameObject obj)
    {
        print("放開物件");
        havekey = true;
        Destroy(obj);

    }
    public void ThrowHeld()
    {
        print("拿著物件");
    }








}


