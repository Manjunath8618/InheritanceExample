using System;

namespace ExceptionHandlingExam
{

    public class AgeResException:Exception
    {
        public AgeResException(string message):base(message)
        {

        }
    }

    public class AgeRes
    {
        public void VoteEligible()
        {
            try
            {
                Console.WriteLine("Input your age");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 18)
                {
                    throw new AgeResException("Minimum voting age is 18 years");
                }
                Console.WriteLine("You are eligilbe to vote");
            }
            catch (AgeResException ex)
            {
                Console.WriteLine("Exception" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception:" + ex.Message);
            }

            finally
            {
                Console.WriteLine("Finaly block completed");
            }
        }
    }

    public class HandlingExcUsingMultiBlock
    {

        public void MultiBlock()
        {
            try
            {
                Console.WriteLine("Enter a number");
                int num = Convert.ToInt32(Console.ReadLine());
                int[] number = { 2, 4, 6, 8 };
                Console.WriteLine("Enter array index position");
                int ind = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Value at position {ind} is:{number[num]}");
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter number only");
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Choose a valid position from the array");
            }
            catch(Exception m)
            {
                Console.WriteLine("Enexpected error"+m);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            AgeRes ageRes = new AgeRes();
           // ageRes.VoteEligible();

            HandlingExcUsingMultiBlock hd = new HandlingExcUsingMultiBlock();
            hd.MultiBlock();


            Console.ReadLine();
        }
    }
}
