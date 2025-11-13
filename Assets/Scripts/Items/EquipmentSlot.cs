using UnityEngine;
using UnityEngine.EventSystems;

public class EquipmentSlot : ItemSlot {

    [SerializeField]
    private Player Player;

    [SerializeField]
    private string SlotName;

    private void SwapItemWithHeld() {
	Debug.Log(2);
        GameObject held = this.GetHand().GetHeld();
	Debug.Log(held);
        this.GetHand().DetatchItems();
        if (CanEquip(held)) {
	    Debug.Log(3);
            GameObject was = this.GetItem();
	    Debug.Log(was);
            this.DetatchItems();
            this.GetHand().SetHeld(was);
            this.SetItem(held);
            this.AttachItem(held);
            if (held == null) {
                Player.Equipment.SetToDefaultItem(SlotName);
		Debug.Log(4);
            } else {
                Player.Equipment.Set(SlotName, held.GetComponent<Equipment>() as Equipment);
		Debug.Log(5);
            }
        } else {
	    Debug.Log(6);
            this.GetHand().SetHeld(held);
        }
    }

    private bool CanEquip(GameObject i){
        if (i == null) return true;
        if (i.GetComponent<Item>().GetType().IsSubclassOf(typeof(Equipment))) {
            Equipment e = i.GetComponent<Equipment>() as Equipment;
            foreach(string t in e.GetEquippableTo()) {
                if (SlotName == t) {
                    return true;
                }
            }
        }
        return false;
    }

    /** 
     *  OnPointerClick(PointerEventData e)
     *  Swap the item in the Hand object with what is in the slot, and versa versa
     */
    override public void OnPointerUp(PointerEventData e) {
        Debug.Log(1);
        SwapItemWithHeld();
    }

}
