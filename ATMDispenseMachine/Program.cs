using ATMDispenseMachine.Chain;
using ATMDispenseMachine.Chain.Classes;
namespace ATMDispenseMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            ATMDispenseChain ATMDispenseChain = new ATMDispenseChain();
            while (true)
            {
                Console.WriteLine("Enter amount to dispense");
                if (int.TryParse(Console.ReadLine(), out int amount))
                {
                    Console.WriteLine(ATMDispenseChain.d100.Dispense(new Model.Currency(amount)));
                }

            }

        }
    }
}
