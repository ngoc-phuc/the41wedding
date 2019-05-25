using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Http;

namespace Dtos.Shared.Inputs
{
    public class SendMailDto
    {
        [Required]
        public int BidOpportunityId { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string[] RecipientEmails { get; set; }

        public string Content { get; set; }

        public IFormFile[] AttachmentFiles { get; set; }
    }
}