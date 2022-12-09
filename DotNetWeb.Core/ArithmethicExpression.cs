using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotNetWeb.Core
{
    public class ArithmethicExpression : BinaryExpression
    {
        private readonly Dictionary<(ExpressionType, ExpressionType, TokenType), ExpressionType> _typeRules;
        public Token Operation { get; }

        public ArithmeticExpression(Expression leftExpression, Expression rightExpression, Token operation)
            : base(leftExpression, rightExpression)
        {
            Operation = operation;
            _typeRules = new Dictionary<(ExpressionType, ExpressionType, TokenType), ExpressionType>
        {
            {(ExpressionType.Int, ExpressionType.Int, TokenType.Plus), ExpressionType.Int},
            {(ExpressionType.Int, ExpressionType.Int, TokenType.Minus), ExpressionType.Int},
            {(ExpressionType.Int, ExpressionType.Int, TokenType.Asterisk), ExpressionType.Int},
            {(ExpressionType.Int, ExpressionType.Int, TokenType.Division), ExpressionType.Int},

            {(ExpressionType.Float, ExpressionType.Float, TokenType.Plus), ExpressionType.Float},
            {(ExpressionType.Float, ExpressionType.Float, TokenType.Minus), ExpressionType.Float},
            {(ExpressionType.Float, ExpressionType.Float, TokenType.Asterisk), ExpressionType.Float},
            {(ExpressionType.Float, ExpressionType.Float, TokenType.Division), ExpressionType.Float},

            {(ExpressionType.Int, ExpressionType.Float, TokenType.Plus), ExpressionType.Float},
            {(ExpressionType.Float, ExpressionType.Int, TokenType.Plus), ExpressionType.Float},

            {(ExpressionType.String, ExpressionType.String, TokenType.Plus), ExpressionType.String},
        };
        }
    }
}
