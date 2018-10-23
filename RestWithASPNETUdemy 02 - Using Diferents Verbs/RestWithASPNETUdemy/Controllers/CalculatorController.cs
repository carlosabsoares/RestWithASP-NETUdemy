using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {
        //**********************************************************************************
        //Sum Operation
        // GET api/values/Sum/5/5
        //**********************************************************************************
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertDecimal(firstNumber) + ConvertDecimal(secondNumber);

                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }
        //**********************************************************************************
        //**********************************************************************************

        //**********************************************************************************
        //Subtraction Operation
        // GET api/values/Subtraction/5/5
        //**********************************************************************************
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtractionlt (string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertDecimal(firstNumber) - ConvertDecimal(secondNumber);

                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }
        //**********************************************************************************
        //**********************************************************************************

        //**********************************************************************************
        //Subtraction Operation
        // GET api/values/Multiplication/5/5
        //**********************************************************************************
        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertDecimal(firstNumber) * ConvertDecimal(secondNumber);

                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }
        //**********************************************************************************
        //**********************************************************************************


        //**********************************************************************************
        //Division Operation
        // GET api/values/Division/5/5
        //**********************************************************************************
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertDecimal(firstNumber) / ConvertDecimal(secondNumber);

                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }
        //**********************************************************************************
        //**********************************************************************************

        private decimal ConvertDecimal(string number)
        {
            decimal decimalValue;

            if (decimal.TryParse(number, out decimalValue))
            {

                return decimalValue;

            }

            return 0;

        }

        private bool IsNumeric(string strNumber)
        {
            double number;

            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.CurrentInfo, out number);
            return isNumber;
            
        }
    }
}
