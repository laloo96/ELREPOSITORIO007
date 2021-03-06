﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces25OCT
{
    public class Deportivo:Auto,IAFIP,IARBA
    {
        protected int _caballosFuerza;

        public Deportivo(int caballos, string patente, double precio)
            : base(precio, patente)
        {
            this._caballosFuerza = caballos;
        }

        double IAFIP.CalcularImpuesto()
        {
            return this.Precio * 1.28;
        }

        //Para que no haya problemas de firma una se declara explicit y el otro se implementa como un metodo propio.
        public double CalcularImpuesto()
        {
            return this.Precio * 1.23;
        }


        public override double Precio
        {
            get
            {
                return base._precio;
            }
            set
            {
                base._precio = value;
            }
        }

    }
}
