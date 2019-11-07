﻿using EMS.Data.dbo_Models;
using EMS.Data.Enums;
using EMS.Services.dto_Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EMS.Services.Contracts
{
    public interface IEmailService
    {
        Task ChangeStatusAsync(string id, EmailStatus newStatus);
        Task<string> GetBodyAsync(string emailId);
        Task<DtoEmail> FindEmailAsync(string id);
        Task<DtoEmail> CreateAsync(DateTime received, string gmailMessageId, string senderEmail, string senderName, string subject, List<DboAttachment> attachments);
        Task<DtoEmail> CreateAsync(DateTime received, string gmailMessageId, string senderEmail, string subject, List<DboAttachment> attachments);
        Task AddBodyAsync(string emailId, string body);
        Task<List<DtoAttachment>> CreateAttachmentsAsync();
    }
}