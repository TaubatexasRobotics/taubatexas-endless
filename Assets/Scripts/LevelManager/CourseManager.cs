using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseManager : MonoBehaviour
{
    public GameObject[] Prefabs;
    public float LevelSpeed = 0.05f;
    public int CoursesInScene = 0;
    public bool CanCreate;


    private void Update()
    {
        int PrefabNumb;

        if (CanCreate == true) {
           PrefabNumb = Random.Range(0, Prefabs.Length);

            Instantiate(Prefabs[PrefabNumb],
                new Vector2(54f, 0),
                Quaternion.identity);

            CanCreate = false;

        }
    }
}
