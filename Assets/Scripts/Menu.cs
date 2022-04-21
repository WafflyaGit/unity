using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] float cardAnimMoveToButton = 0.1f;
    [SerializeField] float cardAnimMoveFromButton = 0.1f;
    [SerializeField] float cardAnimMoveToEndPoint = 0.1f;
    [SerializeField] float cardAnimMoveToStartPoint = 0.1f;
     

    [SerializeField] private Button menuButton;
    [SerializeField] private Component menuPanel;
    private bool isHidden = true;
    
    void Start()
    {
        menuButton.onClick.AddListener(Click);
    }

    private void Click()
    {
        if (isHidden)
        {
            menuPanel.GetComponent<RectTransform>().DOAnchorPosX(555.5f, cardAnimMoveToButton);
            menuButton.GetComponentInChildren<Text>().text = "<";
            transform.DOMoveX(148, cardAnimMoveToEndPoint);
        }
        else
        {
            menuPanel.GetComponent<RectTransform>().DOAnchorPosX(500, cardAnimMoveFromButton);
            menuButton.GetComponentInChildren<Text>().text = ">";
            transform.DOMoveX(-60, cardAnimMoveToStartPoint);
        }

        isHidden ^= true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
