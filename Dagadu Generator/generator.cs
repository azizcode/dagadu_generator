using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagadu_Generator
{
    class generator
    {
        static string[,] aksara = {
                                      {"h", "n", "c", "r", "k"},
                                      {"d", "t", "s", "w", "l"},
                                      {"p", "dh", "j", "y", "ny"},
                                      {"m", "g", "b", "th", "ng"}
                                  };

        public static string generate(string a){
            
            string dagadu = "";

            for (int i = 0; i < a.Length; i++){
                bool upper = false, ketemu = false, vokal=true;
                string dobel = "";
                if (i < a.Length - 1){
                    dobel += a[i];
                    if (Char.IsUpper(dobel[0]))
                    {
                        upper = true;
                    }
                    dobel += a[i + 1];
                }
                
                for (int j = 0; j < aksara.GetLength(0); j++){
                    for (int k = 0; k < aksara.GetLength(1); k++){
                        string hidup = "";
                        if (i < a.Length - 2)
                        {
                            hidup += a[i + 2];
                        }
                        if (dobel.ToLower().Equals(aksara[j, k])){
                            if (is_vokal(hidup))
                            {
                                dagadu += tukar(upper, j, k);
                            }
                            else
                            {
                                dagadu += tetap(upper, dobel);
                            }
                            ketemu = true;
                            vokal = false;
                            i++;
                        }
                    }
                }

                if (!ketemu)
                {
                    for (int j = 0; j < aksara.GetLength(0); j++)
                    {
                        for (int k = 0; k < aksara.GetLength(1); k++)
                        {
                            string single = "";
                            single += a[i];
                            if (Char.IsUpper(single[0]))
                            {
                                upper = true;
                            }
                            if (single.ToLower().Equals(aksara[j, k]))
                            {
                                string hidup = "";
                                if (i < a.Length - 1)
                                {
                                    hidup += a[i + 1];
                                }
                                if (is_vokal(hidup))
                                {
                                    dagadu += tukar(upper, j, k);
                                }
                                else
                                {
                                    dagadu += tetap(upper, single);
                                }
                                ketemu = true;
                                vokal = false;
                            }
                        }
                    }
                }

                if(vokal){
                    string single = "";
                    single += a[i];
                    if (Char.IsUpper(single[0])){
                        upper = true;
                    }
                    dagadu+=tetap(upper,single);
                }
            }
            return dagadu;
        }

        public static bool is_vokal(string huruf) { 
            string[] vokal = {"a","i","u","e","o"};
            bool benar = false;
            for(int i=0; i<vokal.Length;i++){
                if(huruf.ToLower().Equals(vokal[i])){
                    benar = true;
                }
            }
            return benar;
        }

        public static string tukar(bool upper, int baris, int kolom){
            string kembali = "";
            if (upper){
                if (baris < 2){
                    kembali += aksara[baris + 2, kolom].ToUpper();
                }
                else{
                    kembali += aksara[baris - 2, kolom].ToUpper();
                }
            }
            else{
                if (baris < 2)
                {
                    kembali += aksara[baris + 2, kolom];
                }
                else{
                    kembali += aksara[baris - 2, kolom];
                }
            }
            return kembali;
        }

        public static string tetap(bool upper, string huruf) {
            string kembali = "";
            if (upper){
                kembali += huruf;
                kembali.ToUpper();
            }
            else
            {
                kembali += huruf;
            }
            return kembali;
        }

    }
}
