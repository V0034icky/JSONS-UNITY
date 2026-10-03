using System;
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

    [Serializable]
    class InfoJugador
    {
        public string nombre;
        public string color_favorito;
        public int edad;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        datos_texto = "{\r\n    \"vidas\" : 15,\r\n    \"energia\" : 30,\r\n    \"dinero\" : 300,\r\n\r\n    \"info_jugador\" : {\r\n        \"nombre\" : \"Pedro123\",\r\n        \"color_favorito\" : \"verde\",\r\n        \"edad\" : 15,\r\n        \"cumpleanos\" : {\r\n            \"dia\" : 10,\r\n            \"mes\" : 4\r\n        }\r\n    }\r\n}";

        Jugador objeto_jugador = JsonUtility.FromJson<Jugador>(datos_texto);

        Debug.Log(objeto_jugador.info_jugador.nombre);
        */

        Jugador objeto_jugador = new Jugador();
        objeto_jugador.vidas = 4;
        objeto_jugador.energia = 50;
        objeto_jugador.dinero = 100;

        objeto_jugador.info_jugador = new InfoJugador();
        objeto_jugador.info_jugador.nombre = "vicksvaporub";
        objeto_jugador.info_jugador.color_favorito = "Verde";
        objeto_jugador.info_jugador.edad = 22;

        Debug.Log(objeto_jugador.energia);

        string dato_texto = JsonUtility.ToJson(objeto_jugador);

        string datos_incriptados = AESEncryption.Encrypt(datos_texto);

        Debug.Log(datos_incriptados);

        //PlayerPrefs.SetString("datos", dato_texto);

        Debug.Log(dato_texto);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
