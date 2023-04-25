﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagement.Application.DTOs.LeaveType;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class ListLeaveRequestDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime  DateRequested { get; set; }    
        public bool? Approved { get; set; } 
    }
}
