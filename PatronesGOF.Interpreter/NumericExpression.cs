using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Interpreter
{
    public class NumericExpression : IExpression
    {
        // Atributos
        private string _value;

        // Constructores
        public NumericExpression(string token)
        {
            _value = token;
        }

        // Métodos
        public void Interpret(Context context)
        {
            context.setOperator(context.getInteger(_value));
            context.calculate();
        }
    }
}
