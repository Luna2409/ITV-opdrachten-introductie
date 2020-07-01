using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_product_in_a_grid
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            int[] array1 = { 08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08 };
            int[] array2 = { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00 };
            int[] array3 = { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65 };
            int[] array4 = { 52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91 };
            int[] array5 = { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80 };
            int[] array6 = { 24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50 };
            int[] array7 = { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70 };
            int[] array8 = { 67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21 };
            int[] array9 = { 24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72 };
            int[] array10 = { 21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95 };
            int[] array11 = { 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92 };
            int[] array12 = { 16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57 };
            int[] array13 = { 86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58 };
            int[] array14 = { 19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40 };
            int[] array15 = { 04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66 };
            int[] array16 = { 88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69 };
            int[] array17 = { 04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36 };
            int[] array18 = { 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16 };
            int[] array19 = { 20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54 };
            int[] array20 = { 01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48 };

            #endregion

            int som = 0;
            int max = 0;

            #region Horizontal

            //Row 1
            for (int i = 0; i < array1.Length - 3; i++)
            {
                som = array1[i] * array1[i + 1] * array1[i + 2] * array1[i + 3];
                max = Math.Max(max, som);
            }

            //Row 2
            for (int i = 0; i < array2.Length - 3; i++)
            {
                som = array2[i] * array2[i + 1] * array2[i + 2] * array2[i + 3];
                max = Math.Max(max, som);
            }

            //Row 3
            for (int i = 0; i < array3.Length - 3; i++)
            {
                som = array3[i] * array3[i + 1] * array3[i + 2] * array3[i + 3];
                max = Math.Max(max, som);
            }

            //Row 4
            for (int i = 0; i < array4.Length - 3; i++)
            {
                som = array4[i] * array4[i + 1] * array4[i + 2] * array4[i + 3];
                max = Math.Max(max, som);
            }

            //Row 5
            for (int i = 0; i < array5.Length - 3; i++)
            {
                som = array5[i] * array5[i + 1] * array5[i + 2] * array5[i + 3];
                max = Math.Max(max, som);
            }

            //Row 6
            for (int i = 0; i < array6.Length - 3; i++)
            {
                som = array6[i] * array6[i + 1] * array6[i + 2] * array6[i + 3];
                max = Math.Max(max, som);
            }

            //Row 7
            for (int i = 0; i < array7.Length - 3; i++)
            {
                som = array7[i] * array7[i + 1] * array7[i + 2] * array7[i + 3];
                max = Math.Max(max, som);
            }

            //Row 8
            for (int i = 0; i < array8.Length - 3; i++)
            {
                som = array8[i] * array8[i + 1] * array8[i + 2] * array8[i + 3];
                max = Math.Max(max, som);
            }

            //Row 9
            for (int i = 0; i < array9.Length - 3; i++)
            {
                som = array9[i] * array9[i + 1] * array9[i + 2] * array9[i + 3];
                max = Math.Max(max, som);
            }

            //Row 10
            for (int i = 0; i < array10.Length - 3; i++)
            {
                som = array10[i] * array10[i + 1] * array10[i + 2] * array10[i + 3];
                max = Math.Max(max, som);
            }

            //Row 11
            for (int i = 0; i < array11.Length - 3; i++)
            {
                som = array11[i] * array11[i + 1] * array11[i + 2] * array11[i + 3];
                max = Math.Max(max, som);
            }

            //Row 12
            for (int i = 0; i < array12.Length - 3; i++)
            {
                som = array12[i] * array12[i + 1] * array12[i + 2] * array12[i + 3];
                max = Math.Max(max, som);
            }

            //Row 13
            for (int i = 0; i < array13.Length - 3; i++)
            {
                som = array13[i] * array13[i + 1] * array13[i + 2] * array13[i + 3];
                max = Math.Max(max, som);
            }

            //Row 14
            for (int i = 0; i < array14.Length - 3; i++)
            {
                som = array14[i] * array14[i + 1] * array14[i + 2] * array14[i + 3];
                max = Math.Max(max, som);
            }

            //Row 15
            for (int i = 0; i < array15.Length - 3; i++)
            {
                som = array15[i] * array15[i + 1] * array15[i + 2] * array15[i + 3];
                max = Math.Max(max, som);
            }

            //Row 16
            for (int i = 0; i < array16.Length - 3; i++)
            {
                som = array16[i] * array16[i + 1] * array16[i + 2] * array16[i + 3];
                max = Math.Max(max, som);
            }

            //Row 17
            for (int i = 0; i < array17.Length - 3; i++)
            {
                som = array17[i] * array17[i + 1] * array17[i + 2] * array17[i + 3];
                max = Math.Max(max, som);
            }

            //Row 18
            for (int i = 0; i < array18.Length - 3; i++)
            {
                som = array18[i] * array18[i + 1] * array18[i + 2] * array18[i + 3];
                max = Math.Max(max, som);
            }

            //Row 19
            for (int i = 0; i < array19.Length - 3; i++)
            {
                som = array19[i] * array19[i + 1] * array19[i + 2] * array19[i + 3];
                max = Math.Max(max, som);
            }

            //Row 20
            for (int i = 0; i < array20.Length - 3; i++)
            {
                som = array20[i] * array20[i + 1] * array20[i + 2] * array20[i + 3];
                max = Math.Max(max, som);
            }

            #endregion

            #region Vertical

            //Rows 1-4
            for (int i = 0; i < array1.Length; i++)
            {
                som = array1[i] * array2[i] * array3[i] * array4[i];
                max = Math.Max(max, som);
            }

            //Rows 2-5
            for (int i = 0; i < array2.Length; i++)
            {
                som = array2[i] * array3[i] * array4[i] * array5[i];
                max = Math.Max(max, som);
            }

            //Rows 3-6
            for (int i = 0; i < array3.Length; i++)
            {
                som = array3[i] * array4[i] * array5[i] * array6[i];
                max = Math.Max(max, som);
            }

            //Rows 4-7
            for (int i = 0; i < array4.Length; i++)
            {
                som = array4[i] * array5[i] * array6[i] * array7[i];
                max = Math.Max(max, som);
            }

            //Rows 5-8
            for (int i = 0; i < array5.Length; i++)
            {
                som = array5[i] * array6[i] * array7[i] * array8[i];
                max = Math.Max(max, som);
            }

            //Rows 6-9
            for (int i = 0; i < array6.Length; i++)
            {
                som = array6[i] * array7[i] * array8[i] * array9[i];
                max = Math.Max(max, som);
            }

            //Rows 7-10
            for (int i = 0; i < array7.Length; i++)
            {
                som = array7[i] * array8[i] * array9[i] * array10[i];
                max = Math.Max(max, som);
            }

            //Rows 8-11
            for (int i = 0; i < array8.Length; i++)
            {
                som = array8[i] * array9[i] * array10[i] * array11[i];
                max = Math.Max(max, som);
            }

            //Rows 9-12
            for (int i = 0; i < array9.Length; i++)
            {
                som = array9[i] * array10[i] * array11[i] * array12[i];
                max = Math.Max(max, som);
            }

            //Rows 10-13
            for (int i = 0; i < array10.Length; i++)
            {
                som = array10[i] * array11[i] * array12[i] * array13[i];
                max = Math.Max(max, som);
            }

            //Rows 11-14
            for (int i = 0; i < array11.Length; i++)
            {
                som = array11[i] * array12[i] * array13[i] * array14[i];
                max = Math.Max(max, som);
            }

            //Rows 12-15
            for (int i = 0; i < array12.Length; i++)
            {
                som = array12[i] * array13[i] * array14[i] * array15[i];
                max = Math.Max(max, som);
            }

            //Rows 13-16
            for (int i = 0; i < array13.Length; i++)
            {
                som = array13[i] * array14[i] * array15[i] * array16[i];
                max = Math.Max(max, som);
            }

            //Rows 14-17
            for (int i = 0; i < array14.Length; i++)
            {
                som = array14[i] * array15[i] * array16[i] * array17[i];
                max = Math.Max(max, som);
            }

            //Rows 15-18
            for (int i = 0; i < array15.Length; i++)
            {
                som = array15[i] * array16[i] * array17[i] * array18[i];
                max = Math.Max(max, som);
            }

            //Rows 16-19
            for (int i = 0; i < array16.Length; i++)
            {
                som = array16[i] * array17[i] * array18[i] * array19[i];
                max = Math.Max(max, som);
            }

            //Rows 17-20
            for (int i = 0; i < array17.Length; i++)
            {
                som = array17[i] * array18[i] * array19[i] * array20[i];
                max = Math.Max(max, som);
            }

            #endregion

            #region Diagonal top left, bottom right

            //Rows 1-4
            for (int i = 0; i < array1.Length - 3; i++)
            {
                som = array1[i] * array2[i + 1] * array3[i + 2] * array4[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 2-5
            for (int i = 0; i < array2.Length - 3; i++)
            {
                som = array2[i] * array3[i + 1] * array4[i + 2] * array5[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 3-6
            for (int i = 0; i < array3.Length - 3; i++)
            {
                som = array3[i] * array4[i + 1] * array5[i + 2] * array6[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 4-7
            for (int i = 0; i < array4.Length - 3; i++)
            {
                som = array4[i] * array5[i + 1] * array6[i + 2] * array7[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 5-8
            for (int i = 0; i < array5.Length - 3; i++)
            {
                som = array5[i] * array6[i + 1] * array7[i + 2] * array8[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 6-9
            for (int i = 0; i < array6.Length - 3; i++)
            {
                som = array6[i] * array7[i + 1] * array8[i + 2] * array9[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 7-10
            for (int i = 0; i < array7.Length - 3; i++)
            {
                som = array7[i] * array8[i + 1] * array9[i + 2] * array10[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 8-11
            for (int i = 0; i < array8.Length - 3; i++)
            {
                som = array8[i] * array9[i + 1] * array10[i + 2] * array11[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 9-12
            for (int i = 0; i < array9.Length - 3; i++)
            {
                som = array9[i] * array10[i + 1] * array11[i + 2] * array12[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 10-13
            for (int i = 0; i < array10.Length - 3; i++)
            {
                som = array10[i] * array11[i + 1] * array12[i + 2] * array13[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 11-14
            for (int i = 0; i < array11.Length - 3; i++)
            {
                som = array11[i] * array12[i + 1] * array13[i + 2] * array14[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 12-15
            for (int i = 0; i < array12.Length - 3; i++)
            {
                som = array12[i] * array13[i + 1] * array14[i + 2] * array15[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 13-16
            for (int i = 0; i < array13.Length - 3; i++)
            {
                som = array13[i] * array14[i + 1] * array15[i + 2] * array16[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 14-17
            for (int i = 0; i < array14.Length - 3; i++)
            {
                som = array14[i] * array15[i + 1] * array16[i + 2] * array17[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 15-18
            for (int i = 0; i < array15.Length - 3; i++)
            {
                som = array15[i] * array16[i + 1] * array17[i + 2] * array18[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 16-19
            for (int i = 0; i < array16.Length - 3; i++)
            {
                som = array16[i] * array17[i + 1] * array18[i + 2] * array19[i + 3];
                max = Math.Max(max, som);
            }

            //Rows 17-20
            for (int i = 0; i < array17.Length - 3; i++)
            {
                som = array17[i] * array18[i + 1] * array19[i + 2] * array20[i + 3];
                max = Math.Max(max, som);
            }

            #endregion

            #region Digonal top right, bottom left

            //Rows 1-4
            for (int i = 0; i < array1.Length - 3; i++)
            {
                som = array1[i + 3] * array2[i + 2] * array3[i + 1] * array4[i];
                max = Math.Max(max, som);
            }

            //Rows 2-5
            for (int i = 0; i < array2.Length - 3; i++)
            {
                som = array2[i + 3] * array3[i + 2] * array4[i + 1] * array5[i];
                max = Math.Max(max, som);
            }

            //Rows 3-6
            for (int i = 0; i < array3.Length - 3; i++)
            {
                som = array3[i + 3] * array4[i + 2] * array5[i + 1] * array6[i];
                max = Math.Max(max, som);
            }

            //Rows 4-7
            for (int i = 0; i < array4.Length - 3; i++)
            {
                som = array4[i + 3] * array5[i + 2] * array6[i + 1] * array7[i];
                max = Math.Max(max, som);
            }

            //Rows 5-8
            for (int i = 0; i < array5.Length - 3; i++)
            {
                som = array5[i + 3] * array6[i + 2] * array7[i + 1] * array8[i];
                max = Math.Max(max, som);
            }

            //Rows 6-9
            for (int i = 0; i < array6.Length - 3; i++)
            {
                som = array6[i + 3] * array7[i + 2] * array8[i + 1] * array9[i];
                max = Math.Max(max, som);
            }

            //Rows 7-10
            for (int i = 0; i < array7.Length - 3; i++)
            {
                som = array7[i + 3] * array8[i + 2] * array9[i + 1] * array10[i];
                max = Math.Max(max, som);
            }

            //Rows 8-11
            for (int i = 0; i < array8.Length - 3; i++)
            {
                som = array8[i + 3] * array9[i + 2] * array10[i + 1] * array11[i];
                max = Math.Max(max, som);
            }

            //Rows 9-12
            for (int i = 0; i < array9.Length - 3; i++)
            {
                som = array9[i + 3] * array10[i + 2] * array11[i + 1] * array12[i];
                max = Math.Max(max, som);
            }

            //Rows 10-13
            for (int i = 0; i < array10.Length - 3; i++)
            {
                som = array10[i + 3] * array11[i + 2] * array12[i + 1] * array13[i];
                max = Math.Max(max, som);
            }

            //Rows 11-14
            for (int i = 0; i < array11.Length - 3; i++)
            {
                som = array11[i + 3] * array12[i + 2] * array13[i + 1] * array14[i];
                max = Math.Max(max, som);
            }

            //Rows 12-15
            for (int i = 0; i < array12.Length - 3; i++)
            {
                som = array12[i + 3] * array13[i + 2] * array14[i + 1] * array15[i];
                max = Math.Max(max, som);
            }

            //Rows 13-16
            for (int i = 0; i < array13.Length - 3; i++)
            {
                som = array13[i + 3] * array14[i + 2] * array15[i + 1] * array16[i];
                max = Math.Max(max, som);
            }

            //Rows 14-17
            for (int i = 0; i < array14.Length - 3; i++)
            {
                som = array14[i + 3] * array15[i + 2] * array16[i + 1] * array17[i];
                max = Math.Max(max, som);
            }

            //Rows 15-18
            for (int i = 0; i < array15.Length - 3; i++)
            {
                som = array15[i + 3] * array16[i + 2] * array17[i + 1] * array18[i];
                max = Math.Max(max, som);
            }

            //Rows 16-19
            for (int i = 0; i < array16.Length - 3; i++)
            {
                som = array16[i + 3] * array17[i + 2] * array18[i + 1] * array19[i];
                max = Math.Max(max, som);
            }

            //Rows 17-20
            for (int i = 0; i < array17.Length - 3; i++)
            {
                som = array17[i + 3] * array18[i + 2] * array19[i + 1] * array20[i];
                max = Math.Max(max, som);
            }

            #endregion

            Console.WriteLine(max.ToString());
            Console.ReadLine();
        }
    }
}
