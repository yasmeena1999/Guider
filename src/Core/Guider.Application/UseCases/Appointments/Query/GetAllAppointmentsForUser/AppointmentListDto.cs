﻿using Guider.Domain.Enums;

namespace Guider.Application.UseCases.Appointments.Query.GetAllForConsultant
{
    internal class AppointmentListDto
    {
        public int Id { get; set; }
        public float Rate { get; set; }
        public AppointmentState State { get; set; }
        public int Duration { get; set; }
        public DateTime Date { get; set; }
        public int ClientId { get; set; }
        public int ClientUserId { get; set; }
        public string ClientName { get; set; }
        public int ConsultantId { get; set; }
        public int ConsultantUserId { get; set; }
        public string ConsultantName { get; set; }
        public string SubCategoryName { get; set; }
        public string CategoryName { get; set; }
    }
}
