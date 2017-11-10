using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BIODictionary
{
    class dictionaryClass
    {

        public FileStream openFile(String fileToOpen)
        {

            FileStream file = new FileStream(fileToOpen, FileMode.Open, FileAccess.Read);
            return file;
        }


        public string fileToOpen(String word)

        {
            String myword = word.ToLower();
            Char letterWordStartsWith = myword.ElementAt(0);
            String result = "awords.txt";
            switch (letterWordStartsWith)
            {
                case 'a':
                    result = "awords.txt";
                    break;
                case 'b':
                    result = "bwords.txt";
                    break;
                case 'c':
                    result = "cwords.txt";
                    break;
                case 'd':
                    result = "dwords.txt";
                    break;
                case 'e':
                    result = "ewords.txt";
                    break;
                case 'f':
                    result = "gwords.txt";
                    break;
                case 'g':
                    result = "ewords.txt";
                    break;
                case 'h':
                    result = "hwords.txt";
                    break;
                case 'i':
                    result = "iwords.txt";
                    break;
                case 'j':
                    result = "jwords.txt";
                    break;
                case 'k':
                    result = "kwords.txt";
                    break;
                case 'l':
                    result = "lwords.txt";
                    break;
                case 'm':
                    result = "mwords.txt";
                    break;
                case 'n':
                    result = "nwords.txt";
                    break;
                case 'o':
                    result = "owords.txt";
                    break;
                case 'p':
                    result = "pwords.txt";
                    break;
                case 'q':
                    result = "qwords.txt";
                    break;
                case 'r':
                    result = "rwords.txt";
                    break;
                case 's':
                    result = "swords.txt";
                    break;
                case 't':
                    result = "twords.txt";
                    break;
                case 'u':
                    result = "uwords.txt";
                    break;
                case 'v':
                    result = "vwords.txt";
                    break;
                case 'w':
                    result = "wwords.txt";
                    break;
                case 'x':
                    result = "xwords.txt";
                    break;
                case 'y':
                    result = "ywords.txt";
                    break;
                case 'z':
                    result = "zwords.txt";
                    break;

            }

            return result;
        }


        public string readFile(string word)
        { StreamReader reader = new StreamReader(openFile(fileToOpen(word)));
            String text2;
            String text = "";

            while (reader.EndOfStream != true)
            {
                if (reader.ReadLine().Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    do
                    {
                        text2 = reader.ReadLine();
                        if (text2.Length > 0)
                        {
                            text = text + "\n" + text2;
                        }

                    }

                    while (text2.Length > 0);
                    break;

                }
            }

            reader.Close();
            return word + "\n" + text;

        }


        public Color setColor()
        {   
            ColorDialog cd = new ColorDialog();
            Color colorChoose=new Color();
            if (cd.ShowDialog().ToString()=="OK" )
            {
                colorChoose=cd.Color;
                return colorChoose;
            }
           
           return colorChoose;
        }
    }
}
