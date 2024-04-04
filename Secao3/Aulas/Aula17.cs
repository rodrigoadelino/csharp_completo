using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Convenções
// - Camel Case: lastName(parametros de métodos, variaveis dentro de métodos)
// - Pascal Case: LastName (namespaces, classe, properties e métodos)
// - Padrão _lastName(atributos "internos" da classe"


//namespace Curso // "Curso" namespace - Pascal Case
//{
//    class ContaBancaria  //Pascal Case
//    {
//        public string Titular { get; set; } //Titular(prpriedade) Pascal Case
//        private double _saldo;              //Atributo interno da classe

//        public void Deposito (double quantia) //"Deposito" Pascal Case "quantia" =parametro de metodo variavel interna CamelCase
//        {
//            _saldo += quantia;
//        }

//    public double GetSaldo()    // "GetSaldo" = método - PascalCase
//        {
//            return _saldo;
//        }
//    }
//}