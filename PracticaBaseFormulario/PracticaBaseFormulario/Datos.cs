using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace PracticaBaseFormulario
{
    public class DatosFormulario
    {

        long matricula;
        string nombre;
        string apellidos;
        string direccion;
        long telefono;
        string carrera;
        string semestre;
        string correo;
        string github;



        [PrimaryKey, MaxLength(8), Unique]
        public long Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        [MaxLength(50)]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [MaxLength(50)]
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        [MaxLength(80)]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        [MaxLength(10)]
        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        [MaxLength(30)]
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        [MaxLength(2)]
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }



        [MaxLength(40)]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        [MaxLength(50)]
        public string Github
        {
            get { return github; }
            set { github = value; }
        }

    }
}
