using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    public class NextLevel : MonoBehaviour
{
    [SerializeField] AudioClip finish;
    [SerializeField] float delayTime = 1f;
    AudioSource audioSource;
    bool conllisionDisalbled = false;
    void Cheat()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            NextLevels();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            conllisionDisalbled = !conllisionDisalbled;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Finish") { 
            Debug.Log("WWWWWWWWWWWINNER");
            DelayNextLevelMoment();
            PlayAudio(finish);
        }
    }
    void NextLevels()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        int nextscene = scene + 1;
        if (nextscene == SceneManager.sceneCountInBuildSettings)
        {
            nextscene = 0;
        }
        SceneManager.LoadScene(nextscene);
    }
    void PlayAudio(AudioClip i)
    {
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(i);
        }
        else
        {
            audioSource.Stop();
        }
    }
    void DelayNextLevelMoment()
    {
        Invoke("NextLevels", delayTime);
    }
}