using ColaboracionClases;
using System;


    class Banco
    {
        //declaramos 3 atriibutos de tipo Cliente (de la clase Cliente)
        private Cliente cliente1, cliente2, cliente3;

        public Banco()
        {
            //instanciamos los atrbutos en objetos de la clase cliente
            this.cliente1 = new Cliente("Juan");
            this.cliente2 = new Cliente("Maria");
            this.cliente3 = new Cliente("Raul");
        }

        public void Operar()
        {
            cliente1.Depositar(300000);
            cliente2.Depositar(200000);
            cliente3.Depositar(50000);
            cliente3.Girar(40000);
        }

        public void Informacion()
        {
            int valores = cliente1.RetornarMonto() + cliente2.RetornarMonto() + cliente3.RetornarMonto();
            
            Console.WriteLine("Total depositos bancarios: " +valores);
            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }

        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.Operar();
            banco.Informacion();
        }
    }

