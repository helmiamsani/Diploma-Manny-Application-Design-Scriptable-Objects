using UnityEngine;

[ExecuteInEditMode]
public class GameEventListener : MonoBehaviour
{
    [SerializeField] private GameAction[] actions;

    // Update is called once per frame
    void Update()
    {
        if (Application.isEditor)
        {
            foreach(var action in actions)
            {
                action.Update();
            }
        }
    }

    private void OnEnable()
    {
        foreach(var action in actions)
        {
            action.RegisterListener();
        }
    }

    private void OnDisable()
    {
        foreach(var action in actions)
        {
            action.UnRegisterListener();
        }
    }
}
