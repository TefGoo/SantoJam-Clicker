using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Image muteButtonImage;
    public Sprite muteSprite;
    public Sprite unmuteSprite;
    public AudioSource music;

    private bool isMuted = false;

    void Start()
    {
        isMuted = music.mute;
        UpdateMuteButton();
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;
        music.mute = isMuted;
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
