using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

using System.Runtime.Serialization.Formatters.Binary;

public class SavingLoading : MonoBehaviour
{
    SerialiseData mySerData;

    // Start is called before the first frame update
    public void Awake()
    {
        mySerData = new SerialiseData();
    }

    public void SaveMyData()
    {
        mySerData.serialise_score = GameData.Score;
        mySerData.serialise_highscore = GameData.Highscore;
        mySerData.serialise_hearts = GameData.Hearts;

        BinaryFormatter formater = new BinaryFormatter();

        FileStream file = File.Create(Application.persistentDataPath + "gamedata.save");
        formater.Serialize(file, mySerData);
        file.Close();
        Debug.Log("Game Saved!");
    }

    public void LoadMyData()
    {
        SerialiseData loadmyData = new SerialiseData();

        try
        {
            if (File.Exists(Application.persistentDataPath + "gamedata.save"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream file = File.Open(Application.persistentDataPath + "gamedata.save", FileMode.Open);

                //casted into serializedata
                loadmyData = (SerialiseData)formatter.Deserialize(file);
                file.Close();

                if (loadmyData != null)
                {
                    GameData.Score = loadmyData.serialise_score;
                    GameData.Hearts = loadmyData.serialise_hearts;
                    GameData.Highscore = loadmyData.serialise_highscore;
                }
            }
        }

        catch (FileNotFoundException exception)
        {

            Debug.Log("Can't find this file." + "Exceptin message: " + exception);
        }
     }
}

