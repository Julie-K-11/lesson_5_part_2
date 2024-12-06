using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Less_5_pr2
{
    public class Array : IOutput, IMath, ISort
    {
        public int[] Elements { get; set; }

        public Array(int[] elements)
        {
            Elements = elements;
        }

        public void Show()
        {
            Console.WriteLine(string.Join(", ", Elements));
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }

        public int Max()
        {
            int max = Elements[0];
            foreach (int element in Elements)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        public int Min()
        {
            int min = Elements[0];
            foreach (int element in Elements)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }

        public float Avg()
        {
            int sum = 0;
            foreach (int element in Elements)
            {
                sum += element;
            }
            return (float)sum / Elements.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int element in Elements)
            {
                if (element == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }

        public void SortAsc()
        {
            for (int i = 0; i < Elements.Length - 1; i++)
            {
                for (int j = i + 1; j < Elements.Length; j++)
                {
                    if (Elements[i] > Elements[j])
                    {
                        int temp = Elements[i];
                        Elements[i] = Elements[j];
                        Elements[j] = temp;
                    }
                }
            }
        }

        public void SortDesc()
        {
            for (int i = 0; i < Elements.Length - 1; i++)
            {
                for (int j = i + 1; j < Elements.Length; j++)
                {
                    if (Elements[i] < Elements[j])
                    {
                        int temp = Elements[i];
                        Elements[i] = Elements[j];
                        Elements[j] = temp;
                    }
                }
            }
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }
}
