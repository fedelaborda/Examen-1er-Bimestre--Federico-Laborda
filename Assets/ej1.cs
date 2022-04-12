using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Una flota de taxis tiene una cantidad determinada de unidades.Se calcula que cada unidad recorre unos 90 km por día y que cada 
//litro de combustible permite recorrer 15 km.Se calcula también que los días de lluvia se trabaja más, llegando a un recorrido de 110 km 
//por unidad.Teniendo en cuenta que el litro de combustible cuesta $130, debemos hacer un programa que nos permita calcular el costo del 
//combustible para una flota completa de taxis en un período de días determinado.

//Se requiere el ingreso por Inspector de la cantidad de unidades que tiene la flota, la cantidad total de días y una cantidad de 
//días de lluvia a tener en cuenta.

//El programa debe cumplir los siguientes requerimientos:

//El programa debe devolver la información calculada mediante un mensaje en el siguiente formato:
//“Una flota de[cantidadDeUnidades] unidades trabajando durante [periodoDeDias] días implicará un gasto de[costoTotalCombustible] pesos 
//en concepto de combustible”.

//El programa debe devolver un mensaje de error y no realizar ningún cálculo si la cantidad de días total es menor que 5 o si la 
//cantidad de días de lluvia es negativa o mayor que la cantidad total de días. 


public class ej1 : MonoBehaviour
{

    public int cantidadDeUnidades;
    public int dias;
    public int diaslluvia;

    // Start is called before the first frame update
    void Start()
    {
       
        int costoTotalCombustible;
        int valorDiaSoleado = 780;
        int valorDiaLluvia = 910;
        int diasTotales = dias + diaslluvia;

        //para los dias soleados se necesitan 6 litros de combustible, y nos sale $780
        //para los dias de lluvia se necesitan 7 litros de combustible, y nos sale $910

        if (dias < 5)
        {
            Debug.Log("Error, minimo deben ser 5 dias para hacer el cálculo");
        }

        else if (diaslluvia > dias)
        {
            Debug.Log("Error, no pueden haber más dias de lluvia que días totales");
        }

        else if (diaslluvia < 0)
        {
            Debug.Log("Error, no pueden haber dias de lluvia negativos");
        }

        else if (diaslluvia == 0)
        {
            costoTotalCombustible = cantidadDeUnidades * dias * valorDiaSoleado;
            Debug.Log ("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + dias + " días implicará un gasto de " + costoTotalCombustible + " pesos en concepto de combustible");
        }

        else
        {
            costoTotalCombustible = cantidadDeUnidades * ((dias - diaslluvia) * valorDiaSoleado + (diaslluvia * valorDiaLluvia));
            Debug.Log("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + diasTotales + " días implicará un gasto de " + costoTotalCombustible + " pesos en concepto de combustible");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
