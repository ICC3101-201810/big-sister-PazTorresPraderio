using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPOO
{

    public delegate void VerificarProducto(object sender, string input);
    public class DelegateTest
    {
        List<Product> cart;

        public void Verificar(object sender, string input)
        {
            foreach (Product p  in Program.cart)
            {
                
            }
        }
        public event VerificarProducto EventoBacan;

    }
}
