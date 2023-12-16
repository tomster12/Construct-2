using UnityEngine;

public abstract class ConstructShape : MonoBehaviour, IPartController
{
    public virtual bool isControlled { get; protected set; }
    public abstract bool IsBlocking { get; }

    public abstract void SetControlled(bool isControlled);
    public abstract bool CanSetControlled(bool isControlled);
}
