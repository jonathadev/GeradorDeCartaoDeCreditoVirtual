using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        //criar endpoint para bucar os cartoes gerados por email 
        public string Email { get; set; }

        //cartao gerar automatico random
        public int CardNumber { get; set; }
        public string Validity { get; set; }
        public int Cvc { get; set; }
    }
}
