﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace restWithAspNET.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {


        // GET api/subtraction/values/5
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult subtraction(string firstNumber, string secondNumber)
        {
            if (Isnumeric(firstNumber) && Isnumeric(secondNumber))
            {
                var subtraction = ConverttoDecimal(firstNumber) - ConverttoDecimal(secondNumber);
                return Ok(subtraction.ToString());
            }
            return BadRequest("Invalid Input");
        }

        // GET api/values/sum/5
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (Isnumeric(firstNumber) && Isnumeric(secondNumber))
            {
                var sum = ConverttoDecimal(firstNumber) + ConverttoDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private decimal ConverttoDecimal(string number)
        {
            decimal decimalValue;
            if (decimal.TryParse(number, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool Isnumeric(string strNumber)
        {
            double number;

            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }
    }


}