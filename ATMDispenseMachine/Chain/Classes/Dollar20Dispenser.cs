using ATMDispenseMachine.Chain;

namespace ATMDispenseMachine.Chain.Classes
{
    public class Dollar20Dispenser : DispenseChain
    {
        const int defaultValue = 20; 

         public override int GetDefaultValue(){
            return defaultValue;
        }
    }
}