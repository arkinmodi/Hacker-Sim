using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveUserAttributes : MonoBehaviour
{
    public static void SavePlayer(UserAttributes user)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/UserAttributes.a";
        FileStream stream = new FileStream(path, FileMode.Create);

        UserAttributes saveUser = user;

        formatter.Serialize(stream, saveUser);
        Debug.Log("Saved file to: " + path);
        stream.Close();
    }

    public static UserAttributes LoadUser()
    {
        string path = Application.persistentDataPath + "/UserAttributes.a";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            UserAttributes userLoad = formatter.Deserialize(stream) as UserAttributes;
            stream.Close();
            return userLoad;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

}
