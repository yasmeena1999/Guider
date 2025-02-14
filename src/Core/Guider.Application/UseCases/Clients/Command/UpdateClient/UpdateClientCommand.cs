﻿using Guider.Application.Responses;
using MediatR;

namespace Guider.Application.UseCases.Clients.Command.UpdateClient
{
    public class UpdateClientCommand : IRequest<BaseResponse<UpdateClientDto>>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
