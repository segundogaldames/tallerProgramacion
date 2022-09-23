using System;
namespace ColaboracionClases
{
    class Cliente
    {
        private string nombre;
        private int monto;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
            this.monto = 0;
        }

        public void Depositar(int valor)
        {
            this.monto = this.monto + valor;
        }

        public void Girar(int valor)
        {
            if (this.monto >= valor)
            {
                this.monto = this.monto - valor;
            }
            else
            {
                Console.WriteLine("No tiene fondos suficientes... intente depostar");
            }
        }

        //metodo que retorna el monto de tipo entero
        public int RetornarMonto() 
        { 
            return this.monto; 
        }
        //metodo que retorna el nombre del cliente de tipo string
        public void Imprimir() 
        {
            Console.WriteLine(this.nombre + " Tiene depositado " + this.monto);
        }   
    }
}
