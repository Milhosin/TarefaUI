using UnityEngine;

public class ButtonStartParticles : MonoBehaviour
{
    public ParticleSystem particleSystem;

    public void OnClick()
    {
        particleSystem.Play();
    }
}
