using ATMDispenseMachine.Model;

namespace ATMDispenseMachine.Chain
{
    public abstract class DispenseChain
    {
        private DispenseChain _dispenseChain;

        public void SetNextChain(DispenseChain nextChain)
        {
            _dispenseChain = nextChain;
        }

        public abstract int GetDefaultValue();

        public string Dispense(Currency cur)
        {
            string strReturn = "";
            if (cur.getAmount() >= GetDefaultValue())
            {
                int num = cur.getAmount() / GetDefaultValue();
                int remainder = cur.getAmount() % GetDefaultValue();
                strReturn = "Dispensing " + num.ToString() + " note(s) of $" + GetDefaultValue().ToString();
                if (remainder != 0)
                    strReturn = strReturn + ", " + _dispenseChain.Dispense(new Currency(remainder));
            }
            else
            {
                strReturn = this._dispenseChain.Dispense(cur);
            }
            return strReturn;
        }
    }
}