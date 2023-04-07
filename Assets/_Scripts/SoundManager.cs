using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Image muteButtonImage;
    public Sprite muteSprite;
    public Sprite unmuteSprite;
    public GameObject audioGameObject; // the game object with AudioSource component
    private bool isMuted = false;

    void Start()
    {
        isMuted = !audioGameObject.activeSelf;
        UpdateMuteButton();
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;
        audioGameObject.SetActive(!isMuted);
        UpdateMuteButton();
    }

    void UpdateMuteButton()
    {
        if (isMuted)
        {
            muteButtonImage.sprite = muteSprite;
        }
        else
        {
            muteButtonImage.sprite = unmuteSprite;
        }
    }
}