
using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Longhand
            Nullable<DateTime> dateN = null;
            //Shorthand
            DateTime? date = null;

            Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            Console.WriteLine("Value: " + date.Value);

            //Allows you to set value of dateAlt to the Nullable DateTime date
            DateTime dateAlt = date.GetValueOrDefault();
            //Stores dateAlt in nullable dateAlt2
            DateTime dateAlt2 = dateAlt;
            //Null Coalescing Operator used to set a default value for a if the value attempted to be set is null
            DateTime date2 = date ?? DateTime.Today;
            /*Long Form
            if(date != null)
            {
                date2 = date.GetValueOrDefault();
            }
            else
            {
                date2 = DateTime.Today;
            }*/
            //Medium Form
            //DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;



            //Console.WriteLine(date2);



        }
    }
}
