using ATMDispenseMachine.Chain;

namespace ATMDispenseMachine.Chain.Classes
{
    public class Dollar10Dispenser : DispenseChain
    {
        const int defaultValue = 10; 

         public override int GetDefaultValue(){
            return defaultValue;
        }
    }
}