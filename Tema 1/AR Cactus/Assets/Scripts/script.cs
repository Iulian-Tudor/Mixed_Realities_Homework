using UnityEngine;

public class script : MonoBehaviour
{
    public Transform otherCacti; // The other cacti to check distance with
    [Range(0.1f, 10f)] // This makes attackDistance adjustable in the Unity Inspector
    public float attackDistance = 1.0f; // The distance at which to start attacking
    public Animator animator; // The animator controlling the cacti's animations
    private bool isAttacking = false; // Variable to keep track of whether the cacti are attacking
    public AudioSource audioSource; // Variable for the sound clip of punching

    void Update()
    {
        float distance = Vector3.Distance(transform.position, otherCacti.position);

        transform.LookAt(otherCacti);

        if (distance <= attackDistance && !isAttacking)
        {
            animator.SetBool("Attack", true);
            isAttacking = true;
        }
        else if (distance > attackDistance && isAttacking)
        {
            animator.SetBool("Attack", false);
            isAttacking = false;
        }

    }

    public void PlayPunchSound()
    {
        if (isAttacking)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop(); 
        }
        
    }
}