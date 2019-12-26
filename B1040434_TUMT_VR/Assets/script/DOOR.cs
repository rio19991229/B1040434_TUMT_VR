using UnityEngine;

public class DOOR : MonoBehaviour
{
    private Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    
    }
    public void OpenDoor()
    {
        ani.SetBool("character_nearby",true);
    }
    




}
