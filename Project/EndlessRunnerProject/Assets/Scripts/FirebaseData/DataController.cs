using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;

public class DataController : MonoBehaviour
{
    private DatabaseReference reference;
    private string idUser;

    private void Awake() {
        DontDestroyOnLoad(gameObject);
    }

    private void Start() {
        // Get the root reference location of the database.
        reference = FirebaseDatabase.DefaultInstance.RootReference;
#if UNITY_IOS
        idUser = UIDevice.identifierForVendor;
#else
        idUser = SystemInfo.deviceUniqueIdentifier;
#endif

    }

    public void SaveData() {
        var track = TrackManager.instance;
        if (track == null) return;
        User user = new User(idUser, TrackManager.instance.score);
        string json = JsonUtility.ToJson(user);

        reference.Child("users").Child(user.id).SetRawJsonValueAsync(json).ContinueWith(task=> {
            if(task.IsCompleted) {
                Debug.Log("save data complete");
            }else {
                Debug.Log("save data not complete");
            }
        });
    }

    private void OnApplicationQuit() {
        SaveData();
    }

}
