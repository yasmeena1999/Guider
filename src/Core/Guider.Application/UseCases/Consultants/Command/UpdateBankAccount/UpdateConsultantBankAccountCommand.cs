﻿using Guider.Application.Responses;
using MediatR;

namespace Guider.Application.UseCases.Consultants.Command.UpdateBankAccount
{
    public class UpdateConsultantBankAccountCommand : IRequest<BaseResponse<string>>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string BankAccount { get; set; }
    }
}
