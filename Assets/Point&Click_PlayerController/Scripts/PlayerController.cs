using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public static bool playerMovementEnabled = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // changing if player movement is allowed
    public void togglePlayerMovement(bool input)
    {
        playerMovementEnabled = input;
        //Debug.Log("PlayerController - playerMovementEnabled = " + playerMovementEnabled);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovementEnabled)  // checking if player movement is enabled
        {
            // player movement
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    // Move our agent
                    GetComponent<NavMeshAgent>().SetDestination(hit.point);
                }
            }
        }
    }
}
