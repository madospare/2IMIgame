using UnityEngine;

public class Main : MonoBehaviour
{

    public static Main instance;

    public ReceiveData web;

    // Start is called before the first frame update
    void Start()
    {

        instance = this;
        web = GetComponent<ReceiveData>();

    }

}
