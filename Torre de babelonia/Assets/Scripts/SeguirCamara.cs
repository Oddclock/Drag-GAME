using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public GameObject MainCamera;
    public float vel = 10.7f;

    Camera mainCameraComponent;
    void Start()
    {
        mainCameraComponent = MainCamera.GetComponent<Camera>();
    }
    void Update()
    {

        //Mouse


        Debug.Log(string.Concat("Width: ", mainCameraComponent.pixelWidth, " X: ", Input.mousePosition.x));
        Debug.Log(string.Concat("Height: ", mainCameraComponent.pixelHeight, " Y: ", Input.mousePosition.y));
        //Calculamos que porcentaje esta el mouse de la pantalla... Horizontal
        float horizontalPorc = Input.mousePosition.x / mainCameraComponent.pixelWidth * 100 - 50;
        //Calculamos que porcentaje esta el mouse de la pantalla... Vertical
        float verticalPorc = Input.mousePosition.y / mainCameraComponent.pixelHeight * 100 - 50;

        Vector2 targetRotation = new Vector2();
        targetRotation.y = horizontalPorc * 1.80f;

        //Queda feo :P
        //targetRotation.x = verticalPorc * 0.45f;

        transform.rotation = Quaternion.Euler(new Vector3(targetRotation.x, targetRotation.y, 0));
    }
}
