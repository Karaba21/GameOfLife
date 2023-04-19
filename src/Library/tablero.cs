using System;

namespace PII_Game_Of_Life
{
    public class Tablero{
        private bool[,] tablero{get; set;}
        public int Filas {get;}
        public int Columnas {get;}

        public Tablero (int Filas, int Columnas){
            this.Filas = Filas;
            this.Columnas = Columnas;
            tablero = new bool[Filas, Columnas]; //aca se crea una matriz de valores booleanos 
        }

        public bool CambiarCelula (x,y,bool[,]){
            
        }


    }
}