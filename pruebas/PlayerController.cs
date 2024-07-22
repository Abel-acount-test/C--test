namespace pruebas;

public class CameraPlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    //definimos la posición de primera y tercera persona
    private Vector3 _firstPerson = new Vector3(0f, 0.6f, 0.5f);
    private Vector3 _thirdPerson = new Vector3(0f, 1.5f, -1.5f);
    
    void Start()
    {
        transform.localPosition = _firstPerson;        
    }
    // Update is called once per frame
    void Update()
    {
        cameraRotationY();
        KeyControlPlayer();
    }
    private void cameraRotationY()
    {
//obtenemos el exis en el mouse en ‘Y’ solo actualizamos cuando sea!=0
        if (Input.GetAxis("Mouse Y") != 0)
        {
            transform.rotation *= Quaternion.Euler(new Vector3(-Input.GetAxis("Mouse Y"), 0, 0) * 250 * Time.deltaTime);
        }
    }

    private void KeyControlPlayer()
    {

//para cambio de persona
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.localPosition = transform.localPosition == _firstPerson ? _thirdPerson : _firstPerson;
        }


//Cambio de velocidad en el jugador
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerController.Instance._moveSpeed = 11;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            PlayerController.Instance._moveSpeed = 7;
        }
    }
