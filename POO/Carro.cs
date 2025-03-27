using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Carro
    {
        //     Atributos
        public string marca;

        // Nomenclatura
        // Todo atributo privado comeca com _
        private string _modelo;
        public int anoFabricacao;

        //     Metodos
        // Get e Set
        public void SetModelo(string mod)
        {
            if(mod == "Fiesta" || mod == "HB20")
            {
                _modelo = mod;
            }
            else
            {
                Console.WriteLine("Alteracao Inválida");
            }
        }

        public string GetModelo()
        {
            return _modelo;
        }

        public void Andar()
        {
            Console.WriteLine("Carro esta andando！");
        }

        public void Parar()
        {
            Console.WriteLine("Carro esta parando!");
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Ano de Fabricacao: {anoFabricacao}");
        }

    }
}
