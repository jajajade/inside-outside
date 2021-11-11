using UnityEngine;

public class HeadphoneBehaviour : MonoBehaviour
{
    public AudioClip clip;
    public GameObject headphones;
    public float volume = 1;
    private bool audioPlaying;

    public void playMusic()
    {
        //if audio not playing...
        if (!audioPlaying)
        {
            audioPlaying = true;    //set audioplaying bool to true to avoid audio being played multiple times
            AudioSource.PlayClipAtPoint(clip, transform.position, volume);  //play audio from source

            headphones.SetActive(false); //disable headphone gameobject
        }
    }
}
