using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class PlayerMovement : MonoBehaviour
{
    public Button leftButton;
    public Button rightButton;
    public float moveSpeed = 8f;

    private bool isMovingLeft = false;
    private bool isMovingRight = false;

    Rigidbody2D rb;
    Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        if (leftButton != null)
        {
            leftButton.GetComponent<EventTrigger>().triggers.Add(CreateEventTrigger(
                EventTriggerType.PointerDown, () => OnLeftButtonPressed()));

            leftButton.GetComponent<EventTrigger>().triggers.Add(CreateEventTrigger(
                EventTriggerType.PointerUp, () => OnButtonReleased()));
        }

        if (rightButton != null)
        {
         
            rightButton.GetComponent<EventTrigger>().triggers.Add(CreateEventTrigger(
                EventTriggerType.PointerDown, () => OnRightButtonPressed()));

   
            rightButton.GetComponent<EventTrigger>().triggers.Add(CreateEventTrigger(
                EventTriggerType.PointerUp, () => OnButtonReleased()));
        }
    }

    void Update()
    {
        float horizontalInput = 0f;

        if (isMovingLeft)
        {
            horizontalInput = -1f;
        }
        else if (isMovingRight)
        {
            horizontalInput = 1f;
        }

        
        animator.SetFloat("Speed", Mathf.Abs(horizontalInput));

  
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

       
        FlipSprite(horizontalInput);
    }

    private void OnLeftButtonPressed()
    {
        isMovingLeft = true;
        isMovingRight = false;
    }

    private void OnRightButtonPressed()
    {
        isMovingLeft = false;
        isMovingRight = true;
    }

    private void OnButtonReleased()
    {
        isMovingLeft = false;
        isMovingRight = false;
    }

    private void FlipSprite(float horizontalInput)
    {
        if ((horizontalInput > 0 && transform.localScale.x < 0) ||
            (horizontalInput < 0 && transform.localScale.x > 0))
        {
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }

    private EventTrigger.Entry CreateEventTrigger(EventTriggerType triggerType, System.Action action)
    {
        var entry = new EventTrigger.Entry { eventID = triggerType };
        entry.callback.AddListener((eventData) => action.Invoke());
        return entry;
    }
}
