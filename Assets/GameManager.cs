using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform Player;
    public string tempJson = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveAction()
    {
        PlayerData data = new PlayerData();
        data.position = Player.position;
        data.life = 75;
        string dataString = JsonUtility.ToJson(data);
        tempJson = dataString;
        Debug.Log("hola");
        Debug.Log("Data string" + dataString);
    }

    public void LoadAction()
    {
        string dataString = tempJson;
        Debug.Log(dataString);
        PlayerData data = JsonUtility.FromJson<PlayerData>(dataString);
        Player.position = data.position;
    }
}

public class PlayerData
{
    public Vector3 position;
    public int life;

}
