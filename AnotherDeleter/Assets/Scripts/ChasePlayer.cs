using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnotherDeleter.GameScene {

    public class ChasePlayer : MonoBehaviour {
        [SerializeField]
        GameObject player = default;
        [SerializeField]
        Vector3 offsetFromPlayerPos = new Vector3(0, -5, 2);
        // Start is called before the first frame update
        void Start() {
            transform.position = player.transform.position - offsetFromPlayerPos;

        }

        // Update is called once per frame
        void Update() {
            transform.position = player.transform.position - offsetFromPlayerPos;
            LookPlayer();
        }

        private void LookPlayer() {
            Vector3 cameraToPlayerVec = player.transform.position - this.transform.position;
            //Debug.DrawLine(player.transform.position, transform.position,Color.red);
            transform.localRotation = Quaternion.LookRotation(cameraToPlayerVec);
        }
    }
}
