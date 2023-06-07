using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{

    public InputField username;
    public InputField password;

    public Button loginButton;

    void Start()
    {

        loginButton.onClick.AddListener(() =>
        {
            StartCoroutine(Main.instance.web.Login(username.text, password.text));
        });

    }

}