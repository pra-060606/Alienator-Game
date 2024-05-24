/*using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    private float enemySpeed = 3f; // Speed of the enemy movement
    private Animator enemyAnimator;

    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check if the player is within a certain distance from the enemy
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < 10f) // Adjust the value as needed for the distance threshold
        {
            // Determine the direction towards the player
            Vector3 direction = player.position - transform.position;
            direction.Normalize();

            // Set animation based on the direction towards the player
            if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
            {
                // Move horizontally
                if (direction.x > 0)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * enemySpeed);
                    enemyAnimator.SetBool("right", true);
                }
                else
                {
                    transform.Translate(Vector3.left * Time.deltaTime * enemySpeed);
                    enemyAnimator.SetBool("left", true);
                }

                // Reset other animation states
                enemyAnimator.SetBool("up", false);
                enemyAnimator.SetBool("down", false);
            }
            else
            {
                // Move vertically
                if (direction.y > 0)
                {
                    transform.Translate(Vector3.up * Time.deltaTime * enemySpeed);
                    enemyAnimator.SetBool("up", true);
                }
                else
                {
                    transform.Translate(Vector3.down * Time.deltaTime * enemySpeed);
                    enemyAnimator.SetBool("down", true);
                }

                // Reset other animation states
                enemyAnimator.SetBool("right", false);
                enemyAnimator.SetBool("left", false);
            }
        }
        else
        {
            // Player is not within range, so stop moving
            enemyAnimator.SetBool("right", false);
            enemyAnimator.SetBool("left", false);
            enemyAnimator.SetBool("up", false);
            enemyAnimator.SetBool("down", false);
        }
    }
}*/

using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    private float enemySpeed = 3f; // Speed of the enemy movement
    private Animator enemyAnimator;

    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check if the player reference is not null
        if (player != null)
        {
            // Check if the player is within a certain distance from the enemy
            float distance = Vector3.Distance(transform.position, player.position);

            if (distance < 10f) // Adjust the value as needed for the distance threshold
            {
                // Determine the direction towards the player
                Vector3 direction = player.position - transform.position;
                direction.Normalize();

                // Set animation based on the direction towards the player
                if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
                {
                    // Move horizontally
                    if (direction.x > 0)
                    {
                        transform.Translate(Vector3.right * Time.deltaTime * enemySpeed);
                        enemyAnimator.SetBool("right", true);
                    }
                    else
                    {
                        transform.Translate(Vector3.left * Time.deltaTime * enemySpeed);
                        enemyAnimator.SetBool("left", true);
                    }

                    // Reset other animation states
                    enemyAnimator.SetBool("up", false);
                    enemyAnimator.SetBool("down", false);
                }
                else
                {
                    // Move vertically
                    if (direction.y > 0)
                    {
                        transform.Translate(Vector3.up * Time.deltaTime * enemySpeed);
                        enemyAnimator.SetBool("up", true);
                    }
                    else
                    {
                        transform.Translate(Vector3.down * Time.deltaTime * enemySpeed);
                        enemyAnimator.SetBool("down", true);
                    }

                    // Reset other animation states
                    enemyAnimator.SetBool("right", false);
                    enemyAnimator.SetBool("left", false);
                }
            }
            else
            {
                // Player is not within range, so stop moving
                enemyAnimator.SetBool("right", false);
                enemyAnimator.SetBool("left", false);
                enemyAnimator.SetBool("up", false);
                enemyAnimator.SetBool("down", false);
            }
        }
        else
        {
            // Player reference is null, stop all animations
            enemyAnimator.SetBool("right", false);
            enemyAnimator.SetBool("left", false);
            enemyAnimator.SetBool("up", false);
            enemyAnimator.SetBool("down", false);
        }
    }
}

