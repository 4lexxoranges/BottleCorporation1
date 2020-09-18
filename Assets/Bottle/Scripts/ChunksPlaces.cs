using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunksPlaces : MonoBehaviour
{
    public Transform Player;
    public Chunk[] ChunkPrefabs;
    private List<Chunk> spawnedChunks = new List<Chunk>();
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {

    }
    private void SpawnChunk()
        {
        Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0,ChunkPrefabs.Length)]);
        
        spawnedChunks.Add(newChunk);
        }

}
