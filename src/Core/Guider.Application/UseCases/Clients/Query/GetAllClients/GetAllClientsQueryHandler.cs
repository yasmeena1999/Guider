﻿using AutoMapper;
using Guider.Application.Contracts.Persistence;
using Guider.Application.UseCases.Clients.Query.GetClientDetails;
using MediatR;

namespace Guider.Application.UseCases.Clients.Query.GetAllClients
{
    public class GetAllClientsQueryHandler : IRequestHandler<GetAllClientsQuery, List<ClienttoReturnVM>>
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _clientRepository;

        public GetAllClientsQueryHandler(IMapper mapper, IClientRepository clientRepository)
        {
            _mapper = mapper;
            _clientRepository = clientRepository;
        }
        public async Task<List<ClienttoReturnVM>> Handle(GetAllClientsQuery request, CancellationToken cancellationToken)
        {
            var AllClients = await _clientRepository.GetAllClientWithAppointments();
            var ClientsToReturn = _mapper.Map<List<ClienttoReturnVM>>(AllClients);
            return ClientsToReturn;
        }
    }
}
