using UnityEngine;

// ref from http://answers.unity.com/answers/1426123/view.html
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<T>();
            if (instance == null)
                Debug.LogError($"Singleton<{typeof(T)}> instance has not been found.");
            return instance;
        }
    }

    protected void Awake()
    {
        if (instance == null)
            instance = this as T;
        else if (instance != this)
            DestroySelf();
    }

    protected void OnValidate()
    {
        if (instance == null)
            instance = this as T;
        else if (instance != this)
        {
            Debug.LogError($"Singleton<{this.GetType()}> already has an instance on scene. Component will be destroyed.");
#if UNITY_EDITOR
            UnityEditor.EditorApplication.delayCall -= DestroySelf;
            UnityEditor.EditorApplication.delayCall += DestroySelf;
#endif
        }
    }

    private void DestroySelf()
    {
        if (Application.isPlaying)
            Destroy(this);
        else
            DestroyImmediate(this);
    }
}
