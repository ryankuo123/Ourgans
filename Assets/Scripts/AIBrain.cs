using System.Collections.Generic;
using UnityEngine;

public class AIBrain : MonoBehaviour
{
    public Transform player; // Drag player here in the inspector
    public float speed = 3f;
    public float detectionRadius = 5f;

    private Node rootNode;

    void Start()
    {
        ConstructBehaviorTree();
    }

    private void ConstructBehaviorTree()
    {
        // 1. Create the leaf nodes
        CheckPlayerInRangeNode checkRange = new CheckPlayerInRangeNode(transform, player, detectionRadius);
        FleeNode flee = new FleeNode(transform, player, speed);
        WanderNode wander = new WanderNode(transform, speed);

        // 2. Create the Flee Sequence (Check if player is near AND Flee)
        Sequence fleeSequence = new Sequence(new List<Node> { checkRange, flee });

        // 3. Create the Root Selector (Flee Sequence OR Wander)
        rootNode = new Selector(new List<Node> { fleeSequence, wander });
    }

    void Update()
    {
        // Run the tree every frame!
        if (rootNode != null)
        {
            rootNode.Evaluate();
        }
    }
}