﻿using Guider.Application.Responses;
using Guider.Application.UseCases.Consultants.ConsultantPagination.Query;
using Guider.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guider.Application.UseCases.Appointments.AppointmentSort.Query
{
    public class SortAppointmentByRateQuery : IRequest<PaginatedList<SortconsultantByRateDto, Consultant>>
    {
        public bool Ascending { get; }
        public int Page { get; }
        public int PageSize { get; }

        public SortAppointmentByRateQuery(bool ascending, int page, int pageSize)
        {
            Ascending = ascending;
            Page = page;
            PageSize = pageSize;
        }

    }
}
