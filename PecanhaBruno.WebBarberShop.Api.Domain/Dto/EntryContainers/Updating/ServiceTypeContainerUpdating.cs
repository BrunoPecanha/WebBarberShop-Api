﻿using PecanhaBruno.WebBarberShop.Domain.Dto.EntitiesDto.Creating;
using PecanhaBruno.WebBarberShop.Domain.Entities;

namespace Pecanha.WebBarberShopp.Domain.EntryContainers.Updating
{
    public class ServiceTypeContainerUpdating {       
        /// <summary>
        /// Corpo da mensagem
        /// </summary>
        public CreatingServiceTypeDto ServiceTypeMessage { get; set; }

        public ServiceType ToEntity() {
            return new ServiceType(ServiceTypeMessage.Name, ServiceTypeMessage.MediumTime, ServiceTypeMessage.Price, ServiceTypeMessage.CompanyId);
        } 
    }
}