using System;
using System.IO;


namespace Archivos
{
    public class Archivo
    {
        StreamReader archivo = new StreamReader("c:\\Archivos\\prueba.txt"); //Objeto clase StreamReader
        StreamWriter copia = new StreamWriter("c:\\Archivos\\copia.txt"); 
        public void desplegar() //definicion metodo desplegar
        {
            char c;
            int letras = 0, numeros = 0,espacios = 0;

            while(!archivo.EndOfStream)
            {
                c =(char)archivo.Read();
                Console.Write(c);
                if(c=='e' || c=='E')
                {
                    copia.Write('3');
                }
                else if(char.ToLower(c)=='e')
                {
                    copia.Write('4');
                }
                else if(char.ToLower(c)=='i')
                {
                    copia.Write('1');
                }
                else if(char.ToLower(c)=='o')
                {
                    copia.Write('0');
                }
                else if(c=='u')
                {
                    copia.Write('#');
                }
                else
                {
                    copia.Write(c);
                }
                if(char.IsLetter(c))
                {
                    letras++;
                }
                else if(char.IsDigit(c))
                {
                    numeros++;
                }
                else if(c ==' ')
                {
                    espacios++;
                }
            }
            copia.WriteLine("Numeros = " + numeros);
            copia.WriteLine("Espacios = " + espacios);
            copia.WriteLine("letras = " + letras);

            copia.Close();
            archivo.Close();


        }
        public void palabras() 
        {
            char c;
        
            string buffer = "";
            while(!archivo.EndOfStream)
            {
                c =(char)archivo.Read();
                if(char.IsLetterOrDigit(c))
                {
                    buffer += c;      // += buffer = buffer + c;
                }
                else if(char.IsWhiteSpace(c))
                {
                    copia.WriteLine(buffer);
                    buffer = "";
                }
            }
        
            copia.Close();
            archivo.Close();
        }
    }
}