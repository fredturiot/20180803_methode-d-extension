using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180803_methode_d_extension
{

    public static class StringExtension //niveau superieur!
    {
        public static string SupprimerLesEspaces(this string chaine)// this active extension
        {
            return chaine.Replace(" ", "");
        }
        public static bool EstVIde(this string chaine)
        {
            return string.IsNullOrEmpty(chaine);
        }

    }


        class Program

        {


            static void Main(string[] args)
            {

                var chaine = "hjkdjhk jhjkhjk jhkjhj jkhjkh  z";
                chaine = chaine.SupprimerLesEspaces();//this string donc inversion
                Console.WriteLine(chaine);



            }



        
            


        }
    
}
