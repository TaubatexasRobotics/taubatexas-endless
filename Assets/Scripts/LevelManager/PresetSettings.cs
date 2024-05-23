using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresetSettings : MonoBehaviour
{
    public float presetSpeed;
    private float LifeTime = 20f;
    private CourseManager courseManager;
    private bool CanSpawn = true;
    private void Awake()
    {
        courseManager =
        GameObject.FindGameObjectWithTag("coursemanager").GetComponent<CourseManager>();
    }


    private void Start()
    {
        courseManager.CoursesInScene += 1;
    }

    private void Update()
    {
        LifeTime -= Time.deltaTime;

        presetSpeed = courseManager.LevelSpeed;

        if (LifeTime <= 0) { courseManager.CoursesInScene -= 1; Destroy(this.gameObject); }
    }

    private void FixedUpdate()
    {
        if (transform.position.x < 1f && transform.position.x > -1f && CanSpawn == true)
        { courseManager.CanCreate = true; CanSpawn = false; }

        transform.position = new Vector2(transform.position.x - presetSpeed, transform.position.y);
    }
}
