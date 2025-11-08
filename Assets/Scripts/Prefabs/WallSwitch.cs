using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSwitch : Switch {

    [SerializeField]
    private Player Player;

    private void Start() {
        if (this.Player == null) {
            this.Player = GameObject.Find("Player").GetComponent<Player>() as Player;
        }
    }

    public override void SwitchOff() {
        this.transform.localScale = new Vector3(0.03f, 1, 0.03f);
    }

    public override void SwitchOn() {
        this.transform.localScale = new Vector3(0.03f, 1, -0.03f);
    }

    void OnMouseDown() {
        if ((this.transform.position - Player.transform.position).sqrMagnitude <= 1.2) {
            PerformInteractions();
        }
    }
                
}
