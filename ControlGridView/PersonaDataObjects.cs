using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlGridView
{
    class PersonaDataObjects
    {
        private List<Persona> listaPersonas = new List<Persona>();

        public PersonaDataObjects()
        {
            Persona p1 = new Persona { Nombre = "Javier", Email ="javier@gmail.com"
            , Genero= "Hombre", Telefono="123456", ImagenGenero ="Hombre.png"};
            Persona p2 = new Persona { Nombre = "Elena", Email ="elena@gmail.com"
            , Genero= "Hombre", Telefono="789345", ImagenGenero ="mujer.jpg"};
            listaPersonas.Add(p1);
            listaPersonas.Add(p2);
        }

        public List<Persona> Listar()
        {
            return listaPersonas;
        }
    }
}
