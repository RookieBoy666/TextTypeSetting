using System;

namespace TextTypeSetting
{

    class Program
    {
        public static  string FinaString(string str,int maxWidth)
        {
            string[] array = new string[200];//单词数组
            array = str.Split(' ');
            int len;
            len = array.Length;
            string strLine = "";
            string kong = "";
            int tot = 1;//行数 
            Console.WriteLine("****************************");
            Console.WriteLine("{0}个单词,每行最多{1}个字符", len - 1, maxWidth);
            Console.WriteLine("****************************");
            for (int j = 0; j < len; j++)
            {
                if (j == 0)
                {
                    array[j] = array[0];
                }
                else
                {
                    array[j] = array[j] + " ";
                }
            }
            for (int i = 0; i < len; i++)
            {
                if (strLine.Length + array[i].Length >= maxWidth)
                {
                    if (strLine == "")
                    {
                        continue;
                    }
                    Console.Write(strLine);
                    Console.WriteLine();
                    strLine = kong;
                    strLine = strLine + array[i];
                    tot++;
                }
                else
                {
                    strLine = strLine + array[i];
                }
            }
            return strLine;

        }
        public static void Main(string[] args)
        {
            string strRead = "";
            int maxWidth = 30;//每行最大字符数
           
            strRead = Console.ReadLine();
              string finaString=  FinaString(strRead,maxWidth);
            Console.WriteLine(finaString);
        }
    }



}
