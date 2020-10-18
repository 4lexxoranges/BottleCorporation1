using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMaker : MonoBehaviour
{
    public int xOffsetToCreateNew = 15;
    //public /*PlayerControll*/ playerControll;
    public List<BgWall> BgWallPrefabs;
    public List<BgWall> initedWalls;

    private List<BgWall> spawnedBgWalls = new List<BgWall>();
    System.Random random;
    public Bottle bottle;
    private void Start()
    {
        random = new System.Random();
        spawnedBgWalls = initedWalls;
        SpawnBgWall();
    }

    private void Update()
    {
        if (bottle.transform.position.x > spawnedBgWalls[spawnedBgWalls.Count - 1].end.transform.position.x - xOffsetToCreateNew)
        {
            SpawnBgWall();
        }
    }

    private void SpawnBgWall()
    {
        BgWall newBgWall = Instantiate(BgWallPrefabs[random.Next(0, BgWallPrefabs.Count)]);
        var newPos = spawnedBgWalls[spawnedBgWalls.Count - 1].end.transform.position - newBgWall.start.transform.localPosition;
        newBgWall.transform.position = newPos;
        spawnedBgWalls.Add(newBgWall);
        if (spawnedBgWalls.Count >= 6)
        {
            Destroy(spawnedBgWalls[0].gameObject);
            spawnedBgWalls.RemoveAt(0);
        }
    }
}
