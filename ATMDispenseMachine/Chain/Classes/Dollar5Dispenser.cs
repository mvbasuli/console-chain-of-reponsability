using ATMDispenseMachine.Chain;

namespace ATMDispenseMachine.Chain.Classes
{
    public class Dollar5Dispenser : DispenseChain
    {
        const int defaultValue = 5; 

         public override int GetDefaultValue(){
            return defaultValue;
        }
    }
}