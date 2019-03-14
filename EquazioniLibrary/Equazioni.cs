﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        //1 Verificare se un'equazione di primo grado è determinata
        static public bool IsDetermined(double n1)
        {
            bool risp = false;

            if (n1 != 0) 
            {
                risp = true;
            }

            return risp;
        }

        //1.0 Verificare se un'equazione di primo grado è indeterminata
        static public bool IsIndetermined(double n1, double n2)
        {
            bool risp = false;

            if (n1 == 0 && n2 == 0)
            {
                risp = true;
            }

            return risp;
        }

        //2 Verificare se un'equazione di primo grado è impossibile
        static public bool IsInconsisted(double n1, double n2)
        {
            bool risp = false;

            if (n1 == 0 && n2 != 0)
            {
                risp = true;
            }

            return risp;
        }




        //3 Verificare se un'equazione è di secondo grado
        static public bool IsDegree2(double n1)
        {
            bool risp = false;

            if (n1 != 0)
            {
                risp = true;
            }

            return risp;
        }

        //4 Calcolo il Delta
        static public double Delta(double n1, double n2, double n3)
        {
            double delta = 0;

            if (n1 != 0)
            {
                delta = (n2 * n2) - (4 * n1 * n3);
            }

            return delta;
        }

        //5 risolve un'equazione di primo grado
        static public string EquationDegree1(double n1, double n2)
        {
            string risp = "";

            if (IsIndetermined(n1, n2))
            {
                risp = "indeterminata";
            }
            else if (IsDetermined(n1))
            {
                risp = Convert.ToString(-n2 / n1);
            }
            else if (IsInconsisted(n1, n2))
            {
                risp = "impossibile";
            }

            return risp;
        }


    }
}