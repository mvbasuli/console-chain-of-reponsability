using ATMDispenseMachine.Chain;

namespace ATMDispenseMachine.Chain.Classes
{
    public class Dollar50Dispenser : DispenseChain
    {
        const int defaultValue = 50; 

         public override int GetDefaultValue(){
            return defaultValue;
        }
    }
}