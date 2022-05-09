using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitHubExerciseScript : MonoBehaviour
{
    [SerializeField] new string name;
    string lastname;


    private void Update()
    {
        if (name == "Jeff")
            lastname = "Bezos";
        else if (name == "Johnny")
            lastname = "Depp";
        else if (name == "Ryan")
            lastname = "Reynolds";



        if (Input.GetKey(KeyCode.Space))
        Debug.Log($"{name} {lastname}");
    }


}
