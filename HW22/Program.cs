namespace HW22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region T1
            //1.Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək 
            //string a = "we are the world";
            //string b = string.Empty;
            //for(int i= 0; i < a.Length; i++)
            //{
            //    if (a[i] !=' ')
            //    {
            //        b += a[i];
            //    }

            //}
            //Console.WriteLine(b);
            #endregion
            #region T2
            //2.Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram
            //string a = "Breaking News: World War 3 is coming";
            //char b= 'i';
            //int count = default;
            //for(int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] == b)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);
            #endregion
            #region T3
            //3.Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram
            //(Misalçün verilmiş yazı "   salam necesen?   "-dirsə yeni düzələcək string "salam necəsən?   " olmalıdır.
            //string a = "   salam necesen?   ";
            //string b = string.Empty;
            //string c = string.Empty;
            //for(int i=0; i<a.Length; i++)
            //{
            //   if(a[i] != ' ')
            //    {

            //        b += a[i];


            //    }

            //}



            #endregion
            #region T4
            //4.Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram. Simvol +,-,* və ya / olmalıdır,
            //əks halda simvolu yenidən daxil edilməsi istənilməlidir.
            //(Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)
            //int a = 30;
            //int b = 15;
            //char c = '/';
            //if (c == '+')
            //{
            //    Console.WriteLine(a+b);

            //}  if(c == '-')
            //{
            //    Console.WriteLine(a-b);
            //}if(c == '*')
            //{
            //    Console.WriteLine(a*b);
            //}
            //if (c == '/')
            //{
            //    Console.WriteLine(a/b);
            //}
            //else if(c!='+'&&c!='-'&&c!='*'&&c!='/') 
            //{
            //    Console.WriteLine("duzgun simvolu daxil edin");
            //}

            #endregion
            #region T5
            //5.Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram

            //string text = "Nokia is connecting people";

            //bool a = text.Contains('A');
            //Console.WriteLine(a);




            #endregion
            #region T6
            //6.Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram
            //string text = "There are nine of 11 climate in Azerbaijan";
            //int count = default;

            //for(int i=0; i<text.Length; i++)
            //{
            //    if (text[i] == 'A')
            //    {
            //        count++;

            //    }

            //}
            //Console.WriteLine(count);
            #endregion
            #region T7
            //Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram. Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir
            //int a = -4;
            //if(a%2 == 0&&a>0)
            //{
            //    Console.WriteLine(a*a);
            //}
            //else
            //{
            //    Console.WriteLine("ededi yeniden daxil edin");
            //}
            #endregion
            #region T8
            //Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.
            //Əgər verilmiş dəyər "programming"dirsə console-da 400 saat, "design"dırsa 250 saat,
            //"system"dirsə 200 saat, heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.

            //string a = "system";
            //switch (a)
            //{
            //    case "programming":
            //        Console.WriteLine("400 saat");
            //        break;
            //    case "design":
            //        Console.WriteLine("250 saat");
            //        break;
            //    case "system":
            //        Console.WriteLine("200 saat");
            //        break;
            //    default:
            //        Console.WriteLine("tehsil novu yanlisdir");
            //        break;
            //}
            


                    #endregion
            }
    }
}
