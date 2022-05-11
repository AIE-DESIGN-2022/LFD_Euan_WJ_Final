using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.FPS.Gameplay
{
    public class ObjectiveTriggerBased : Objective
    {
        [Tooltip("Visible transform that will be destroyed once the objective is completed")]
        public Transform DestroyRoot;
        public UnityEvent additionalEvent;

        void Awake()
        {
            if (DestroyRoot == null)
                DestroyRoot = transform;
        }

        public void TriggerObjective()
        {
            if (IsCompleted) return;
            CompleteObjective(string.Empty, string.Empty, "Objective complete : " + Title);
            if(additionalEvent != null)
            {
                additionalEvent.Invoke();
            }
            if (numberCompleted >= numberToComplete)
            {
                Destroy(DestroyRoot.gameObject);
            }
        }
    }
}