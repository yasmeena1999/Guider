﻿using Guider.Application.Responses;
using Guider.Application.UseCases.consultant.Query.GetAll;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guider.Application.UseCases.consultant.Query.GetDetails
{
    public class GetConsultantDetailsQuery : IRequest<BaseResponse<ConsultantVM>>
    {
        public int Id { get; set; }
    }
}
