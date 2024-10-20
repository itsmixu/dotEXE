using UnityEngine;

public class HealthEffect : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void PlayHealthEffect()
    {
        animator.SetTrigger("Play");
    }
}
