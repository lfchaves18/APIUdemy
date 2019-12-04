using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiCurso.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {

        // PUT api/values/5
        [HttpGet("soma/{primeiroNum}/{segundoNum}")]
        public IActionResult Soma(string primeiroNum, string segundoNum)
        {
            if (ENumero(primeiroNum) && ENumero(segundoNum))
            {
                var sum = ConverterDecimal(primeiroNum) + ConverterDecimal(segundoNum);
                return Ok(sum.ToString());
            }
            return BadRequest("Valor invalido");
        }

        [HttpGet("subtracao/{primeiroNum}/{segundoNum}")]
        public IActionResult Subtracao(string primeiroNum, string segundoNum)
        {
            if (ENumero(primeiroNum) && ENumero(segundoNum))
            {
                var sum = ConverterDecimal(primeiroNum) - ConverterDecimal(segundoNum);
                return Ok(sum.ToString());
            }
            return BadRequest("Valor invalido");
        }


        [HttpGet("divisao/{primeiroNum}/{segundoNum}")]
        public IActionResult Divisao(string primeiroNum, string segundoNum)
        {
            if (ENumero(primeiroNum) && ENumero(segundoNum))
            {
                var sum = ConverterDecimal(primeiroNum) / ConverterDecimal(segundoNum);
                return Ok(sum.ToString());
            }
            return BadRequest("Valor invalido");
        }


        [HttpGet("multiplicacao/{primeiroNum}/{segundoNum}")]
        public IActionResult Multiplicacao(string primeiroNum, string segundoNum)
        {
            if (ENumero(primeiroNum) && ENumero(segundoNum))
            {
                var sum = ConverterDecimal(primeiroNum) * ConverterDecimal(segundoNum);
                return Ok(sum.ToString());
            }
            return BadRequest("Valor invalido");
        }


        [HttpGet("media/{primeiroNum}/{segundoNum}")]
        public IActionResult Media(string primeiroNum, string segundoNum)
        {
            if (ENumero(primeiroNum) && ENumero(segundoNum))
            {
                var sum = (ConverterDecimal(primeiroNum) + ConverterDecimal(segundoNum))/2;
                return Ok(sum.ToString());
            }
            return BadRequest("Valor invalido");
        }

        private decimal ConverterDecimal(string num)
        {
            decimal decimalValue;
            if (decimal.TryParse(num, out decimalValue))
                return decimalValue;

            return 0;
        }
        private bool ENumero(string numeroRecebido)
        {
            double Numero;
            bool ehNumero = double.TryParse(numeroRecebido, out Numero);
            return ehNumero;
        }

    }
}
