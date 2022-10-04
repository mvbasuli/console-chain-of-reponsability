using ATMDispenseMachine.Chain.Classes;
using ATMDispenseMachine.Chain;

namespace ATMDispenseMachine.Chain
{
    public class ATMDispenseChain
    {
        public DispenseChain d100;

        public ATMDispenseChain()
        {
            // Initialize the chain
            DispenseChain d1 = new Dollar1Dispenser();
            DispenseChain d5 = new Dollar5Dispenser();
            DispenseChain d10 = new Dollar10Dispenser();
            DispenseChain d20 = new Dollar20Dispenser();
            DispenseChain d50 = new Dollar50Dispenser();
            d100 = new Dollar100Dispenser();

            // Set the chain of responsability
            d100.SetNextChain(d50);
            d50.SetNextChain(d20);
            d20.SetNextChain(d10);
            d10.SetNextChain(d5);
            d5.SetNextChain(d1);
        }
    }
}