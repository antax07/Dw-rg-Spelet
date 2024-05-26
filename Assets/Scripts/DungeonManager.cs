using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonManager : MonoBehaviour
{
    private struct Room
    {
        public byte x, y, z;
        public byte w, h, d;
        public GameObject prefab;

        public Room(byte x, byte y, byte z, byte width, byte height, byte depth, GameObject prefab)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            this.w = width;
            this.h = height;
            this.d = depth;

            this.prefab = prefab;
        }

        public void DisplayDimensions()
        {
            Debug.Log($"Room Dimensions - X: {x}, Y: {y}, Z: {z}, W: {w}, H: {h}, D: {d}");
        }

        public void InstantiateRoom()
        {
            if (prefab != null)
            {
                Object.Instantiate(prefab, new Vector3(x, y, z), Quaternion.identity);
            }
        }
    }

    public GameObject spawn3x1x3Prefab;
    public GameObject stair2x2x1Prefab;
    public GameObject boss5x3x3Prefab;
    public GameObject room3x1x2Prefab;
    public GameObject room1x1x1Prefab;

    private const sbyte EMPTY = 0;
    private const sbyte BUFFER = -1;

    private const byte dungeonWidth = 10;
    private const byte dungeonHeight = 10;
    private const byte dungeonFloors = 5;

    private List<Room> rooms = new List<Room>();

    void Start()
    {
        Room room1 = new Room(0, 0, 0, 1, 1, 1, room1x1x1Prefab);
        rooms.Add(room1);
        Room room2 = new Room(2, 0, 2, 1, 1, 1, room1x1x1Prefab);
        rooms.Add(room2);


        GenerateDungeon();
    }

    void GenerateDungeon()
    {
        foreach (Room room in rooms)
        {
            Instantiate(room.prefab);
        }
    }
}
