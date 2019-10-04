using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// TODO: You must set the values for the enum
public enum GameMode
{
    idle,
    playing,
    levelEnd


}


// TODO: implement the MissionDemolition script
public class MissionDemolition : MonoBehaviour {
    static private MissionDemolition S;

    [Header("Set in Inpector")]
    public Text uitLevel;
    public Text uitShots;
    public Text uitButton;
    public Vector3 castlePos;
    public GameObject[] castles;

    [Header("Set Dynamically")]
    public int level;
    public int levelMax;
    public int shotsTaken;
    public GameObject castle;
    public GameMode mode = GameMode.idle;
    public string showing = "Show Slingshot";






	// Use this for initialization
	void Start ()
    {
        S = this;

        level = 0;
        levelMax = castles.Length;
        StartLevel();



    }
	
	void StartLevel()
    {
       if(castle != null)
        {
            Destroy(castle);
        }

        GameObject[] gos = GameObject.FindGameObjectsWithTag("Projectile");
        foreach(GameObject pTemp in gos)
        {
            Destroy(pTemp);
        }

        castle = Instantiate<GameObject>(castles[level]);
        castle.transform.position = castlePos;
        shotsTaken = 0;

        SwitchView("Show Both");
        ProjectileLine.S.Clear();

        Goal.goalMet = false;
        UpdateGUI();

        mode = GameMode.playing;

 
    }

    void UpdateGUI()
    {


    }

    void Update()
    {


    }

    void NextLevel()
    {

    }

    public void SwitchView(string eView = "")
    {

    }

    // Static method that allows code anywhere to increment shotsTaken
    public static void ShotFired()
    {

    }
}
