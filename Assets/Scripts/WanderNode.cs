using UnityEngine;

public class WanderNode : Node
{
    private Transform aiTransform;
    private float moveSpeed;
    private Vector2 targetPosition;
    private bool hasTarget = false;
    private float wanderRadius = 5f;

    public WanderNode(Transform ai, float speed)
    {
        aiTransform = ai;
        moveSpeed = speed;
    }

    public override NodeState Evaluate()
    {

        if (hasTarget && Vector2.Distance(aiTransform.position, targetPosition) > wanderRadius + 1f)
        {
            hasTarget = false; 
        }

        if (!hasTarget)
        {
            // Pick a random spot in a 5-unit radius
            targetPosition = (Vector2)aiTransform.position + Random.insideUnitCircle * 5f;
            hasTarget = true;
        }

        // Move towards target
        aiTransform.position = Vector2.MoveTowards(aiTransform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Check if we arrived
        if (Vector2.Distance(aiTransform.position, targetPosition) < 0.1f)
        {
            hasTarget = false; // Reset so we pick a new spot next time
            return NodeState.Success;
        }

        return NodeState.Running;
    }
}