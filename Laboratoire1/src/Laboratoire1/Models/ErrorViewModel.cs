using System;
/**
 * 
 * Yan Ha Routhier-Chevrier
 * 1473192 - laboratoire 1
 * 
 * */
namespace Laboratoire1.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}