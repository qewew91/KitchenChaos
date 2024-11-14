using System;
using UnityEngine;

public class ContainerCounter : BaseCounter
{
    public event EventHandler OnPlayerGrabObject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        Transform kitchenOjbectSOTransform = Instantiate(kitchenObjectSO.prefab);
        kitchenOjbectSOTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);

        OnPlayerGrabObject?.Invoke(this, EventArgs.Empty);
    }
}
