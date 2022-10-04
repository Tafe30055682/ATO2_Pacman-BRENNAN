using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minicam : MonoBehaviour
{
    //reference to the player game object
    [SerializeField] private GameObject player;

    //variable for the player offset
    [SerializeField] private Vector3 offset;

    //exectute the code inside this function on each frame while the game is running

    private void Update()
    {

        //camera matches the x and z position of player, but stays above them and doesn't rotate when player rotates

    }

} 