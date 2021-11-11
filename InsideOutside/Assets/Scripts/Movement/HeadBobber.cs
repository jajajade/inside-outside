using UnityEngine;

public class HeadBobber : MonoBehaviour
{
    private float timer = 0.0f;
    private float midpoint = 1.5f;
    [SerializeField] private float bobbingSpeed = 0.18f;
    [SerializeField] private float bobbingAmount = 0.2f;

    void Update()
    {
        float waveslice = 0.0f;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 cSharpConversion = transform.localPosition;

        //if player is still, don't bob head
        if (Mathf.Abs(horizontal) == 0 && Mathf.Abs(vertical) == 0)
        {
            timer = 0.0f;
        }

        //set waveslice to a sine wave value at one point in time (i.e. slicing the sine wave)
        else
        { 
            waveslice = Mathf.Sin(timer);
            timer = timer + bobbingSpeed;
            if (timer > Mathf.PI * 2)
            {
                timer = timer - (Mathf.PI * 2);
            }
        }

        //if waveslice doesn't equal 0, set the cSharpConversion to the midpoint +- a modified value
        if (waveslice != 0)
        {
            //times the sine value by the bobbing amount value set in the inspector
            float translateChange = waveslice * bobbingAmount;
            float totalAxes = Mathf.Abs(horizontal) + Mathf.Abs(vertical);
            totalAxes = Mathf.Clamp(totalAxes, 0.0f, 1.0f);

            translateChange = totalAxes * translateChange;
            cSharpConversion.y = midpoint + translateChange;
        }

        //else, make the y value the midpoint between the peaks and troughs
        else
        {
            cSharpConversion.y = midpoint;
        }

        //transform the camera's local position according to the cSharpConversion
        transform.localPosition = cSharpConversion;
    }
}