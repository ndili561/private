using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckForPanagram("The quick brown fox jumps over the lazy dog");
            var smallPyramid = new[]
         {
              new[] {3},
              new[] {7, 4},
              new[] {2, 4, 6},
              new[] {8, 5, 9, 3}
          };
            MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });
            IEnumerable enumerable = smallPyramid.Select(f => f.Count());
            LongestSlideDown(smallPyramid);
            ToCamelCase("the-stealth-warrior");
            SortArray(new int[] { 5, 3, 2, 8, 1, 4 });
            orderWeight("56 65 74 100 99 68 86 180 90");
           bool result = OnlyOne(new bool[] { false, false });
            Narcissistic(153);
            Solution("abc");
            ArrayPreviousLess(new int[] { 3, 5, 2, 4, 5 });
            TrailingZeros(6);
            Smallest(74831256910614416);
            Evaluate("2 / 2 + 3 * 4 - 6");
            AlphabetPosition("The sunset sets at twelve o' clock.");
            ValidParent(")((((");
            Solution(10);
            SpinWords("Hey fellow warriors");
            Countyy("aaaa");
            ArrayDiff(new int[] { 1, 2 }, new int[] { 1 });
            Switcheroo("abc");
            solution(123456);
            RemoveDuplicateWords("alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta");
            ToDoubleArray(new string[] { "1.1", "2.2", "3.3" });
            find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 });
            Count("aabb");
            TwoSort(new[] { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps" });
            OddCount(15023);
            Correct("");

        }

        public async void testHttpGet()
        {
            var url = "jdak";
            using (var clie = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(new Program());
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var result = clie.PostAsync(url, content).Result;
                if (result.IsSuccessStatusCode)
                {

                }


            }
         
           
            using(var client = new HttpClient())
            {
                
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = JsonConvert.DeserializeObject(await client.GetStringAsync(url));
                var content = client.GetAsync(url).Result;
                var result = content.Content.ReadAsStringAsync().Result;

            }
          
        }

        public static int[] MoveZeroes(int[] arr)
        {
            
            Queue<int> r = new Queue<int>();

            for(int i = 0; i < arr.Length; i++)
            {
               
                if (arr[i] != 0)
                {
                    r.Enqueue(arr[i]);
                }
               
            }
            var count = arr.Where(f=>f==0).Count();
            while(count != 0)
            {
                r.Enqueue(0);
                count--;
            }
           


            return r.Reverse().ToArray();
        }

        public static bool CheckForPanagram(string str)
        {
            //TO DO
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            IEnumerable h = str.Select(c => c.Equals("f"));
            bool y = str.ToCharArray().Where(t => t.Equals(alpha.ToCharArray().Where(o => o.Equals(t)))).Count()>0;
            foreach (char u in str)
            {
                if (alpha.IndexOf(char.ToString(u),StringComparison.InvariantCultureIgnoreCase)!=-1){
                    return true;
                }
                return false;
            }

            return true;
        }

        public static int LongestSlideDown(int[][] pyramid)
        {
            char y = 'h';
        
            int result = 0;
            int count = 0;
          
            return result;
        }

        public int[] FirstReverseTry(int[] arr)
        {
            HashSet<int> st = arr.ToHashSet();

            return new int[0];
        }



        public static string ToCamelCase(string str)
        {
            str.Where(g => char.GetNumericValue(g)>0.1);
            IEnumerable f=  str.Select((c, i) => i > 0 ? true : false);
            char u = str.Select(c => c).Where(v => !char.IsLetterOrDigit(v)).FirstOrDefault();
            string[] arr = str.Split(u);
            StringBuilder result = new StringBuilder();
            for (int i=0;i<arr.Length;i++)
            {
               
                 result.Append(arr[i].First().ToString().ToUpper() + arr[i].Substring(1));
                       
            }
            if (char.IsLower(arr[0].First()))
            {
                result.Replace(result.ToString().First(), arr[0].First());
            }
            return result.ToString();
        }

        public static int[] SortArray(int[] array)
        {
            HashSet<int> ts = new HashSet<int>(array);
            HashSet<int> gh = ts.Select(c =>c).Where(f=>f%2!=0).OrderBy(x=>x).ToHashSet();
           

            return array;
        }
        public static string orderWeight(string strng)
        {
            string[] arr = strng.Split(' ');
            int[] result = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                int relt = 0;
                char[] rr = arr[i].ToCharArray();

                foreach (char hh in rr)
                {
                    relt += (int)Char.GetNumericValue(hh);


                }
                result[i] = relt;
                relt = 0;
            }
             Array.Sort(result);
            Array.Exists(result, t => t > 1);
            Array.Resize(ref result, 7);
         
            return "66";
        }

        public static bool OnlyOne(params bool[] flags)
        {
            return flags.Select(c => c.Equals(true)).Count()== 1;

        }

        public static bool Narcissistic(int value)
        {
            char[] arr = value.ToString().ToCharArray();
            double[] resu = new double[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                resu[i] = Math.Pow(Char.GetNumericValue(arr[i]), arr.Length);
            }
            int total = (int)resu.Sum();
            return total == value;
          
        }

        public static string[] Solution(string str)
        {
            char[] arr = str.ToCharArray();
            List<string> result = new List<string>();
            if (str.Length % 2 == 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        result.Add(string.Concat(arr[i] + arr[i + 1].ToString()));
                    }
                }

            }
            str += "_";
            string [] gsjgskj= Enumerable.Range(0, str.Length)
              .Where(f => f % 2 == 0)
              .Select(x => str.Substring(x, 2))
              .ToArray();
            var numbers = new List<int> { 6, 2, 8, 3 };
            int sum = numbers.Aggregate(func: (res, item) => res + item);
            var chars = new[] { "a", "b", "c", "d" };
            var igmsmg = chars.Aggregate((u, o) => string.Concat(u, o));
            if (str.Length % 2 != 0)
                str += "_";
            return Enumerable.Range(0, str.Length)
              .Where(f => f % 2 == 0)
              .Select(x => str.Substring(x, 2))
              .ToArray();

        }

        public static int[] ArrayPreviousLess(int[] arr)
        {
            ArrayList myArryList = new ArrayList(arr);

          
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > -1)
                {
                    myArryList.Insert(i, -1);
                }
                count++;


            }


   
            return arr;
        }
        public static int TrailingZeros(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            char[] r = result.ToString().ToCharArray();
            int count = 0;
            for(int y = r.Length-1;y>=0;y--)
            {
                if (char.Equals(r[y],'0'))
                {
                    count++;
                }

            }
            return count;
        }

        public static long[] Smallest(long n)
        {
            List<int> resy = n.ToString().Select(o => int.Parse(o.ToString())).ToList();
            int smallest = 1;
            int index = 0;
            foreach(int y in resy.AsEnumerable().ToList())
            {
                if (y <= smallest)
                {
                    if(index == 0)
                    {
                        index = resy.IndexOf(y);
                        resy.RemoveAt(index);
                        resy.Insert(0, y);
                      

                    }
                  
                }
             
            }
            string[] test = { "ajfka", "jfnfakj" };
        

            long[] result = new long[3];
            string uu = resy.Select(i => i.ToString()).Aggregate((s1, s2) => s1 + s2);
         
            result[0] = long.Parse(uu);
            result[1] = index;
            result[2] = 0;

            return result;
        }

        public static double Evaluate(string expression)
        {
            
            
            char[] arr = expression.ToCharArray();
            double result = 0.0;
            string[] arr2 = new string[arr.Length];
          
            for (int i = 0; i < arr.Length; i++)
            {
                if (Char.IsNumber(arr[i]))
                {
                    arr2[i]= arr[i].ToString();
                   

                }
                else if (Char.Equals(arr[i],' '))
                {
                    continue;
                }
                else
                {
                   
                }

                int[] array1 = { 1, 2, 4 };
                int[] array2 = { 2, 3, 4 };

                // Call Intersect extension method.
                var intersect = array1.Intersect(array2);
   
                
        









            }
            return result;
        }

        public static double MyOpp(int a,int b,int c, int d, int e, Func<int, int,int,int,int> op)
        {
          
            return 0.0;
        }

        public static string AlphabetPosition(string text)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            char[] arr = text.ToLower().ToCharArray();
            string result = String.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!Char.IsWhiteSpace(arr[i]) && !Char.Equals('.', arr[i]) && Char.IsLetter(arr[i]))
                {
                    result += Array.IndexOf(alpha, arr[i]) + 1 + " ";

                }
            }

            return text.TrimEnd();
        }

        public static bool ValidParent(string input)
        {
            char[] res = input.ToCharArray();
            int countt = 0;
            int count = 0;
            foreach (char t in res)
            {
                if (t.Equals('('))
                {
                    countt++;
                }
                if (t.Equals(')'))
                {
                    count++;
                }

            }
            if (countt == count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Solution(int value)
        {
            int result = 0;


            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i%5==0)
                {
                    result += i;
                }
               



            }

            return result;

        }

        public static string SpinWords(string sentence)
        {
            string[] arr = sentence.Split(" ");
            string[] result = new string[arr.Length];
            for (int y = 0; y < arr.Length; y++)
            {

                result[y] = new string(arr[y].Reverse().ToArray());



            }


            return string.Join(" ", result);


        }


        public static Dictionary<char, int> Countyy(string str)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            char[] result2 = str.ToCharArray();
            foreach (char u in result2)
            {

                if (!result.ContainsKey(u))
                {
                  

                    result.Add(u, result2.Where(f => f.Equals(u)).Count());
                }

            }
            string y = "fksfkja";
            y.Reverse();
            return result;
        }


        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> list = new List<int>(a);
            List<int> list2 = new List<int>(b);
            foreach (int y in list)
            {
                if (list2.Contains(y))
                {
                    list.Remove(y);
                    break;
                }

            }
            return list.ToArray();

        }


        public static string Switcheroo(string y)
        {
           
         
            return String.Join("", y.ToCharArray()
                             .Select(x => x == 'a' ? x = 'b' : (x == 'b' ? x = 'a' : x))
                             .ToArray());
            
          
        }

        public static int solution(int A)
        {

            string f = A.ToString();
            char[] arr = f.ToCharArray();
            char[] result = new char[arr.Length];
            var list = new List<char>(arr);
            var test = new List<char>();
            int i = 0;
            foreach(char u in list)
            {
                if (test.Contains(u))
                {
                    break;
                }
                test.Add(u);
                i++;
                test.Add(list.ElementAt(list.Count()-i));
              
                
               
            }
            int count = arr.Length;
            int j = 0;
         
            Console.WriteLine(result);
            int r = 0;
            return r;
        }

        public static bool ValidParentheses(string input)
        {
            char[] res = input.ToCharArray();
            int countt = 0;
            int count = 0;
            foreach (char t in res)
            {
                if (t.Equals('('))
                {
                    countt++;
                }
                if (t.Equals(')'))
                {
                    count++;
                }

            }
            if (countt == count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string Correct(string text)
        {
            char[] result = text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals('O'))
                {
                    result[i] = Convert.ToChar(0);
                }
                else
                  if (text[i].Equals('S'))
                {
                    result[i] = Convert.ToChar(5);
                }
                else
                  if (text[i].Equals('I'))
                {
                    result[i] = Convert.ToChar(1);
                }

            }
            return new string(result);
        }

        public static ulong OddCount(ulong n)
        {
            List<ulong> result = new List<ulong>();
            for (ulong i = n; i <= n; i--)
            {
                if (i % 2 != 0)
                {
                    result.Add(i);
                }
                Convert.ToChar(0);
            }
            return Convert.ToUInt32(result.Count);
        }

        public static string TwoSort(string[] s)
        {
            StringBuilder st = new StringBuilder();
            Array.Sort(s);
            foreach(char y in s[0])
            {
                st.Append(y + "***");
            }
           
            bool t = char.IsDigit('g');
          
            st.Remove(st.Length-3, 3);
            return st.ToString();
           
               
               

        }
            
           

        





        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            //List<string> list = new List<string>(str);
          
      
           
            int c = str.GroupBy(f => f).Count();

            foreach(char u in str)
            {
                if (!result.ContainsKey(u))
                {
                    result.Add(u, str.GroupBy(f => f).Count());
                }
            }

           
                

       


            return result;
      }



        public static int find_it(int[] seq)
        {
            int count = 0;
            var coun = seq
     .GroupBy(e => e);
            String.Concat("", "");
     //.Where(e => e.Count() % 2!=0)
     //.Select(e => e.First());
            return Convert.ToInt32(coun.First());
        }

        public static string RemoveDuplicateWords(string s)
        {
            double[] result = new double[5];
            int f = result.Length;

            Dictionary<char, int> dic = new Dictionary<char, int>();
            
            int y = s.Length;


           
            return s;

        }


        public static double[] ToDoubleArray(string[] stringArray)
        {
            double[] result = new double[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {

                result[i] = Convert.ToDouble(stringArray[i]);

            }
            return result;
        }



    }
}
