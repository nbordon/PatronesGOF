using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Interpreter
{
    class OperatorExpression : IExpression
    {
        // Atributos
        private string _operation;

        // Constructores
        public OperatorExpression(string token)
        {
            _operation = token;
        }

        // Métodos
        public void Interpret(Context context)
        {
            context.setOperation(_operation);
        }
    }
}
