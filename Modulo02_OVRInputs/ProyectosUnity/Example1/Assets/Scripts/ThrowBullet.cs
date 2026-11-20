using System.Collections;
using UnityEngine;
using static OVRInput;
using Oculus.Haptics;

public class ThrowBullet : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float limitThrow = 1.5f;
    [SerializeField] private float force = 2f; 
    [SerializeField] private float latency = 0.5f;
    private float lastShoot;
    public HapticClip clip1;
    private HapticClipPlayer player;
    public AudioSource audioSource; 

    void Awake()
    {
        player = new HapticClipPlayer(clip1);
    }

    void Update()
    {
        if (Time.time < (lastShoot + latency))
        {
            return;
        }

        Vector3 velocityController = OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch);
        Quaternion rotationController = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);

        float velocity = velocityController.magnitude;

       
        Vector3 forwardDirection = rotationController * Vector3.forward;

        // Ahora hacemos el Dot entre la dirección del movimiento (velocidad normalizada) y la dirección del mando
        bool isThrow = Vector3.Dot(velocityController.normalized, forwardDirection) > 0;

        if (velocity > limitThrow && isThrow)
        {


            // SOLUCIÓN: Usamos la posición y rotación globales del Transform en el mundo
            Vector3 worldpositionController = transform.position;
            Quaternion worldrotationController = transform.rotation;
            shootBullet(worldpositionController, worldrotationController, velocityController);

            // Vector3 positionController = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);

            //shootBullet(positionController, rotationController, velocityController);

            player.Play(Oculus.Haptics.Controller.Right);

            if (audioSource != null) audioSource.Play();

            lastShoot = Time.time;
        }
    }

    
    private void shootBullet(Vector3 positionController, Quaternion rotationController, Vector3 velocityController)
    {
        GameObject bala = Instantiate(bulletPrefab, positionController, rotationController);
        Rigidbody rb = bala.GetComponent<Rigidbody>();

        if (rb != null)
        {
            
            rb.AddForce(rotationController * Vector3.forward * velocityController.magnitude * force, ForceMode.VelocityChange);
        }
    }

    IEnumerator VibrateForSeconds(float duration, float frequency, float amplitude, OVRInput.Controller controller)
    {
        OVRInput.SetControllerVibration(frequency, amplitude, controller);
        yield return new WaitForSeconds(duration);
        OVRInput.SetControllerVibration(0, 0, controller);
    }
}

