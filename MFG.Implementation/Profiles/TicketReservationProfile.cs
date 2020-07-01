using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Profiles
{
    public class TicketReservationProfile : Profile
    {
        public TicketReservationProfile()
        {
            CreateMap<TicketReservation, TicketReservationDto>();
            CreateMap<TicketReservationDto, TicketReservation>();

            CreateMap<TicketReservation, TicketResevationQueryDto>();
            CreateMap<TicketResevationQueryDto, TicketReservation>();

            CreateMap<TicketReservation, TicketReservationCreateDto>();
            CreateMap<TicketReservationCreateDto, TicketReservation>();
        }
    }
}