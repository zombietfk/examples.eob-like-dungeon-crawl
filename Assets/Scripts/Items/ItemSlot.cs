using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    private GameObject Item;
    
    [SerializeField]
    private Unit Owner;

    [SerializeField]
    private Hand Hand;

    /* GetHand()
     * Get the hand (mouse pointer) associated with this slot
     */
    public Hand GetHand() {
        return Hand;
    }

    /**
     * MakeChild(GameObject o)
     * @param GameObject o - make O a child of this GameObject's transform
     */
    protected void AttachItem(GameObject o) {
        if (o != null) {
            o.transform.SetParent(this.transform);
            (o.GetComponent<Image>() as Image).rectTransform.localPosition = new Vector3(0, 0, 0);
        }
    }

    /**
     * DetatchItem()
     * Detatch all items from this GameObject's transform
     */
    public void DetatchItems() {
        this.transform.DetachChildren();
    }

    /**
     * SetItem(GameObject o)
     * @param GameObject o - set the current item
     */
    protected void SetItem(GameObject o) {
        this.Item = o;
    }

    /**
     * GetItem()
     * @return GameObject - the currently occupying item GameObject
     */
    public GameObject GetItem() {
        return this.Item;
    }

    private float pointerDownTime;
    private bool longPressTriggered = false;

    [SerializeField] private float longPressThreshold = 0.5f; // seconds

    public virtual void OnPointerClick(PointerEventData e) { }

    public void OnPointerDown(PointerEventData e) {
        longPressTriggered = false;
        pointerDownTime = Time.time;
        StartCoroutine(CheckLongPress());
    }

    public virtual void OnPointerUp(PointerEventData e) {
        if (e.button == PointerEventData.InputButton.Right && !longPressTriggered) {
            HandleRightClick();
        } else if (e.button == PointerEventData.InputButton.Left) {
            HandleLeftClick();
        }
        StopAllCoroutines();
    }

    private IEnumerator CheckLongPress() {
        while (true) {
            if (Time.time - pointerDownTime > longPressThreshold) {
                longPressTriggered = true;
                HandleRightClick();
                break;
            }
            yield return null;
        }
    }

    private void HandleRightClick() {
        GameObject was = GetItem();
        DetatchItems();
	if (was != null) {
            Consumable wasAsConsumable = was.GetComponent<Consumable>() as Consumable;
            if (wasAsConsumable != null) {
                wasAsConsumable.ConsumeEffectOn(Owner);
                Destroy(was);
            }
            else {
                SetItem(was);
                AttachItem(was);
            }
	}
    }

    private void HandleLeftClick() {
        SwapItemWithHeld();
    }

    private void SwapItemWithHeld() {
        GameObject held = this.GetHand().GetHeld();
        this.GetHand().DetatchItems();
        GameObject was = this.GetItem();
        this.DetatchItems();
        this.GetHand().SetHeld(was);
        this.SetItem(held);
        this.AttachItem(held);
    }
}
