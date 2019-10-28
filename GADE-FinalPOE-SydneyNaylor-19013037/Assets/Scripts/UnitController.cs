using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    private int health = 500;
    public int Health { get { return health; } set { health = value; } }
    private int attack = 10;
    private int attackRange = 5;
    private int speed = 2;
    private int attackCounter = 0;
    private int attackSpeed = 50;

    GameObject closestTarget;
    void Start()
    {
        attackCounter = 0;
    }

    void Update()
    {
        closestTarget = FindTarget();
        transform.LookAt(closestTarget.transform);
        Movement();

        if (attackCounter % attackSpeed == 0)
        {
            Attack(closestTarget);
        }
        attackCounter++;
    }

    private void Movement()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void Attack(GameObject closestUnit)
    {
        UnitController uc = closestUnit.GetComponent<UnitController>();
        if(uc == null)
        {
            BuildingController bc = closestUnit.GetComponent<BuildingController>();

            Vector3 currentPosition = transform.position;
            float distance = Vector3.Distance(closestUnit.transform.position, currentPosition);

            if (distance <= attackRange)
            {
                bc.Health -= attack;
                if (bc.Health <= 0)
                {
                    Destroy(closestUnit);
                }
            }
        }
        else
        {
            Vector3 currentPosition = transform.position;
            float distance = Vector3.Distance(closestUnit.transform.position, currentPosition);

            if (distance <= attackRange)
            {
                uc.Health -= attack;
                if (uc.Health <= 0)
                {
                    Destroy(closestUnit);
                }
            }
        }
    }

    private GameObject FindTarget()
    {
        GameObject target = null;
        float minDistance = Mathf.Infinity;
        Vector3 currentPosition = transform.position;

        if (this.tag == "TeamRed")
        {
            GameObject[] team1 = GameObject.FindGameObjectsWithTag("TeamBlue");
            foreach (GameObject unit in team1)
            {
                float distance = Vector3.Distance(unit.transform.position, currentPosition);

                if (distance < minDistance)
                {
                    target = unit;
                    minDistance = distance;
                }
            }
            GameObject[] team2 = GameObject.FindGameObjectsWithTag("TeamGreen");
            foreach (GameObject unit in team2)
            {
                float distance = Vector3.Distance(unit.transform.position, currentPosition);

                if (distance < minDistance)
                {
                    target = unit;
                    minDistance = distance;
                }
            }


            GameObject[] team3 = GameObject.FindGameObjectsWithTag("TeamBlue");
            foreach (GameObject unit in team3)
            {
                float distance = Vector3.Distance(unit.transform.position, currentPosition);

                if (distance < minDistance)
                {
                    target = unit;
                    minDistance = distance;
                }
            }
            GameObject[] team4 = GameObject.FindGameObjectsWithTag("TeamGreen");
            foreach (GameObject unit in team4)
            {
                float distance = Vector3.Distance(unit.transform.position, currentPosition);

                if (distance < minDistance)
                {
                    target = unit;
                    minDistance = distance;
                }
            }
        }
        if (this.tag == "TeamBlue")
        {
            GameObject[] team1 = GameObject.FindGameObjectsWithTag("TeamRed");
            foreach (GameObject unit in team1)
            {
                float distance = Vector3.Distance(unit.transform.position, currentPosition);

                if (distance < minDistance)
                {
                    target = unit;
                    minDistance = distance;
                }
            }
            GameObject[] team2 = GameObject.FindGameObjectsWithTag("TeamGreen");
            foreach (GameObject unit in team2)
            {
                float distance = Vector3.Distance(unit.transform.position, currentPosition);

                if (distance < minDistance)
                {
                    target = unit;
                    minDistance = distance;
                }
            }
        }
        if (this.tag == "TeamGreen")
        {
            GameObject[] team1 = GameObject.FindGameObjectsWithTag("TeamBlue");
            foreach (GameObject unit in team1)
            {
                float distance = Vector3.Distance(unit.transform.position, currentPosition);

                if (distance < minDistance)
                {
                    target = unit;
                    minDistance = distance;
                }
            }
            GameObject[] team2 = GameObject.FindGameObjectsWithTag("TeamRed");
            foreach (GameObject unit in team2)
            {
                float distance = Vector3.Distance(unit.transform.position, currentPosition);

                if (distance < minDistance)
                {
                    target = unit;
                    minDistance = distance;
                }
            }
        }
        return target;
    }
}
