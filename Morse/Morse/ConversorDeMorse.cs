using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor
{
    class ConversorDeMorse
    {
        static Dictionary<char, string> DiccionarioMorse = new Dictionary<char, string>()
        {
            {'A' , ".-"},
            {'B' , "-..."},
            {'C' , "-.-."},
            {'D' , "-.."},
            {'E' , "."},
            {'F' , "..-."},
            {'G' , "--."},
            {'H' , "...."},
            {'I' , ".."},
            {'J' , ".---"},
            {'K' , "-.-"},
            {'L' , ".-.."},
            {'M' , "--"},
            {'N' , "-."},
            {'O' , "---"},
            {'P' , ".--."},
            {'Q' , "--.-"},
            {'R' , ".-."},
            {'S' , "..."},
            {'T' , "-"},
            {'U' , "..-"},
            {'V' , "...-"},
            {'W' , ".--"},
            {'X' , "-..-"},
            {'Y' , "-.--"},
            {'Z' , "--.."},
        };

        public static string TextoAMorse(string texto)
        {
            string morse = "";

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == ' ')
                {
                    morse += "/ ";
                }
                else
                {
                    morse += DiccionarioMorse[texto[i]] + " ";
                }
            }

            return morse;
        }

        public static string MorseATexto(string morse)
        {
            string texto = "";
            string letra = "";

            for (int i = 0; i < morse.Length; i++)
            {
                if (morse[i] == '/')
                {
                    texto += ' ';
                }
                else if (morse[i] != ' ')
                {
                    letra += morse[i];
                }
                else
                {
                    foreach (KeyValuePair<char, string> item in DiccionarioMorse)
                    {
                        if (letra == item.Value)
                        {
                            texto += item.Key;
                            letra = "";
                        }
                    }
                }
            }
            return texto;
        }
    }
}
