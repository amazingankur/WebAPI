using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPISolution.Util;

namespace WebAPISolution.Controllers
{
    public class ArrayCalculationController : ApiController
    {
        int[] ArrayOfIntegers = { 1, 2, 3, 4, 5 };
        [Route("api/arraycalc/reverse")]
        [HttpGet]
        public IEnumerable<int> GetReverse()
        {
            for (int i = 0; i < ArrayOfIntegers.Length / 2; i++)
            {
                int temp = ArrayOfIntegers[i];
                ArrayOfIntegers[i] = ArrayOfIntegers[ArrayOfIntegers.Length - i - 1];
                ArrayOfIntegers[ArrayOfIntegers.Length - i - 1] = temp;
            }
            return ArrayOfIntegers;
        }

        [Route("api/arraycalc/deletepart")]
        [HttpDelete]
        public IEnumerable<int> Delete(int position)
        {
            return ArrayOfIntegers.RemoveAtIndex(position);
        } 

    }
}
