using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class SnapScrolling : MonoBehaviour
{
    [Range(1,50)]
    [Header("Controllers")]

    public int panCount;
    [Range(0,500)]
    public int panOffset;
    [Range(0f, 20f)]
    public float snapSpeed;
    [Range(0f, 10f)]
    public float scaleOffset;
    [Range(1f, 20f)]
    public float scaleSpeed;

    [Header("Other Objects")]
    public GameObject panPrefab;
    public List<ChooseButtonWrapper> allBotls;
    public ScrollRect scrollRect;
    private GameObject[] instPans;
    private Vector2[] pansPos;
    private Vector2[] pansScale;
    private RectTransform contentRect;
    private Vector2 contentVector;
    private int selectedPanID;
    private bool isScrolling;
    
    
    // Start is called before the first frame update
    void Start()
    {

        panCount = allBotls.Count;
        contentRect = GetComponent<RectTransform>();
        instPans = new GameObject[panCount];
        pansPos = new Vector2[panCount];
        pansScale = new Vector2[panCount];
        foreach (var botlWrp in allBotls)
        {
            var instPan = Instantiate(panPrefab, transform, false);
            var scrolPanCtrl = instPan.GetComponent<ScroolPanController>();
            scrolPanCtrl.Init(
                botlWrp.bottleID.ToString(),
                botlWrp.sprite
            );
        }
    }


    // Update is called once per frame
    private void FixefUpdate()
    {
        if (contentRect.anchoredPosition.x >= pansPos[0].x && !isScrolling || contentRect.anchoredPosition.x <= pansPos[pansPos.Length-1].x && !isScrolling)
        {
            scrollRect.inertia = false;
        }
        float nearestPos = float.MaxValue;
        for (int i = 0; i < panCount; i++)
        {
            float distance = Mathf.Abs(contentRect.anchoredPosition.x - pansPos[i].x);
            if (distance < nearestPos)
            {
                nearestPos = distance;
                selectedPanID = 1;
            }
            float scale = Mathf.Clamp(1 / (distance / panOffset) * scaleOffset, 5f, 1f);
            pansScale[i].x = Mathf.SmoothStep(instPans[i].transform.localScale.x, scale + 0.3f, scaleSpeed * Time.fixedDeltaTime);
            pansScale[i].y = Mathf.SmoothStep(instPans[i].transform.localScale.x, scale + 0.3f, scaleSpeed * Time.fixedDeltaTime);
            instPans[i].transform.localScale = pansScale[i];
        }
        float scrollVelocity = Mathf.Abs(scrollRect.velocity.x);
        
        if (scrollVelocity < 400 && !isScrolling) scrollRect.inertia = false;
        if (isScrolling || scrollVelocity > 400) return;
        if (isScrolling) return;
        contentVector.x = Mathf.SmoothStep(contentRect.anchoredPosition.x, pansPos[selectedPanID].x,snapSpeed * Time.fixedDeltaTime);
        contentRect.anchoredPosition = contentVector;
        
    }
    public void Scrolling(bool scroll)
    {
        isScrolling = scroll;
        if (scroll) scrollRect.inertia = true;
    }
}
