using UnityEngine;

public class FleeNode : Node
{
    private Transform aiTransform;
    private Transform playerTransform;
    private float moveSpeed;

    public FleeNode(Transform ai, Transform player, float speed)
    {
        aiTransform = ai;
        playerTransform = player;
        moveSpeed = speed;
    }

    public override NodeState Evaluate()
    {
        Vector2 directionAway = (aiTransform.position - playerTransform.position).normalized;
    
        aiTransform.position = Vector2.MoveTowards(aiTransform.position, (Vector2)aiTransform.position + directionAway, moveSpeed * Time.deltaTime);
        
        return NodeState.Running;
    }
}
