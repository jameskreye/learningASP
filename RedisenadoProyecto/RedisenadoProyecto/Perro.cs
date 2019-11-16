using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisenadoProyecto
{
    class Perro
    {   
        //declaro atributos O variables privadas
        private short edad;
        private string color;
        private string nombre;
        private string raza;

        private int nivelEstres;
        private bool estaEstresado;
        private bool estaDormido;


        //defino metodo get y set 
        public Perro(short edad, string color, string nombre, string raza)
        {
            this.edad = edad;
            this.color = color;
            this.nombre = nombre;
            this.raza = raza;
        }

        //otro metodo pero con menos parametros 
        public Perro(string nombre, string color, string raza)
        {
            this.color = color;
            this.nombre = nombre;
            this.raza = raza;
        }

        //otro metodo pero con 1 solo parametro
        public Perro(string nombre)
        {
            this.nombre = nombre;
        }

        public bool EstaEstresado
        {
            get
            {
                return this.estaEstresado;
            }
        }

        public  int NivelEstres
        {
            get
            {
                return this.nivelEstres;
            }
        }

        public bool EstaDormido
        {
            get
            {
                return this.estaDormido;
            }
        }

        
        //esos metodos permite modificar los valores de los atributos privados
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Raza
        {
            get { return this.raza; }
            set { this.raza = value; }
        }

        public short Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        //metodo de comportamiento del perro
        //hace que el perro ladre
        public void ladrar()
        {
            Console.WriteLine("Guauuuu Guauuu");
            nivelEstres++;
            evaluarNivelEstres();
            Console.ReadKey();
        }

        //Metodo para evaluar el nivel de estres del perro 
        private void evaluarNivelEstres()
        {
            if(nivelEstres >= 5)
            {
                Console.WriteLine("Estoy Estresado!!!!!!!!!!");
                estaEstresado = true;
            }
            else if (nivelEstres < 5 && nivelEstres > 3)
            {
                Console.WriteLine("Me estoy empezando a estresar!!!!!!!!!!");
                estaEstresado = false;
            }

            else  
            {
                Console.WriteLine("Estoy Sin estres !!!");
                estaEstresado = false;
            }

        }

        //metodo cuando el perro esta dormido
        public void dormir()
        {
            Console.WriteLine("ZZZzzzZZZzzzZZZzzz...");
            nivelEstres = 0;
            evaluarNivelEstres();
            estaDormido = true;
            Console.ReadKey();
        }

        public void caminar()
        {
            Console.WriteLine("Estoy Caminando...");
            Console.ReadKey();
        }
    }
}
