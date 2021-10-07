using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{

    [SerializeField] private Button joinPlayerOne;
    [SerializeField] private Button joinPlayerTwo;
    [SerializeField] private Boolean p1Alive = false;
    [SerializeField] private Boolean p2Alive = false;
    [SerializeField] private Text p1Txt = null;
    [SerializeField] private Text p2Txt = null;


    //TODO: Add PlayerTwoButton reference

    [SerializeField]
    private SplitKeyboardPlayerInputManager playerInputManager;
    // Start is called before the first frame update
    void Start()
    {
        joinPlayerOne.onClick.AddListener(() => JoinPlayerOne());
        joinPlayerTwo.onClick.AddListener(() => JoinPlayerTwo());
        
       

    }

    private void JoinPlayerOne()
    {

        if (p1Alive == false) {

            playerInputManager.JoinPlayer(0, "Keyboard&Mouse");
            p1Alive = true;
            p1Txt.text = "Leave Player One";
            

        } else
        {

            p1Alive = false;
            playerInputManager.LeavePlayer(0);
            p1Txt.text = "Join Player One";

        }
        
        //TODO flip text to say "Leave Player One"
        //TODO on click after player has joined, remove player
    }

    private void JoinPlayerTwo()
    {

        if (p2Alive == false) {

            playerInputManager.JoinPlayer(1, "PlayerTwo");
            p2Alive = true;
            p2Txt.text = "Leave Player Two";

        } else
        {

            p2Alive = false;
            playerInputManager.LeavePlayer(1);
            p2Txt.text = "Join Player Two";

        }
        
        //TODO flip text to say "Leave Player One"
        //TODO on click after player has joined, remove player
    }



    //TODO Invoke JoinPlayer passing a playerIndex value and targeting a control scheme
    //TODO flip text after player has joined to say "Leave Player Two"
    //TODO on click after player has joined, remove player
}
