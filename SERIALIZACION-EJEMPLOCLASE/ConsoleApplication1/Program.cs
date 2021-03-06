﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscrituraXMLInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Juan");
            Persona p2 = null;
            //SERAILIZO UNA SOLA PERSONA.
            Serializador.SerializarPersona(p1);
            //DESSERIALIZO UNA PERSONA.
            p2=Serializador.DesserializarPersona();

            Console.Write(p2.nombre);
            /* Aula y lista test.
            //CREO UN AULA.
            Aula miAula = new Aula(205,new Persona("Octavio"),"Programacion 2");
            //CREO UNA LISTA.
            List<Persona> laLista = new List<Persona>();
            //CARGO LA LISTA CON ALUMNOS(Y PERSONAS).
            laLista.Add(p1);
            laLista.Add(new Persona("Richi"));
            laLista.Add(new Persona("coco"));
            laLista.Add(new Alumno("Michael",3399));
            laLista.Add(new Alumno("Diego",666444));
            //ASIGNO LA LISTA CARGADA A LA LISTA DEL AULA.
            miAula.MiList = laLista;
            //SERIALIZO EL AULA.
            Serializador.SerializarAula(miAula);
            //SERIALIZO SOLO LA LISTA.
            //Serializador.SerializarListado(laLista);
             */

            Console.ReadKey();
        }
    }
}
