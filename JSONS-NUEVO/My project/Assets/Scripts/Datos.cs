using UnityEngine;

public class Datos : MonoBehaviour
{
    string datos_texto;

    class Jugador
    {
        public int vidas;
        public float energia;
        public int dinero;
        public InfoJugador info_jugador;
    }

    class InfoJugador
    {
        public string nombre;
        public string color_favorito;
        public int edad;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        datos_texto = "{\r\n    \"vidas\" : 15,\r\n    \"energia\" : 30,\r\n    \"dinero\" : 300,\r\n\r\n    \"info_jugador\" : {\r\n        \"nombre\" : \"Pedro123\",\r\n        \"color_favorito\" : \"verde\",\r\n        \"edad\" : 15,\r\n        \"cumpleanos\" : {\r\n            \"dia\" : 10,\r\n            \"mes\" : 4\r\n        }\r\n    }\r\n}";

        Jugador objeto_jugador = JsonUtility.FromJson<Jugador>(datos_texto);

        Debug.Log(objeto_jugador.info_jugador.nombre);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
