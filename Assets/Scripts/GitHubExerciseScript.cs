using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitHubExerciseScript : MonoBehaviour
{
    [SerializeField] new string name;
    new string lastname;


    private void Update()
    {
        if (name == "Jeff")
            lastname = "Bezos";
        else if (name == "Johnny")
            lastname = "Depp";



        if (Input.GetKey(KeyCode.Space))
        Debug.Log(name + lastname);
    }


}
