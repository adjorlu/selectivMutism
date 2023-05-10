using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class videoPlayerController : MonoBehaviour
{


    [SerializeField] private VideoPlayer myVideo;
    int videoNumber = 0;
    int videoEditorNumber = 0; 
    public string editorLink = "S:/Lager/unity/My project/Assets/videos/";
    
    // Start is called before the first frame update
    string videoFileName = "";
    public string dataPath = "";
    void Start()
    {
        Debug.Log("Is Editor: " + Application.isEditor);
        dataPath = Application.persistentDataPath + "/";
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playMyVideo()
    {
        Debug.Log("AM I PRESSED!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!?");
        if (Application.isEditor)
        {
            if (videoNumber <= 3 && videoNumber >= 0)
            {
                videoNumber++;
                videoFileName = "Video" + videoNumber.ToString() + ".mp4";
                myVideo.url = editorLink + videoFileName;
                myVideo.Play();
                Debug.Log("VideoNumber is: " + videoNumber);
            }
        }

        else {
            if (videoNumber <= 3 && videoNumber >= 0)
            {
                videoNumber++;
                videoFileName = "Video" + videoNumber.ToString() + ".mp4";
                myVideo.url = dataPath + videoFileName;
                myVideo.Play();
                Debug.Log("My VIDEO PATH IS: " + videoFileName);
            }
        }
    }

    public void playMyLastVideo()
    {
        Debug.Log("AM I PRESSED!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!?");
        if (Application.isEditor)
        {
            if(videoNumber <=3 && videoNumber >= 0) { 
            videoNumber--;
            videoFileName = "Video" + videoNumber.ToString() + ".mp4";
            myVideo.url = editorLink + videoFileName;
            myVideo.Play();
                Debug.Log("VideoNumber is: " + videoNumber);
            }

        }

        else
        {
            if (videoNumber <= 3 && videoNumber >= 0)
            {
                videoNumber--;
                videoFileName = "Video" + videoNumber.ToString() + ".mp4";
                myVideo.url = dataPath + videoFileName;
                myVideo.Play();
                Debug.Log("My VIDEO PATH IS: " + videoFileName);
            }
        }
    }

    public void playGris()
    {
        videoFileName = "gris.mp4";

        if (Application.isEditor)
        {
            myVideo.url = editorLink + videoFileName;
            Debug.Log("The path for editor is: " + editorLink);
        }

        myVideo.url = dataPath + videoFileName;
        myVideo.Play();
        Debug.Log("The path for VR is: " + dataPath);
    }

    public void playDean()
    {
        videoFileName = "dean.mp4";

        if (Application.isEditor)
        {
            myVideo.url = editorLink + videoFileName;
            Debug.Log("The path for editor is: " + editorLink);
        }

        myVideo.url = dataPath + videoFileName;
        myVideo.Play();
        Debug.Log("The path for VR is: " + dataPath);
    }


}
