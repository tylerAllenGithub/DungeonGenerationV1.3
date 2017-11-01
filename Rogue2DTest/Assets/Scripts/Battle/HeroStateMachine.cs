using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroStateMachine : MonoBehaviour {

    public BaseHero hero;

    public enum TurnState
    {
        PROCESSING, //waiting for progress bar to fill
        READY, //add to list, progress bar filled
        WAITING, //idle
        SELECTING,
        ACTION,
        DEAD
    }


    public TurnState currentState;

    private float currentCoolDown = 0f;
    private float maxCoolDown = 5f;

    public Image progressBar;

	// Use this for initialization
	void Start ()
    {
        currentState = TurnState.PROCESSING;
	}
	
	// Update is called once per frame
	void Update ()
    {
		switch(currentState)
        {
            case (TurnState.PROCESSING):
                FillProgressBar();
                break;

            case (TurnState.READY):

                break;

            case (TurnState.WAITING):

                break;

            case (TurnState.SELECTING):

                break;

            case (TurnState.ACTION):

                break;

            case (TurnState.DEAD):

                break;
        }
	}

    void FillProgressBar()
    {
        currentCoolDown = currentCoolDown + Time.deltaTime;
        float calculateCoolDown = currentCoolDown / maxCoolDown;
        progressBar.transform.localScale = new Vector3(Mathf.Clamp(calculateCoolDown,0,1), progressBar.transform.localScale.y, progressBar.transform.localScale.z);
        if(currentCoolDown >= maxCoolDown)
        {
            currentState = TurnState.READY;
        }
    }
}
