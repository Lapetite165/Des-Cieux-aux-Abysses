using UnityEngine;
using UnityEngine.VFX;

public class AnimationManager : MonoBehaviour
{
	VisualEffect lights;
	ParticleSystem smokes;
	[SerializeField] VisualEffect Burst;
	AudioSource audioSource;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		lights = GetComponentInChildren<VisualEffect>();
		smokes = GetComponentInChildren<ParticleSystem>();
		audioSource = GetComponentInChildren<AudioSource>();
		Burst.Stop();
	}

	// Update is called once per frame
	void Update()
	{
		if (3f <= Time.timeSinceLevelLoad && Time.timeSinceLevelLoad <= 3.5f)
		{
			lights.Stop();
			smokes.Stop();
			Debug.Log(Time.timeSinceLevelLoad);
		}
		if (12f <= Time.timeSinceLevelLoad && Time.timeSinceLevelLoad >= 15f)
		{
			audioSource.Play();
			Burst.Play();
		}
        if (15f <= Time.timeSinceLevelLoad && Time.timeSinceLevelLoad >= 15.5f)
        {
            Burst.pause = true;
			audioSource.Stop();
        }
    }
}
