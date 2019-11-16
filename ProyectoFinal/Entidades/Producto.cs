using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private int id;
        private string glosa;


        public Producto(int id, string glosa)
        {
            this.id = id;
            this.glosa = glosa;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Glosa
        {
            get { return glosa; }
            set { glosa = value; }
        }
    }


}
