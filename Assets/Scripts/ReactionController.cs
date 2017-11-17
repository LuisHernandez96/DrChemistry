using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class ReactionController : MonoBehaviour {

	public Vector3 size1;
	public Vector3 size2;

	public Vector3 sizeOriginal1;
	public Vector3 sizeOriginal2;

	public VideoPlayer VideoPlayer1;
	public VideoPlayer VideoPlayer2;
	public VideoClip clip1;
	public VideoClip clip2;
	public VideoClip clipOriginal1;
	public VideoClip clipOriginal2;
	public GameObject window1;
	public GameObject window2;

	// Update is called once per frame
    void Update () {
        // Get the Vuforia StateManager
        StateManager sm = TrackerManager.Instance.GetStateManager ();
 
        // Query the StateManager to retrieve the list of
        // currently 'active' trackables 
        //(i.e. the ones currently being tracked by Vuforia)
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();
 		
        var trackableCount = 0;

       // Iterate through the list of active trackables
        Debug.Log ("List of trackables currently active (tracked): ");
        foreach (TrackableBehaviour tb in activeTrackables) {
            Debug.Log("Trackable: " + tb.TrackableName);
            trackableCount ++;
            Debug.Log("Num: " + trackableCount);
        }

        if(trackableCount > 1){
        	VideoPlayer1.clip = clip1;
        	VideoPlayer2.clip = clip2;

        	window1.transform.localScale = size1;
        	window2.transform.localScale = size2;
        }else{
        	VideoPlayer1.clip = clipOriginal1;
        	VideoPlayer2.clip = clipOriginal2;

        	window1.transform.localScale = sizeOriginal1;
        	window2.transform.localScale = sizeOriginal2;
        }
    }
}
