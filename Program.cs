namespace try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number :");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entered number is a : " + number);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata:"+ ex.Message.ToString());
                throw;
            }
            finally
            {
                Console.WriteLine("işlem tamamlandı");
            }
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a=int.Parse("-200000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz");
                Console.WriteLine(ex);
                throw;
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Değer çok küçük yada çok büyük");
                Console.WriteLine(ex);
            }
            
        }
    }
}