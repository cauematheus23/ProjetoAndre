﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class EmployeeDTO : Person
    {
        public int PositionId { get; set; }
        public Decimal EmployeeComissionValue { get; set; } // Porcentagem
        public Decimal EmployeeComission { get; set; } //

    }
}
