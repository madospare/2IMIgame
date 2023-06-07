using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ReceiveData : MonoBehaviour
{

    public GameObject loginScreen;
    public Text errorMessage;

    void Start()
    {

        StartCoroutine(GetRequest("http://192.168.0.40/"));

    }

    IEnumerator GetRequest(string url)
    {

        using (UnityWebRequest www = UnityWebRequest.Get(url))
        {

            yield return www.SendWebRequest();

            string[] pages = url.Split('/');
            int page = pages.Length - 1;

            switch (www.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + "Error: " + www.error);
                    break;

                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + "HTTP Error: " + www.error);
                    break;

                case UnityWebRequest.Result.Success:
                    Debug.Log(pages[page] + "Connection success!");
                    break;
            }

        }

    }

    public IEnumerator Login(string uid, string pwd)
    {

        WWWForm form = new WWWForm();
        form.AddField("uid", uid);
        form.AddField("pwd", pwd);

        using (UnityWebRequest www = UnityWebRequest.Post("http://192.168.0.40/unity/unity_login.php", form))
        {

            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError(www.error);
            } else
            {
                Debug.Log(www.downloadHandler.text);
                if (www.downloadHandler.text.Contains("Connected successfully. User list: <br><br>Login Success!"))
                {
                    loginScreen.SetActive(false);
                } else
                {
                    errorMessage.text = "Failed to login. Please try again.";
                }
            }

        }

    }

}
