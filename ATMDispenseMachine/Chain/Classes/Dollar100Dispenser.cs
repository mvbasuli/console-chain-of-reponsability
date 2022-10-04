using ATMDispenseMachine.Chain;

namespace ATMDispenseMachine.Chain.Classes
{
    public class Dollar100Dispenser : DispenseChain
    {
        const int defaultValue = 100; 

         public override int GetDefaultValue(){
            return defaultValue;
        }
    }
}