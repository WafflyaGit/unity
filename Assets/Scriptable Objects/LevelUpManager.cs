using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUpManager : MonoBehaviour
{
    [SerializeField] private List<Level> levels;
    [SerializeField] private Text levelText;
    [SerializeField] private Text experienseText;

    private int currentExperiense = 0;
    private int currentLevel = 0;

    private void FixedUpdate()
    {
        levelText.text = "Level " + (currentLevel + 1).ToString();
        experienseText.text = "EXP: " + currentExperiense.ToString();

        if (Input.GetKeyDown(KeyCode.Space) && currentLevel < levels.Count)
            currentExperiense++;

        if (currentLevel < levels.Count && CheckIfLevelUpRequired())
            currentLevel++;
    }

    private bool CheckIfLevelUpRequired()
    {
        return currentExperiense - levels[currentLevel].ExpCumulative == 0;
    }
}
