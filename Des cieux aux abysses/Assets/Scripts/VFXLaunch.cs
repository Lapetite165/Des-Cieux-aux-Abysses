using UnityEngine;
using UnityEngine.VFX;

public class VFXLaunch : MonoBehaviour
{
    VisualEffect visualEffect;
    ParticleSystem particlesSyst;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //AnimationTime = Player.GetComponentInChildren<Animation>();
        visualEffect = GetComponentInChildren<VisualEffect>();
        particlesSyst = GetComponentInChildren<ParticleSystem>();
        visualEffect.Stop();
        particlesSyst.Stop();
        Debug.Log(particlesSyst.isPlaying);
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Time.timeSinceLevelLoad >= particlesSyst.startDelay)
        {
            visualEffect.Play();
            //particleSystem.Play();
        }
    }
}
