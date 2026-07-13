using UnityEngine;

public class CheckPlayerInRangeNode : Node
{
    private Transform aiTransform;
    private Transform playerTransform;
    private float detectionRange;

    public CheckPlayerInRangeNode(Transform ai, Transform player, float range)
    {
        aiTransform =ai;
        playerTransform = player;
        detectionRange = range;
    }

    public override NodeState Evaluate()
    {
        float distance = Vector2.Distance(aiTransform.position, playerTransform.position);

        if(distance <= detectionRange)
            return NodeState.Success;
        else
            return NodeState.Failure;
    }
}
