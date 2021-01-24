using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPose : MonoBehaviour
{
    private void Awake() {
        DontDestroyOnLoad(this);
    }
}