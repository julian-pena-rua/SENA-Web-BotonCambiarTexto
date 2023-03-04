using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
public class Usuario
{

    int edad;
    string nombre;
    string apellido;

    public Usuario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public Usuario(int edad, string nombre, string apellido)
    {
        this.edad = edad;
        this.nombre = nombre;
        this.apellido = apellido;
    }

    public int Edad
    {
        get
        {
            return edad;
        }

        set
        {
            edad = value;
        }
    }

    public string Nombre
    {
        get
        {
            return nombre;
        }

        set
        {
            nombre = value;
        }
    }

    public string Apellido
    {
        get
        {
            return apellido;
        }

        set
        {
            apellido = value;
        }
    }
}