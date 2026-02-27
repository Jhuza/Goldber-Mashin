using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
public class GolfClub : MonoBehaviour
{
    [SerializeField] private KeyCode activationKey = KeyCode.Space;
    [SerializeField] private float motorForce = 200f;
    [SerializeField] private float motorVelocity = 300f;
    [SerializeField] private float swingDuration = 0.3f;

    private HingeJoint hinge;
    private bool isActivated = false;

    private void Awake()
    {
        hinge = GetComponent<HingeJoint>();
        ConfigureMotor();
    }

    private void Update()
    {
        if (Input.GetKeyDown(activationKey))
        {
            Activate();
        }
    }

    private void Activate()
    {
        if (isActivated) return;

        isActivated = true;
        hinge.useMotor = true;

        Invoke(nameof(StopSwing), swingDuration);
    }

    private void StopSwing()
    {
        hinge.useMotor = false;
    }

    private void ConfigureMotor()
    {
        JointMotor motor = hinge.motor;
        motor.force = motorForce;
        motor.targetVelocity = motorVelocity;
        hinge.motor = motor;

        hinge.useMotor = false;
    }
}