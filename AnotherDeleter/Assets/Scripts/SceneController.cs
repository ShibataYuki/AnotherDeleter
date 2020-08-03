using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    PlayerStateMachine playerStateMachine = null;

    private void Awake() {
        playerStateMachine.Init();
    }
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        playerStateMachine.Do();
    }

    private void FixedUpdate() {
        playerStateMachine.Do_Fix();
    }
}
