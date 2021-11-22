using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPdfViewer
{
    public static class DesignerPdfViewer
    {

        static void TestDesingerViewer()
        {
            Console.WriteLine("Enter the height of the 26 alphabets");
            List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();
            Console.WriteLine("Enter a word (small letter)");
            string word = Console.ReadLine();

            int rectangle = GetSelectionRectangle(h, word);

            Console.WriteLine("The rectangle of selection is: {0}", rectangle);
        }

        // Source matrial
        // https://www.hackerrank.com/challenges/designer-pdf-viewer/problem
        public static int GetSelectionRectangle(List<int> h, string word)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            int maxIndex = 0;
            foreach (char l in word)
            {
                maxIndex = h[(int)l - 97] > maxIndex ? h[(int)l - 97] : maxIndex;
                // maxIndex = h[letters.IndexOf(l)] > maxIndex ? h[letters.IndexOf(l)] : maxIndex;
            }
            return maxIndex * 1 * word.Length;
        }
    }
}
