using UnityEngine;

[CreateAssetMenu(fileName = "New Level Up Config", menuName = "Level Up Config")]
public class Level : ScriptableObject
{
    [SerializeField] public int LevelId;
    [SerializeField] public int Experience;
    [SerializeField] public int ExpCumulative;
}
