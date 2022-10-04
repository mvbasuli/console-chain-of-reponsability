using ATMDispenseMachine.Chain;

namespace ATMDispenseMachine.Chain.Classes
{
    public class Dollar1Dispenser : DispenseChain
    {
        const int defaultValue = 1; 

         public override int GetDefaultValue(){
            return defaultValue;
        }
    }
}